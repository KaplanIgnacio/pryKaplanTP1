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
using System.IO;

namespace pryKaplanTP1
{
    public partial class frmMenuJuego : Form
    {
        public frmMenuJuego()
        {
            InitializeComponent();

            SoundPlayer sonidoInicio = new SoundPlayer();
            sonidoInicio.Stream = pryKaplanTP1.Properties.Resources.Inicio_musica;
            sonidoInicio.Play();
        }

        private void btnGuardarJugador_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jugador Guardado");
        }

        private void frmMenuJuego_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnIrAlJuego_Click(object sender, EventArgs e)
        {
            frmJuego frmJuego = new frmJuego();
            this.Hide();
            frmJuego.Show();
        }
    }
}
