using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializador.Archivos
{   
    /// <summary>
    /// Interfaz con el metodo que permite exportar informacion
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IArchivo<T>
    {
        bool Exportar(T datos, string mensaje);
    }

}
