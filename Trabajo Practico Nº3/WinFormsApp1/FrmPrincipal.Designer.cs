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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_AgregarMamifero = new System.Windows.Forms.Button();
            this.btn_InformeLeon = new System.Windows.Forms.Button();
            this.btn_InformeHipopotamo = new System.Windows.Forms.Button();
            this.btn_InformeDelfin = new System.Windows.Forms.Button();
            this.btn_InformeElefante = new System.Windows.Forms.Button();
            this.lbl_Informes = new System.Windows.Forms.Label();
            this.btn_InformeGrandes = new System.Windows.Forms.Button();
            this.btn_InformeMedianos = new System.Windows.Forms.Button();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.btn_InformeArgentina = new System.Windows.Forms.Button();
            this.btn_InformeUruguay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Formularios.Properties.Resources.RescatistasEsperanza__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-8, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(841, 476);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_AgregarMamifero
            // 
            this.btn_AgregarMamifero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_AgregarMamifero.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarMamifero.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_AgregarMamifero.Location = new System.Drawing.Point(12, 12);
            this.btn_AgregarMamifero.Name = "btn_AgregarMamifero";
            this.btn_AgregarMamifero.Size = new System.Drawing.Size(195, 36);
            this.btn_AgregarMamifero.TabIndex = 1;
            this.btn_AgregarMamifero.Text = "Agregar Mamifero";
            this.btn_AgregarMamifero.UseVisualStyleBackColor = false;
            this.btn_AgregarMamifero.Click += new System.EventHandler(this.btn_AgregarMamifero_Click);
            // 
            // btn_InformeLeon
            // 
            this.btn_InformeLeon.BackColor = System.Drawing.Color.White;
            this.btn_InformeLeon.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_InformeLeon.Location = new System.Drawing.Point(12, 162);
            this.btn_InformeLeon.Name = "btn_InformeLeon";
            this.btn_InformeLeon.Size = new System.Drawing.Size(84, 36);
            this.btn_InformeLeon.TabIndex = 1;
            this.btn_InformeLeon.Text = "Leones";
            this.btn_InformeLeon.UseVisualStyleBackColor = false;
            this.btn_InformeLeon.Click += new System.EventHandler(this.btn_InformeLeones_Click);
            // 
            // btn_InformeHipopotamo
            // 
            this.btn_InformeHipopotamo.BackColor = System.Drawing.Color.White;
            this.btn_InformeHipopotamo.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_InformeHipopotamo.Location = new System.Drawing.Point(102, 205);
            this.btn_InformeHipopotamo.Name = "btn_InformeHipopotamo";
            this.btn_InformeHipopotamo.Size = new System.Drawing.Size(84, 38);
            this.btn_InformeHipopotamo.TabIndex = 2;
            this.btn_InformeHipopotamo.Text = "Hipopotamos";
            this.btn_InformeHipopotamo.UseVisualStyleBackColor = false;
            this.btn_InformeHipopotamo.Click += new System.EventHandler(this.btn_InformeHipopotamos_Click);
            // 
            // btn_InformeDelfin
            // 
            this.btn_InformeDelfin.BackColor = System.Drawing.Color.White;
            this.btn_InformeDelfin.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_InformeDelfin.Location = new System.Drawing.Point(102, 162);
            this.btn_InformeDelfin.Name = "btn_InformeDelfin";
            this.btn_InformeDelfin.Size = new System.Drawing.Size(84, 36);
            this.btn_InformeDelfin.TabIndex = 3;
            this.btn_InformeDelfin.Text = "Delfines";
            this.btn_InformeDelfin.UseVisualStyleBackColor = false;
            this.btn_InformeDelfin.Click += new System.EventHandler(this.btn_InformeDelfines_Click);
            // 
            // btn_InformeElefante
            // 
            this.btn_InformeElefante.BackColor = System.Drawing.Color.White;
            this.btn_InformeElefante.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_InformeElefante.ForeColor = System.Drawing.Color.Black;
            this.btn_InformeElefante.Location = new System.Drawing.Point(12, 204);
            this.btn_InformeElefante.Name = "btn_InformeElefante";
            this.btn_InformeElefante.Size = new System.Drawing.Size(84, 38);
            this.btn_InformeElefante.TabIndex = 4;
            this.btn_InformeElefante.Text = "Elefantes";
            this.btn_InformeElefante.UseVisualStyleBackColor = false;
            this.btn_InformeElefante.Click += new System.EventHandler(this.btn_InformeElefantes_Click);
            // 
            // lbl_Informes
            // 
            this.lbl_Informes.BackColor = System.Drawing.Color.White;
            this.lbl_Informes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Informes.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Informes.Location = new System.Drawing.Point(12, 67);
            this.lbl_Informes.Name = "lbl_Informes";
            this.lbl_Informes.Size = new System.Drawing.Size(174, 32);
            this.lbl_Informes.TabIndex = 6;
            this.lbl_Informes.Text = "INFORMES";
            this.lbl_Informes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_InformeGrandes
            // 
            this.btn_InformeGrandes.BackColor = System.Drawing.Color.White;
            this.btn_InformeGrandes.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_InformeGrandes.Location = new System.Drawing.Point(12, 116);
            this.btn_InformeGrandes.Name = "btn_InformeGrandes";
            this.btn_InformeGrandes.Size = new System.Drawing.Size(84, 40);
            this.btn_InformeGrandes.TabIndex = 9;
            this.btn_InformeGrandes.Text = "Grandes";
            this.btn_InformeGrandes.UseVisualStyleBackColor = false;
            this.btn_InformeGrandes.Click += new System.EventHandler(this.btn_InformeGrandes_Click);
            // 
            // btn_InformeMedianos
            // 
            this.btn_InformeMedianos.BackColor = System.Drawing.Color.White;
            this.btn_InformeMedianos.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_InformeMedianos.Location = new System.Drawing.Point(102, 116);
            this.btn_InformeMedianos.Name = "btn_InformeMedianos";
            this.btn_InformeMedianos.Size = new System.Drawing.Size(84, 40);
            this.btn_InformeMedianos.TabIndex = 10;
            this.btn_InformeMedianos.Text = "Medianos";
            this.btn_InformeMedianos.UseVisualStyleBackColor = false;
            this.btn_InformeMedianos.Click += new System.EventHandler(this.btn_InformeMedianos_Click);
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.BackColor = System.Drawing.Color.Black;
            this.lbl_Hora.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hora.ForeColor = System.Drawing.Color.White;
            this.lbl_Hora.Location = new System.Drawing.Point(12, 428);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(142, 34);
            this.lbl_Hora.TabIndex = 11;
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.BackColor = System.Drawing.Color.Black;
            this.lbl_Fecha.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_Fecha.Location = new System.Drawing.Point(12, 375);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(194, 40);
            this.lbl_Fecha.TabIndex = 12;
            // 
            // btn_InformeArgentina
            // 
            this.btn_InformeArgentina.BackColor = System.Drawing.Color.White;
            this.btn_InformeArgentina.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_InformeArgentina.Location = new System.Drawing.Point(12, 248);
            this.btn_InformeArgentina.Name = "btn_InformeArgentina";
            this.btn_InformeArgentina.Size = new System.Drawing.Size(84, 33);
            this.btn_InformeArgentina.TabIndex = 13;
            this.btn_InformeArgentina.Text = "Argentina";
            this.btn_InformeArgentina.UseVisualStyleBackColor = false;
            this.btn_InformeArgentina.Click += new System.EventHandler(this.btn_InformeArgentina_Click);
            // 
            // btn_InformeUruguay
            // 
            this.btn_InformeUruguay.BackColor = System.Drawing.Color.White;
            this.btn_InformeUruguay.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_InformeUruguay.Location = new System.Drawing.Point(102, 249);
            this.btn_InformeUruguay.Name = "btn_InformeUruguay";
            this.btn_InformeUruguay.Size = new System.Drawing.Size(84, 32);
            this.btn_InformeUruguay.TabIndex = 14;
            this.btn_InformeUruguay.Text = "Uruguay";
            this.btn_InformeUruguay.UseVisualStyleBackColor = false;
            this.btn_InformeUruguay.Click += new System.EventHandler(this.btn_InformeUruguay_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 467);
            this.Controls.Add(this.btn_InformeUruguay);
            this.Controls.Add(this.btn_InformeArgentina);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.btn_InformeMedianos);
            this.Controls.Add(this.btn_InformeGrandes);
            this.Controls.Add(this.lbl_Informes);
            this.Controls.Add(this.btn_InformeElefante);
            this.Controls.Add(this.btn_InformeDelfin);
            this.Controls.Add(this.btn_InformeHipopotamo);
            this.Controls.Add(this.btn_InformeLeon);
            this.Controls.Add(this.btn_AgregarMamifero);
            this.Controls.Add(this.pictureBox1);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_AgregarMamifero;
        private System.Windows.Forms.Label lbl_Informes;
        private System.Windows.Forms.Button btn_InformeGrandes;
        private System.Windows.Forms.Button btn_InformeMedianos;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Button btn_InformeLeon;
        private System.Windows.Forms.Button btn_InformeHipopotamo;
        private System.Windows.Forms.Button btn_InformeDelfin;
        private System.Windows.Forms.Button btn_InformeElefante;
        private System.Windows.Forms.Button btn_InformeArgentina;
        private System.Windows.Forms.Button btn_InformeUruguay;
    }
}

