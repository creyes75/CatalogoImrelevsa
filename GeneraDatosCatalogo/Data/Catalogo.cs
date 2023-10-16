using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneraDatosCatalogo.Data
{
    public class Catalogo
    {
        public int Pk { get; set; }
        public string NombreCatalogo { get; set; }
        public string DescripcionCatalogo { get; set; }
        public string ODA { get; set; }
        public string FiltroSAP { get; set; }
        public string FiltroWeb { get; set; }
        public DataSet detalles { get; set; }
        public bool Modificado { get; set; } //definido para identificar si este catalogo fue modificado y esta pendiente de ser almacenado.
        public String TipoCatalogo { get; set; }
    }
}
