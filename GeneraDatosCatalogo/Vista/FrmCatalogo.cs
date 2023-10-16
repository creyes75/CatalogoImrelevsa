using DataGridViewAutoFilter;
using DBConfig;
using GeneraDatosCatalogo.Data;
using GeneraDatosCatalogo.Data.ObjectsWizard;
using GeneraDatosCatalogo.Data.Wizard;
using GeneraDatosCatalogo.Modelo;
using GeneraDatosCatalogo.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WizardLayout;

namespace GeneraDatosCatalogo
{
    public partial class Form1 : Form
    {
        DataSet dsCatalogoGeneral;
        bool CatalogoGrabado = false;
        string QuerySAP = "";
        string QueryWeb = "";
        string TipoCatalogo = ""; //18abril2023
        List<OrigenDatosAdicionales> oListaOrigenDatosAdic = new List<OrigenDatosAdicionales>();
        Catalogo oCatalogo = new Catalogo();
        NegLogCatalogo oNegLogCatalogo = new NegLogCatalogo();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //NegCatalogo oNegCatalogo = new NegCatalogo();
            //DataSet ds = oNegCatalogo.CargaNuevoCatalogo("","");
            //dGViewProductos.DataSource = ds.Tables[0].DefaultView;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                RespuestaReg oRespuesta = new RespuestaReg();
                reiniciarDataset();
                this.Enabled = false;

                //ProgramWizard oWizar = new ProgramWizard();
                //objeto q contiene todos los filtros aplicados al query
                List<FiltroQuery> ListaFiltrosQuery = new List<FiltroQuery>();

                ClsWizard oClsWizard = new ClsWizard();

                //ListaFiltrosQuery.Clear();
                //oWizar.inicio(ref ListaFiltrosQuery);
                FrmWizard ofrmWizard = new FrmWizard();
                ofrmWizard.ShowDialog();

                if (ofrmWizard.ProcesoCancelado) { this.Enabled = true; return; }
                ProgressBarIni(100);
                ListaFiltrosQuery = ofrmWizard.oListaFiltrosQuery;
                oListaOrigenDatosAdic = ofrmWizard.oListaOrigenDatosAdic;
                TipoCatalogo = ofrmWizard.TipoCatalogo;

                QuerySAP = oClsWizard.GeneraFiltosQuery(ListaFiltrosQuery, "SAP"); ProgressBarAdd(5);
                //QueryWeb = oClsWizard.GeneraFiltosQuery(ListaFiltrosQuery, "Web"); ProgressBarAdd(5);
                NegCatalogo oNegCatalogo = new NegCatalogo();
                //cra 6jun2023
                oRespuesta = oNegCatalogo.CargaNuevoCatalogo(QuerySAP, QueryWeb, oListaOrigenDatosAdic, TipoCatalogo);
                dsCatalogoGeneral = oRespuesta.detalle;
                ProgressBarAdd(60);
                tSLDetalles.Text = "Nuevo Catalogo ";
                if (QuerySAP != "")
                {
                    tSLDetalles.Text += " con filtros SAP: " + QuerySAP;
                }
                if (QueryWeb != "")
                {
                    tSLDetalles.Text += " con filtros Web: " + QueryWeb;
                }
                //ordenar la tabla por la columna orden
                //cra 6jun2023 
                if (oRespuesta.errCodigo !=0)
                {
                    MessageBox.Show("Error en la generacion de la informacion de Catalogos, si incluyo un Origen de datos adicional por favor revise el formato de las columnas, valores validos en las celdas y caracteres especiales(" + oRespuesta.errMensaje + ")", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Enabled = true;
                    return ;
                }
                BindingSource source1 = new BindingSource();
                source1.DataSource = dsCatalogoGeneral.Tables[0].DefaultView;

                // Set the data source for the DataGridView.
                dGViewProductos.DataSource = source1;

                //restablecerDataSet();// activo el orenamento por la columna orden.

                ProgressBarAdd(10);

                //este codigo estaba incluido para habilitar el filtrado por columnas pero empezo a dar error para la columna OrdenNivel6
                //foreach (DataGridViewColumn item in dGViewProductos.Columns)
                //    item.HeaderCell = new DataGridViewAutoFilterColumnHeaderCell(item.HeaderCell);
                ProgressBarFin();
                this.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
                ProgressBarError();
                //this.Close();
            }
        }
        private void restablecerDataSet()
        {
            //dGViewProductos.DataSource = null;
            //BindingSource source1 = new BindingSource();
            //source1.DataSource = ds.Tables[0].DefaultView;

            //// Set the data source for the DataGridView.
            //dGViewProductos.DataSource = source1;
            dGViewProductos.Sort(dGViewProductos.Columns["OrdenNivel6"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void reiniciarDataset()
        {
            dGViewProductos.DataSource = null;
            BindingSource source1 = new BindingSource();
            source1.DataSource = null;
            // Set the data source for the DataGridView.
            dGViewProductos.DataSource = source1;
            dsCatalogoGeneral = null;
        }


        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var reader = new AppSettingsReader();
                var stringSetting = reader.GetValue("Ruta_XLS", typeof(string));

                string Ruta_xls = stringSetting.ToString(); // "C:\\temp\\";
                DBConfig.NegExcel OnegExcel = new DBConfig.NegExcel();
                DataSet dsExcel = new DataSet();
                DataTable dtExcel = new DataTable();

                saveFileDialog1.Filter = "XLS files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFileDialog1.DefaultExt = "xls";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Ruta_xls = saveFileDialog1.FileName;
                    dtExcel = GeneraDataTable(dGViewProductos);
                    //dtExcel = dGViewProductos.DataSource as DataTable;
                    dsExcel.Tables.Add(dtExcel);
                    OnegExcel.GenerarExcel_rowData(Ruta_xls, dsExcel);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.Close();
            }


        }
        private DataTable GeneraDataTable (DataGridView GridView1)
        {
            DataTable dt = new DataTable();

            // add the columns to the datatable            


            for (int i = 0; i < GridView1.ColumnCount; i++)
            {
                dt.Columns.Add(GridView1.Columns[i].Name);
                } 
            

            //  add each of the data rows to the table
            foreach (DataGridViewRow row in GridView1.Rows)
            {
                DataRow dr;
                dr = dt.NewRow();

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dr[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(dr);
            }

            return dt;

        }

        private void dGViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dGViewProductos_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void tSBExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lista_dias_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if(e.ColumnIndex<0|| e.RowIndex<0)
                { return; }
                dGViewProductos.CurrentCell = dGViewProductos.Rows[e.RowIndex].Cells[e.ColumnIndex];

                //ContextMenuStrip menu = new ContextMenuStrip();
                //menu.Items.Add("insertar").Name = "AGREGAR";
               


                //Obtienes las coordenadas de la celda seleccionada. 
                Rectangle coordenada = dGViewProductos.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                int anchoCelda = coordenada.Location.X; //Ancho de la localizacion de la celda
                int altoCelda = coordenada.Location.Y;  //Alto de la localizacion de la celda

                //Y para mostrar el menú lo haces de esta forma:  
                int X = anchoCelda;// + dGViewProductos.Location.X;
                int Y = altoCelda;// + dGViewProductos.Location.Y ;

                contextMenuStrip1.Show(dGViewProductos, new Point(X, Y));
            }
        }
        private void ContextMenuStrip_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgwr = new DataGridViewRow();
            restablecerDataSet();
            DataGridViewRow dgrow = dGViewProductos.Rows[dGViewProductos.SelectedCells[0].RowIndex];// dGViewProductos.SelectedRows[1];

            DataRow row = dsCatalogoGeneral.Tables[0].NewRow();
            row["OrdenNivel6"] = (dgrow.Cells["OrdenNivel6"].Value.ToString()) ; //dGViewProductos.SelectedRows(dGViewProductos.SelectedCells[0].RowIndex).Cells("Orden").Value;
            
            for (int i =0; i< dgrow.Cells.Count-1;i++)
            {
                row[i] = dgrow.Cells[i].Value;
            }
            
            //row["Orden"] = decimal.Parse( row["Orden"].ToString()) - decimal.Parse("0.01");
            dsCatalogoGeneral.Tables[0].Rows.InsertAt( row, dGViewProductos.SelectedCells[0].RowIndex);

           
        }
        private void ProgressBarIni(int maximo)
        {
            //pBarCatalogo.Minimum = 0;
            //pBarCatalogo.Maximum = maximo;
            //pBarCatalogo.Step = 1;
            //pBarCatalogo.Style = ProgressBarStyle.Continuous;
            //pBarCatalogo.Visible = true;
            lblProgress.Text = "Proceso iniciado...";
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            Application.DoEvents();
        }
        private void ProgressBarFin()
        {
            lblProgress.Text = "Proceso Finalizado.";
            this.Cursor = System.Windows.Forms.Cursors.Default;
            Application.DoEvents();

            //pBarCatalogo.Value = 0;
            //pBarCatalogo.Visible = false;
        }
        private void ProgressBarAdd(int valor)
        {
            //if (pBarCatalogo.Value + valor   <= pBarCatalogo.Maximum)
            //{
            //     pBarCatalogo.Value += valor;
            //}
            lblProgress.Text = "Cargando datos";
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            Application.DoEvents();
        }
        private void ProgressBarError()
        {
            lblProgress.Text = "Proceso Finalizado con errores.";
            this.Cursor = System.Windows.Forms.Cursors.Default;
            Application.DoEvents();

            //pBarCatalogo.Value = 0;
            //pBarCatalogo.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dsCatalogoGeneral == null )
            {
                MessageBox.Show("No existe informacion para ser grabada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dsCatalogoGeneral.Tables.Count == 0)
            {
                MessageBox.Show("No existe informacion para ser grabada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return;
            }
            FrmSave ofrmSave = new FrmSave();
            oCatalogo.detalles = dsCatalogoGeneral;
            oCatalogo.FiltroSAP= QuerySAP;
            oCatalogo.FiltroWeb = QueryWeb;
            oCatalogo.TipoCatalogo = TipoCatalogo;
           
            string StrODA = "";

            for (int i_oda = 0; i_oda < oListaOrigenDatosAdic.Count; i_oda++)
            {
                StrODA += oListaOrigenDatosAdic[i_oda].NombreArchivo;
            }
            oCatalogo.ODA = StrODA;
            //            ofrmSave.ODA = StrODA;
            ofrmSave.oCatalogo = oCatalogo;
            ofrmSave.ShowDialog();

            oCatalogo = ofrmSave.oCatalogo;
            CatalogoGrabado = ofrmSave.GrabadoExitoso;


    }


        private void restablecerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restablecerDataSet();
        }
        private void tSBOpen_Click(object sender, EventArgs e)
        {
            FrmOpen oFrmOpen = new FrmOpen();

            oFrmOpen.ShowDialog();
            if (!oFrmOpen.oProcesoCancelado)
            {
                dsCatalogoGeneral = null;
                dsCatalogoGeneral = oFrmOpen.dsCatalogoExist;
                BindingSource source1 = new BindingSource();
                source1.DataSource = dsCatalogoGeneral.Tables[0].DefaultView;
                oNegLogCatalogo = oFrmOpen.oLogCatalogo;
                // Set the data source for the DataGridView.
                dGViewProductos.AllowUserToResizeColumns = true;
                dGViewProductos.DataSource = source1;

            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tSBConfig_Click(object sender, EventArgs e)
        {
            FrmMantOrden oFrmOrden = new FrmMantOrden();
            oFrmOrden.ShowDialog();

        }
    }
}
