using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region Enumeradores
 
        /// <summary>
        /// Enumerador de cantidad de puertas del Sedan.
        /// </summary>
        public enum ETipo 
        { 
          CuatroPuertas, 
          CincoPuertas 
        }

        #endregion

        #region Atributos

        private ETipo tipo;

        #endregion

        #region Constructores

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"> Marca que va a ser asignada al Sedan. </param>
        /// <param name="chasis"> Chasis que va a ser asignado al Sedan. </param>
        /// <param name="color"> Color que va a ser asignado al Sedan. </param>

        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Crea la instancia de Sedan e inicializa al objeto con los datos correspondientes.
        /// </summary>
        /// <param name="marca"> Marca que va a ser asignada al Sedan. </param>
        /// <param name="chasis"> Chasis que va a ser asignado al Sedan. </param>
        /// <param name="color"> Color que va a ser asignado al Sedan. </param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color) : this(marca, chasis, color, ETipo.CuatroPuertas)
        {
 
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Genera todos los datos del Sedan.
        /// </summary>
        /// <returns> Los datos del Sedan en formato de string. </returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendFormat(base.Mostrar() +"TIPO : {0}\n", this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    
        #endregion
    }
}
