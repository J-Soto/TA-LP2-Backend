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
    public partial class frmModificarPreferencias : Form
    {
        private frmPlantillaGestion formPlantilla;
        public frmModificarTutor formAnterior;
        public frmModificarPreferencias(frmModificarTutor formModificarTutor, frmPlantillaGestion formPlantilla)
        {
            InitializeComponent();
            this.formPlantilla = formPlantilla;
            this.formAnterior = formModificarTutor;

            chblDias.CheckOnClick = true;
            chblDispositivos.CheckOnClick = true;
            chblInternet.CheckOnClick = true;
            chblTurno.CheckOnClick = true;
            chblRedes.CheckOnClick = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formAnterior);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formAnterior.formOperacionPersona);
        }
    }
}
