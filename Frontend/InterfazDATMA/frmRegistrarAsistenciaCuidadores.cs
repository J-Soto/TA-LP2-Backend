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
    public partial class frmRegistrarAsistenciaCuidadores : Form
    {
        public frmRegistrarAsistenciaCuidadores()
        {
            InitializeComponent();
        }

        private void frmRegistrarAsistenciaCuidadores_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmGestionarModulosPsicologo formGestionarModulosPsicologo = new frmGestionarModulosPsicologo();
            formGestionarModulosPsicologo.Show();
            this.Hide();
        }

        private void brnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModificarPrograma formModificarProgramaPsicologo = new frmModificarPrograma();
            formModificarProgramaPsicologo.Show();
        }
    }
}
