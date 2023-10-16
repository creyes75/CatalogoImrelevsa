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
using GeneraDatosCatalogo.Data;

namespace GeneraDatosCatalogo.Vista
{
    public partial class FrmSave : Form
    {
        //public Int32 Pk { get; set; }
        //public string ODA { get; set; }
        //public string Filtro { get; set; }
        //public string Filtro2 { get; set; }
        //public DataSet ds { get; set; }
        public bool ProcesoCancelado { get; set; }
        public bool GrabadoExitoso { get; set; }

        public Catalogo oCatalogo { get; set; }

        public FrmSave()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            NegLogCatalogo oNegLogCatalogo = new NegLogCatalogo();
            oCatalogo.NombreCatalogo = txtNombre.Text;
            oCatalogo.DescripcionCatalogo = txtDescripcion.Text;

            oNegLogCatalogo.nombreCatalogo = txtNombre.Text;
            oNegLogCatalogo.descripcion = txtDescripcion.Text;
            oNegLogCatalogo.ODA = oCatalogo.ODA;
            oNegLogCatalogo.filtros = oCatalogo.FiltroSAP;
            oNegLogCatalogo.filtros2 = oCatalogo.FiltroWeb;
            oNegLogCatalogo.detalle = oCatalogo.detalles;
            oNegLogCatalogo.TipoCatalogo = oCatalogo.TipoCatalogo;
            ProcesoCancelado = false;

            oCatalogo.Pk = oNegLogCatalogo.NuevoCatalogo();
            if (oCatalogo.Pk != -10000)
            {
                MessageBox.Show("Catalogo " + oNegLogCatalogo.nombreCatalogo + " almacenado con exito", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);                
                GrabadoExitoso = true;
            }
            else
            {
                MessageBox.Show("Se presento un error al grabar un nuevo catalogo");
                GrabadoExitoso = false;
            }
            this.Close();

            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GrabadoExitoso = false;
            ProcesoCancelado = true;
            this.Close();
        }
    }
}
