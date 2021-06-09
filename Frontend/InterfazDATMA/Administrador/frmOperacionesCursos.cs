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
        

        public frmOperacionesCursos(frmGestionarModuloAdmin formGestionarModuloAdmin, frmPlantillaGestion formPlantillaGest)
        {
            this.formGestionarModuloAdmin = formGestionarModuloAdmin;
            this.formPlantillaGest = formPlantillaGest;

            InitializeComponent();
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
    }
}
