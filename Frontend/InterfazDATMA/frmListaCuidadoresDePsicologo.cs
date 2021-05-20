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
    public partial class frmListaCuidadoresDePsicologo : Form
    {
        public frmListaCuidadoresDePsicologo()
        {
            InitializeComponent();
        }

        private void frmListaCuidadoresDePsicologo_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmConfigurarModuloPsicologo formconfigurarmodulopsicologo = new frmConfigurarModuloPsicologo();
            this.Hide();
            formconfigurarmodulopsicologo.Show();
        }

        private void btnRegresarCurso_Click(object sender, EventArgs e)
        {
            frmConfigurarModuloPsicologo formconfigurarmodulopsicologo = new frmConfigurarModuloPsicologo();
            this.Hide();
            formconfigurarmodulopsicologo.Show();
        }
    }
}
