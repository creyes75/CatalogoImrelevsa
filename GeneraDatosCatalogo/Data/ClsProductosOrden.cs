using DBConfig;
using GeneraDatosCatalogo.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace GeneraDatosCatalogo.Data
{
    class ClsProductosOrden
    {
        public RespuestaReg ObtenerDatosOrden(string Condicion)
        {
            NegOrden oNegOrden = new NegOrden();            
            RespuestaReg oRespuesta = new RespuestaReg();
            try
            {                
                DataSet dsOrden = new DataSet();            
                dsOrden = oNegOrden.ObtenerOrdenProductos();
                
                oRespuesta.errCodigo = 0;
                oRespuesta.errMensaje = "";
                oRespuesta.detalle = dsOrden;      
                return oRespuesta;
            }


            catch (Exception ex)
            {
                oRespuesta.errCodigo = -1000;
                oRespuesta.errMensaje = ex.Message;
                return oRespuesta;
            }

        }


    }
}
