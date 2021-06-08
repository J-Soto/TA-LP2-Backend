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
    public partial class frmGestionarModuloAdmin : Form
    {
        private frmPlantillaGestion plantillaGestion;
        public frmGestionarModuloAdmin(frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            dgvTutores.AutoGenerateColumns = false;
            dgvTutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPsicologos.AutoGenerateColumns = false;
            dgvPsicologos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            plantillaGestion = plantilla;
        }

        private void btnOpPersona_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmOperacionesPersona(this, plantillaGestion));
        }
    }
}
