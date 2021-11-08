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
    public class TestImportarInformacion
    {
        [TestMethod]

        public void ImportarInformacion()
        {
            Xml<List<Mamifero>> miVariable = new Xml<List<Mamifero>>();
            List<Mamifero> listaMamiferos = new List<Mamifero>();
            bool validacion;

            validacion = miVariable.Importar("C:\\Users\\Usuario\\source\\repos\\Trabajo Practico Nº3\\WinFormsApp1\\bin\\Debug\\net5.0-windows" + @"\ImportarDesdeXml\InformeInicial.xml", out listaMamiferos);

            Assert.IsTrue(validacion);
        }
    }
}
