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

namespace InterfazDATMA.Administrador
{
    public partial class frmCrearGrupo : Form
    {
        private frmVerGruposCurso formVerGruposCurso;
        private frmPlantillaGestion formPlantillaGest;

        public frmCrearGrupo(frmVerGruposCurso formVerGruposCurso, frmPlantillaGestion formPlantillaGest)
        {
            this.formVerGruposCurso = formVerGruposCurso;
            this.formPlantillaGest = formPlantillaGest;
            InitializeComponent();
            dgvPsicologos.AutoGenerateColumns = false;
            dgvPsicologos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvTutores.AutoGenerateColumns = false;
            dgvTutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGest.abrirFormulario(formVerGruposCurso);
        }

        private void btnAgregarPsico_Click(object sender, EventArgs e)
        {
            frmBuscarPsicologoGrupo formBuscarPsicologoGrupo = new frmBuscarPsicologoGrupo();
            if (formBuscarPsicologoGrupo.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
