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
    public partial class frmInsertarTutor : Form
    {
        private frmPlantillaGestion formPlantilla;
        public frmOperacionesPersona formOperacionPersona;

        private TutorWS.TutorWSClient daoTutor;
        public TutorWS.tutor tutor;

        public frmInsertarTutor(frmOperacionesPersona formOperacionPersona, frmPlantillaGestion formPlantilla)
        {
            InitializeComponent();
            this.formPlantilla = formPlantilla;
            this.formOperacionPersona = formOperacionPersona;
            daoTutor = new TutorWS.TutorWSClient();
            tutor = new TutorWS.tutor();
        }


        private void rbtnMujer_Click(object sender, EventArgs e)
        {
            rbtnHombre.Checked = false;
            rbtnMujer.Checked = true;
        }

        private void rbtnHombre_Click(object sender, EventArgs e)
        {
            rbtnMujer.Checked = false;
            rbtnHombre.Checked = true;
        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(new frmInsertarPreferencias(this, formPlantilla));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formOperacionPersona);
        }

        private void btnNuevoDistrito_Click(object sender, EventArgs e)
        {
            frmInsertarDistrito frmDistrito = new frmInsertarDistrito();
            if (frmDistrito.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void lblGenero_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbtnHombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnMujer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblApMat_Click(object sender, EventArgs e)
        {

        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void lblDni_Click(object sender, EventArgs e)
        {

        }

        private void lblDistrito_Click(object sender, EventArgs e)
        {

        }

        private void lblCelular_Click(object sender, EventArgs e)
        {

        }

        private void lblApPat_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblTutores_Click(object sender, EventArgs e)
        {

        }
    }
}
