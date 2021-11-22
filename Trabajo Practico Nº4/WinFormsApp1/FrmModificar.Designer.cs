
namespace Formularios
{
    partial class FrmModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificar));
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Ubicacion = new System.Windows.Forms.Label();
            this.lbl_Tamanio = new System.Windows.Forms.Label();
            this.cmb_Ubicacion = new System.Windows.Forms.ComboBox();
            this.cmb_Tamanio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(108, 191);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(59, 49);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_Nombre.TabIndex = 1;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(193, 52);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 5;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Ubicacion
            // 
            this.lbl_Ubicacion.AutoSize = true;
            this.lbl_Ubicacion.Location = new System.Drawing.Point(193, 91);
            this.lbl_Ubicacion.Name = "lbl_Ubicacion";
            this.lbl_Ubicacion.Size = new System.Drawing.Size(60, 15);
            this.lbl_Ubicacion.TabIndex = 6;
            this.lbl_Ubicacion.Text = "Ubicacion";
            // 
            // lbl_Tamanio
            // 
            this.lbl_Tamanio.AutoSize = true;
            this.lbl_Tamanio.Location = new System.Drawing.Point(193, 135);
            this.lbl_Tamanio.Name = "lbl_Tamanio";
            this.lbl_Tamanio.Size = new System.Drawing.Size(49, 15);
            this.lbl_Tamanio.TabIndex = 7;
            this.lbl_Tamanio.Text = "Tamaño";
            // 
            // cmb_Ubicacion
            // 
            this.cmb_Ubicacion.AutoCompleteCustomSource.AddRange(new string[] {
            "Delfin",
            "Elefante",
            "Leon",
            "Hipopotamo"});
            this.cmb_Ubicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Ubicacion.FormattingEnabled = true;
            this.cmb_Ubicacion.Items.AddRange(new object[] {
            "Argentina",
            "Uruguay"});
            this.cmb_Ubicacion.Location = new System.Drawing.Point(59, 88);
            this.cmb_Ubicacion.Name = "cmb_Ubicacion";
            this.cmb_Ubicacion.Size = new System.Drawing.Size(100, 23);
            this.cmb_Ubicacion.TabIndex = 11;
            // 
            // cmb_Tamanio
            // 
            this.cmb_Tamanio.AutoCompleteCustomSource.AddRange(new string[] {
            "Delfin",
            "Elefante",
            "Leon",
            "Hipopotamo"});
            this.cmb_Tamanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tamanio.FormattingEnabled = true;
            this.cmb_Tamanio.Items.AddRange(new object[] {
            "Grande",
            "Mediano"});
            this.cmb_Tamanio.Location = new System.Drawing.Point(59, 127);
            this.cmb_Tamanio.Name = "cmb_Tamanio";
            this.cmb_Tamanio.Size = new System.Drawing.Size(100, 23);
            this.cmb_Tamanio.TabIndex = 12;
            // 
            // FrmModificar
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(297, 246);
            this.Controls.Add(this.cmb_Tamanio);
            this.Controls.Add(this.cmb_Ubicacion);
            this.Controls.Add(this.lbl_Tamanio);
            this.Controls.Add(this.lbl_Ubicacion);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Ubicacion;
        private System.Windows.Forms.Label lbl_Tamanio;
        private System.Windows.Forms.ComboBox cmb_Ubicacion;
        private System.Windows.Forms.ComboBox cmb_Tamanio;
    }
}