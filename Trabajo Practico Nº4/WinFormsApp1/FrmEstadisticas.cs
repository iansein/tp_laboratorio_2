using Entidades;
using Entidades.Excepciones;
using Serializador;
using Serializador.Archivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    
    public partial class FrmEstadisticas : Form
    {
        Calculos calculos;

        public delegate void ExportarDelegado();
        ExportarDelegado exportarDelegado;

        /// <summary>
        /// Constructor de instancia que inicializa el formulario y un objeto de la clase Calculo
        /// </summary>
        /// <param name="calculos"></param>
        public FrmEstadisticas(Calculos calculos)
        {
            InitializeComponent();
            this.calculos = calculos;
        }   

        /// <summary>
        /// Mediante un hilo secundario se traen las estadisticas de la lista de mamiferos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            btn_Volver.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Volver.FlatAppearance.MouseOverBackColor = Color.Transparent;

            Task hilo = Task.Run(() => TraerContenido());
            exportarDelegado = ImprimirEstadisticas;
        }

        /// <summary>
        /// Invoca el metodo que exporta las estadisticas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exportar_Click(object sender, EventArgs e)
        {

            exportarDelegado.Invoke();
           
        }

        /// <summary>
        /// Trae todas las estadisticas de la lista de mamiferos y las muestra en las TextBox.
        /// </summary>
        private void TraerContenido()
        {
            if (InvokeRequired)
            {
                Action action = TraerContenido;
                object[] parameters = new object[] { };
                Invoke(action, parameters);
            }
            else
            {
                txt_TotalDelfines.Text = this.calculos.TotalDelfines.ToString();
                txt_TotalLeones.Text = this.calculos.TotalLeones.ToString();
                txt_TotalElefantes.Text = this.calculos.TotalElefantes.ToString();
                txt_TotalHipopotamos.Text = this.calculos.TotalHipopotamos.ToString();
                txt_PorcentajeArgentina.Text = "%" + this.calculos.PorcentajeDeMamiferosEnArgentina.ToString();
                txt_PorcentajeUruguay.Text = "%" + this.calculos.PorcentajeDeMamiferosEnUruguay.ToString();
                txt_PorcentajeGrandes.Text = "%" + this.calculos.PorcentajeDeGrandes.ToString();
                txt_PorcentajeMedianos.Text = "%" + this.calculos.PorcentajeDeMedianos.ToString();
                txt_PorcentajeDelfinesEnArgentina.Text = "%" + this.calculos.PorcentajeDelfinesEnArgentina.ToString();
                txt_PorcentajeLeonesEnArgentina.Text = "%" + this.calculos.PorcentajeLeonesEnArgentina.ToString();
                txt_PorcentajeElefantesEnArgentina.Text = "%" + this.calculos.PorcentajeElefantesEnArgentina.ToString();
                txt_PorcentajeHipopotamosEnArgentina.Text = "%" + this.calculos.PorcentajeHipopotamosEnArgentina.ToString();
                txt_PorcentajeDelfinesEnUruguay.Text = "%" + this.calculos.PorcentajeDelfinesEnUruguay.ToString();
                txt_PorcentajeLeonesEnUruguay.Text = "%" + this.calculos.PorcentajeLeonesEnUruguay.ToString();
                txt_PorcentajeElefantesEnUruguay.Text = "%" + this.calculos.PorcentajeElefantesEnUruguay.ToString();
                txt_PorcentajeHipopotamosEnUruguay.Text = "%" + this.calculos.PorcentajeHipopotamosEnUruguay.ToString();

           
            }

        }

        /// <summary>
        /// Exporta las estadisticas en el formato elegido por el usuario.
        /// </summary>
        private void ImprimirEstadisticas()
        {


            try
            {
                switch (cmb_FormatoExportar.Text)
                {
                    case "":

                        MessageBox.Show("Ingrese un formato para exportar");
                        break;

                    case "TXT":

                        Txt<string> estadisticaDatosTxt = new Txt<string>();

                        if (estadisticaDatosTxt.Exportar(calculos.ToString(), "estadistico"))
                        {
                            MessageBox.Show("Informe exportado con éxito en el ESCRITORIO");

                        }
                        else
                        {
                            ExportarEstadisticasException exc = new ExportarEstadisticasException();
                            throw exc;
                        }
                        break;

                    case "XML":

                        Xml<string> estadisticaDatosXml = new Xml<string>();

                        if (estadisticaDatosXml.Exportar(calculos.ToString(), "estadistico"))
                        {
                            MessageBox.Show("Informe exportado con éxito en el ESCRITORIO");

                        }
                        else
                        {
                            ExportarEstadisticasException exc = new ExportarEstadisticasException();
                            throw exc;
                        }

                        break;

                    case "JSON":

                        Json<string> estadisticaDatosJson = new Json<string>();

                        if (estadisticaDatosJson.Exportar(calculos.ToString(), "estadistico"))
                        {
                            MessageBox.Show("Informe exportado con éxito en el ESCRITORIO");

                        }
                        else
                        {
                            ExportarEstadisticasException exc = new ExportarEstadisticasException();
                            throw exc;
                        }

                        break;

                }


            }
            catch (ExportarEstadisticasException exc)
            {
                MessageBox.Show(exc.InformarSobreEstadisticas(), "Error");
            }
        }

        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();

            sound.SoundLocation = Environment.CurrentDirectory + @"\miau.wav";
            sound.Play();

            this.Close();
        }

    }
}
