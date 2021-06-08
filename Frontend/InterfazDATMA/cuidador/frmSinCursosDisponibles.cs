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
    public partial class frmSinCursosDisponibles : Form
    {
        public frmSinCursosDisponibles()
        {
            InitializeComponent();
        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            Form formularioMostrar = new frmNotificacionActiva();
            formularioMostrar.Show();
            this.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //Form formularioMostrar = new frmMenuUsuario();
            //formularioMostrar.Show();
            this.Hide();
        }
    }
}
