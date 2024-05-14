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

namespace pryKaplanTP1
{
    public partial class frmJuego : Form
    {
        private System.Windows.Forms.Timer timerEnemigos = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer timerDisparo = new System.Windows.Forms.Timer();

        clsJugador objJugador = new clsJugador();
        clsEnemigo objEnemigo = new clsEnemigo();
        public bool escape = false;
        public bool explosion = false;
        Int32 puntaje = 0;

        public frmJuego()
        {
            InitializeComponent();

            pctNave.BackColor = Color.Transparent;
            timerEnemigos.Interval = 2500;
            timerEnemigos.Tick += timerEnemigos_Tick;
            timerEnemigos.Start();
            timerDisparo.Start();
            timerDisparo.Interval = 2;
            timerDisparo.Tick += TimerDisparo_Tick;

            colisionNave();
        }

        public void colisionNave()
        {
            System.Windows.Forms.Timer timerColision = new System.Windows.Forms.Timer();
            timerColision.Interval = 200;

            timerColision.Tick += (sender, arges) =>
            {
                foreach (var enemigo in objEnemigo.listaEnemigos.ToList())
                {
                    if (pctNave.Bounds.IntersectsWith(enemigo.Bounds))
                    {
                        objJugador.Vidas -= 1;
                        ExplosionEnemigo(enemigo.Location.X + 30, enemigo.Location.Y);
                        enemigo.Visible = false;
                        objEnemigo.listaEnemigos.Remove(enemigo);
                        enemigo.Dispose();

                        switch (objJugador.Vidas)
                        {
                            case 0:
                                pctVida3.Visible = false;
                                pctVida2.Visible = false;
                                pctVida1.Visible = false;
                                break;
                            case 1:
                                pctVida3.Visible = false;
                                pctVida2.Visible = false;
                                break;
                            case 2:
                                pctVida3.Visible = false;
                                break;
                        }

                        if (objJugador.Vidas <= 0)
                        {
                            ExplosionNave();
                            if (explosion == true)
                            {
                                Panel.BringToFront();
                                timerDisparo.Stop();
                                timerEnemigos.Stop();
                                objEnemigo.timerEnemigos.Stop();
                                objJugador.timerDisparo.Stop();
                                escape = true;
                                lblPausa.Text = "GAME OVER";
                                Panel.Visible = true;
                                btnReanudar.Enabled = false;
                                btnReanudar.Visible = false;
                                explosion = false;
                                
                            }
                        }

                    }
                }
            };
            timerColision.Start();
        }

        private void ExplosionNave()
        {
            pctNave.Image = pryKaplanTP1.Properties.Resources.explosionNave;
            System.Windows.Forms.Timer timerExplosionNave = new System.Windows.Forms.Timer();
            timerExplosionNave.Interval = 1000;
            timerExplosionNave.Tick += (sender, arges) =>
            {
                this.Controls.Remove(pctNave);
                pctNave.Dispose();

                timerExplosionNave.Stop();
            };
            timerExplosionNave.Start();
            explosion = true;
        }

        private void timerEnemigos_Tick(object sender, EventArgs e)
        {
            objEnemigo.Enemigo(this);
        }


        public void ExplosionEnemigo(Int32 x, Int32 y)
        {
            PictureBox pctExplosionEnemigo = new PictureBox();
            pctExplosionEnemigo.Image = pryKaplanTP1.Properties.Resources.explosion_enemigo_2_unscreen;
            pctExplosionEnemigo.Size = new Size(36, 43);
            pctExplosionEnemigo.BackColor = Color.Transparent;
            pctExplosionEnemigo.SizeMode = PictureBoxSizeMode.Zoom;
            pctExplosionEnemigo.Location = new Point(x, y);
            pctExplosionEnemigo.Visible = true;

            this.Controls.Add(pctExplosionEnemigo);
            pctExplosionEnemigo.BringToFront();

            System.Windows.Forms.Timer timerExplosion = new System.Windows.Forms.Timer();
            timerExplosion.Interval = 300;
            timerExplosion.Tick += (sender, arges) =>
            {
                this.Controls.Remove(pctExplosionEnemigo);
                pctExplosionEnemigo.Dispose();

                timerExplosion.Stop();
            };
            timerExplosion.Start();
        }

        private void TimerDisparo_Tick(object sender, EventArgs e)
        {
            foreach (var disparo in objJugador.listaDisparos.ToList())
            {
                if (disparo != null)
                {
                    disparo.Top -= 10;
                    // Verificar colisión con los enemigos
                    foreach (var enemigo in objEnemigo.listaEnemigos.ToList())
                    {
                        if (disparo.Bounds.IntersectsWith(enemigo.Bounds))
                        {
                            // Si hay colisión, ocultar el enemigo
                            enemigo.Visible = false;
                            disparo.Visible = false;
                            ExplosionEnemigo(enemigo.Location.X + 30, enemigo.Location.Y);
                            puntaje += 1;
                            //Vel += 500;
                            lblPuntaje.Text = "Puntaje: " + puntaje.ToString();

                            objEnemigo.listaEnemigos.Remove(enemigo);
                            objJugador.listaDisparos.Remove(disparo);
                        }
                    }
                }
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            frmJuego frmJuego = new frmJuego();
            this.Hide();
            frmJuego.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if (escape == false)
            {
                objJugador.Controles(pctNave, e, this);

            }

            if (e.KeyCode == Keys.Escape)
            {
                if (escape == false)
                {
                    Panel.Visible = true;
                    Panel.BringToFront();
                    timerDisparo.Stop();
                    timerEnemigos.Stop();
                    objEnemigo.timerEnemigos.Stop();
                    objJugador.timerDisparo.Stop();
                    escape = true;
                }
                else
                {
                    btnReanudar_Click(sender, e);
                }
            }
        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            Panel.Visible = false;
            timerDisparo.Start();
            timerEnemigos.Start();
            objEnemigo.timerEnemigos.Start();
            objJugador.timerDisparo.Start();
            escape = false;
            this.Focus();
        }
    }
}
