using DBConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneraDatosCatalogo.Vista
{
    public partial class FrmOrdenBusqueda : Form
    {
        public FrmOrdenBusqueda()
        {
            InitializeComponent();
        }

        private void FrmOrdenBusqueda_Load(object sender, EventArgs e)
        {
            AccionBuscar();
        }




        //*******************************************************************

        public string Pk { get; set; }
        public string Origen { get; set; } // V de ventas o C de Cartera, P de producto o R de RRHH
        private NegOrden oNegOrden = new NegOrden();
        
        //private SqlClient.SqlConnection con;
        public void AccionBuscar()
        {
            try
            {
                if (Origen == "O")
                {
                    BindingSource bindingSource1 = new BindingSource();
                    
                    //this.dgrBusqueda.DataSource = 
                    // Automatically generate the DataGridView columns.
                    dgrBusqueda.AutoGenerateColumns = true;

                    // Set up the data source.
                    bindingSource1.DataSource = oNegOrden.BuscarReg();
                    dgrBusqueda.DataSource = bindingSource1;

                    // Automatically resize the visible rows.
                    dgrBusqueda.AutoSizeRowsMode =
                        DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

                    // Set the DataGridView control's border.
                    dgrBusqueda.BorderStyle = BorderStyle.Fixed3D;

                    // Put the cells in edit mode when user enters them.
                    dgrBusqueda.EditMode = DataGridViewEditMode.EditOnEnter;


                    //this.negConfigVentas.Desconectar();
                }
                
            }
            catch (Exception ex)
            {
                //if (Origen == "O")
                //    this.oNegOrden.Desconectar();
                
                MessageBox.Show(ex.Message);
            }
        }

        private void dgrBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrBusqueda_DoubleClick(object sender, EventArgs e)
        {
            if (dgrBusqueda.Rows.Count > 0)
            {
                if (dgrBusqueda.CurrentRow.Cells[0].Value.ToString() != "")
                    Pk = dgrBusqueda.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            

            }
        }

        private void dgrBusqueda_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        //-----------------------------------------------------------------
    }
}
