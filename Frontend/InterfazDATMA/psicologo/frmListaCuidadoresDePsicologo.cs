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
    public partial class frmListaCuidadoresDePsicologo : Form
    {
        private frmConfigurarModuloPsicologo formConfigurarModulo;
        private frmPlantillaGestion formPlantillaGestion;

        public frmListaCuidadoresDePsicologo(frmConfigurarModuloPsicologo formConfigurarModulo, frmPlantillaGestion formPlantillaGestion)
        {
            InitializeComponent();
            this.formConfigurarModulo = formConfigurarModulo;
            this.formPlantillaGestion = formPlantillaGestion;
        }

        private void frmListaCuidadoresDePsicologo_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
          
        }

        private void btnRegresarCurso_Click(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(formConfigurarModulo);
        }
    }
}
