namespace pryKaplanTP1
{
    partial class frmJuego
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
            this.pctNave = new System.Windows.Forms.PictureBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnReanudar = new System.Windows.Forms.Button();
            this.lblPausa = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.pctVida1 = new System.Windows.Forms.PictureBox();
            this.pctVida3 = new System.Windows.Forms.PictureBox();
            this.pctVida2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctNave)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVida1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVida3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVida2)).BeginInit();
            this.SuspendLayout();
            // 
            // pctNave
            // 
            this.pctNave.BackColor = System.Drawing.Color.Transparent;
            this.pctNave.Image = global::pryKaplanTP1.Properties.Resources.NaveJugador;
            this.pctNave.Location = new System.Drawing.Point(301, 357);
            this.pctNave.Name = "pctNave";
            this.pctNave.Size = new System.Drawing.Size(116, 91);
            this.pctNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctNave.TabIndex = 0;
            this.pctNave.TabStop = false;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Black;
            this.Panel.Controls.Add(this.btnSalir);
            this.Panel.Controls.Add(this.btnReiniciar);
            this.Panel.Controls.Add(this.btnReanudar);
            this.Panel.Controls.Add(this.lblPausa);
            this.Panel.Location = new System.Drawing.Point(207, 105);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(285, 288);
            this.Panel.TabIndex = 1;
            this.Panel.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(80, 220);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 43);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Black;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(80, 154);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(125, 43);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnReanudar
            // 
            this.btnReanudar.BackColor = System.Drawing.Color.Black;
            this.btnReanudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReanudar.ForeColor = System.Drawing.Color.White;
            this.btnReanudar.Location = new System.Drawing.Point(80, 88);
            this.btnReanudar.Name = "btnReanudar";
            this.btnReanudar.Size = new System.Drawing.Size(125, 43);
            this.btnReanudar.TabIndex = 1;
            this.btnReanudar.Text = "Reanudar";
            this.btnReanudar.UseVisualStyleBackColor = false;
            this.btnReanudar.Click += new System.EventHandler(this.btnReanudar_Click);
            // 
            // lblPausa
            // 
            this.lblPausa.BackColor = System.Drawing.Color.Black;
            this.lblPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPausa.ForeColor = System.Drawing.Color.White;
            this.lblPausa.Location = new System.Drawing.Point(0, 22);
            this.lblPausa.Name = "lblPausa";
            this.lblPausa.Size = new System.Drawing.Size(285, 35);
            this.lblPausa.TabIndex = 0;
            this.lblPausa.Text = "Pausa";
            this.lblPausa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje.ForeColor = System.Drawing.Color.White;
            this.lblPuntaje.Location = new System.Drawing.Point(17, 13);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(46, 13);
            this.lblPuntaje.TabIndex = 2;
            this.lblPuntaje.Text = "Puntaje:";
            // 
            // pctVida1
            // 
            this.pctVida1.BackColor = System.Drawing.Color.Transparent;
            this.pctVida1.Image = global::pryKaplanTP1.Properties.Resources.VidaSinFondo;
            this.pctVida1.Location = new System.Drawing.Point(561, 13);
            this.pctVida1.Name = "pctVida1";
            this.pctVida1.Size = new System.Drawing.Size(38, 25);
            this.pctVida1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVida1.TabIndex = 3;
            this.pctVida1.TabStop = false;
            // 
            // pctVida3
            // 
            this.pctVida3.BackColor = System.Drawing.Color.Transparent;
            this.pctVida3.Image = global::pryKaplanTP1.Properties.Resources.VidaSinFondo;
            this.pctVida3.Location = new System.Drawing.Point(629, 13);
            this.pctVida3.Name = "pctVida3";
            this.pctVida3.Size = new System.Drawing.Size(38, 25);
            this.pctVida3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVida3.TabIndex = 4;
            this.pctVida3.TabStop = false;
            // 
            // pctVida2
            // 
            this.pctVida2.BackColor = System.Drawing.Color.Transparent;
            this.pctVida2.Image = global::pryKaplanTP1.Properties.Resources.VidaSinFondo;
            this.pctVida2.Location = new System.Drawing.Point(593, 13);
            this.pctVida2.Name = "pctVida2";
            this.pctVida2.Size = new System.Drawing.Size(38, 25);
            this.pctVida2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVida2.TabIndex = 5;
            this.pctVida2.TabStop = false;
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryKaplanTP1.Properties.Resources.fondo_pixel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 474);
            this.Controls.Add(this.pctVida2);
            this.Controls.Add(this.pctVida3);
            this.Controls.Add(this.pctVida1);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.pctNave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmJuego";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmJuego_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctNave)).EndInit();
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctVida1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVida3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVida2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctNave;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnReanudar;
        private System.Windows.Forms.Label lblPausa;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.PictureBox pctVida1;
        private System.Windows.Forms.PictureBox pctVida3;
        private System.Windows.Forms.PictureBox pctVida2;
    }
}