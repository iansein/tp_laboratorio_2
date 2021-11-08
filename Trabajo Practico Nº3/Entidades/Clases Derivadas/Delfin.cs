using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Derivadas
{
    public class Delfin : Mamifero
    {
        /// <summary>
        /// Constructor por defecto de delfin.
        /// </summary>
        public Delfin()
        {
       
        }

        /// <summary>
        /// Constructor de un delfin con todos sus datos.
        /// </summary>
        /// <param name="nombre"> Nombre a asignarle al delfin. </param>
        /// <param name="ubicacion"> Ubicacion a asignarle al delfin. </param>
        /// <param name="codigoDeIdentificacion"> Codigo de identificacion a asignarle al delfin. </param>
        /// <param name="tamanio"> Tamaño asignarle al delfin. </param>
        public Delfin(string nombre, EUbicacion ubicacion, int codigoDeIdentificacion, ETamanio tamanio) : base(nombre, ubicacion, codigoDeIdentificacion, tamanio)
        {
            
        }
    }
}
