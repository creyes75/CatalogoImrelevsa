using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneraDatosCatalogo.Modelo
{
    public class RespuestaReg
    {
        public int errCodigo { get; set; }
        public string errMensaje { get; set; }
        public DataSet detalle { get; set; }
    }




}
