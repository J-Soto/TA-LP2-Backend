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
    public partial class frmModificarPrograma : Form
    {
        public frmModificarPrograma()
        {
            InitializeComponent();
        }

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            frmAgregarMaterialPsicologo formAgregarMaterialPsicologo = new frmAgregarMaterialPsicologo();
            formAgregarMaterialPsicologo.ShowDialog();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmGestionarModulosPsicologo formGestionarModulosPsicologo = new frmGestionarModulosPsicologo();
            formGestionarModulosPsicologo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConfigurarModuloPsicologo formconfigurarmodulopsicologo = new frmConfigurarModuloPsicologo();
            this.Hide();
            formconfigurarmodulopsicologo.Show();
        }

        private void btnAgregarReunion_Click(object sender, EventArgs e)
        {
            frmAgregarReunionPsicologo formAgregarReunionPsicologo = new frmAgregarReunionPsicologo();
            formAgregarReunionPsicologo.ShowDialog();

        }

        private void btnAsitencia_Click(object sender, EventArgs e)
        {
            frmRegistrarAsistenciaCuidadores formRegistrarAsistenciaCuidadores = new frmRegistrarAsistenciaCuidadores();
            this.Hide();
            formRegistrarAsistenciaCuidadores.Show();
        }
    }
}
