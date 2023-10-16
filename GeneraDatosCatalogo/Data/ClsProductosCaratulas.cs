using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Odbc;
using System.Data;
using GeneraDatosCatalogo.Modelo;
using DBConfig;

namespace GeneraDatosCatalogo.Data
{
    class ClsProductosCaratula
    {
        public RespuestaReg ObtenerDatosProductos(string Condicion)
        {
            RespuestaReg oRespuesta = new RespuestaReg();
            NegParametro oNEgParametro = new NegParametro();
            NegFiltros oNegFiltros = new NegFiltros();
            try
            {
                string connectionString;
                string queryCaratula = "";

               
                connectionString = oNEgParametro.BuscarParametro("DBCaratula");
                queryCaratula = oNEgParametro.BuscarParametro("DataSetCar");

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    queryCaratula = oNegFiltros.CombinarQueryCondicion(queryCaratula, Condicion);

                    SqlCommand cmd = new SqlCommand(queryCaratula, conn);

                    conn.Open();
                    cmd.CommandTimeout = 30;
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter theDataAdapter = new SqlDataAdapter(cmd);

                    DataSet DsProductos = new DataSet();
                    theDataAdapter.Fill(DsProductos);
                    cmd.Connection.Close();

                    oRespuesta.errCodigo = 0;
                    oRespuesta.errMensaje = "";
                    oRespuesta.detalle = DsProductos;

                    conn.Close();
                }
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
