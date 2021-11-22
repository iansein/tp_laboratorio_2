using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Formularios
{
    public class Reloj
    {
        int hora;
        int minuto;
        int segundo;

        public delegate void NotificarTiempo(Reloj reloj);
        public event NotificarTiempo segundoCambiado;

        /// <summary>
        /// En un hilo secundario cada vez que el segundo cambie, se dispara el evento segundoCambiado.
        /// </summary>
        public void Iniciar()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    DateTime dt = DateTime.Now;
                    Thread.Sleep(10);

                    if (dt.Second != segundo)
                    {
                        if (segundoCambiado != null)
                        {
                            segundoCambiado.Invoke(this);
                        }
                    }

                    hora = dt.Hour;
                    minuto = dt.Minute;
                    segundo = dt.Second;
                }
            });
        }

        /// <summary>
        /// Se sobreescribe el metodo ToString para que devuelva la hora exacta.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {   
            if(segundo < 10 && minuto < 10)
            {   
                return $"{hora} : 0{minuto} : 0{segundo}";

            }

            if(minuto < 10)
            {
                return $"{hora} : 0{minuto} : {segundo}";
            }

            if (segundo < 10)
            {
                return $"{hora} : {minuto} : 0{segundo}";
            }

            return $"{hora} : {minuto} : {segundo}";
        }

    }
}
