using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        #region Enumerados

        /// <summary>
        /// Enumerado de las marcas que puede tener el vehiculo
        /// </summary>
        public enum EMarca
        {
            Chevrolet, 
            Ford, 
            Renault, 
            Toyota, 
            BMW, 
            Honda, 
            HarleyDavidson
        }

        /// <summary>
        /// Enumerado de los tamanios que puede tener el vehiculo
        /// </summary>
        public enum ETamanio
        {
            Chico, 
            Mediano, 
            Grande
        }

        #endregion

        #region Atributos

        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        #endregion

        #region Constructor

        /// <summary>
        /// Crea la instancia de Vehiculo e inicializa al objeto con su respectiva informacion.
        /// </summary>
        /// <param name="chasis"> Chasis que se le va a asignar al vehiculo. </param>
        /// <param name="marca"> Marca que se le va a asignar al vehiculo. </param>
        /// <param name="color"> Color que se le va a asignar al vehiculo. </param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        #endregion

        #region Propiedad

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        public abstract ETamanio Tamanio { get; }

        #endregion

        #region Metodo

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns>Todos los datos del vehiculo como string</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Castea el objeto de tipo Vehiculo y retorna los datos generados en formato de string.
        /// </summary>
        /// <param name="p"> Objeto de tipo Vehiculo a ser casteado </param>

        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------\n");
            sb.AppendFormat("TAMAÑO : {0}", p.Tamanio);

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"> Primer objeto de tipo "Vehiculo" a ser comparado </param>
        /// <param name="v2"> Segundo objeto de tipo "Vehiculo" a ser comparado </param>
        /// <returns> True si los dos vehiculos comparten el mismo chasis, sino retornara false </returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {   
            return v1.chasis == v2.chasis;
        }

        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"> Primer objeto de tipo "Vehiculo" a ser comparado </param>
        /// <param name="v2"> Segundo objeto de tipo "Vehiculo" a ser comparado </param>
        /// <returns> True si los chasis de los vehiculos son distintos, sino retornara false </returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        #endregion
    }
}
