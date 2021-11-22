using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Entidades.Clases_Derivadas;

namespace Entidades
{   
    [Serializable]

    [XmlInclude(typeof(Delfin))]
    [XmlInclude(typeof(Elefante))]
    [XmlInclude(typeof(Leon))]
    [XmlInclude(typeof(Hipopotamo))]
    public class Mamifero
    {   

        private string nombre;
        private ETamanio tamanio;
        private EUbicacion ubicacion;
        private int id;
        
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Mamifero()
        {

        }

        /// <summary>
        /// Constructor de un mamifero
        /// </summary>
        /// <param name="nombre"> Nombre a asignar al mamifero. </param>
        /// <param name="ubicacion"> Ubicacion a asignar del mamifero. </param>
        /// <param name="id"> Codigo de identificacion a asignar al mamifero. </param>
        /// <param name="tamanio"> Tamaño a asignar al mamifero. </param>

        public Mamifero(string nombre, EUbicacion ubicacion, int id, ETamanio tamanio)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            this.id = id;
            this.tamanio = tamanio;
        }

        /// <summary>
        /// Propiedad que retorna el tamaño de un mamifero.
        /// </summary>
        public ETamanio Tamanio
        {   
            set
            {
                this.tamanio = value;
            }
            get
            {
                return this.tamanio;
            }
        }
        
        /// <summary>
        /// Propiedad que retorna el nombre del mamifero.
        /// </summary>
        public string Nombre
        {   
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// Propiedad que retorna la ubicacion del mamifero.
        /// </summary>
        public EUbicacion Ubicacion
        {
            set
            {
                this.ubicacion = value;
            }
            get
            {
                return this.ubicacion;
            }
        }

        /// <summary>
        /// Propiedad que retorna el codigo de identificacion del mamifero.
        /// </summary>
        public int Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }



        /// <summary>
        /// Compara si dos mamiferos son iguales al tener el mismo codigo de identificacion
        /// </summary>
        /// <param name="primerAnimal"> Primer mamifero a comparar. </param>
        /// <param name="segundoAnimal"> Segundo mamifero a comparar. </param>
        /// <returns> True si los dos mamiferos son iguales o false si son distintos </returns>
        public static bool operator ==(Mamifero primerAnimal, Mamifero segundoAnimal)
        {
            if(!(primerAnimal is null) && !(segundoAnimal is null))
            {
                if(primerAnimal.id == segundoAnimal.id)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Compara si dos mamiferos son distintos al tener distinto codigo de identificacion
        /// </summary>
        /// <param name="primerAnimal"> Primer mamifero a comparar. </param>
        /// <param name="segundoAnimal"> Segundo mamifero a comparar. </param>
        /// <returns> True si los dos mamiferos son distintos o false si son iguales. </returns>
        public static bool operator !=(Mamifero primerAnimal, Mamifero segundoAnimal)
        {
            return !(primerAnimal == segundoAnimal);
        }

        /// <summary>
        /// Se sobreescribe el metodo Equals
        /// </summary>
        /// <param name="obj"> Objeto a comparar. </param>
        /// <returns> False si los objetos son distintos o true si son iguales. </returns>
        public override bool Equals(object obj)
        {
            bool rta = false;

            if (obj is Mamifero)
            {
                rta = (Mamifero)obj == this;
            }
            return rta;
        }
        
        /// <summary>
        /// Se sobreescribe el metodo GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return 0;
        }

    }
}
