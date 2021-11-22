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

        /// <summary>
        /// Inicializa el formulario con todas las listas
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Importa informacion a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Reloj reloj = new Reloj();
            reloj.segundoCambiado += AsignarHora;
            reloj.Iniciar();

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
        /// Instancia un formulario de lista y lo abre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Lista_Click(object sender, EventArgs e)
        {
            FrmLista lista = new FrmLista();

            lista.ShowDialog();
        }

        /// <summary>
        /// Instancia un formulario de estadisticas y lo abre mostrando todos los correspondientes calculos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            listaGeneralMamiferos = MamiferosAcessoDatos.ObtenerTodos();

            Calculos calculos = new Calculos(listaGeneralMamiferos);

            FrmEstadisticas frmEstadisticas = new FrmEstadisticas(calculos) ;

            frmEstadisticas.ShowDialog();
        }

        /// <summary>
        /// Manejador de evento que trae la informacion de la hora en string y la muestra en un label.
        /// </summary>
        /// <param name="reloj"></param>
        public void AsignarHora(Reloj reloj)
        {
            if(lbl_Hora.InvokeRequired)
            {
                Action<Reloj> delegado = AsignarHora;

                lbl_Hora.Invoke(delegado, reloj);
            }
            else
            {
                lbl_Hora.Text = reloj.ToString();
            }
        }


    }
}
