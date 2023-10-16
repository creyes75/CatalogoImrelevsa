using GeneraDatosCatalogo.Data.Wizard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        ClsWizard oClsWizard = new ClsWizard();
        //-----------------

        public FrmWizard()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
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

            if (top == 1) { PnlOpt1.Visible = true; }
            if (top == 2) { PnlOpt2.Visible = true; }
            if (top == 3) { PnlOpt3.Visible = true; }

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
            Next();

            //load para la pnelOpt3
            oFiltosParametrosWeb = oClsWizard.Wzd_ObtenerDatosParametrosFiltro("Web");
            oFiltosParametrosSAP = oClsWizard.Wzd_ObtenerDatosParametrosFiltro("SAP");
            cmbOrigenDatos.SelectedIndex = 0;
            //------------------------------------

        }
        //********************************************************************************
        //fuente para panelOpt3
        private void btnAdd_Click(object sender, EventArgs e)
        {
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
                                if (cmbOrigenDatos.Text == oListaFiltrosQuery[i].OrigenDatos && cmbCampo.Text == oListaFiltrosQuery[i].campo && cmbOperador.Text == oListaFiltrosQuery[i].operador)
                                {
                                    return;
                                }
                            }
                            //validacion de tipo de datos
                            if (cmbOrigenDatos.SelectedIndex == 0) //web
                            {
                                if (oFiltosParametrosWeb[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "INT" && !double.TryParse(txtValor.Text, out double result))
                                {
                                    return;
                                }
                                if (oFiltosParametrosWeb[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "DECIMAL" && !double.TryParse(txtValor.Text, out double resultdbl))
                                {
                                    return;
                                }
                                if (oFiltosParametrosWeb[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "DATE" && !DateTime.TryParse(txtValor.Text, out DateTime resultdt))
                                {
                                    return;
                                }

                            }
                            else
                            {
                                if (oFiltosParametrosSAP[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "INT" && !double.TryParse(txtValor.Text, out double result))
                                {
                                    return;
                                }
                                if (oFiltosParametrosSAP[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "DECIMAL" && !double.TryParse(txtValor.Text, out double resultdbl))
                                {
                                    return;
                                }
                                if (oFiltosParametrosSAP[cmbCampo.SelectedIndex].tipoDato.ToUpper() == "DATE" && !DateTime.TryParse(txtValor.Text, out DateTime resultdt))
                                {
                                    return;
                                }
                            }

                            //-------------------------------
                            //-------------------------------
                            //agrado texto a la lista en pantalla
                            LstCriterios.Items.Add(cmbCampo.Text + " " + cmbOperador.Text + " " + txtValor.Text);
                            FiltroQuery oFiltroQuery = new FiltroQuery();
                            //anado el elemento a la lista de campos seleccionados
                            oFiltroQuery.OrigenDatos = cmbOrigenDatos.Text;
                            if (cmbOrigenDatos.SelectedIndex == 0)
                            {
                                oFiltroQuery.campo = oFiltosParametrosWeb[cmbCampo.SelectedIndex].campo;
                                oFiltroQuery.tipoDato = oFiltosParametrosWeb[cmbCampo.SelectedIndex].tipoDato;
                                oFiltroQuery.Tabla = oFiltosParametrosWeb[cmbCampo.SelectedIndex].Tabla;
                            }
                            else
                            {
                                oFiltroQuery.campo = oFiltosParametrosSAP[cmbCampo.SelectedIndex].campo;
                                oFiltroQuery.tipoDato = oFiltosParametrosSAP[cmbCampo.SelectedIndex].tipoDato;
                                oFiltroQuery.Tabla = oFiltosParametrosSAP[cmbCampo.SelectedIndex].Tabla;
                            }
                            oFiltroQuery.operador = cmbOperador.Text;
                            oFiltroQuery.valor = txtValor.Text;
                            oListaFiltrosQuery.Add(oFiltroQuery);
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
            if (cmbOrigenDatos.SelectedIndex == 0)
            {
                cmbCampo.Items.Clear();

                for (int i = 0; i < oFiltosParametrosWeb.Count; i++)
                {
                    cmbCampo.Items.Add(oFiltosParametrosWeb[i].campo);
                }
            }

            if (cmbOrigenDatos.SelectedIndex == 1)
            {
                cmbCampo.Items.Clear();

                for (int i = 0; i < oFiltosParametrosSAP.Count; i++)
                {
                    cmbCampo.Items.Add(oFiltosParametrosSAP[i].campo);
                }
            }

        }
        //********************************************************************************
    }
}
