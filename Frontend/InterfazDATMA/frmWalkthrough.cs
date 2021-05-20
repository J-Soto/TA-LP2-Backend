using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceDATMA
{
    public partial class frmWalkthrough : Form
    {
        private int estado = 1;
        public frmWalkthrough()
        {
            InitializeComponent();
            //cambiarEstado(estado);
        }
        /*
        private void cambiarEstado(int estado)
        {
            if (estado == 1)
            {
                btnAnt.Enabled = false;
                pictureboxWalk.Image = ;
            }
                
            else if (estado == 2)
            {
                btnAnt.Enabled = true;
                btnNext.Enabled = true;
                pictureboxWalk.Image = Properties.Resources._2;
            }
            else
            {
                btnNext.Enabled = false;
                pictureboxWalk.Image = Properties.Resources._3;
            }
        }
        */

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            Form formularioMostrar = new frmMenuUsuario();
            formularioMostrar.Show();
            this.Hide();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            estado += 1;
           // cambiarEstado(estado);
        }

        private void btnAnt_Click_1(object sender, EventArgs e)
        {
            estado -= 1;
            //cambiarEstado(estado);
        }
    }
}
