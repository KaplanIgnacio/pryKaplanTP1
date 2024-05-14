namespace pryKaplanTP1
{
    partial class frmMenuJuego
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
            this.btnGuardarJugador = new System.Windows.Forms.Button();
            this.txtJugador = new System.Windows.Forms.TextBox();
            this.btnIrAlJuego = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardarJugador
            // 
            this.btnGuardarJugador.Location = new System.Drawing.Point(501, 263);
            this.btnGuardarJugador.Name = "btnGuardarJugador";
            this.btnGuardarJugador.Size = new System.Drawing.Size(109, 40);
            this.btnGuardarJugador.TabIndex = 0;
            this.btnGuardarJugador.Text = "Guardar Jugador";
            this.btnGuardarJugador.UseVisualStyleBackColor = true;
            this.btnGuardarJugador.Click += new System.EventHandler(this.btnGuardarJugador_Click);
            // 
            // txtJugador
            // 
            this.txtJugador.Location = new System.Drawing.Point(318, 274);
            this.txtJugador.Name = "txtJugador";
            this.txtJugador.Size = new System.Drawing.Size(161, 20);
            this.txtJugador.TabIndex = 1;
            // 
            // btnIrAlJuego
            // 
            this.btnIrAlJuego.BackColor = System.Drawing.Color.Thistle;
            this.btnIrAlJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrAlJuego.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIrAlJuego.Location = new System.Drawing.Point(290, 460);
            this.btnIrAlJuego.Name = "btnIrAlJuego";
            this.btnIrAlJuego.Size = new System.Drawing.Size(205, 46);
            this.btnIrAlJuego.TabIndex = 2;
            this.btnIrAlJuego.Text = "Jugar";
            this.btnIrAlJuego.UseVisualStyleBackColor = false;
            this.btnIrAlJuego.Click += new System.EventHandler(this.btnIrAlJuego_Click);
            // 
            // frmMenuJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryKaplanTP1.Properties.Resources.Fondo_Carga;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 533);
            this.Controls.Add(this.btnIrAlJuego);
            this.Controls.Add(this.txtJugador);
            this.Controls.Add(this.btnGuardarJugador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuJuego";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenuJuego_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarJugador;
        private System.Windows.Forms.TextBox txtJugador;
        private System.Windows.Forms.Button btnIrAlJuego;
    }
}