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
    public partial class frmInformacionCurso : Form
    {
        public frmInformacionCurso()
        {
            InitializeComponent();
        }



        private void btnVerMas_Click_1(object sender, EventArgs e)
        {
            Form formularioMostrar = new frmDetalleCurso();
            formularioMostrar.Show();
            this.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form formularioMostrar = new frmMenuUsuario();
            formularioMostrar.Show();
            this.Hide();
        }

        private void frmInformacionCurso_Load(object sender, EventArgs e)
        {

        }
    }
}
