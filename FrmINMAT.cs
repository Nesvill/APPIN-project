using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmINMAT : Form
    {
        string numero, palbra;
        public FrmINMAT()
        {
            InitializeComponent();
        }


        private void mostrarNumero(int nC)
        {
            switch (nC)
            {
                case 1:
                    picNum.Image = Image.FromFile("once.jpg");
                    numero = " eleven ";
                    break;
                case 2:
                    picNum.Image = Image.FromFile("och.png");
                    numero = " eight ";
                    break;
                case 4:
                    picNum.Image = Image.FromFile("nueve.jpg");
                    numero = " nine";
                    break;
                case 5:
                    picNum.Image = Image.FromFile("cinco.jpg");
                    numero = " five";
                    break;
                case 6:
                    picNum.Image = Image.FromFile("tres.jpg");
                    numero = " three";
                    break;
                case 7:
                    picNum.Image = Image.FromFile("dos.jpg");
                    numero = " two ";
                    break;
                case 8:
                    picNum.Image = Image.FromFile("cuatro.jpg");
                    numero = " four ";
                    break;
                case 9:
                    picNum.Image = Image.FromFile("uno.jpg");
                    numero = " one";
                    break;
                case 10:
                    picNum.Image = Image.FromFile("seis.jpg");
                    numero = " six ";
                    break;
                case 11:
                    picNum.Image = Image.FromFile("siete.jpg");
                    numero = " seven ";
                    break;
                case 12:
                    picNum.Image = Image.FromFile("diez.jpg");
                    numero = " ten ";
                    break;
                case 13:
                    picNum.Image = Image.FromFile("doce.jpg");
                    numero = " twelve ";
                    break;
            }


        }

        private void mostrarLetra(int nM)
        {
            switch (nM)
            {
                case 1:
                    picLet.Image = Image.FromFile("guiño.jpg");
                    palbra = "excellent!:) ";
                    break;
                case 2:
                    picLet.Image = Image.FromFile("estrella.jpg");
                    palbra = "Good job! ";
                    break;
                case 3:
                    picLet.Image = Image.FromFile("crazy.jpg");
                    palbra = " excellent!:)";
                    break;
                case 4:
                    picLet.Image = Image.FromFile("smile.jpg");
                    palbra = "Good job!:) ";
                    break;
            }

        }
        private void lectura(string m, string c)
        {
            lblResul.Text = "the number" + m + " is " + c;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            {
                picNum = null;
                picLet = null;
                lblResul = null;
                btnNum.Focus();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void FrmINMAT_Load(object sender, EventArgs e)
        {
           
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            int numNum, numLet;
            Random rnd = new Random();
            numLet = rnd.Next(1, 5);
            numNum = rnd.Next(1, 14);
            mostrarLetra(numLet);
            mostrarNumero(numNum);
            lectura(numero, palbra);
        }
    }
}
