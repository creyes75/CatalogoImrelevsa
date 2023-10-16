using DBConfig;
using GeneraDatosCatalogo.Data;
using GeneraDatosCatalogo.Data.ObjectsWizard;
using GeneraDatosCatalogo.Data.Wizard;
using Microsoft.Office.Interop.Excel;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace WizardLayout
{
    public partial class FrmWizard : Form
    {
        int top = -1;
        int count=3;
        //variables para forma3
        List<FiltroParametros> oFiltosParametrosWeb = new List<FiltroParametros>();
        List<FiltroParametros> oFiltosParametrosSAP = new List<FiltroParametros>();
        public List<FiltroQuery> oListaFiltrosQuery = new List<FiltroQuery>() ;

        public List<OrigenDatosAdicionales> oListaOrigenDatosAdic = new List<OrigenDatosAdicionales>();
        public DataSet dsODatosAdic = new DataSet();

        public bool ProcesoCancelado = false;
        public string TipoCatalogo = "";

        ClsWizard oClsWizard = new ClsWizard();
        //-----------------

        public FrmWizard()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ProcesoCancelado = true;
            this.Close();
        }

        private void Back()
        {
            top--;

            if (top <= -1)
            {
                return;
            }
            else
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                btnNext.Text = "&Next >";
                 
                LoadNewForm();
                if (top - 1 <= -1)
                {
                    btnBack.Enabled = false;
                }
            }

            if (top >= count)
            {
                btnNext.Enabled = false;
            }
        }
        private void LoadNewForm()
        {
            PnlOpt1.Visible = false;
            PnlOpt2.Visible = false;
            PnlOpt3.Visible = false;

            if (top == 0) { PnlOpt1.Visible = true; }
            if (top == 1) { PnlOpt2.Visible = true; }
            if (top == 2) { PnlOpt3.Visible = true; }

            LlenarComboOperador();

        }


        private void Next()
        {

            top++;
            if (top >= count)//finalizar
            {
                //return;
                //this.pnlContent.Controls 
                this.Close();
            }
            else
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                btnNext.Text = "&Next >";
                LoadNewForm();
                if (top + 1 == count)
                {
                    //btnNext.Enabled = false;
                    btnNext.Text = "&Finalizar";
                }
            }

            if (top <= 0)
            {
                btnBack.Enabled = false;
            }
        }

        private void FrmWizard_Load(object sender, EventArgs e)
        {
            Next();oFiltosParametrosWeb

            //load para la pnelOpt3
             = oClsWizard.Wzd_ObtenerDatosParametrosFiltro("Web");
            oFiltosParametrosSAP = oClsWizard.Wzd_ObtenerDatosParametrosFiltro("SAP");
            cmbOrigenDatos.SelectedIndex = 0;
            cmbOrigenDatos_SelectedIndexChanged(sender, e);
            cmbTipoCatalogo.SelectedIndex = 0;
            //------------------------------------

        }
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            Next();
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Back();
        }
        //********************************************************************************
        //fuente para panelOpt3
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbOperador.SelectedIndex == 5 || cmbOperador.SelectedIndex == 6)
            {
                txtValor.Text = devuelveListaIn();
            }


                
            lblSeleccionCampos.Text = "";
            if (cmbOrigenDatos.SelectedIndex >= 0)
            {
                if (cmbCampo.SelectedIndex >= 0)
                {
                    if (cmbOperador.SelectedIndex >= 0)
                    {
                        if (txtValor.Text.Trim() != "")
                        {
                            //validacion de duplicidad
                            for (int i = 0; i < oListaFiltrosQuery.Count; i++)
                            {
                                if (cmbOrigenDatos.Text == oListaFiltrosQuery[i].OrigenDatos && cmbCampo.Text == oListaFiltrosQuery[i].campo && cmbOperador.SelectedValue.ToString() == oListaFiltrosQuery[i].operador)
                                {
                                    lblSeleccionCampos.Text = "Criterio seleccionado ya existe";
                                    lblSeleccionCampos.ForeColor = Color.Red;
                                    return;
                                }
                            }
                            //validacion de tipo de datos
                            //if (cmbOrigenDatos.SelectedIndex == 0) //web
                            //{
                            //    if (cmbOperador.SelectedIndex <= 4)
                            //    {
                            //        if (oFiltosParametrosWeb[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "INT" && !double.TryParse(txtValor.Text, out double result))
                            //        {
                            //            lblSeleccionCampos.Text = "Error en el tipo de datos digitado";
                            //            lblSeleccionCampos.ForeColor = Color.Red;
                            //            return;
                            //        }
                            //        if (oFiltosParametrosWeb[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "DECIMAL" && !double.TryParse(txtValor.Text, out double resultdbl))
                            //        {
                            //            lblSeleccionCampos.Text = "Error en el tipo de datos digitado";
                            //            lblSeleccionCampos.ForeColor = Color.Red;
                            //            return;
                            //        }
                            //        if (oFiltosParametrosWeb[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "DATE" && !DateTime.TryParse(txtValor.Text, out DateTime resultdt))
                            //        {
                            //            lblSeleccionCampos.Text = "Error en el tipo de datos digitado";
                            //            lblSeleccionCampos.ForeColor = Color.Red;
                            //            return;
                            //        }
                            //    }

                            //}
                            //else
                            {
                                if (cmbOperador.SelectedIndex <= 4)
                                {
                                    if (oFiltosParametrosSAP[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "INT" && !double.TryParse(txtValor.Text, out double result))
                                    {
                                        lblSeleccionCampos.Text = "Error en el tipo de datos digitado";
                                        lblSeleccionCampos.ForeColor = Color.Red;
                                        return;
                                    }
                                    if (oFiltosParametrosSAP[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "DECIMAL" && !double.TryParse(txtValor.Text, out double resultdbl))
                                    {
                                        lblSeleccionCampos.Text = "Error en el tipo de datos digitado";
                                        lblSeleccionCampos.ForeColor = Color.Red;
                                        return;
                                    }
                                    if (oFiltosParametrosSAP[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "DATE" && !DateTime.TryParse(txtValor.Text, out DateTime resultdt))
                                    {
                                        lblSeleccionCampos.Text = "Error en el tipo de datos digitado";
                                        lblSeleccionCampos.ForeColor = Color.Red;
                                        return;
                                    }
                                }
                            }

                            //-------------------------------
                            //-------------------------------
                            //agrado texto a la lista en pantalla
                            LstCriterios.Items.Add(cmbCampo.Text + " " + cmbOperador.SelectedValue.ToString() + " " + txtValor.Text);
                            FiltroQuery oFiltroQuery = new FiltroQuery();
                            //anado el elemento a la lista de campos seleccionados
                            oFiltroQuery.OrigenDatos = cmbOrigenDatos.Text;
                            //if (cmbOrigenDatos.SelectedIndex == 0)
                            //{
                            //    oFiltroQuery.campo = oFiltosParametrosWeb[cmbCampo.SelectedIndex].campo;
                            //    oFiltroQuery.tipoDato = oFiltosParametrosWeb[cmbCampo.SelectedIndex].tipoDato;
                            //    oFiltroQuery.Tabla = oFiltosParametrosWeb[cmbCampo.SelectedIndex].Tabla;
                            //}
                            //else
                            {
                                oFiltroQuery.campo = oFiltosParametrosSAP[cmbCampo.SelectedIndex].campo;
                                oFiltroQuery.tipoDato = oFiltosParametrosSAP[cmbCampo.SelectedIndex].tipoDato;
                                oFiltroQuery.Tabla = oFiltosParametrosSAP[cmbCampo.SelectedIndex].Tabla;
                            }
                            oFiltroQuery.operador = cmbOperador.SelectedValue.ToString();
                            oFiltroQuery.valor = txtValor.Text;
                            oListaFiltrosQuery.Add(oFiltroQuery);
                            lblSeleccionCampos.Text = "Criterio Adicionado";
                            lblSeleccionCampos.ForeColor = Color.Green;

                            txtValor.Text = "";
                            txtInValor.Text = "";
                            LstInDetalle.Items.Clear();

                        }

                    }
                }

            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (LstCriterios.SelectedIndex >= 0)
            {
                oListaFiltrosQuery.RemoveAt(LstCriterios.SelectedIndex);
                LstCriterios.Items.Remove(LstCriterios.SelectedItem);
            }
        }

        private void cmbOrigenDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrigenDatos.SelectedIndex == 1)
            {
                cmbCampo.Items.Clear();

                for (int i = 0; i < oFiltosParametrosWeb.Count; i++)
                {
                    cmbCampo.Items.Add(oFiltosParametrosWeb[i].campo);
                }
            }

            if (cmbOrigenDatos.SelectedIndex == 0)
            {
                cmbCampo.Items.Clear();

                for (int i = 0; i < oFiltosParametrosSAP.Count; i++)
                {
                    cmbCampo.Items.Add(oFiltosParametrosSAP[i].campo);
                }
            }

        }







        //********************************************************************************

        //codigo fuente para el panel 2
        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            NegExcel oNegExcel = new NegExcel();

            openFileDialog.Filter = "XLS files (*.xls)|*.xls|All files (*.*)|*.*";
            openFileDialog.DefaultExt = "xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProgressBarIni(3);
                ds = oNegExcel.CargarHojaExcel(openFileDialog.FileName);
                ProgressBarAdd();
                txtODatosAdic_File.Text = openFileDialog.FileName;
                //                Microsoft.Office.Interop.Excel.Application excel;
                //                Workbook workbook;
                //                excel = new Microsoft.Office.Interop.Excel.Application();
                //                workbook = excel.Workbooks.Open(openFileDialog.FileName); //Abrir archivo

                //                Worksheet sheet = (Worksheet)workbook.Sheets[1];

                //                // Obtener el número de filas y columnas
                //                //int rows = sheet.Cells.MaxDataRow;
                //                //int rows = sheet.UsedRange.Columns[1, Type.Missing].Rows.Count;
                ////                int cols = sheet.UsedRange.Rows[1, Type.Missing].Cols.Count;

                //                int rows = sheet.UsedRange.Rows.Count;
                //                int cols = sheet.UsedRange.Columns.Count;

                //                DataTable dt = new DataTable();

                //                //int cols = sheet.Cells.MaxDataColumn;
                //                for (int j = 0; j < cols; j++)
                //                {
                //                    Console.WriteLine(sheet.Cells[0, j].Value);
                //                    dt.Columns.Add(sheet.Cells[0, j].Value2);                    
                //                }

                //                    // Bucle a través de filas
                //                for (int i = 0; i < rows; i++)
                //                {
                //                    DataRow dr = dt.NewRow();
                //                    // Recorra cada columna en la fila seleccionada
                //                    for (int j = 0; j < cols; j++)
                //                    {
                //                        // Valor de la celda de impresión
                //                        //Console.Write(sheet.Cells[i, j].Value + " | ");
                //                        dr[j] = sheet.Cells[i, j].Value;
                //                    }
                //                    dt.Rows.Add(dr);
                //                    // Salto de línea de impresión
                //                    //Console.WriteLine(" ");
                //                }



                //var numberOfRows = sheet.UsedRange.Columns[1, Type.Missing].Rows.Count;
                //var values = sheet.Range["A7:A" + numberOfRows].Value2;
                //for (int i = 1; i <= values.Length; i++)
                //{

                //    txt3.Text += (values[i, 1] + " ");
                //}



                //// Connect EXCEL sheet with OLEDB using connection string
                //// if the File extension is .XLS using below connection string
                ////In following sample 'szFilePath' is the variable for filePath
                //szConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                //       "Data Source = '" + szFilePath + 
                //       "';Extended Properties=\"Excel 8.0;HDR=YES;\"";

                //// if the File extension is .XLSX using below connection string
                //szConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;
                //      "Data Source='" + szFilePath +
                //      "';Extended Properties=\"Excel 12.0;HDR=YES;\"";


                //string excelFileName = openFileDialog.FileName;// "Book2.xls";
                ////string excelConnectString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Book2.xls;Extended Properties=""Excel 8.0;HDR=YES;""";
                ////string excelConnectString = @"Provider = Microsoft.Jet.OLEDB.4.0;Data Source = " + excelFileName + ";" + "Extended Properties = Excel 8.0; HDR=Yes;";
                //string excelConnectString = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source = " + excelFileName + ";" + "Extended Properties = Excel 12.0; HDR=Yes;IMEX=1";

                //OleDbConnection objConn = new OleDbConnection(excelConnectString);
                //OleDbCommand objCmd = new OleDbCommand("Select * From [Sheet1$]", objConn);

                //OleDbDataAdapter objDatAdap = new OleDbDataAdapter();
                //objDatAdap.SelectCommand = objCmd;
                //DataSet ds = new DataSet();
                //objDatAdap.Fill(ds);
                dsODatosAdic = ds;

                BindingSource source1 = new BindingSource();
                source1.DataSource = ds.Tables[0].DefaultView;
                ProgressBarAdd();
                // Set the data source for the DataGridView.

                dGVOrigenDatosAdic.DataSource = source1;
                chkListCampos.Items.Clear();
                if (ds.Tables[0].Columns.Count>=2)
                {                
                    for (int i= 1; i< ds.Tables[0].Columns.Count;i++ )
                    {
                        chkListCampos.Items.Add(ds.Tables[0].Columns[i].ColumnName);
                    }
                }
                ProgressBarAdd();
                ProgressBarFin();
            }

        }

        private void btnODatosAdic_Add_Click(object sender, EventArgs e)
        {
            int indiceODA = 0;
            if (txtODatosAdic_File.Text=="" || chkListCampos.CheckedItems.Count ==0)
            {
                return;
            }

            for (int j = 0; j< oListaOrigenDatosAdic.Count;j++)
            {
                if (oListaOrigenDatosAdic[j].Id > indiceODA)
                    indiceODA = oListaOrigenDatosAdic[j].Id;
            }

            OrigenDatosAdicionales oOrigenDatosAdic = new OrigenDatosAdicionales();

            oOrigenDatosAdic.Id = indiceODA+1;
            oOrigenDatosAdic.NombreODatos = "ODA" + oOrigenDatosAdic.Id;
            oOrigenDatosAdic.NombreArchivo = txtODatosAdic_File.Text;
            oOrigenDatosAdic.Detalle = dsODatosAdic;
            oOrigenDatosAdic.CamposSelect = new List<string>();

            for (int x = 0; x < chkListCampos.CheckedItems.Count; x++)
            {                
                oOrigenDatosAdic.CamposSelect.Add(chkListCampos.CheckedItems[x].ToString() );
            }

            oListaOrigenDatosAdic.Add(oOrigenDatosAdic);
            string filenameODA = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName).ToString();
            LboxODatosAdic.Items.Add(filenameODA);

            //limpio los campos usados //
            txtODatosAdic_File.Text = "";
            dGVOrigenDatosAdic.DataSource = null;
            chkListCampos.Items.Clear();
            //---------------------------------

        }

        private void btnODatosAdic_Remove_Click(object sender, EventArgs e)
        {
            if (LboxODatosAdic.SelectedIndex >= 0)
            {
                oListaOrigenDatosAdic.RemoveAt(LboxODatosAdic.SelectedIndex);
                LboxODatosAdic.Items.Remove(LboxODatosAdic.SelectedItem);
            }
        }

        private void btnInAdd_Click(object sender, EventArgs e)
        {
            if (cmbOrigenDatos.SelectedIndex >= 0)
            {
                if (cmbCampo.SelectedIndex >= 0)
                {
                    if (txtInValor.Text != "")
                    {

                        //if (cmbOrigenDatos.SelectedIndex == 0) //web
                        //{
                        //    if (oFiltosParametrosWeb[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "INT" && !double.TryParse(txtInValor.Text, out double result))
                        //    {
                        //        lblSeleccionCampos.Text = "Error en el tipo de datos digitado";
                        //        lblSeleccionCampos.ForeColor = Color.Red;
                        //        return;
                        //    }
                        //    if (oFiltosParametrosWeb[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "DECIMAL" && !double.TryParse(txtInValor.Text, out double resultdbl))
                        //    {
                        //        lblSeleccionCampos.Text = "Error en el tipo de datos digitado";
                        //        lblSeleccionCampos.ForeColor = Color.Red;
                        //        return;
                        //    }
                        //}
                        //else
                        {
                            if (oFiltosParametrosSAP[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "INT" && !double.TryParse(txtInValor.Text, out double result))
                            {
                                lblSeleccionCampos.Text = "Error en el tipo de datos digitado";
                                lblSeleccionCampos.ForeColor = Color.Red;
                                return;
                            }
                            if (oFiltosParametrosSAP[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "DECIMAL" && !double.TryParse(txtInValor.Text, out double resultdbl))
                            {
                                lblSeleccionCampos.Text = "Error en el tipo de datos digitado";
                                lblSeleccionCampos.ForeColor = Color.Red;
                                return;
                            }
                        }

                        LstInDetalle.Items.Add(txtInValor.Text);
                        txtInValor.Text = "";
                        lblSeleccionCampos.Text = "";
                    }
                }
            }

        }
        private  string devuelveListaIn ()
        {
            string resultado = "";
            for (int i=0; i<LstInDetalle.Items.Count; i++)
            {
                //if (cmbOrigenDatos.SelectedIndex == 0) //web
                //{
                //    if (oFiltosParametrosWeb[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "INT" || oFiltosParametrosWeb[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "DECIMAL")
                //    { resultado += LstInDetalle.Items[i].ToString() + ", "; }
                //    else
                //    { resultado += "'" + LstInDetalle.Items[i].ToString() + "', "; }
                //}
                //else
                {
                    if (oFiltosParametrosSAP[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "INT" || oFiltosParametrosSAP[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "DECIMAL")
                    { resultado += LstInDetalle.Items[i].ToString() + ", "; }
                    else
                    { resultado += "'" + LstInDetalle.Items[i].ToString() + "', "; }
                }
            }
            if (resultado.Length >2)
            {
            resultado = resultado.Remove(resultado.Length - 2); //elimino el ultima coma y el espacio
            resultado = "(" + resultado + ")";
            }
            
            return resultado;
        }

        private void btnInDel_Click(object sender, EventArgs e)
        {
            if (LstInDetalle.SelectedIndex >= 0)
            {                
                LstInDetalle.Items.Remove(LstInDetalle.SelectedItem);
            }
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOperador.SelectedIndex == 5 || cmbOperador.SelectedIndex ==6 )
            {
                gBoxIn.Visible = true;
                gBoxValor.Visible = false;
            }
            else
            {
                gBoxIn.Visible = false;
                gBoxValor.Visible = true;
            }
        }
        private void ProgressBarIni(int maximo)
        {
            pBarCatalogo.Minimum = 0;
            pBarCatalogo.Maximum = maximo;
            pBarCatalogo.Step = 1;
            pBarCatalogo.Style = ProgressBarStyle.Continuous;
            pBarCatalogo.Visible= true;
        }
        private void ProgressBarFin()
        {
            pBarCatalogo.Value = 0;
            pBarCatalogo.Visible = false;
        }
        private void ProgressBarAdd()
        {
            if (pBarCatalogo.Value + 1 <= pBarCatalogo.Maximum)
            {
                pBarCatalogo.Value += 1;
            }


        }

        private void cmbTipoCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoCatalogo = cmbTipoCatalogo.Text.ToUpper();
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCampo.SelectedIndex >=0 )
            {
                if (cmbOrigenDatos.Text =="SAP")
                {
                    if (oFiltosParametrosSAP[cmbCampo.SelectedIndex].tipoCampo == "LIST")
                    {
                        cmbValor.Visible = true;
                        cmbInValor.Visible = true;
                        txtValor.Visible = false;
                        NegFiltros onegFiltros = new NegFiltros();
                        DataSet dsFiltros = new DataSet();
                        dsFiltros = onegFiltros.EjecutaQuery(oFiltosParametrosSAP[cmbCampo.SelectedIndex ].DataSet);
                        
                        cmbValor.ValueMember = dsFiltros.Tables[0].Columns[0].ColumnName.ToString();
                        cmbValor.DisplayMember = dsFiltros.Tables[0].Columns[1].ColumnName.Trim();
                        cmbValor.DataSource = dsFiltros.Tables[0];

                        cmbInValor.ValueMember = dsFiltros.Tables[0].Columns[0].ColumnName.ToString();
                        cmbInValor.DisplayMember = dsFiltros.Tables[0].Columns[1].ColumnName.Trim();
                        cmbInValor.DataSource = dsFiltros.Tables[0];
                    }
                    else
                    {
                        cmbValor.Visible = false;
                        cmbInValor.Visible = false;
                        txtValor.Visible = true;
                    }

                }


            }



        }

        private void cmbValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbValor.SelectedIndex>=0)
            {
                txtValor.Text = cmbValor.SelectedValue.ToString();
            }
        }

        private void cmbInValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInValor.SelectedIndex >= 0)
            {
                txtInValor.Text = cmbInValor.SelectedValue.ToString();
            }
        }

        private void LlenarComboOperador()
        {


            List<ClsOperador> listaOperador = new List<ClsOperador>();
            ClsOperador oOperador1 = new ClsOperador();
            oOperador1.Id = "=";
            oOperador1.Descripcion = "Igual";
            listaOperador.Add(oOperador1);

            ClsOperador oOperador2 = new ClsOperador();
            oOperador2.Id = ">";
            oOperador2.Descripcion = "Mayor";
            listaOperador.Add(oOperador2);

            ClsOperador oOperador3 = new ClsOperador();
            oOperador3.Id = ">=";
            oOperador3.Descripcion = "Mayor Igual";
            listaOperador.Add(oOperador3);

            ClsOperador oOperador4 = new ClsOperador();
            oOperador4.Id = "<";
            oOperador4.Descripcion = "Menor";
            listaOperador.Add(oOperador4);

            ClsOperador oOperador5 = new ClsOperador();
            oOperador5.Id = "<=";
            oOperador5.Descripcion = "Menor Igual";
            listaOperador.Add(oOperador5);

            ClsOperador oOperador6= new ClsOperador();
            oOperador6.Id = "In";
            oOperador6.Descripcion = "Contiene";
            listaOperador.Add(oOperador6);

            ClsOperador oOperador7 = new ClsOperador();
            oOperador7.Id = "not in";
            oOperador7.Descripcion = "No contiene";
            listaOperador.Add(oOperador7);
            //Vaciar comboBox
            cmbOperador.DataSource = null;

            //Asignar la propiedad DataSource
            cmbOperador.DataSource = listaOperador;

            //Indicar qué propiedad se verá en la lista
            cmbOperador.DisplayMember = "Descripcion";

            //Indicar qué valor tendrá cada ítem
            cmbOperador.ValueMember = "Id";
        }

        private void pnlBottom_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
