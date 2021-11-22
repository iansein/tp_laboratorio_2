using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ExportarListaException : Exception
    {
        /// <summary>
        /// Se sobreescribe la propiedad que devuelve un mensaje de excepcion
        /// </summary>
        public override string Message
        {
            get
            {
                return "Hubo un error al querer exportar, la lista esta vacia!";
            }
        }
    }
}
