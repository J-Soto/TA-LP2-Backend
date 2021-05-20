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
    public partial class frmDetalleCurso : Form
    {
        public frmDetalleCurso()
        {
            InitializeComponent();
        }



        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form formularioMostrar = new frmInformacionCurso();
            this.Hide();
            formularioMostrar.Show();
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form formularioMostrar = new frmMenuUsuario();
            formularioMostrar.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
