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
    public partial class frmConfigurarModuloPsicologo : Form
    {
        public frmConfigurarModuloPsicologo()
        {
            InitializeComponent();
        }

        private void btnModificarPrograma_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModificarPrograma formModificarProgramaPsicologo = new frmModificarPrograma();
            formModificarProgramaPsicologo.Show();

        }

        private void btnListaCursos_Click(object sender, EventArgs e)
        {
            frmGestionarModulosPsicologo formGestionarModulosPsicologo = new frmGestionarModulosPsicologo();
            formGestionarModulosPsicologo.Show();
            this.Hide();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmGestionarModulosPsicologo formGestionarModulosPsicologo = new frmGestionarModulosPsicologo();
            formGestionarModulosPsicologo.Show();
            this.Hide();
        }

        private void btnListaCuidadores_Click(object sender, EventArgs e)
        {
            frmListaCuidadoresDePsicologo formListaCuidadoresDePsicologo = new frmListaCuidadoresDePsicologo();
            this.Hide();
            formListaCuidadoresDePsicologo.Show();
        }
    }
}
