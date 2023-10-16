using DBConfig;
using GeneraDatosCatalogo.Data;
using GeneraDatosCatalogo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneraDatosCatalogo.Vista
{
    public partial class FrmMantOrden : Form
    {


        private string intpk;
        private NegOrden oNegOrden = new NegOrden();
        // Private negTipComp As New NegTiposComprob.NegTiposComprob
        private bool bCargando = false;
        private string strAccion = "";
        private Boolean Editando = false;
        
        private int TipoPK;
        private DataTable dtsAnticipoRol = new DataTable();

        //private SqlClient.SqlConnection con;
        // Private dtsAntQuincena As New DataTable

        private DataTable dtMensajeImportarRegistros = new DataTable();

        public void AccionBuscar()
        {
            FrmOrdenBusqueda objBuscar = new FrmOrdenBusqueda();
            objBuscar.Origen = "O";
            objBuscar.ShowDialog();
            if (string.IsNullOrEmpty(objBuscar.Pk))
            {
                objBuscar.Pk = "";
            }
            
            CargarDatos(objBuscar.Pk);
            if (String.IsNullOrEmpty(objBuscar.Pk ))
            {
                AccionCancelar();
            }
           
        }

        public void CargarDatos(string Pk)
        {
            bCargando = true;
            this.GroupBox1.Enabled = true;

            if (this.oNegOrden.Leer(Pk))
            {
                this.LimpiarDatos();

                this.txtProductoId.Text = oNegOrden.ProductoId;
                this.txtIdNivel1.Text = oNegOrden.IdNivel1;
                this.txtIdNivel2.Text = oNegOrden.IdNivel2;
                this.txtIdNivel3.Text = oNegOrden.IdNivel3;
                this.txtIdNivel4.Text = oNegOrden.IdNivel4;
                this.txtIdNivel5.Text = oNegOrden.IdNivel5;
                this.txtOrdenNivel6.Text = oNegOrden.OrdenNivel6;                
                NUDOrden.Value = oNegOrden.Orden;
               
                this.lblAnular.Text = ""; // oNegOrden.Estado

                this.intpk = Pk;

                // Select Case oNegOrden.Estado
                // Case "E"
                // LblAnular.Text = "ACTIVO"
                this.GroupBox1.Enabled = true;
                ActivarDesactivarBotones("Consultar");
                this.strAccion = "U";

                // Case "A"
                // LblAnular.Text = "ANULADO"
                // MyBase.ActivarDesactivarBotones(Maestros.FrmMaestro.Accion.Anular)
                // bCargando = False : GroupBox1.Enabled = False 'bloque el formulario
                // Exit Sub ' salta todos los demas pasos y va al ensub
                // End Select

                bCargando = false;
            }
            bCargando = false;
        }



        public void Colocar_Modificacion()
        {
            if (btnGrabar.Enabled == false & !bCargando)
            {
                this.strAccion = "U";
                ActivarDesactivarBotones("Modificar");
                Editando = true;
            }
        }
        public void Armar_OrdenNivel6()
        {
            txtOrdenNivel6.Text = txtIdNivel1.Text + "-" + txtIdNivel2.Text + "-"+ txtIdNivel3.Text + "-" + txtIdNivel4.Text + "-" + txtIdNivel5.Text + "-"+ NUDOrden.Value.ToString().PadLeft(3, '0');
        }

        public void ActivarDesactivarBotones(string accion)
        {
            BtnNuevo.Enabled = false;
            btnBuscar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGrabar.Enabled = false;
            btnSalir.Enabled = false;
            if (accion == "Cancelar")
            {
                BtnNuevo.Enabled = true;
                btnBuscar.Enabled = true;
                btnSalir.Enabled = true;
            }
            if (accion == "Nuevo")
            {
                btnGrabar.Enabled = true;
                btnCancelar.Enabled = true;
                btnSalir.Enabled = true;
            }
            if (accion == "Modificar")
            {
                btnGrabar.Enabled = true;
                btnCancelar.Enabled = true;
                btnSalir.Enabled = true;
            }
            if (accion == "Consultar")
            {
                btnEliminar.Enabled = true;
                btnCancelar.Enabled = true;
                btnSalir.Enabled = true;
            }

        }

        public void AccionAgregar()
        {
            ActivarDesactivarBotones("Nuevo");
            LimpiarDatos();
            GroupBox1.Enabled = true;

            this.strAccion = "I";

        }

        public void AccionCancelar()
        {
            this.LimpiarDatos();
            ActivarDesactivarBotones("Cancelar");
            this.GroupBox1.Enabled = false;
        }

        public void AccionGrabar()
        {
            bool st_Transaccion = false;

            if (Validar() == false)
                return;

            

            try
            {
               
                // negTablaImpRenta.EnTransaccion = True
                oNegOrden.Accion = strAccion;
                oNegOrden.ProductoId = intpk; // intpk  GRABA EN la cabecera y el detalle

                oNegOrden.ProductoId = this.txtProductoId.Text;
                oNegOrden.IdNivel1 = this.txtIdNivel1.Text;
                oNegOrden.IdNivel2 = this.txtIdNivel2.Text;
                oNegOrden.IdNivel3 = this.txtIdNivel3.Text;
                oNegOrden.IdNivel4 = this.txtIdNivel4.Text;
                oNegOrden.IdNivel5 = this.txtIdNivel5.Text;
                oNegOrden.TipoModif =  this.cmbTipoModificacion.Text.Substring(0, 1);

                oNegOrden.Orden = this.NUDOrden.Value;
                oNegOrden.OrdenNivel6= this.txtOrdenNivel6.Text;
                

                // Select Case oNegOrden.Accion
                // Case "I"
                // oNegOrden.Estado = "E"
                // Case "U"
                // oNegOrden.Estado = "E"
                // Case "A"
                // Me.LblAnular.Text = "Anulado"
                // oNegOrden.Estado = "A"
                // Me.GroupBox1.Enabled = False
                // End Select
                // oNegOrden.Usr_pk = UsuarioPk

                this.oNegOrden.Grabar();
                intpk = oNegOrden.ProductoId;

                //this.oNegOrden.GrabarTransaccion();
                st_Transaccion = false;

                MessageBox.Show("Grabados con exito ", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.CargarDatos(intpk);

                ActivarDesactivarBotones("Consultar");

                //this.oNegOrden.Desconectar();

                AccionAgregar();
                AccionCancelar();
                ActivarDesactivarBotones("Nuevo");

                ActivarDesactivarBotones("Cancelar");
            }

            // ' si hay error regresa
            catch (Exception ex)
            {
               

                MessageBox.Show(ex.Message);
            }


            //this.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        public void AccionAnular()
        {
           
            if (MessageBox.Show("¿Está Seguro de Anular estos registro?", "Mensaje del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                // Cambia el estatus a Anulado
                this.strAccion = "A";              
                try
                {
                    this.oNegOrden.ProductoId = this.intpk;
                    oNegOrden.Accion = strAccion;
                    // Da parametros de conexión y transaciòn
                    this.oNegOrden.Anular();

                    //this.oNegOrden.GrabarTransaccion();
                   this.lblAnular.Text = "ANULADO";
                    AccionAgregar();
                    AccionCancelar();
                    ActivarDesactivarBotones("Cancelar");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

                
                //ActivarDesactivarBotones("Anular");
            }
            else
                ActivarDesactivarBotones("Consultar");

            Editando = false;
            this.GroupBox1.Enabled = false;
        }



        public void LimpiarDatos()
        {

            // Me.GroupBox1.Enabled = True
            strAccion = "I";
            this.txtProductoId.Text = "";
            this.txtIdNivel1.Text = "";
            this.txtIdNivel2.Text = "";
            this.txtIdNivel3.Text = "";
            this.txtIdNivel4.Text = "";
            this.txtIdNivel5.Text = "";
            this.txtOrdenNivel6.Text = "";
            this.cmbTipoModificacion.SelectedIndex = 0;
            NUDOrden.Value = 0;
            this.GroupBox1.Enabled = true;
            this.intpk = "";
            this.lblAnular.Text = "";
        }

        public bool Validar()
        {
            if (this.txtProductoId.Text=="")
            {
                //ErrorProvider1.SetError(this.CboVendedor, "");
                MessageBox.Show("Ingrese el Producto Id.", "Mensaje al Usuario");
                return false;
            }
            if (cmbTipoModificacion.Text.Substring(0,1)!="A")
            {
                if (NUDOrden.Value ==0)
                    {
                        //ErrorProvider1.SetError(this.NUDDiasCarteraMax, "");
                        MessageBox.Show("Ingrese un valor de Orden Valido.", "Mensaje al Usuario");
                        return false;
                    }
            }
            

            if (this.txtIdNivel1.Text == "")
            {              
                MessageBox.Show("Ingrese el Nivel 1.", "Mensaje al Usuario");
                return false;
            }
            if (this.txtIdNivel2.Text == "")
            {
                MessageBox.Show("Ingrese el Nivel 2.", "Mensaje al Usuario");
                return false;
            }
            if (this.txtIdNivel3.Text == "")
            {
                MessageBox.Show("Ingrese el Nivel 3.", "Mensaje al Usuario");
                return false;
            }

            if (this.txtIdNivel4.Text == "")
            {
                MessageBox.Show("Ingrese el Nivel 4.", "Mensaje al Usuario");
                return false;
            }
            if (this.txtIdNivel5.Text == "")
            {
                MessageBox.Show("Ingrese el Nivel 5.", "Mensaje al Usuario");
                return false;
            }


            return true;
        }

        public FrmMantOrden()
        {
            InitializeComponent();
        }
        public void FrmMantOrden_Load(object sender, EventArgs e)
            {
            AccionCancelar();
            }

        private void txtProductoId_TextChanged(object sender, EventArgs e)
        {
            Colocar_Modificacion();

                
                


        }

        private void txtIdNivel1_TextChanged(object sender, EventArgs e)
        {
            Colocar_Modificacion();
            Armar_OrdenNivel6();
        }

        private void txtIdNivel2_TextChanged(object sender, EventArgs e)
        {
            Colocar_Modificacion();
            Armar_OrdenNivel6();
        }

        private void txtIdNivel3_TextChanged(object sender, EventArgs e)
        {
            Colocar_Modificacion();
            Armar_OrdenNivel6();
        }

        private void txtIdNivel4_TextChanged(object sender, EventArgs e)
        {
            Colocar_Modificacion();
            Armar_OrdenNivel6();
        }

        private void txtIdNivel5_TextChanged(object sender, EventArgs e)
        {
            Colocar_Modificacion();
            Armar_OrdenNivel6();
        }

        private void NUDOrden_ValueChanged(object sender, EventArgs e)
        {
            Colocar_Modificacion();
            Armar_OrdenNivel6();
        }

        private void txtOrdenNivel6_TextChanged(object sender, EventArgs e)
        {
            Colocar_Modificacion();
        }

        private void cmbTipoModificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Colocar_Modificacion();            
            if (strAccion=="I" || strAccion=="U")
            {
                if (cmbTipoModificacion.Text.Substring(0,1) =="A")
                    {
                        NUDOrden.Enabled = false;
                        NUDOrden.Value = 0;
                    }
                else
                {
                    NUDOrden.Enabled = true;
                }
            }
            
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            AccionAgregar();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            AccionGrabar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AccionAnular();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AccionBuscar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AccionCancelar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultaSAP_Click(object sender, EventArgs e)
        {
            ClsOrdenSAP oclsOrdenSAP = new ClsOrdenSAP();

            RespuestaReg oRespuestaReg = new RespuestaReg();
            oRespuestaReg = oclsOrdenSAP.ObtenerDatosProductos("\"ItemCode\" = '" + txtProductoId.Text + "'");
            if (oRespuestaReg.errCodigo ==0)
            {
                DataSet dsOrdenSAP = new DataSet();
                dsOrdenSAP = oRespuestaReg.detalle;

                if (dsOrdenSAP.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dsOrdenSAP.Tables[0].Rows[0];                    
                    txtIdNivel1.Text = row["IdNivel1"].ToString().Trim();
                    txtIdNivel2.Text = row["IdNivel2"].ToString().Trim();
                    txtIdNivel3.Text = row["IdNivel3"].ToString().Trim();
                    txtIdNivel4.Text = row["IdNivel4"].ToString().Trim();
                    txtIdNivel5.Text = row["IdNivel5"].ToString().Trim();
                }

            }

        }

        private void txtProductoId_Leave(object sender, EventArgs e)
        {

            if ((strAccion == "I") || (strAccion == "U"))
            {
                oNegOrden.Accion = strAccion;
                oNegOrden.ProductoId = this.txtProductoId.Text;
                this.oNegOrden.Leer(oNegOrden.ProductoId);
                if (string.IsNullOrEmpty(oNegOrden.IdNivel1))
                { strAccion = "I"; }
                else
                { strAccion = "U"; }
                intpk = oNegOrden.ProductoId;
            }
        }
    }
}
