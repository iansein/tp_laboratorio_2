using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Derivadas
{
    public class Elefante : Mamifero
    {   
        /// <summary>
        /// Constructor por defecto de un elefante
        /// </summary>
        public Elefante()
        {

        }

        /// <summary>
        /// Constructor de un elefante con todos sus datos.
        /// </summary>
        /// <param name="nombre"> Nombre a asignarle al elefante. </param>
        /// <param name="ubicacion"> Ubicacion a asignarle al elefante. </param>
        /// <param name="id"> Codigo de identificacion a asignarle al elefante. </param>
        /// <param name="tamanio"> Tamaño asignarle al elefante. </param>
        public Elefante(string nombre, EUbicacion ubicacion, int id, ETamanio tamanio) : base(nombre, ubicacion, id, tamanio)
        {
            
        }

    }
}
