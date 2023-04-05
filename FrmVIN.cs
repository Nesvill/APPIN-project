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
    public partial class FrmVIN : Form
    {
        string[] imagenes = { @"ROJO.jpg", @"escuela.jpg", @"burger.jpg", @"ocho.jpg", @"read.jpg", @"nariz.jpg", @"pina.jpg", @"shoe.jpg", @"avion.jpg", @"piedra.png" , @"sing.jpg" , @"paint.jpg", @"dance.jpg", @"play.jpg" };
        string[] respuestas = { "RED", "SCHOOL", "BURGER", "EIGHT", "READ", "NOSE", "PINAPPLE", "SHOE", "PLANE", "STONE","SING", "PAINT", "DANCE", "PLAY"};
        int[] opciones = new int[4];
        int[] radios = new int[4];
        
        
        int[] fotosRealizadas = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        int resultado = 0;
        int seleccion = 1;
        int cP = 0;
        int cRa = 0;                                   
        int cRb = 0;   
        int cRc = 0;
        int cRd = 0;
        

        public FrmVIN()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmVIN_Load(object sender, EventArgs e)
        {
           
        }
        private void crearOpciones(int numFoto)
        {

           
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            RadioButton[]opcionesRadio = {rdbA, rdbB,rdbC,rdbD };
            int[] respuestasPosibles = new int[4];
        
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
               
                txtResultados.AppendText("\r\n");

                int posicionCorrecta;
                posicionCorrecta = random.Next(0, 4);
                opcionesRadio[posicionCorrecta].Text = respuestas[fotosLanzadas];
             

                int[] otrasRespuestas = new int[4];
                otrasRespuestas[0] = posicionCorrecta;
                int otraPosicion;
                do
                {
                    
                    otraPosicion = random.Next(0, 4);
                    
                } while (otrasRespuestas.Contains(otraPosicion));
                int[] opcFalsa = { -1, -1, -1, -1 };
                opcFalsa[0] = fotosLanzadas;
                int opc2, cOpc2 = 0;
                    do
                    {
                    opc2 = random.Next(0, 14);

                    } while (opcFalsa.Contains(opc2));
                cOpc2++;
                opcionesRadio[otraPosicion].Text = respuestas[opc2];

                int sincronizacion;
                sincronizacion = random.Next(0, 4);
              
                

            }
            else
            {
                MessageBox.Show("preguntas agotadas", "fin de preguntas");
            }
           
           

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtResultados.Clear();
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;

        }
    }
}
