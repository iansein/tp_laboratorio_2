using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmModificar : Form
    {
        Mamifero mamifero;

        /// <summary>
        /// Constructor de instancia que inicializa el formulario y al objeto de la clase Mamifero.
        /// </summary>
        /// <param name="mamifero"></param>
        public FrmModificar(Mamifero mamifero)
        {   
            InitializeComponent();
            this.mamifero = mamifero;
            this.mamifero.Id = mamifero.Id;
        }

        /// <summary>
        /// Devuelve al mamifero modificado.
        /// </summary>
        public Mamifero MamimeroModificado
        {
            get
            {
                return this.mamifero;
            }
        }

        /// <summary>
        /// Valida todos los campos escritos por el usuario y modifica al mamifero si esta todo correcto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                EUbicacion ubicacion;
                ETamanio tamanio;

                if (ValidarNombre(txt_Nombre.Text) == false || String.IsNullOrWhiteSpace(txt_Nombre.Text))
                {
                    NombreException nombreEx = new NombreException();
                    throw nombreEx;
                }

                if (txt_Nombre.Text == "")
                {
                    NombreException nombreEx = new NombreException();
                    throw nombreEx;
                }

                if (!Enum.TryParse(cmb_Ubicacion.Text, out ubicacion))
                {
                    UbicacionException ubicacionEx = new UbicacionException();
                    throw ubicacionEx;
                }
                if (!Enum.TryParse(cmb_Tamanio.Text, out tamanio))
                {
                    TamanioException tamanioEx = new TamanioException();
                    throw tamanioEx;
                }

                this.mamifero.Nombre = txt_Nombre.Text;
                this.mamifero.Tamanio = tamanio;
                this.mamifero.Ubicacion = ubicacion;
                

                MessageBox.Show("Mamifero modificado satisfactoriamente\n\n", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (NombreException nombreEx)
            {
                MessageBox.Show(nombreEx.Message);
            }
            catch (UbicacionException ubicacionEx)
            {
                MessageBox.Show(ubicacionEx.Message);
            }
            catch (MamiferoRepetidoException mamiferoRepetidoEx)
            {
                MessageBox.Show(mamiferoRepetidoEx.Message);
            }
            catch (TamanioException tamanioEx)
            {
                MessageBox.Show(tamanioEx.Message);
            }


        }

        /// <summary>
        /// Valida que el nombre no contenga simbolos ni numeros.
        /// </summary>
        /// <param name="nombre"> Nombre a validar. </param>
        /// <returns> True si el nombre no contiene simbolos ni numeros o false si los contiene. </returns>
        private static bool ValidarNombre(string nombre)
        {
            int i;

            for (i = 0; i < nombre.Length; i++)
            {
                if (nombre[i] != '\0')
                {
                    if (((nombre[i] < 'a' || nombre[i] > 'z') && (nombre[i] < 'A' || nombre[i] > 'Z')) || nombre[i] == ' ')
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
