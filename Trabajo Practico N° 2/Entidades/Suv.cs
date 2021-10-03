using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region Constructores

        /// <summary>
        /// Crea la instancia de SUV e inicializa al objeto con los datos correspondientes 
        /// </summary>
        /// <param name="marca"> Marca que va a ser asignada al SUV. </param>
        /// <param name="chasis"> Chasis que va a ser asignado al SUV. </param>
        /// <param name="color"> Color que va a ser asignado al SUV. </param>
        public Suv(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Genera todos los datos del SUV
        /// </summary>
        /// <returns> Los datos del SUV en formato de string. </returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
