
using System.Windows.Forms;

namespace Formularios
{
    partial class FrmLista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLista));
            this.dtgv_ListaGeneral = new System.Windows.Forms.DataGridView();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Exportar = new System.Windows.Forms.Button();
            this.cmb_Exportar = new System.Windows.Forms.ComboBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lbl_Volver = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.Mamifero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListaGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_ListaGeneral
            // 
            this.dtgv_ListaGeneral.AllowUserToAddRows = false;
            this.dtgv_ListaGeneral.AllowUserToDeleteRows = false;
            this.dtgv_ListaGeneral.AllowUserToResizeColumns = false;
            this.dtgv_ListaGeneral.AllowUserToResizeRows = false;
            this.dtgv_ListaGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_ListaGeneral.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtgv_ListaGeneral.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgv_ListaGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv_ListaGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mamifero});
            this.dtgv_ListaGeneral.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtgv_ListaGeneral.Location = new System.Drawing.Point(-2, -3);
            this.dtgv_ListaGeneral.MultiSelect = false;
            this.dtgv_ListaGeneral.Name = "dtgv_ListaGeneral";
            this.dtgv_ListaGeneral.ReadOnly = true;
            this.dtgv_ListaGeneral.RowTemplate.Height = 25;
            this.dtgv_ListaGeneral.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgv_ListaGeneral.Size = new System.Drawing.Size(516, 520);
            this.dtgv_ListaGeneral.TabIndex = 0;
            // 
            // btn_Remover
            // 
            this.btn_Remover.BackColor = System.Drawing.Color.Red;
            this.btn_Remover.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Remover.Location = new System.Drawing.Point(585, 183);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(121, 63);
            this.btn_Remover.TabIndex = 1;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = false;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Exportar.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exportar.Location = new System.Drawing.Point(585, 317);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(121, 62);
            this.btn_Exportar.TabIndex = 2;
            this.btn_Exportar.Text = "Exportar";
            this.btn_Exportar.UseVisualStyleBackColor = false;
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
            // 
            // cmb_Exportar
            // 
            this.cmb_Exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmb_Exportar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Exportar.FormattingEnabled = true;
            this.cmb_Exportar.Items.AddRange(new object[] {
            "CSV",
            "JSON",
            "XML"});
            this.cmb_Exportar.Location = new System.Drawing.Point(710, 342);
            this.cmb_Exportar.Name = "cmb_Exportar";
            this.cmb_Exportar.Size = new System.Drawing.Size(74, 23);
            this.cmb_Exportar.TabIndex = 3;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.Lime;
            this.btn_Agregar.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Agregar.Location = new System.Drawing.Point(585, 119);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(121, 58);
            this.btn_Agregar.TabIndex = 5;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Volver.BackgroundImage = global::Formularios.Properties.Resources.gato_imagen1;
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Volver.Location = new System.Drawing.Point(698, 431);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(98, 81);
            this.btn_Volver.TabIndex = 7;
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // lbl_Volver
            // 
            this.lbl_Volver.AutoSize = true;
            this.lbl_Volver.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Volver.Location = new System.Drawing.Point(710, 399);
            this.lbl_Volver.Name = "lbl_Volver";
            this.lbl_Volver.Size = new System.Drawing.Size(76, 29);
            this.lbl_Volver.TabIndex = 8;
            this.lbl_Volver.Text = "Volver";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Modificar.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Modificar.Location = new System.Drawing.Point(585, 252);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(121, 59);
            this.btn_Modificar.TabIndex = 9;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // Mamifero
            // 
            this.Mamifero.HeaderText = "Mamifero";
            this.Mamifero.Name = "Mamifero";
            this.Mamifero.ReadOnly = true;
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(794, 512);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.lbl_Volver);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.cmb_Exportar);
            this.Controls.Add(this.btn_Exportar);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.dtgv_ListaGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.FrmLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListaGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView dtgv_ListaGeneral;
        private Button btn_Remover;
        private Button btn_Exportar;
        private ComboBox cmb_Exportar;
        private Button btn_Agregar;
        private Timer timer1;
        private Button btn_Volver;
        private Label lbl_Volver;
        private Button btn_Modificar;
        private DataGridViewTextBoxColumn Mamifero;
    }
}