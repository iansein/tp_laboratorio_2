using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Entidades;
using Entidades.Clases_Derivadas;

namespace Serializador.Archivos
{
     public class Xml<T> : IArchivo<T>
     {

            readonly string pathBase;

            /// <summary>
            /// Constructor con la ruta donde se guardaran los informes
            /// </summary>
            public Xml()
            {
                pathBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\RescatistasEsperanza\";
            }

            /// <summary>
            /// Exporta en un archivo xml los datos que son pasados por parametro
            /// </summary>
            /// <param name="datos"> Datos que van a ser exportados </param>
            /// <param name="nombre"> Nombre del informe </param>
            /// <returns> False si no se pudo serializar o true si se pudo </returns>
            public bool Exportar(T datos, string nombre)
            {
                bool validacion = false;
                string pathArchivo = pathBase + @"\InformesExportadosEnXml\";

                try
                {
                    if (!Directory.Exists(pathArchivo))
                    {
                        Directory.CreateDirectory(pathArchivo);
                    }

                    pathArchivo += @"Informe " + nombre + ".xml";

                    if (pathArchivo != null)
                    {
                        using (XmlTextWriter auxWriter = new XmlTextWriter(pathArchivo, Encoding.UTF8))
                        {
                            XmlSerializer nuevoXml = new XmlSerializer(typeof(T));
                            nuevoXml.Serialize(auxWriter, datos);
                            validacion = true;
                        }
                    }
                }
                catch(Exception ex)
                {
                    ex = new Exception("Error al querer exportar el archivo");
                    throw ex;
                }

                return validacion;
            }

            /// <summary>
            /// Importa los datos de la ruta que es pasada por parametro 
            /// </summary>
            /// <param name="ruta"> Ruta donde esta el archivo a importar </param>
            /// <param name="datos"> Donde se van a importar la informacion del archivo </param>
            /// <returns> False si no se pudo deserealizar o true si se pudo </returns>
            public bool Importar(string ruta, out T datos)
            {
                bool validacion = false;
                datos = default;
                
                try
                {
                    if (ruta != null)
                    {
                        using (XmlTextReader auxReader = new XmlTextReader(ruta))
                        {
                            XmlSerializer nuevoXml = new XmlSerializer(typeof(T));
                            datos = (T)nuevoXml.Deserialize(auxReader);
                            validacion = true;
                        }
                    }
                }
                catch(Exception ex)
                {
                    ex = new Exception("Error al querer importar el archivo");
                    throw ex;

                }

                return validacion;
            }
     }

}