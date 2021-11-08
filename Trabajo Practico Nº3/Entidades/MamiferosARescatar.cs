using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clases_Derivadas;

namespace Entidades
{
    public class MamiferosARescatar
    {
        private List<Mamifero> listaMamiferos;

        /// <summary>
        /// Constructor por defecto que inicializa la lista de mamiferos
        /// </summary>
        public MamiferosARescatar()
        {
            this.listaMamiferos = new List<Mamifero>();
        }

        /// <summary>
        /// Propiedad que devuelve la lista de mamiferos
        /// </summary>
        public List<Mamifero> ListaMamiferos
        {
            get
            {
                return this.listaMamiferos;
            }
        }

        /// <summary>
        /// Agrega a la lista a un mamifero si no se encuentra en ella
        /// </summary>
        /// <param name="listaMamiferos"> Lista de mamiferos </param>
        /// <param name="mamifero1"> Mamifero a agregar a la lista </param>
        /// <returns> La lista con el mamifero agregado si se pudo, si no la lista como estaba. </returns>
        public static MamiferosARescatar operator +(MamiferosARescatar listaMamiferos ,  Mamifero mamifero1)
        {
            if(!(listaMamiferos is null) && !(mamifero1 is null))
            {
                foreach(Mamifero mamifero2 in listaMamiferos.listaMamiferos)
                {
                    if(mamifero2 == mamifero1)
                    {     
                        return listaMamiferos;
                    }
                }

                listaMamiferos.ListaMamiferos.Add(mamifero1);
            }

            return listaMamiferos;
        }


    }
}
