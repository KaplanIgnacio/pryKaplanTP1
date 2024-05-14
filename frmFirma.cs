using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryKaplanTP1
{
    public partial class frmFirma : Form
    {
        private Point previousPoint;
        private bool isDrawing = false;
        private List<Point> signaturePoints = new List<Point>();

        public frmFirma()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInicio v1 = new frmInicio();
            v1.Show();
            this.Hide();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, previousPoint, e.Location);
                }
                previousPoint = e.Location;

                // Almacena los puntos del trazo
                signaturePoints.Add(e.Location);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string folderPath = "FIRMAS";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fileName = DateTime.Now.ToString("yyyy.MM.dd.HH.mm") + ".png";
            string filePath = Path.Combine(folderPath, fileName);

            using (Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    // Dibujar la firma basada en los puntos almacenados
                    if (signaturePoints.Count > 1)
                    {
                        g.DrawLines(Pens.Black, signaturePoints.ToArray());
                    }
                }

                // Guardar el bitmap en el archivo
                bmp.Save(filePath);
            }

            MessageBox.Show("Firma guardada correctamente en: " + filePath);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            using (Graphics g = pictureBox1.CreateGraphics())
            {
                g.Clear(Color.White);
            }
        }
    }
}
