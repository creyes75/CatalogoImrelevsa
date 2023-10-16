
using GeneraDatosCatalogo.Data.Wizard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WizardLayout
{
    public partial class frm3 : Form
    {
      

        List<FiltroParametros> oFiltosParametrosWeb = new List<FiltroParametros>();
        List<FiltroParametros> oFiltosParametrosSAP = new List<FiltroParametros>();
        List<FiltroQuery> oListaFiltrosQuery = new List<FiltroQuery>();
        
        ClsWizard oClsWizard = new ClsWizard();
        public frm3(ref List<FiltroQuery> ListaFiltrosQuery)
        {
            InitializeComponent();
            oListaFiltrosQuery = ListaFiltrosQuery;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cmbOrigenDatos.SelectedIndex >=0)
            {
                if (cmbCampo.SelectedIndex >=0)
                {
                    if (cmbOperador.SelectedIndex>=0)
                    {
                        if (txtValor.Text.Trim() != "")
                        {
                            //validacion de duplicidad
                            for (int i = 0; i < oListaFiltrosQuery.Count; i++)
                            {
                                if (cmbOrigenDatos.Text == oListaFiltrosQuery[i].OrigenDatos && cmbCampo.Text == oListaFiltrosQuery[i].campo && cmbOperador.Text == oListaFiltrosQuery[i].operador )
                                    {
                                    return;
                                }
                            }
                            //validacion de tipo de datos
                            if(cmbOrigenDatos.SelectedIndex ==0) //web
                            {
                                if (oFiltosParametrosWeb[cmbCampo.SelectedIndex].tipoDato.ToUpper()=="INT" && !double.TryParse(txtValor.Text, out double result))
                                {
                                    return ;
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
            if(LstCriterios.SelectedIndex>=0)
            {                
                oListaFiltrosQuery.RemoveAt( LstCriterios.SelectedIndex);
                LstCriterios.Items.Remove(LstCriterios.SelectedItem);
            }
        }

        private void frm3_Load(object sender, EventArgs e)
        {
            oFiltosParametrosWeb = oClsWizard.Wzd_ObtenerDatosParametrosFiltro("Web");
            oFiltosParametrosSAP = oClsWizard.Wzd_ObtenerDatosParametrosFiltro("SAP");

            cmbOrigenDatos.SelectedIndex = 0;
        }

        private void cmbOrigenDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrigenDatos.SelectedIndex == 0)
            {
                cmbCampo.Items.Clear();

                for(int i=0; i< oFiltosParametrosWeb.Count; i++)
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
    }
}
