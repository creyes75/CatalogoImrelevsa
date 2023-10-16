
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
            public List<FiltroParametros> Wzd_ObtenerDatosParametrosFiltro(string OrigenDatos)
            {
                NegFiltros oNegFiltros = new NegFiltros();
                DataTable dtFiltros = new DataTable();
                dtFiltros = oNegFiltros.BuscarFiltros(OrigenDatos);
                List<FiltroParametros> oListaFiltros = new List<FiltroParametros>();

                for (int i = 0; i < dtFiltros.Rows.Count; i++)
                {
                    FiltroParametros oFiltro = new FiltroParametros();
                    oFiltro.pk = i;
                    oFiltro.OrigenDatos = dtFiltros.Rows[i]["OrigenDatos"].ToString();
                    oFiltro.Tabla= dtFiltros.Rows[i]["Tabla"].ToString();
                    oFiltro.campo = dtFiltros.Rows[i]["Campo"].ToString();
                    oFiltro.tipoDato = dtFiltros.Rows[i]["TipoDato"].ToString();
                    oFiltro.tipoCampo = dtFiltros.Rows[i]["TipoCampo"].ToString();
                    oFiltro.DataSet = dtFiltros.Rows[i]["DataSource"].ToString();

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
                                    if (oListaFiltroQuery[i].operador.ToUpper().ToString()== "IN" || oListaFiltroQuery[i].operador.ToUpper().ToString() == "NOT IN" )
                                    {
                                        queryFinal = queryFinal + oListaFiltroQuery[i].valor.ToString();
                                    }
                                    else
                                    {
                                        queryFinal = queryFinal + "'" + oListaFiltroQuery[i].valor.ToString() + "'";
                                    }                                    
                                }
                            if (oListaFiltroQuery[i].tipoDato.ToUpper() == "INT" || oListaFiltroQuery[i].tipoDato.ToUpper() == "DECIMAL")
                            {
                                queryFinal = queryFinal + oListaFiltroQuery[i].valor.ToString() ;
                            }
                            queryFinal = queryFinal + " And ";
                        }
                    }
                    if (queryFinal.Length > 0)
                    {
                        queryFinal = queryFinal.TrimEnd();
                        queryFinal = queryFinal.Remove(queryFinal.Length - 3); //eimino el ultimo AND
                    }
                    return queryFinal.TrimEnd();
                }

    }
    
}
