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
    public partial class frmInscripcionHecha : Form
    {
        public frmInscripcionHecha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIrLista_Click(object sender, EventArgs e)
        {
            Form formularioMostrar = new frmMenuUsuario();
            formularioMostrar.Show();
            this.Hide();
        }

        private void btnIrCurso_Click(object sender, EventArgs e)
        {

        }
    }
}
