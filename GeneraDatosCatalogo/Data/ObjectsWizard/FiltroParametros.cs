using DBConfig;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneraDatosCatalogo.Data.Wizard
{
    public class FiltroParametros
    {
        public int pk {get; set;}
        public string OrigenDatos { get; set; }
        public string Tabla { get; set; }
        public string campo { get; set;}
        public string tipoDato { get; set; }
        public string tipoCampo { get; set; }
        public string DataSet { get; set; }


    }

}
