using DBConfig;
using GeneraDatosCatalogo.Data;
using GeneraDatosCatalogo.Data.ObjectsWizard;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Dynamic;


using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WebApi.Data;

namespace GeneraDatosCatalogo.Modelo
{
    class ODA_Campos
    {
        public string Tabla { get; set; }
        public string Campo { get; set; }
        public string TipoDato { get; set; }
    }
    class NegCatalogo
    {
        public RespuestaReg CargaNuevoCatalogo(string CondicionSAP, string CondicionWeb, List<OrigenDatosAdicionales> ListaOrigenDatosAdic, string TipoCatalogo)
        {
            RespuestaReg oRespuestaCatalogo = new RespuestaReg();
            try
            { //para la grabacion del log

                AuxLogAPI Log = new AuxLogAPI();
                bool rLog = true;
                rLog = Log.RegistraLog("NegCatalogo.CargaNuevoCatalogo", "**************************NUEVA EJECUCION " + DateTime.Now.ToString() + "********************************************");
                


                RespuestaReg oRespuestaSAP = new RespuestaReg();
                ClsProductosSAP oProductosSAP = new ClsProductosSAP();
                DataSet dsSAP = new DataSet();
                oRespuestaSAP = oProductosSAP.ObtenerDatosProductos(CondicionSAP);
                rLog = Log.RegistraLog("NegCatalogo.CargaNuevoCatalogo", "se recuperaron los productos de SAP: " + oRespuestaSAP.errMensaje);

                dsSAP = oRespuestaSAP.detalle;

                if(oRespuestaSAP.errCodigo != 0)
                {
                    oRespuestaCatalogo.errCodigo = oRespuestaSAP.errCodigo;
                    oRespuestaCatalogo.errMensaje = "Error en ejecucion Query SAP: " + oRespuestaSAP.errMensaje;
                    return oRespuestaCatalogo;
                }
                
               

                //RespuestaReg oRespuestaWeb = new RespuestaReg();
                //DataSet dsWeb = new DataSet();
                //ClsProductosWeb oProductosWeb = new ClsProductosWeb();
                //oRespuestaWeb = oProductosWeb.ObtenerDatosProductos(CondicionWeb);
                //dsWeb = oRespuestaWeb.detalle;

                RespuestaReg oRespuestaOrden = new RespuestaReg();
                ClsProductosOrden oProductosOrden = new ClsProductosOrden();
                DataSet dsOrden = new DataSet();
                oRespuestaOrden = oProductosOrden.ObtenerDatosOrden("");

                if (oRespuestaOrden.errCodigo != 0)
                {
                    oRespuestaCatalogo.errCodigo = oRespuestaOrden.errCodigo;
                    oRespuestaCatalogo.errMensaje = "Error en ejecucion Query Orden: " + oRespuestaOrden.errMensaje;
                    return oRespuestaCatalogo;
                }

                dsOrden = oRespuestaOrden.detalle;
                rLog = Log.RegistraLog("NegCatalogo.CargaNuevoCatalogo", "se recuperaron los datos de ordenamiento: " + oRespuestaOrden.errMensaje);

                //----se obtiene los registros de caratula desde la BD.
                //RespuestaReg oRespuestaCaratula = new RespuestaReg();
                //DataSet dsCaratula = new DataSet();
                //ClsProductosCaratula oProductosCaratula = new ClsProductosCaratula();
                //oRespuestaCaratula = oProductosCaratula.ObtenerDatosProductos("");
                //dsCaratula = oRespuestaCaratula.detalle;


                //ClsProductosWeb ProductWeb = new ClsProductosWeb();

                //esta es la version inicial
                //var productsQuery =
                //        (from SAP in dsSAP.Tables[0].AsEnumerable()

                //             //join Web in dsWeb.Tables[0].AsEnumerable()
                //             // on SAP.Field<string>("Item").Trim() equals Web.Field<string>("Articulo").Trim() into tmpWeb
                //             //    from jweb in tmpWeb.DefaultIfEmpty()

                //         join Web in dsWeb.Tables[0].AsEnumerable()
                //         on SAP.Field<string>("Item").Trim() equals
                //            Web.Field<string>("Articulo").Trim()

                //         join Orden in dsOrden.Tables[0].AsEnumerable()
                //          on SAP.Field<string>("Item").Trim() equals Orden.Field<string>("ProductoId").Trim() into tmpOrden
                //          from jorden in tmpOrden.DefaultIfEmpty()

                //         select new
                //         {
                //             ProductId    = SAP.Field<string>("Item"),
                //             //ProductoName = jweb?.Field<string>("NombreArticulo") ?? String.Empty,
                //             ProductoName = Web.Field<string>("NombreArticulo"),
                //             //ImagenArticulo = jweb?.Field<string>("ImagenArticulo") ?? String.Empty,
                //             ImagenArticulo = Web.Field<string>("ImagenArticulo"),
                //             //Especificaciones = jweb?.Field<string>("Especificaciones")?? string.Empty,
                //             Especificaciones = Web.Field<string>("Especificaciones"),
                //             OrdenProducto = jorden?.Field<decimal>("Orden") ?? 0
                //         }).ToList();


                var productsQueryDynamic2 =
                                   (from SAP in dsSAP.Tables[0].AsEnumerable()
                                        //esto sirve como left join
                                        //join Web in dsWeb.Tables[0].AsEnumerable()
                                        // on SAP.Field<string>("Item").Trim() equals Web.Field<string>("Articulo").Trim() into tmpWeb
                                        //    from jweb in tmpWeb.DefaultIfEmpty()

                                        //18 de mayo se decide eliminar el ODatos Web
                                        //join Web in dsWeb.Tables[0].AsEnumerable()
                                        //           on SAP.Field<string>("Item").Trim() equals
                                        //              Web.Field<string>("Articulo").Trim()

                                join Orden in dsOrden.Tables[0].AsEnumerable()
                                     on SAP.Field<string>("Item").Trim() equals Orden.Field<string>("ProductoId").Trim() into tmpOrden
                                    from jorden in tmpOrden.DefaultIfEmpty()

                                    select new
                                    { x = SAP, z = jorden }).AsQueryable();//y= Web,                
                rLog = Log.RegistraLog("NegCatalogo.CargaNuevoCatalogo", "se ejecuto el linq entre sap y orden " );

                //busco la configuracion de los campos que se deben incluir en el catalogo
                NegCatalogoCampos oNegCatalogoCampos = new NegCatalogoCampos();
                oNegCatalogoCampos.TipoCatalogo = TipoCatalogo;
                DataSet dsCatalogoCampos = new DataSet();
                dsCatalogoCampos = oNegCatalogoCampos.ObtenerCatalogoCampos();
                DataTable dtCatalogo = new DataTable();

                rLog = Log.RegistraLog("NegCatalogo.CargaNuevoCatalogo", "se recuperaron los datos ls campos a presntar en pantalla (de la tabla ql CatalogoCampos) ");

                //creo el objeto datatable
                foreach (DataRow row in dsCatalogoCampos.Tables[0].Rows)
                {
                    switch (row["TipoDato"].ToString().TrimEnd())
                    {
                        case "Int":
                        case "Integer":
                            dtCatalogo.Columns.Add(row["Campo"].ToString().Trim(), typeof(int));
                            break;
                        case "Date":
                            dtCatalogo.Columns.Add(row["Campo"].ToString().Trim(), typeof(DateTime));
                            break;
                        case "float":
                            dtCatalogo.Columns.Add(row["Campo"].ToString().Trim(), typeof(Decimal));
                            break;
                        case "Decimal":
                        case "decimal":
                            dtCatalogo.Columns.Add(row["Campo"].ToString().Trim(), typeof(Decimal));
                            break;
                        default:
                            dtCatalogo.Columns.Add(row["Campo"].ToString().Trim(), typeof(String));
                            break;
                    }
                }

                rLog = Log.RegistraLog("NegCatalogo.CargaNuevoCatalogo", "se crea el objeto datatable");



                rLog = Log.RegistraLog("NegCatalogo.CargaNuevoCatalogo", "antes de recorrer el dataset uno a uno(linq) Linea 156 ");
                //lleno cada row en base al datatable creado y relleno el datatable.
                int cuanto = 0;
                foreach (var reg in productsQueryDynamic2)
                {
                    DataRow catalogorow = dtCatalogo.NewRow();
                    foreach (DataRow camposrow in dsCatalogoCampos.Tables[0].Rows)
                    {
                        string campo = camposrow["Campo"].ToString().TrimEnd();
                        string tdato = camposrow["TipoDato"].ToString();



                        //rLog = Log.RegistraLog("NegCatalogo.CargaNuevoCatalogo", "procesando el campo:" + campo + " - tdato: " + tdato);

                        //18 de abril se decide eliminar el Odigen de datos Web
                        //if (camposrow["Tabla"].ToString()=="Web")
                        //{
                        //    switch (tdato)
                        //    {
                        //        case "Int":
                        //        case "Integer":
                        //            catalogorow[campo] = reg.y.Field<int>(campo);
                        //            break;
                        //        case "Date":
                        //            catalogorow[campo] = reg.y.Field<DateTime>(campo);
                        //            break;
                        //        case "Decimal":
                        //        case "decimal":
                        //            catalogorow[campo] = reg.y.Field<decimal>(campo);
                        //            break;
                        //        case "Float":
                        //        case "float":
                        //            catalogorow[campo] = reg.y.Field<Double>(campo);
                        //            break;
                        //        default:
                        //            catalogorow[campo] = reg.y.Field<string>(campo);
                        //            break;
                        //    }
                        //}
                        if (camposrow["Tabla"].ToString() == "SAP")
                        {
                            switch (tdato)
                            {
                                case "Int":
                                case "Integer":
                                    catalogorow[campo] = reg.x.Field<int>(campo);
                                    break;
                                case "Date":
                                    catalogorow[campo] = reg.x.Field<DateTime>(campo);
                                    break;
                                case "Decimal":
                                case "decimal":
                                    catalogorow[campo] = reg.x.Field<decimal>(campo);
                                    break;
                                case "Float":
                                case "float":
                                    catalogorow[campo] = reg.x.Field<Double>(campo);
                                    break;
                                default:
                                    catalogorow[campo] = reg.x.Field<string>(campo);
                                    break;
                            }
                        }
                        if (camposrow["Tabla"].ToString() == "Orden")
                        {
                            switch (tdato)
                            {
                                case "Int":
                                case "Integer":
                                    if (reg.z != null)
                                    { catalogorow[campo] = reg.z.Field<int>(campo); }
                                    else { catalogorow[campo] = 0; }
                                    break;
                                case "Date":
                                    if (reg.z != null)
                                    { catalogorow[campo] = reg.z.Field<DateTime>(campo); }
                                    break;
                                case "Decimal":
                                case "decimal":
                                    if (reg.z != null)
                                    { catalogorow[campo] = reg.z.Field<decimal>(campo); }
                                    else { catalogorow[campo] = 0; }
                                    break;
                                default:
                                    if (reg.z != null)
                                    { catalogorow[campo] = reg.z.Field<string>(campo); }
                                    else { catalogorow[campo] = ""; }
                                    break;
                            }
                        }

                    }

                    dtCatalogo.Rows.Add(catalogorow);
                    cuanto += 1;
                }


                rLog = Log.RegistraLog("NegCatalogo.CargaNuevoCatalogo", "termina de recorrer uno a uno los regstros del dataset(linq) linea 254");

                DataSet dsCatalogo = new DataSet();

                dsCatalogo.Tables.Add(dtCatalogo);
                ////---aqui se debe recorrer el ds de caratula y anadir cada registro al datatable final
                ////dsCatalogo.Merge(dsCaratula);
                //foreach (DataRow r in dsCaratula.Tables[0].Rows)
                //{
                //    dsCatalogo.Tables[0].Rows.Add(r.ItemArray);
                //}
                ////dsCatalogo.Merge(dsCaratula, true, MissingSchemaAction.Add);
                ////dsCatalogo.AcceptChanges();
                ////Sorting the Table
                dtCatalogo.DefaultView.Sort = "OrdenNivel6 asc";
                dtCatalogo = dtCatalogo.DefaultView.ToTable(true);

                //////////////////////////////////////////////////////////////////////////////////////////////
                ///recorro uno a uno los Origenes de datos adicionales y extraigo la informacion requerida.///
                //////////////////////////////////////////////////////////////////////////////////////////////

                rLog = Log.RegistraLog("NegCatalogo.CargaNuevoCatalogo", "antes de entrar a evaluar los ODA");

                for (int i_oda = 0; i_oda < ListaOrigenDatosAdic.Count; i_oda++)
                {
                    List<ODA_Campos> ListaODA_Campos = new List<ODA_Campos>();
                    DataSet ds_ODA = new DataSet();
                    ds_ODA = ListaOrigenDatosAdic[i_oda].Detalle;

                    DataTable dtResultODA = new DataTable();
                    //creo la estructura para almacenar los campos q existen en el actual DS + los del DS del Origen de dato aducuianl
                    //adiciono las columnas del DS original
                    for (int k = 0; k < dsCatalogo.Tables[0].Columns.Count; k++)
                    {
                        ODA_Campos oODA_Campos = new ODA_Campos();
                        oODA_Campos.Tabla = "ODP"; //origen de datos principal
                        oODA_Campos.Campo = dsCatalogo.Tables[0].Columns[k].ColumnName;
                        oODA_Campos.TipoDato = dsCatalogo.Tables[0].Columns[k].DataType.ToString();
                        ListaODA_Campos.Add(oODA_Campos);
                    }
                    //adiciono las columnas del DS adicional
                    for (int k = 1; k < ds_ODA.Tables[0].Columns.Count; k++)
                    {
                        for (int l = 0; l< ListaOrigenDatosAdic[i_oda].CamposSelect.Count; l++)
                        {
                            if (ds_ODA.Tables[0].Columns[k].ColumnName == ListaOrigenDatosAdic[i_oda].CamposSelect[l].ToString())
                            {
                                ODA_Campos oODA_Campos = new ODA_Campos();
                                oODA_Campos.Tabla = "ODA"; //origen de datos adicional
                                oODA_Campos.Campo = ds_ODA.Tables[0].Columns[k].ColumnName;
                                oODA_Campos.TipoDato = ds_ODA.Tables[0].Columns[k].DataType.ToString();
                                ListaODA_Campos.Add(oODA_Campos);
                            }
                        }
                        
                    }

                    //query Linq uniendo el origen de datos anterior o principal con el origen de datos adicional
                    var productoQueryODA = (from Q in dsCatalogo.Tables[0].AsEnumerable()
                                            join ODA in ds_ODA.Tables[0].AsEnumerable()
                                               on Q.Field<string>("Item").Trim() equals ODA.Field<string>("Item").Trim() into tmpOrden
                                            from tODA in tmpOrden.DefaultIfEmpty()
                                            select new
                                            { x = Q, y = tODA }).AsQueryable();

                    //creo la estructura del datatable usando la lista de campos
                    for (int w = 0; w < ListaODA_Campos.Count; w++)
                    {
                        switch (ListaODA_Campos[w].TipoDato.ToString().TrimEnd())
                        {
                            case "System.Int":
                            case "System.Int32":
                                dtResultODA.Columns.Add(ListaODA_Campos[w].Campo.Trim(), typeof(int));
                                break;
                            case "System.Date":
                                dtResultODA.Columns.Add(ListaODA_Campos[w].Campo.Trim(), typeof(DateTime));
                                break;
                            case "System.Decimal":
                                dtResultODA.Columns.Add(ListaODA_Campos[w].Campo.Trim(), typeof(Decimal));
                                break;
                            default:
                                dtResultODA.Columns.Add(ListaODA_Campos[w].Campo.Trim(), typeof(String));
                                break;
                        }
                    }

                    //lleno cada row en base al datatable creado y relleno el datatable.

                    foreach (var reg in productoQueryODA)
                    {
                        DataRow catalogorow = dtResultODA.NewRow();
                        for (int w = 0; w < ListaODA_Campos.Count; w++)
                        {
                            string campo = ListaODA_Campos[w].Campo.Trim();
                            string tdato = ListaODA_Campos[w].TipoDato.Trim();
                            string tabla = ListaODA_Campos[w].Tabla.Trim();

                            if (tabla == "ODP")
                            {
                                switch (tdato)
                                {
                                    case "System.Int":
                                    case "System.Int32":
                                        catalogorow[campo] = reg.x.Field<int>(campo);
                                        break;
                                    case "System.Date":
                                    case "System.DateTime":
                                        catalogorow[campo] = reg.x.Field<DateTime>(campo);
                                        break;
                                    case "System.Decimal":
                                        catalogorow[campo] = reg.x.Field<decimal>(campo);
                                        break;
                                    default:
                                        catalogorow[campo] = reg.x.Field<string>(campo);
                                        break;
                                }
                            }
                            if (tabla == "ODA" && reg.y != null)
                            {
                                switch (tdato)
                                {
                                    case "System.Int":
                                    case "System.Int32":
                                        catalogorow[campo] = reg.y.Field<int>(campo);
                                        break;
                                    case "System.Date":
                                    case "System.DateTime":
                                        catalogorow[campo] = reg.y.Field<DateTime>(campo);
                                        break;
                                    case "System.Decimal":

                                        catalogorow[campo] = reg.y.Field<decimal>(campo);
                                        break;
                                    default:

                                        catalogorow[campo] = reg.y.Field<string>(campo);
                                        break;
                                }
                            }

                        }
                        dtResultODA.Rows.Add(catalogorow);
                    }
                    dsCatalogo.Tables.RemoveAt(0);

                    //Sorting the Table
                    dtResultODA.DefaultView.Sort = "OrdenNivel6 asc";
                    dtResultODA = dtResultODA.DefaultView.ToTable(true);


                    dsCatalogo.Tables.Add(dtResultODA);



                }

                //DataTable TableProducts = LINQResultToDataTable(productsQueryDynamic2);
                //esto se uso primero antes de incluir el select de los campos dinamicos
                rLog = Log.RegistraLog("NegCatalogo.CargaNuevoCatalogo", "termina de evaluar los ODA");

                rLog = Log.RegistraLog("NegCatalogo.CargaNuevoCatalogo", "**************************FIN EJECUCION********************************************");


                oRespuestaCatalogo.errCodigo = 0;
                oRespuestaCatalogo.errMensaje = "";
                oRespuestaCatalogo.detalle  = dsCatalogo;
                return oRespuestaCatalogo;

            }
            catch (Exception ex)
            {
                AuxLogAPI Log = new AuxLogAPI();
                bool rLog = true;
                
                rLog = Log.RegistraLog("NegCatalogo.CargaNuevoCatalogo", ex.Message);
                oRespuestaCatalogo.errCodigo = -5000;
                oRespuestaCatalogo.errMensaje = ex.Message;
                oRespuestaCatalogo.detalle = null;
                return oRespuestaCatalogo;

            }
        }


        public DataTable LINQResultToDataTable<T>(IEnumerable<T> Linqlist)
        {
            DataTable dt = new DataTable();
            PropertyInfo[] columns = null;

            if (Linqlist == null) return dt;

            foreach (T Record in Linqlist)
            {

                if (columns == null)
                {
                    columns = ((Type)Record.GetType()).GetProperties();
                    foreach (PropertyInfo GetProperty in columns)
                    {
                        Type colType = GetProperty.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
                    }
                }

                DataRow dr = dt.NewRow();

                foreach (PropertyInfo pinfo in columns)
                {
                    dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue
                    (Record, null);
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }

    }



}

