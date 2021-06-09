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
    public partial class frmSeleccionarTemasDeCurso : Form
    {
        private frmInsertarCurso formInsertarCurso;
        private frmPlantillaGestion formPlantillaGest;

        public frmSeleccionarTemasDeCurso(frmInsertarCurso formInsertarCurso, frmPlantillaGestion formPlantillaGest)
        {
            this.formInsertarCurso = formInsertarCurso;
            this.formPlantillaGest = formPlantillaGest;
            InitializeComponent();
            dgvTemas.AutoGenerateColumns = false;
            dgvTemas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void lblTutoresUser_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGest.abrirFormulario(formInsertarCurso);
        }

        private void btnCrearTema_Click(object sender, EventArgs e)
        {
            frmCrearTemaDeCurso formCrearTemaCurso = new frmCrearTemaDeCurso();
            if(formCrearTemaCurso.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
