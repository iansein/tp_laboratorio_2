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
            Delfin delfin = new Delfin("Delfinsito", EUbicacion.Argentina, 555, ETamanio.Mediano);
            MamiferosARescatar listaMamiferos = new MamiferosARescatar();

            listaMamiferos += delfin;

            Assert.IsTrue(listaMamiferos.ListaMamiferos.Contains(delfin));
            
        }

    }
}
