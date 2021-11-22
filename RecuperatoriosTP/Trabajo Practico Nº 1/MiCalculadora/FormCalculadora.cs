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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        #region Limpiar Formulario

        /// <summary>
        /// Limpia el formulario.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = null;
            this.txtNumero2.Text = null;
            this.cmbOperador.Text = null;
            this.lblResultado.Text = null;
        }

        /// <summary>
        /// Limpia el formulario al apretar el boton "LIMPIAR"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        #endregion

        #region Cerrar Formulario

        /// <summary>
        /// Pregunta si se quiere salir de la aplicacion, y lo hace depende la decision.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        /// <summary>
        ///  Pregunta si se quiere salir de la aplicacion, y lo hace depende la decision.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region Operar

        /// <summary>
        /// Realiza una operacion, la muestra en el label de "Resultado" y la operacion hecha queda guardada en un historial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);

            this.lblResultado.Text = resultado.ToString();
            
            string historialOperacion = txtNumero1.Text + " " + cmbOperador.Text + " " + txtNumero2.Text + " " + "=" + " " + resultado;

            this.lstOperaciones.Items.Add(historialOperacion);
            

        }

        /// <summary>
        /// Realiza una operacion y calcula el resultado.
        /// </summary>
        /// <param name="numero1"> Primer numero escrito por el usuario </param>
        /// <param name="numero2"> Segundo numero escrito por el usuario </param>
        /// <param name="operador"> Operador elegido por el usuario </param>
        /// <returns> Resultado de la operacion </returns>
        static private double Operar(string numero1, string numero2, string operador)
        {
            double resultado = 0;
            char operadorValido;

            char.TryParse(operador, out operadorValido);

            Operando numero1Convertido = new Operando(numero1);
            Operando numero2Convertido = new Operando(numero2);

            resultado = Calculadora.Operar(numero1Convertido, numero2Convertido, operadorValido);

                
            return resultado;
        }

        #endregion

        #region Convertidores

        /// <summary>
        /// Realiza la conversion a decimal de un numero y lo muestra en el cuadro de resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando numeroAConvertir = new Operando();

            string resultado = numeroAConvertir.BinarioDecimal(lblResultado.Text);

            lblResultado.Text = resultado;
        }

        /// <summary>
        /// Realiza la conversion a binario de un numero decimal y lo muestra en el cuadro de resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

            Operando numeroAConvertir = new Operando();

            string resultado = numeroAConvertir.DecimalBinario(lblResultado.Text);

            lblResultado.Text = resultado;

        }

        #endregion

    }
}
