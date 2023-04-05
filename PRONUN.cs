using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class PRONUN : Form
    {
        string[] imagenes = { @"bike.png", @"book.png", @"jouse.png", @"bed.png", @"videp.png", @"shirt.png" };
        int cP = 0;
        int[] fotosRealizadas = { -1, -1, -1, -1, -1, -1 };
        SoundPlayer reproductoWav;
        public PRONUN()
        {
            InitializeComponent();
            reproductoWav = new SoundPlayer();
        }

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int grabar(string comando, string stringRetono, int longitud, int hwndCallback);
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            grabar("open new Type waveaudio Alias recsound", "", 0, 0);
            grabar("record recsound", "", 0, 0);

            btnGrabar.Image = Properties.Resources.Recordoff;
            micro.Image = Properties.Resources.Micro;
            btnParar.Image = Properties.Resources.Stop;
            btnReproducir.Image = Properties.Resources.playoff;
            UrlRpr.Text = "";
            reproductoWav.Stop();

        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            micro.Image = Properties.Resources.MicroOff;
            SaveFileDialog cajaDeDialogoGuardar = new SaveFileDialog();
            cajaDeDialogoGuardar.AddExtension = true;
            cajaDeDialogoGuardar.FileName = "Audio.wav";
            cajaDeDialogoGuardar.Filter = "sonido(*.wav)|*.wav";
            cajaDeDialogoGuardar.ShowDialog();
            if (!string.IsNullOrEmpty(cajaDeDialogoGuardar.FileName)) ;
            {
                UrlRpr.Text = cajaDeDialogoGuardar.FileName;
                btnParar.Image = Properties.Resources.Stopoff;
                btnGrabar.Image = Properties.Resources.Record;
                btnReproducir.Image = Properties.Resources.play;

                grabar("save recsound " + cajaDeDialogoGuardar.FileName, "", 0, 0);
                grabar("close recsound", "", 0, 0);
                MessageBox.Show("Archivo Guardado en: " + cajaDeDialogoGuardar.FileName);

            }

        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            reproductoWav.SoundLocation = UrlRpr.Text;
            reproductoWav.Play();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int fotosLanzadas;

            if (cP < (imagenes.Length) - 1)
            {


                do
                {
                    fotosLanzadas = random.Next(0, imagenes.Length);
                    txtResultados.AppendText(fotosLanzadas + " - ");
                } while (fotosRealizadas.Contains(fotosLanzadas));
                cP++;
                picPregun.Image = Image.FromFile(imagenes[fotosLanzadas]);
                fotosRealizadas[cP] = fotosLanzadas;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
