using DBConfig;
using GeneraDatosCatalogo.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneraDatosCatalogo.Data
{
    public class ClsOrdenSAP
    {

        public RespuestaReg ObtenerDatosProductos(string Condicion)
        {

            NegParametro oNEgParametro = new NegParametro();
            RespuestaReg oRespuesta = new RespuestaReg();


            try
            {
                string connectionString = "";
                string queryOrden = "";


                connectionString = oNEgParametro.BuscarParametro("DBSAP");
                queryOrden = oNEgParametro.BuscarParametro("DataSetOrd");
                NegFiltros oNegFiltros = new NegFiltros();
                queryOrden = oNegFiltros.CombinarQueryCondicion(queryOrden, Condicion);

                //var reader = new AppSettingsReader();
                //var stringSetting = reader.GetValue("conectarSAP", typeof(string));
                //var stringSetting2 = reader.GetValue("TimeoutSAP", typeof(string));
                //var stringSetting3 = reader.GetValue("QuerySAP", typeof(string));
                //queryProductos = stringSetting3.ToString();
                //connectionString = stringSetting.ToString();

                OdbcConnection conn = new OdbcConnection(connectionString);
                conn.ConnectionTimeout = 60;//int.Parse(stringSetting2.ToString());
                conn.Open();

                OdbcCommand sc = new OdbcCommand(queryOrden, conn);
                OdbcDataAdapter da = new OdbcDataAdapter(sc);
                DataSet ds = new DataSet("OrdenSAP");
                da.Fill(ds);
                oRespuesta.errCodigo = 0;
                oRespuesta.errMensaje = "";
                oRespuesta.detalle = ds;

                conn.Close();
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
