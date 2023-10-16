using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneraDatosCatalogo.Data.ObjectsWizard
{
    //class OrigenDatosAdicional
    //{
    //    public List<OrigenDatos> OrigenDatosAdic{ get; set; }
    //}

    public class OrigenDatosAdicionales
    {
        public int Id;
        public string NombreODatos;
        public string NombreArchivo; //xls
        public DataSet Detalle;//": "CIUDAD CELESTE",
        public List<string> CamposSelect;//": "GUAYAQUIL",
        
    }
}
