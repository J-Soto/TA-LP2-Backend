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
    public partial class frmCursosDisponibles : Form
    {
        public frmCursosDisponibles()
        {
            InitializeComponent();
        }

        private void btnMasInformacion_Click(object sender, EventArgs e)
        {
            Form formularioMostrar = new frmInformacionCurso();
            formularioMostrar.Show();
            this.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form formularioMostrar = new frmMenuUsuario();
            formularioMostrar.Show();
            this.Hide();
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            Form formularioMostrar = new frmInscripcionHecha();
            formularioMostrar.Show();
            this.Hide();
        }
    }
}
