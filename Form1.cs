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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVIN_Click(object sender, EventArgs e)
        {
            FrmVIN frmVIN = new FrmVIN();
            this.Hide();
            frmVIN.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("SEGURO QUE QUIERES SALIR??", "SALIENDO DEL PROGRAMA", MessageBoxButtons.YesNo);

            if (s == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPronun_Click(object sender, EventArgs e)
        {
            PRONUN pro = new PRONUN();
            this.Hide();
            pro.Show();

        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            FrmNosotros frmNosotros = new FrmNosotros();
            this.Hide();
            frmNosotros.Show();
        }

        private void btnInmat_Click(object sender, EventArgs e)
        {
            FrmINMAT frmINMAT = new FrmINMAT();
            this.Hide();
            frmINMAT.Show();
        }
    }
}
