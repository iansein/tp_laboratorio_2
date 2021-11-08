using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Derivadas
{
    public class Hipopotamo : Mamifero
    {   
        /// <summary>
        /// Constructor por defecto de un hipopotamo
        /// </summary>
        public Hipopotamo()
        {

        }

        /// <summary>
        /// Constructor de un hipopotamo con todos sus datos.
        /// </summary>
        /// <param name="nombre"> Nombre a asignarle al hipopotamo. </param>
        /// <param name="ubicacion"> Ubicacion a asignarle al hipopotamo. </param>
        /// <param name="codigoDeIdentificacion"> Codigo de identificacion a asignarle al hipopotamo. </param>
        /// <param name="tamanio"> Tamaño asignarle al hipopotamo. </param>
        public Hipopotamo(string nombre, EUbicacion ubicacion, int codigoDeIdentificacion, ETamanio tamanio) : base(nombre, ubicacion, codigoDeIdentificacion, tamanio)
        {

        }

    }
}
