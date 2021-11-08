using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializador.Archivos
{   
    /// <summary>
    /// Metodos que permiten exportar e importar informacion
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IArchivo<T>
    {
        bool Exportar(T datos, string mensaje);
        bool Importar(string path, out T datos);
    }
}
