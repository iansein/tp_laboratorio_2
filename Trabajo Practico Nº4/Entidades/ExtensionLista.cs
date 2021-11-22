using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Metodo de extension que informa el mensaje de error de una excepcion
    /// </summary>
    public static class ExtensionLista
    {
        public static string InformarSobreLista(this ExportarListaException exception)
        {
            return exception.Message;
        }
    }
}
