using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TamanioException : Exception
    {
        /// <summary>
        /// Se sobreescribe la propiedad que devuelve un mensaje de excepcion
        /// </summary>
        public override string Message
        {
            get
            {
                return "Ingrese un tamaño valido";
            }
        }

    }
}
