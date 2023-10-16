using DBConfig;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneraDatosCatalogo.Data.Wizard
{
    class ClsWizard
    {
            public List<FiltroParametros> Wzd_ObtenerDatosParametrosFiltro()
            {
                NegFiltros oNegFiltros = new NegFiltros();
                DataTable dtFiltros = new DataTable();
                dtFiltros = oNegFiltros.BuscarFiltros();
                List<FiltroParametros> oListaFiltros = new List<FiltroParametros>();

                for (int i = 0; i < dtFiltros.Rows.Count; i++)
                {
                    FiltroParametros oFiltro = new FiltroParametros();
                    oFiltro.pk = i;
                    oFiltro.OrigenDatos = dtFiltros.Rows[i]["OrigenDatos"].ToString();
                    oFiltro.Tabla= dtFiltros.Rows[i]["Tabla"].ToString();
                    oFiltro.campo = dtFiltros.Rows[i]["Campo"].ToString();
                    oFiltro.tipoDato = dtFiltros.Rows[i]["TipoDato"].ToString();
                    oListaFiltros.Add(oFiltro);                                               
                }
            return oListaFiltros;
            }
            public string GeneraFiltosQuery(List<FiltroQuery> oListaFiltroQuery, string OrigenDatos)
                {
                    List<FiltroQuery> oListaFiltrosQuery = new List<FiltroQuery>();
                    
                    string queryFinal = "";
                    for (int i=0; i< oListaFiltroQuery.Count; i++)
                    {
                        if (oListaFiltroQuery[i].OrigenDatos.ToString() == OrigenDatos)
                        {
                           
                            queryFinal = queryFinal + oListaFiltroQuery[i].Tabla.ToString() + "." + oListaFiltroQuery[i].campo.ToString() + " " + oListaFiltroQuery[i].operador.ToString();
                            if (oListaFiltroQuery[i].tipoDato.ToUpper() == "STRING" || oListaFiltroQuery[i].tipoDato.ToUpper() == "DATE")
                                {
                                     queryFinal = queryFinal + "'" + oListaFiltroQuery[i].valor.ToString() + "'";
                                }
                            if (oListaFiltroQuery[i].tipoDato.ToUpper() == "INT" || oListaFiltroQuery[i].tipoDato.ToUpper() == "DECIMAL")
                            {
                                queryFinal = queryFinal + oListaFiltroQuery[i].valor.ToString() ;
                            }
                            queryFinal = queryFinal + " And ";
                        }
                    }
                    queryFinal = queryFinal.Remove(queryFinal.Length - 3); //eimino el ultimo AND
                    return queryFinal.TrimEnd();
                }

    }
    
}
