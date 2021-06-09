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
    public partial class frmVerGruposCurso : Form
    {
        private frmInsertarCurso formInsertarCurso;
        private frmPlantillaGestion formPlantillaGest;

        public frmVerGruposCurso(frmInsertarCurso formInsertarCurso, frmPlantillaGestion formPlantillaGest)
        {
            this.formInsertarCurso = formInsertarCurso;
            this.formPlantillaGest = formPlantillaGest;
            InitializeComponent();

            dgvTutores.AutoGenerateColumns = false;
            dgvTutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGest.abrirFormulario(formInsertarCurso);
        }

        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            frmCrearGrupo formCrearGrupo = new frmCrearGrupo(this, formPlantillaGest);
            formPlantillaGest.abrirFormulario(formCrearGrupo);
        }
    }
}
