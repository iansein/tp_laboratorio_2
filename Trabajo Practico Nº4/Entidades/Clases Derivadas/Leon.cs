using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Leon : Mamifero
    {   
        /// <summary>
        /// Constructor por defecto de Leon
        /// </summary>
        public Leon()
        {

        }

        /// <summary>
        /// Constructor de un leon con todos sus datos.
        /// </summary>
        /// <param name="nombre"> Nombre a asignarle al leon. </param>
        /// <param name="ubicacion"> Ubicacion a asignarle al leon. </param>
        /// <param name="id"> Codigo de identificacion a asignarle al leon. </param>
        /// <param name="tamanio"> Tamaño asignarle al leon. </param>
        public Leon(string nombre, EUbicacion ubicacion, int id, ETamanio tamanio) : base(nombre, ubicacion, id, tamanio)
        {
           
        }

    }
}
