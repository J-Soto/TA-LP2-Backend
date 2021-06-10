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
    public partial class frmOperacionesCursos : Form
    {
        private frmPlantillaGestion formPlantillaGest;
        private frmGestionarModuloAdmin formGestionarModuloAdmin;
        private CursoWS.CursoWSClient daoCurso;
        private BindingList<CursoWS.curso> cursos;

        public frmOperacionesCursos(frmGestionarModuloAdmin formGestionarModuloAdmin, frmPlantillaGestion formPlantillaGest)
        {
            this.formGestionarModuloAdmin = formGestionarModuloAdmin;
            this.formPlantillaGest = formPlantillaGest;
            this.daoCurso = new CursoWS.CursoWSClient();

            InitializeComponent();
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FetchCursos();
            UpdateCursosTable();
        }

        private void UpdateCursosTable()
        {
            dgvCursos.Rows.Clear();
            foreach (var curso in cursos) {
                dgvCursos.Rows.Add(curso.descripcion, curso.fechaInicio, curso.fechaFin, curso.fechaInscripcion, curso.cantSemanas);
            }
        }

        private void FetchCursos()
        {
            try
            {
                cursos = new BindingList<CursoWS.curso>(daoCurso.listarCursos().ToList());
            } catch (ArgumentNullException ex)
            {
                cursos = new BindingList<CursoWS.curso>();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGest.abrirFormulario(formGestionarModuloAdmin);
        }

        private void btnInsertarCurso_Click(object sender, EventArgs e)
        {
            frmInsertarCurso formInsertarCurso = new frmInsertarCurso(this, formPlantillaGest);
            formPlantillaGest.abrirFormulario(formInsertarCurso);
        }

        private void frmOperacionesCursos_VisibleChanged(object sender, EventArgs e)
        {
            FetchCursos();
            UpdateCursosTable();
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            var index = dgvCursos.CurrentCell.RowIndex;
            daoCurso.eliminarCurso(cursos[index].idCurso);
            cursos.RemoveAt(index);
            UpdateCursosTable();
        }
    }
}
