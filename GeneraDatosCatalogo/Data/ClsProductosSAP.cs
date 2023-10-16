using DBConfig;
using GeneraDatosCatalogo.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace GeneraDatosCatalogo.Data
{
    class ClsProductosSAP
    {
        public RespuestaReg ObtenerDatosProductos(string Condicion)
        {
            
            NegParametro oNEgParametro = new NegParametro();
            NegFiltros oNegFiltros = new NegFiltros();
            RespuestaReg oRespuesta = new RespuestaReg();          

          
                try
                {
                    string connectionString="";
                    string queryProductos = "";


                    connectionString = oNEgParametro.BuscarParametro("DBSAP");
                    queryProductos = oNEgParametro.BuscarParametro("DataSetSAP");

                    //var reader = new AppSettingsReader();
                    //var stringSetting = reader.GetValue("conectarSAP", typeof(string));
                    //var stringSetting2 = reader.GetValue("TimeoutSAP", typeof(string));
                    //var stringSetting3 = reader.GetValue("QuerySAP", typeof(string));
                    //queryProductos = stringSetting3.ToString();
                    //connectionString = stringSetting.ToString();

                    queryProductos = oNegFiltros.CombinarQueryCondicion(queryProductos, Condicion);

                    OdbcConnection conn = new OdbcConnection(connectionString);
                    conn.ConnectionTimeout = 60;//int.Parse(stringSetting2.ToString());
                    conn.Open();

                    OdbcCommand sc = new OdbcCommand(queryProductos, conn);
                    OdbcDataAdapter da = new OdbcDataAdapter(sc);
                    DataSet ds = new DataSet("ProductosSAP");
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
