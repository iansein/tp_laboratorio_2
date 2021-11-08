using System;
using Entidades;
using Entidades.Clases_Derivadas;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            MamiferosARescatar listaMamiferos;
            listaMamiferos = new MamiferosARescatar();

            Delfin delfin1 = new Delfin("Delfinsito", Mamifero.EUbicacion.Argentina, 555, Mamifero.ETamanio.Grande);
            Delfin delfin2 = new Delfin("Brillante", Mamifero.EUbicacion.Argentina, 555, Mamifero.ETamanio.Mediano);
            Hipopotamo hipopotamo1 = new Hipopotamo("Hipopotamito", Mamifero.EUbicacion.Uruguay, 999, Mamifero.ETamanio.Grande);
            Hipopotamo hipopotamo2 = new Hipopotamo("Hermoso", Mamifero.EUbicacion.Uruguay, 999, Mamifero.ETamanio.Mediano);
            Leon leon1 = new Leon("Leonsito", Mamifero.EUbicacion.Argentina, 333, Mamifero.ETamanio.Grande);
            Elefante elefante1 = new Elefante("Elefantito", Mamifero.EUbicacion.Uruguay, 777, Mamifero.ETamanio.Mediano);
            Elefante elefante2 = new Elefante("Elefanton", Mamifero.EUbicacion.Argentina, 779, Mamifero.ETamanio.Grande);

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
                Console.WriteLine("Mamifero: {0}\nNombre: {1}\nUbicacion: {2}\nTamaño: {3}\nCodigo de identificacion: {4}\n\n", item.GetType().Name, item.Nombre, item.Ubicacion, item.Tamanio, item.CodigoDeIdentificacion);

            }

        }
    }
}
