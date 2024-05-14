using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryKaplanTP1
{
    public class clsEnemigo
    {
        public System.Windows.Forms.Timer timerEnemigos = new System.Windows.Forms.Timer();
        public List<PictureBox> listaEnemigos = new List<PictureBox>(); // Lista para almacenar los enemigos


        public clsEnemigo()
        {
            timerEnemigos.Interval = 15;
            timerEnemigos.Tick += timerEnemigos_Tick;
        }

        private void timerEnemigos_Tick(object sender, EventArgs e)
        {
            foreach (var pctEnemigo in listaEnemigos)
            {

                if (pctEnemigo != null)
                {
                    pctEnemigo.Top += 4;

                }
            }
        }

        public void Enemigo(frmJuego frmJuego)
        {
            PictureBox pctEnemigo = new PictureBox();
            Random random = new Random();
            int rndX = random.Next(0, 820);

            pctEnemigo.Image = pryKaplanTP1.Properties.Resources.NaveEnemiga;
            pctEnemigo.SizeMode = PictureBoxSizeMode.Zoom;
            pctEnemigo.BackColor = Color.Transparent;
            pctEnemigo.Location = new Point(rndX, 0);
            pctEnemigo.Visible = true;
            frmJuego.Controls.Add(pctEnemigo);
            listaEnemigos.Add(pctEnemigo);
            pctEnemigo.BringToFront();

            timerEnemigos.Start();

        }
    }
}
