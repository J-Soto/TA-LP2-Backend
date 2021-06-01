using InterfazDATMA.plantilla;
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
        private frmConfigurarModuloPsicologo formConfigurarModuloPsicologo;
        private frmPlantillaGestion formPlantillaGestion;

        public frmModificarPrograma(frmConfigurarModuloPsicologo formConfigurarModuloPsicologo, frmPlantillaGestion formPlantillaGestion)
        {
            InitializeComponent();
            this.formConfigurarModuloPsicologo = formConfigurarModuloPsicologo;
            this.formPlantillaGestion = formPlantillaGestion;
        }

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            frmAgregarMaterialPsicologo formAgregarMaterialPsicologo = new frmAgregarMaterialPsicologo();
            formAgregarMaterialPsicologo.ShowDialog();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(formConfigurarModuloPsicologo);
        }

        private void btnAgregarReunion_Click(object sender, EventArgs e)
        {
            frmAgregarReunionPsicologo formAgregarReunionPsicologo = new frmAgregarReunionPsicologo();
            formAgregarReunionPsicologo.ShowDialog();

        }

        private void btnAsitencia_Click(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(new frmRegistrarAsistenciaCuidadores(this, formPlantillaGestion));
        }
    }
}
