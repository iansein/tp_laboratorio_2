using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Clases_Derivadas;
using static Entidades.Mamifero;
using Serializador.Archivos;

namespace Formularios
{
    public partial class FrmPrincipal : Form
    {
        MamiferosARescatar listaGeneralMamiferos;
        MamiferosARescatar listaDelfines;
        MamiferosARescatar listaLeones;
        MamiferosARescatar listaHipopotamos;
        MamiferosARescatar listaElefantes;
        MamiferosARescatar listaMedianos;
        MamiferosARescatar listaGrandes;
        MamiferosARescatar listaArgentina;
        MamiferosARescatar listaUruguay;

        /// <summary>
        /// Inicializa el formulario con todas las listas
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
            listaGeneralMamiferos = new MamiferosARescatar();
            listaDelfines = new MamiferosARescatar();
            listaDelfines = new MamiferosARescatar();
            listaLeones = new MamiferosARescatar();
            listaHipopotamos = new MamiferosARescatar();
            listaElefantes = new MamiferosARescatar();
            listaMedianos = new MamiferosARescatar();
            listaGrandes = new MamiferosARescatar();
            listaArgentina = new MamiferosARescatar();
            listaUruguay = new MamiferosARescatar();
        }

        /// <summary>
        /// Importa informacion a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Xml<List<Mamifero>> miVariable = new Xml<List<Mamifero>>();
            List<Mamifero> listaMamiferos = new List<Mamifero>();
            
            try
            {
                miVariable.Importar(Environment.CurrentDirectory + @"\ImportarDesdeXml\InformeInicial.xml", out listaMamiferos);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (Mamifero item in listaMamiferos)
            {
                listaGeneralMamiferos.ListaMamiferos.Add(item);
            }

        }

        /// <summary>
        /// Cierra el formulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quieres salir de la aplicacion?", "Saliendo de 'Rescatistas Esperanza'", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Muestra la fecha y la hora en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void horafecha_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToString("h:mm:ss");
            lbl_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        /// <summary>
        /// Abre un formulario para dar de agregar a un mamifero a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AgregarMamifero_Click(object sender, EventArgs e)
        {

            FrmAlta formAlta = new FrmAlta(this.listaGeneralMamiferos);
            if(formAlta.ShowDialog() == DialogResult.OK)
            {
                
            }

        }

        #region Informes

        
        /// <summary>
        /// Exporta un informe de los delfines que hay en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_InformeDelfines_Click(object sender, EventArgs e)
        {
            foreach (Mamifero item in this.listaGeneralMamiferos.ListaMamiferos)
            {
                if(item is Delfin)
                {
                    listaDelfines+=item;
                }
            }

            try
            {
                Xml<List<Mamifero>> miVariable = new Xml<List<Mamifero>>();

                if (listaDelfines.ListaMamiferos.Count > 0 && miVariable.Exportar(listaDelfines.ListaMamiferos, "de delfines"))
                {
                    MessageBox.Show("Informe exportado con éxito en el ESCRITORIO");

                }
                else
                {
                    MessageBox.Show("No se exporto el informe correctamente\nLa lista no contiene ningun delfin\n");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        /// <summary>
        /// Exporta un informe de los leones que hay en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_InformeLeones_Click(object sender, EventArgs e)
        {
            foreach (Mamifero item in this.listaGeneralMamiferos.ListaMamiferos)
            {
                if (item is Leon)
                {
                    listaLeones += item;
                }
            }

            try
            {
                Xml<List<Mamifero>> miVariable = new Xml<List<Mamifero>>();

                if (listaLeones.ListaMamiferos.Count > 0 && miVariable.Exportar(listaLeones.ListaMamiferos, "de leones"))
                {
                    MessageBox.Show("Informe exportado con éxito en el ESCRITORIO");

                }
                else
                {
                    MessageBox.Show("No se exporto el informe correctamente\nLa lista no contiene ningun leon\n");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        /// <summary>
        /// Exporta un informe de los hipopotamos que hay en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_InformeHipopotamos_Click(object sender, EventArgs e)
        {
            foreach (Mamifero item in this.listaGeneralMamiferos.ListaMamiferos)
            {
                if (item is Hipopotamo)
                {
                    listaHipopotamos += item;
                }
            }

            try
            {
                Xml<List<Mamifero>> miVariable = new Xml<List<Mamifero>>();

                if (listaHipopotamos.ListaMamiferos.Count > 0 && miVariable.Exportar(listaHipopotamos.ListaMamiferos, "de hipopotamos"))
                {
                    MessageBox.Show("Informe exportado con éxito en el ESCRITORIO");

                }
                else
                {
                    MessageBox.Show("No se exporto el informe correctamente\nLa lista no contiene ningun hipopotamo\n");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// Exporta un informe de los elefantes que hay en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_InformeElefantes_Click(object sender, EventArgs e)
        {
            foreach (Mamifero item in this.listaGeneralMamiferos.ListaMamiferos)
            {
                if (item is Elefante)
                {
                    listaElefantes += item;
                }
            }

            try
            {
                Xml<List<Mamifero>> miVariable = new Xml<List<Mamifero>>();

                if (listaElefantes.ListaMamiferos.Count > 0 && miVariable.Exportar(listaElefantes.ListaMamiferos, "de elefantes"))
                {
                    MessageBox.Show("Informe exportado con éxito en el ESCRITORIO");

                }
                else
                {
                    MessageBox.Show("No se exporto el informe correctamente\nLa lista no contiene ningun elefante\n");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        /// <summary>
        /// Exporta un informe de los mamiferos que sean de tamaño mediano
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_InformeMedianos_Click(object sender, EventArgs e)
        {
            foreach (Mamifero item in this.listaGeneralMamiferos.ListaMamiferos)
            {
                if (item.Tamanio == ETamanio.Mediano)
                {
                    listaMedianos += item;
                }
            }

            try
            {
                Xml<List<Mamifero>> miVariable = new Xml<List<Mamifero>>();

                if (listaMedianos.ListaMamiferos.Count > 0 && miVariable.Exportar(listaMedianos.ListaMamiferos, "de medianos"))
                {
                    MessageBox.Show("Informe exportado con éxito en el ESCRITORIO");

                }
                else
                {
                    MessageBox.Show("No se exporto el informe correctamente\nLa lista no contiene ningun mamifero de tamaño mediano\n");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// Exporta un informe de los mamiferos que sean de tamaño grande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_InformeGrandes_Click(object sender, EventArgs e)
        {
            foreach (Mamifero item in this.listaGeneralMamiferos.ListaMamiferos)
            {
                if (item.Tamanio == ETamanio.Grande)
                {
                    listaGrandes += item;
                }
            }
            try
            {
                Xml<List<Mamifero>> miVariable = new Xml<List<Mamifero>>();

                if (listaGrandes.ListaMamiferos.Count > 0 && miVariable.Exportar(listaGrandes.ListaMamiferos, "de grandes"))
                {
                    MessageBox.Show("Informe exportado con éxito en el ESCRITORIO");

                }
                else
                {
                    MessageBox.Show("No se exporto el informe correctamente\nLa lista no contiene ningun mamifero de tamaño grande\n");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_InformeArgentina_Click(object sender, EventArgs e)
        {
            foreach (Mamifero item in this.listaGeneralMamiferos.ListaMamiferos)
            {
                if (item.Ubicacion == EUbicacion.Argentina)
                {
                    listaArgentina += item;
                }
            }
            try
            {
                Xml<List<Mamifero>> miVariable = new Xml<List<Mamifero>>();

                if (listaArgentina.ListaMamiferos.Count > 0 && miVariable.Exportar(listaArgentina.ListaMamiferos, "de Argentina"))
                {
                    MessageBox.Show("Informe exportado con éxito en el ESCRITORIO");

                }
                else
                {
                    MessageBox.Show("No se exporto el informe correctamente\nLa lista no contiene ningun mamifero de Argentina\n");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_InformeUruguay_Click(object sender, EventArgs e)
        {
            foreach (Mamifero item in this.listaGeneralMamiferos.ListaMamiferos)
            {
                if (item.Ubicacion == EUbicacion.Uruguay)
                {
                    listaUruguay += item;
                }
            }
            try
            {
                Xml<List<Mamifero>> miVariable = new Xml<List<Mamifero>>();

                if (listaUruguay.ListaMamiferos.Count > 0 && miVariable.Exportar(listaUruguay.ListaMamiferos, "de Uruguay"))
                {
                    MessageBox.Show("Informe exportado con éxito en el ESCRITORIO");

                }
                else
                {
                    MessageBox.Show("No se exporto el informe correctamente\nLa lista no contiene ningun mamifero de Uruguay\n");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        #endregion
    }
}
