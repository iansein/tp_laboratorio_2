using Entidades;
using Serializador;
using Serializador.Archivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using Entidades.Excepciones;

namespace Formularios
{
    public partial class FrmLista : Form
    {
        MamiferosARescatar listaMamiferos;

        /// <summary>
        /// Constructor que inicializa al formulario
        /// </summary>
        public FrmLista()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Actualiza la lista trayendola desde la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLista_Load(object sender, EventArgs e)
        {

            ActualizarListaDeMamiferos();

            btn_Volver.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Volver.FlatAppearance.MouseOverBackColor = Color.Transparent;


        }

        /// <summary>
        /// Actualiza la datagrid con la nueva lista modificada desde la base de datos.
        /// </summary>
        private void ActualizarListaDeMamiferos()
        {
            int i = 0;
            int j = 0;

            listaMamiferos = MamiferosAcessoDatos.ObtenerTodos();
            dtgv_ListaGeneral.DataSource = listaMamiferos.ListaMamiferos;
            dtgv_ListaGeneral.Refresh();
            dtgv_ListaGeneral.Update();

            foreach (Mamifero item in listaMamiferos.ListaMamiferos)
            {
                dtgv_ListaGeneral.Rows[i].Cells[0].Value = item.GetType().Name;
                i++;
            }

            foreach (DataGridViewRow row in dtgv_ListaGeneral.Rows)
            {
                dtgv_ListaGeneral.Rows[j].DefaultCellStyle.BackColor = Color.LightPink;

                j++;
            }


        }

        /// <summary>
        /// Remueve un mamifero de la lista de mamiferos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Remover_Click(object sender, EventArgs e)
        {

            if (dtgv_ListaGeneral.SelectedRows.Count == 1)
            {
                Mamifero mamifero = (Mamifero)dtgv_ListaGeneral.CurrentRow.DataBoundItem;

                if (MessageBox.Show("Desea eliminar al mamifero seleccionado?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MamiferosAcessoDatos.Eliminar(mamifero);
                    ActualizarListaDeMamiferos();
                }

            }
            else
            {
                MessageBox.Show("Para eliminar un mamifero debe seleccionar solo una fila", "Error");
            }

        }

        /// <summary>
        /// Exporta la lista en el formato elegido por el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmb_Exportar.Text)
                {
                    case "":
                        MessageBox.Show("Ingrese un formato para exportar");
                        break;

                    case "XML":
                        Xml<List<Mamifero>> listaDatosXml = new Xml<List<Mamifero>>();

                        if (listaMamiferos.ListaMamiferos.Count > 0 && listaDatosXml.Exportar(listaMamiferos.ListaMamiferos, "general"))
                        {
                            MessageBox.Show("Informe exportado con éxito en el ESCRITORIO");

                        }
                        else
                        {
                            ExportarListaException exc = new ExportarListaException();
                            throw exc;
                        }

                        break;

                    case "JSON":

                        Json<List<Mamifero>> listaDatosJson = new Json<List<Mamifero>>();

                        if (listaMamiferos.ListaMamiferos.Count > 0 && listaDatosJson.Exportar(listaMamiferos.ListaMamiferos, "general"))
                        {
                            MessageBox.Show("Informe exportado con éxito en el ESCRITORIO");

                        }
                        else
                        {
                            ExportarListaException exc = new ExportarListaException();
                            throw exc;
                        }

                        break;

                    case "CSV":

                        Csv<List<Mamifero>> listaDatosCsv = new Csv<List<Mamifero>>(listaMamiferos);

                        if (listaMamiferos.ListaMamiferos.Count > 0 && listaDatosCsv.Exportar(listaMamiferos.ListaMamiferos, "general"))
                        {
                            MessageBox.Show("Informe exportado con éxito en el ESCRITORIO");

                        }
                        else
                        {
                            ExportarListaException exc = new ExportarListaException();
                            throw exc;
                        }

                        break;
                }
            }
            catch (ExportarListaException exc)
            {
                MessageBox.Show(exc.InformarSobreLista(), "Error");
            }
        }

        /// <summary>
        /// Agrega un mamifero a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            FrmAlta formAlta = new FrmAlta(listaMamiferos);
            if (formAlta.ShowDialog() == DialogResult.OK)
            {
                ActualizarListaDeMamiferos();
            }
            else
            {
                MessageBox.Show("No se agrego ningun mamifero");
            }

        }

        /// <summary>
        /// Cierra el formulario
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

        /// <summary>
        /// Modifica el mamifero elegido por el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            if (dtgv_ListaGeneral.SelectedRows.Count == 1)
            {
                Mamifero mamifero;
                mamifero = (Mamifero)dtgv_ListaGeneral.CurrentRow.DataBoundItem;

                FrmModificar modificar = new FrmModificar(mamifero);
                DialogResult dialog = modificar.ShowDialog();

                if (dialog == DialogResult.OK)
                {
                    MamiferosAcessoDatos.Modificar(modificar.MamimeroModificado);
                    ActualizarListaDeMamiferos();

                }
                else
                {
                    MessageBox.Show("No se modifico al mamifero");
                }

            }
            else
            {
                MessageBox.Show("Para modificar un mamifero debe seleccionar solo una fila", "Error");
            }

        }

    }
}
