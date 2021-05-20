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
    public partial class frmGestionarModulosPsicologo : Form
    {
        public frmGestionarModulosPsicologo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConfigurarModuloPsicologo formconfigurarmodulopsicologo = new frmConfigurarModuloPsicologo();
            this.Hide();
            formconfigurarmodulopsicologo.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }
    }
}
