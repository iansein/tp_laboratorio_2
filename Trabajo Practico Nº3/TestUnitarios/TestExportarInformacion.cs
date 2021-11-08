using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serializador;
using Entidades;
using Entidades.Clases_Derivadas;
using Serializador.Archivos;

namespace TestUnitarios
{   
    [TestClass]
    public class TestExportarInformacion
    {
        [TestMethod]

        public void ImportarInformacion()
        {
            Xml<List<Mamifero>> miVariable = new Xml<List<Mamifero>>();
            MamiferosARescatar listaMamiferos = new MamiferosARescatar();
            Delfin delfin = new Delfin("Delfinsito", Mamifero.EUbicacion.Argentina, 888, Mamifero.ETamanio.Mediano);

            listaMamiferos += delfin;

            bool validacion;

            validacion = miVariable.Exportar(listaMamiferos.ListaMamiferos, "De Prueba");

            Assert.IsTrue(validacion);
        }
    }
}
