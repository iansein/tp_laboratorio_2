using Serializador.Archivos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Serializador
{
    public class Json<T> : IArchivo<T>
    {
        readonly string pathBase;

        /// <summary>
        /// Constructor con la ruta donde se guardaran los informes
        /// </summary>
        public Json()
        {
            pathBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\RescatistasEsperanza\";
        }

        /// <summary>
        /// Exporta en un archivo json los datos que son pasados por parametro
        /// </summary>
        /// <param name="datos"> Datos que van a ser exportados </param>
        /// <param name="nombre"> Nombre del informe </param>
        /// <returns> False si no se pudo serializar o true si se pudo </returns>
        public bool Exportar(T datos, string nombre)
        {
            bool validacion = false;
            string pathArchivo = pathBase + @"\InformesExportadosEnJson\";

            try
            {
                if (!Directory.Exists(pathArchivo))
                {
                    Directory.CreateDirectory(pathArchivo);
                }

                pathArchivo += @"Informe " + nombre + " " + DateTime.Now.ToString("HH_mm_ss") + ".json";

                JsonSerializerOptions opciones = new JsonSerializerOptions();

                opciones.WriteIndented = true;

                string jsonString = JsonSerializer.Serialize(datos, opciones);
                    
                File.WriteAllText(pathArchivo, jsonString);

                validacion = true;
                
            }
            catch (Exception ex)
            {
                ex = new Exception("Error al querer exportar el archivo");
                throw ex;
            }

            return validacion;
        }
    }
}
