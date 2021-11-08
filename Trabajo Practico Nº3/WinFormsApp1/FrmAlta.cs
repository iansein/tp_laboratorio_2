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

namespace Formularios
{
    public partial class FrmAlta : Form
    {
        Delfin delfin;
        Leon leon;
        Elefante elefante;
        Hipopotamo hipopotamo;
        MamiferosARescatar listaMamiferos;

        /// <summary>
        /// Constructor del formulario con sus datos.
        /// </summary>
        /// <param name="listaMamiferos"></param>
        public FrmAlta(MamiferosARescatar listaMamiferos)
        {      
            InitializeComponent();
            this.listaMamiferos = listaMamiferos;
         
        }

        /// <summary>
        /// Cierra el formulario de alta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAlta_FormClosing(object sender, FormClosingEventArgs e)
        {   
            if(btn_Cancelar.DialogResult == DialogResult.OK)
            {
                if (MessageBox.Show("Desea volver al menu principal?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                }
                else
                {
                    e.Cancel = true;
                }
            }

        }
        
        /// <summary>
        /// Agrega un mamifero a la lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {           
           
            try
            {
                int codigoIdentificacion;
                EUbicacion ubicacion;
                ETamanio tamanio;

                if(cmb_Mamifero.Text == "")
                {
                    MamiferoException mamiferoEx = new MamiferoException();
                    throw mamiferoEx;
                }

                if(ValidarNombre(txtBox_Nombre.Text) == true || String.IsNullOrWhiteSpace(txtBox_Nombre.Text))
                {
                    NombreException nombreEx = new NombreException();
                    throw nombreEx;
                }        

                if (txtBox_Nombre.Text == "")
                {
                    NombreException nombreEx = new NombreException();
                    throw nombreEx;
                }

                if (!Enum.TryParse(cmb_Ubicacion.Text, out ubicacion))
                {
                    UbicacionException ubicacionEx = new UbicacionException();
                    throw ubicacionEx;
                }

                if (!Int32.TryParse(txtBox_CodigoIdentificacion.Text, out codigoIdentificacion))
                {
                    CodigoException codigoEx = new CodigoException();
                    throw codigoEx;
                }

                if(!Enum.TryParse(cmb_Tamanio.Text, out tamanio))
                {
                    TamanioException tamanioEx = new TamanioException();
                    throw tamanioEx;
                }

                switch (cmb_Mamifero.Text)
                {

                    case "Leon":
                        this.leon = new Leon(txtBox_Nombre.Text, ubicacion, codigoIdentificacion, tamanio);
                        
                        if(listaMamiferos.ListaMamiferos.Contains(this.leon))
                        {
                            MamiferoRepetidoException mamiferoRepetidoEx = new MamiferoRepetidoException();
                            throw mamiferoRepetidoEx;
                        }

                        this.listaMamiferos += this.leon;

                        break;

                    case "Elefante":
                        this.elefante = new Elefante(txtBox_Nombre.Text, ubicacion, codigoIdentificacion, tamanio);

                        if (listaMamiferos.ListaMamiferos.Contains(this.elefante))
                        {
                            MamiferoRepetidoException mamiferoRepetidoEx = new MamiferoRepetidoException();
                            throw mamiferoRepetidoEx;
                        }

                        this.listaMamiferos += this.elefante;

                        break;

                    case "Hipopotamo":
                        this.hipopotamo = new Hipopotamo(txtBox_Nombre.Text, ubicacion, codigoIdentificacion, tamanio);
                        
                        if (listaMamiferos.ListaMamiferos.Contains(this.hipopotamo))
                        {
                            MamiferoRepetidoException mamiferoRepetidoEx = new MamiferoRepetidoException();
                            throw mamiferoRepetidoEx;
                        }

                        this.listaMamiferos += this.hipopotamo;

                        break;

                    case "Delfin":
                        this.delfin = new Delfin(txtBox_Nombre.Text, ubicacion, codigoIdentificacion, tamanio);

                        if (listaMamiferos.ListaMamiferos.Contains(this.delfin))
                        {
                            MamiferoRepetidoException mamiferoRepetidoEx = new MamiferoRepetidoException();
                            throw mamiferoRepetidoEx;
                        }

                        this.listaMamiferos += this.delfin;

                        break;

                }
               
                MessageBox.Show("Mamifero agregado satisfactoriamente a la lista\n\n", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch(MamiferoException mamiferoEx)
            {
                MessageBox.Show(mamiferoEx.Message);
            }
            catch(NombreException nombreEx)
            {
                MessageBox.Show(nombreEx.Message);
            }
            catch(UbicacionException ubicacionEx)
            {
                MessageBox.Show(ubicacionEx.Message);
            }
            catch(CodigoException codigoEx)
            {
                MessageBox.Show(codigoEx.Message);               
            }
            catch(MamiferoRepetidoException mamiferoRepetidoEx)
            {
                MessageBox.Show(mamiferoRepetidoEx.Message);
            }
            catch(TamanioException tamanioEx)
            {
                MessageBox.Show(tamanioEx.Message);
            }

        }

        /// <summary>
        /// Cierra el formulario de agregar un mamifero a la lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            btn_Cancelar.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Valida que el nombre no contenga numeros
        /// </summary>
        /// <param name="nombre"> Nombre a validar. </param>
        /// <returns></returns>
        private static bool ValidarNombre(string nombre)
        {
            foreach (Char caracater in nombre.ToCharArray())
            {
                if (Char.IsDigit(caracater))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
