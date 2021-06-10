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
    public partial class frmConfigurarModuloPsicologo : Form
    {
        private frmPlantillaGestion formPlantilla;
        public frmGestionarModulosPsicologo formGestionarModulos;

        public frmConfigurarModuloPsicologo(frmGestionarModulosPsicologo formGestionarModulos, frmPlantillaGestion formPlantilla)
        {
            InitializeComponent();
            this.formPlantilla = formPlantilla;
            this.formGestionarModulos = formGestionarModulos;
        }

        private void btnModificarPrograma_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(new frmModificarPrograma(this, formPlantilla));
        }

        private void btnListaCursos_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formGestionarModulos);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
        }

        private void btnListaCuidadores_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(new frmListaCuidadoresDePsicologo(this, formPlantilla));
        }

    }
}
