
namespace Formularios
{
    partial class FrmAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlta));
            this.cmb_Mamifero = new System.Windows.Forms.ComboBox();
            this.txtBox_Nombre = new System.Windows.Forms.TextBox();
            this.cmb_Ubicacion = new System.Windows.Forms.ComboBox();
            this.txtBox_CodigoIdentificacion = new System.Windows.Forms.TextBox();
            this.lbl_Mamifero = new System.Windows.Forms.Label();
            this.lbl_NombreMamifero = new System.Windows.Forms.Label();
            this.lbl_UbicacionMamifero = new System.Windows.Forms.Label();
            this.lbl_CodigoIdentificacion = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.cmb_Tamanio = new System.Windows.Forms.ComboBox();
            this.lbl_Tamanio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_Mamifero
            // 
            this.cmb_Mamifero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Mamifero.FormattingEnabled = true;
            this.cmb_Mamifero.Items.AddRange(new object[] {
            "Leon",
            "Elefante",
            "Delfin",
            "Hipopotamo"});
            this.cmb_Mamifero.Location = new System.Drawing.Point(12, 50);
            this.cmb_Mamifero.Name = "cmb_Mamifero";
            this.cmb_Mamifero.Size = new System.Drawing.Size(121, 23);
            this.cmb_Mamifero.TabIndex = 0;
            // 
            // txtBox_Nombre
            // 
            this.txtBox_Nombre.Location = new System.Drawing.Point(12, 88);
            this.txtBox_Nombre.Name = "txtBox_Nombre";
            this.txtBox_Nombre.Size = new System.Drawing.Size(121, 23);
            this.txtBox_Nombre.TabIndex = 1;
            // 
            // cmb_Ubicacion
            // 
            this.cmb_Ubicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Ubicacion.FormattingEnabled = true;
            this.cmb_Ubicacion.Items.AddRange(new object[] {
            "Argentina",
            "Uruguay"});
            this.cmb_Ubicacion.Location = new System.Drawing.Point(12, 126);
            this.cmb_Ubicacion.Name = "cmb_Ubicacion";
            this.cmb_Ubicacion.Size = new System.Drawing.Size(121, 23);
            this.cmb_Ubicacion.TabIndex = 2;
            // 
            // txtBox_CodigoIdentificacion
            // 
            this.txtBox_CodigoIdentificacion.Location = new System.Drawing.Point(12, 164);
            this.txtBox_CodigoIdentificacion.Name = "txtBox_CodigoIdentificacion";
            this.txtBox_CodigoIdentificacion.Size = new System.Drawing.Size(121, 23);
            this.txtBox_CodigoIdentificacion.TabIndex = 3;
            // 
            // lbl_Mamifero
            // 
            this.lbl_Mamifero.AutoSize = true;
            this.lbl_Mamifero.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Mamifero.Location = new System.Drawing.Point(150, 54);
            this.lbl_Mamifero.Name = "lbl_Mamifero";
            this.lbl_Mamifero.Size = new System.Drawing.Size(57, 14);
            this.lbl_Mamifero.TabIndex = 4;
            this.lbl_Mamifero.Text = "Mamifero";
            // 
            // lbl_NombreMamifero
            // 
            this.lbl_NombreMamifero.AutoSize = true;
            this.lbl_NombreMamifero.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreMamifero.Location = new System.Drawing.Point(150, 92);
            this.lbl_NombreMamifero.Name = "lbl_NombreMamifero";
            this.lbl_NombreMamifero.Size = new System.Drawing.Size(49, 14);
            this.lbl_NombreMamifero.TabIndex = 5;
            this.lbl_NombreMamifero.Text = "Nombre";
            // 
            // lbl_UbicacionMamifero
            // 
            this.lbl_UbicacionMamifero.AutoSize = true;
            this.lbl_UbicacionMamifero.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_UbicacionMamifero.Location = new System.Drawing.Point(150, 130);
            this.lbl_UbicacionMamifero.Name = "lbl_UbicacionMamifero";
            this.lbl_UbicacionMamifero.Size = new System.Drawing.Size(57, 14);
            this.lbl_UbicacionMamifero.TabIndex = 6;
            this.lbl_UbicacionMamifero.Text = "Ubicacion";
            // 
            // lbl_CodigoIdentificacion
            // 
            this.lbl_CodigoIdentificacion.AutoSize = true;
            this.lbl_CodigoIdentificacion.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CodigoIdentificacion.Location = new System.Drawing.Point(150, 168);
            this.lbl_CodigoIdentificacion.Name = "lbl_CodigoIdentificacion";
            this.lbl_CodigoIdentificacion.Size = new System.Drawing.Size(18, 14);
            this.lbl_CodigoIdentificacion.TabIndex = 8;
            this.lbl_CodigoIdentificacion.Text = "Id";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(36, 256);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 9;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(179, 256);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // cmb_Tamanio
            // 
            this.cmb_Tamanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tamanio.FormattingEnabled = true;
            this.cmb_Tamanio.Items.AddRange(new object[] {
            "Grande",
            "Mediano"});
            this.cmb_Tamanio.Location = new System.Drawing.Point(12, 202);
            this.cmb_Tamanio.Name = "cmb_Tamanio";
            this.cmb_Tamanio.Size = new System.Drawing.Size(121, 23);
            this.cmb_Tamanio.TabIndex = 11;
            // 
            // lbl_Tamanio
            // 
            this.lbl_Tamanio.AutoSize = true;
            this.lbl_Tamanio.Location = new System.Drawing.Point(150, 205);
            this.lbl_Tamanio.Name = "lbl_Tamanio";
            this.lbl_Tamanio.Size = new System.Drawing.Size(49, 15);
            this.lbl_Tamanio.TabIndex = 12;
            this.lbl_Tamanio.Text = "Tamaño";
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(290, 293);
            this.Controls.Add(this.lbl_Tamanio);
            this.Controls.Add(this.cmb_Tamanio);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_CodigoIdentificacion);
            this.Controls.Add(this.lbl_UbicacionMamifero);
            this.Controls.Add(this.lbl_NombreMamifero);
            this.Controls.Add(this.lbl_Mamifero);
            this.Controls.Add(this.txtBox_CodigoIdentificacion);
            this.Controls.Add(this.cmb_Ubicacion);
            this.Controls.Add(this.txtBox_Nombre);
            this.Controls.Add(this.cmb_Mamifero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Mamifero";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAlta_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Mamifero;
        private System.Windows.Forms.TextBox txtBox_Nombre;
        private System.Windows.Forms.ComboBox cmb_Ubicacion;
        private System.Windows.Forms.TextBox txtBox_CodigoIdentificacion;
        private System.Windows.Forms.Label lbl_Mamifero;
        private System.Windows.Forms.Label lbl_NombreMamifero;
        private System.Windows.Forms.Label lbl_UbicacionMamifero;
        private System.Windows.Forms.Label lbl_CodigoIdentificacion;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Tamanio;
        private System.Windows.Forms.ComboBox cmb_Tamanio;
    }
}