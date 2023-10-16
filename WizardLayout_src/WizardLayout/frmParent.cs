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
    public partial class frmParent : Form
    {
        static List<FiltroQuery> parListaFiltrosQuery = new List<FiltroQuery>();
        //se asocia la lista de Filtros como referencia

        Form[] frm = { new frm1(), new frm2(), new frm3(ref parListaFiltrosQuery) };
        int top = -1;
        int count;

        public frmParent(ref List<FiltroQuery> ListaFiltrosQuery)
        {
            count = frm.Count();
            parListaFiltrosQuery = ListaFiltrosQuery;
            InitializeComponent();
        }
        private void LoadNewForm()
        {

            frm[top].TopLevel = false;
            frm[top].AutoScroll = true;
            frm[top].Dock = DockStyle.Fill;
            this.pnlContent.Controls.Clear();
            //if (top ==3)
            //{
            //        ListaFiltrosQuery.Clear();
            //}
            
            this.pnlContent.Controls.Add(frm[top]);
            //falta inicializar ListaFiltosQuery

            frm[top].Show();
            

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

        private void frmParent_Load(object sender, EventArgs e)
        {
            Next();
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
    }
}
