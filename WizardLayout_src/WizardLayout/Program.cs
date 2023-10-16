using GeneraDatosCatalogo.Data.Wizard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

 namespace WizardLayout
{
     public class ProgramWizard
    {

        public List<FiltroQuery> ListaFiltrosQuery { get; set; } //propiedad q devuelve todo lo escogido n filtros
        ///ojo aqui hay q incluir los otros objetos q se deben enviar desde Wizard a la forma q lo llamo.
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Application.Run(new frmParent());
        }
        public void inicio(ref List<FiltroQuery> ListaFiltrosQuery)
        {
            Application.EnableVisualStyles();
            frmParent ofrmParent = new frmParent(ref ListaFiltrosQuery);

            ofrmParent.ShowDialog();
            
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmParent());
        }
    }
}
