using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace pryKaplanTP1
{
    public class clsJugador
    {
        public System.Windows.Forms.Timer timerDisparo = new System.Windows.Forms.Timer();
        public List<PictureBox> listaDisparos = new List<PictureBox>(); // Lista para almacenar los disparos
        public clsEnemigo objEnemigo = new clsEnemigo();
        public Int32 Vidas = 3;

        public void Controles(PictureBox nave, KeyEventArgs Tecla, frmJuego frmJuego)
        {
            PictureBox pctNave = nave;

            switch (Tecla.KeyCode)
            {
                case Keys.Right:
                    if (pctNave.Location.X < 720)
                    {
                        pctNave.Left += 30;
                    }
                    break;

                case Keys.Left:
                    if (pctNave.Location.X > -3)
                    {
                        pctNave.Left -= 30;
                    }
                    break;
            }

            if (Tecla.KeyCode == Keys.Space)
            {
                Disparo(pctNave, frmJuego);
            }

        }

        public void Disparo(PictureBox nave, frmJuego frmJuego)
        {
            PictureBox pctNave = nave;

            PictureBox pctDisparo = new PictureBox(); // Crea una nueva instancia de PictureBox para el disparo
            pctDisparo.Image = pryKaplanTP1.Properties.Resources.Disparo;
            pctDisparo.Size = new Size(36, 43);
            pctDisparo.BackColor = Color.Transparent;
            pctDisparo.SizeMode = PictureBoxSizeMode.Zoom;
            pctDisparo.Location = new Point(pctNave.Location.X + 72, 385);
            pctDisparo.Visible = true;
            frmJuego.Controls.Add(pctDisparo);
            listaDisparos.Add(pctDisparo); // Agrega el disparo a la lista
            pctDisparo.BringToFront();
            timerDisparo.Start();
        }


    }
}
