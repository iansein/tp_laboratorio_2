namespace Formularios
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.btn_Lista = new System.Windows.Forms.Button();
            this.btn_Estadisticas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Hora.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hora.ForeColor = System.Drawing.Color.Black;
            this.lbl_Hora.Location = new System.Drawing.Point(661, 424);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(212, 34);
            this.lbl_Hora.TabIndex = 11;
            // 
            // btn_Lista
            // 
            this.btn_Lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Lista.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Lista.Location = new System.Drawing.Point(342, 149);
            this.btn_Lista.Name = "btn_Lista";
            this.btn_Lista.Size = new System.Drawing.Size(144, 61);
            this.btn_Lista.TabIndex = 15;
            this.btn_Lista.Text = "Listado";
            this.btn_Lista.UseVisualStyleBackColor = false;
            this.btn_Lista.Click += new System.EventHandler(this.btn_Lista_Click);
            // 
            // btn_Estadisticas
            // 
            this.btn_Estadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Estadisticas.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Estadisticas.Location = new System.Drawing.Point(342, 243);
            this.btn_Estadisticas.Name = "btn_Estadisticas";
            this.btn_Estadisticas.Size = new System.Drawing.Size(144, 61);
            this.btn_Estadisticas.TabIndex = 16;
            this.btn_Estadisticas.Text = "Estadisticas";
            this.btn_Estadisticas.UseVisualStyleBackColor = false;
            this.btn_Estadisticas.Click += new System.EventHandler(this.btn_Estadisticas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Formularios.Properties.Resources.gato_imagen;
            this.pictureBox1.Location = new System.Drawing.Point(242, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Formularios.Properties.Resources.gato_imagen;
            this.pictureBox2.Location = new System.Drawing.Point(242, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(201, 29);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(430, 41);
            this.lbl_Titulo.TabIndex = 19;
            this.lbl_Titulo.Text = "RESCATISTAS ESPERANZA";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(818, 467);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Estadisticas);
            this.Controls.Add(this.btn_Lista);
            this.Controls.Add(this.lbl_Hora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rescatistas Esperanza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Button btn_Lista;
        private System.Windows.Forms.Button btn_Estadisticas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}

