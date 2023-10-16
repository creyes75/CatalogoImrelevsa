using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBConfig;
using System.IO;
using System.Configuration;

namespace WebApi.Data
{
    public class AuxLogAPI
    {
        
        public  Boolean RegistraLog(string seccion, String Comentario)
        {
            var reader = new AppSettingsReader();

            var stringSetting = reader.GetValue("LogPath", typeof(string));
            string ruta = stringSetting.ToString();

            var stringSetting2 = reader.GetValue("GeneraLog", typeof(string));
            string GeneraLog = stringSetting2.ToString();
            if (GeneraLog.ToUpper() =="Y")
            { 
            string fecha = DateTime.Today.ToString("yyyyMMdd");
            string filename = $" {ruta}APICliente_{fecha}.txt";
            if (!File.Exists(filename))
            {
                using (StreamWriter sw = File.CreateText(filename))
                {
                    //sw.WriteLine("--------------------------------------------");
                    //sw.WriteLine(seccion);
                    //sw.WriteLine("--------------------------------------------");
                    sw.WriteLine(seccion + "//"+ Comentario);
                }
            }

            else
            {
                using (StreamWriter sw = File.AppendText(filename))
                {
                    //sw.WriteLine("--------------------------------------------");
                    //sw.WriteLine(seccion);
                   // sw.WriteLine("--------------------------------------------");
                    sw.WriteLine(seccion + "//" + Comentario);
                }

            }
            }

            return true;

        }


    }
}