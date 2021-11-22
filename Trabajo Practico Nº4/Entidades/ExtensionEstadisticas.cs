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
    public static class ExtensionEstadisticas
    {
        public static string InformarSobreEstadisticas(this ExportarEstadisticasException exception)
        {
            return exception.Message;
        }
    }
}
