using System;
using Entidades;
using Entidades.Clases_Derivadas;
using static Entidades.Mamifero;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            MamiferosARescatar listaMamiferos;
            listaMamiferos = new MamiferosARescatar();

            Delfin delfin1 = new Delfin("Delfinsito", EUbicacion.Argentina, 555, ETamanio.Grande);
            Delfin delfin2 = new Delfin("Brillante", EUbicacion.Argentina, 555, ETamanio.Mediano);
            Hipopotamo hipopotamo1 = new Hipopotamo("Hipopotamito", EUbicacion.Uruguay, 999, ETamanio.Grande);
            Hipopotamo hipopotamo2 = new Hipopotamo("Hermoso", EUbicacion.Uruguay, 999, ETamanio.Mediano);
            Leon leon1 = new Leon("Leonsito", EUbicacion.Argentina, 333, ETamanio.Grande);
            Elefante elefante1 = new Elefante("Elefantito", EUbicacion.Uruguay, 777, ETamanio.Mediano);
            Elefante elefante2 = new Elefante("Elefanton", EUbicacion.Argentina, 779, ETamanio.Grande);

            listaMamiferos += delfin1;
            listaMamiferos += delfin2; // No lo deberia agregar ya que tiene el mismo codigo de identificacion que delfin1
            listaMamiferos += hipopotamo1;
            listaMamiferos += hipopotamo2; // No lo deberia agregar ya que tiene el mismo codigo de identificacion que hipopotamo1
            listaMamiferos += leon1;
            listaMamiferos += elefante1;
            listaMamiferos += elefante2;

            if(delfin1.Equals(delfin2))
            {
                Console.WriteLine("Funciona el metodo equals\n");
            }

            foreach (Mamifero item in listaMamiferos.ListaMamiferos)
            {   
                Console.WriteLine("Mamifero: {0}\nNombre: {1}\nUbicacion: {2}\nTamaño: {3}\nCodigo de identificacion: {4}\n\n", item.GetType().Name, item.Nombre, item.Ubicacion, item.Tamanio, item.Id);

            }

        }
    }
}
