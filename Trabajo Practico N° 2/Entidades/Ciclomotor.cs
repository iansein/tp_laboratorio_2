using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region Constructores

        /// <summary>
        /// Crea la instancia de CicloMotor e inicializa al objeto con los datos correspondiente.
        /// </summary>
        /// <param name="marca"> Marca que va a ser asignada al Ciclomotor. </param>
        /// <param name="chasis"> Chasis que va a ser asignado al Ciclomotor. </param>
        /// <param name="color"> Color que va a ser asignado al Ciclomotor. </param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Genera todos los datos del Ciclomotor.
        /// </summary>
        /// <returns> Los datos del Ciclomotor en formato de string. </returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
