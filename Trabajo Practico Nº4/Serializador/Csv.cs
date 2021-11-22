using Entidades;
using Serializador.Archivos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializador
{
    public class Csv <T> : IArchivo<T>
    {
        readonly string pathBase;
        MamiferosARescatar listaMamiferos;
        /// <summary>
        /// Constructor con la ruta donde se guardaran los informes
        /// </summary>
        public Csv(MamiferosARescatar listaMamiferos)
        {
            this.listaMamiferos = listaMamiferos;
            pathBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\RescatistasEsperanza\";
        }

        /// <summary>
        /// Exporta en un archivo csv los datos que son pasados por parametro
        /// </summary>
        /// <param name="datos"> Datos que van a ser exportados </param>
        /// <param name="nombre"> Nombre del informe </param>
        /// <returns> False si no se pudo serializar o true si se pudo </returns>
        public bool Exportar(T datos, string nombre)
        {
            bool validacion = false;
            string pathArchivo = pathBase + @"\InformesExportadosEnCsv\";

            try
            {
                if (!Directory.Exists(pathArchivo))
                {
                    Directory.CreateDirectory(pathArchivo);
                }

                pathArchivo += @"Informe " + nombre + " " + DateTime.Now.ToString("HH_mm_ss")+ ".csv";

                if (pathArchivo != null)
                {
                    using (StreamWriter streamWriter = new StreamWriter(pathArchivo))
                    {
                        streamWriter.WriteLine($"MAMIFERO;TAMANIO;NOMBRE;UBICACION;ID");

                        foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                        {
                            streamWriter.WriteLine($"{item.GetType().Name};{item.Tamanio};{item.Nombre};{item.Ubicacion};{item.Id}");
                        }

                        validacion = true;
                    }
                }
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
