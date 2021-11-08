using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Entidades.Clases_Derivadas;

namespace TestUnitarios
{
    [TestClass]
    public class TestAgregarMamifero
    {
        [TestMethod]

        public void TestAgregarMamiferoALista()
        {
            Delfin delfin = new Delfin("Delfinsito", Mamifero.EUbicacion.Argentina, 555, Mamifero.ETamanio.Mediano);
            MamiferosARescatar listaMamiferos = new MamiferosARescatar();

            listaMamiferos += delfin;

            Assert.IsTrue(listaMamiferos.ListaMamiferos.Contains(delfin));
            
        }

    }
}
