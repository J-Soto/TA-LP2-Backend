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
    public partial class frmInsertarCurso : Form
    {
        private frmPlantillaGestion formPlantillaGest;
        private frmOperacionesCursos formOperacionesCursos;

        public frmInsertarCurso(frmOperacionesCursos formOperacionesCursos, frmPlantillaGestion formPlantillaGest)
        {
            this.formPlantillaGest = formPlantillaGest;
            this.formOperacionesCursos = formOperacionesCursos;

            InitializeComponent();
            dgvReq.AutoGenerateColumns = false;
            dgvReq.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnSelaccionarTemas_Click(object sender, EventArgs e)
        {
            frmSeleccionarTemasDeCurso formSeleccionarTemaCurso = new frmSeleccionarTemasDeCurso(this, formPlantillaGest);
            formPlantillaGest.abrirFormulario(formSeleccionarTemaCurso);
        }

        private void btnVerGrupos_Click(object sender, EventArgs e)
        {
            frmVerGruposCurso formVerGruposCurso = new frmVerGruposCurso(this, formPlantillaGest);
            formPlantillaGest.abrirFormulario(formVerGruposCurso);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGest.abrirFormulario(formOperacionesCursos);
        }
    }
}
