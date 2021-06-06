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
    public partial class frmInsertarPreferencias : Form
    {
        private frmPlantillaGestion formPlantilla;
        private frmInsertarTutor formAnterior;
        public frmInsertarPreferencias(frmInsertarTutor formAnterior, frmPlantillaGestion formPlantilla)
        {
            InitializeComponent();
            this.formPlantilla = formPlantilla;
            this.formAnterior = formAnterior;

            chblDias.CheckOnClick = true;
            chblDispositivos.CheckOnClick = true;
            chblInternet.CheckOnClick = true;
            chblTurno.CheckOnClick = true;
            chblRedes.CheckOnClick = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formAnterior.formOperacionPersona);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formAnterior);
        }
    }
}
