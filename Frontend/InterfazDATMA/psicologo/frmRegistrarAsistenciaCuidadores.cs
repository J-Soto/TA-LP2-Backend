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
    public partial class frmRegistrarAsistenciaCuidadores : Form
    {
        private frmModificarPrograma formModificarPrograma;
        private frmPlantillaGestion formPlantillaGestion;

        public frmRegistrarAsistenciaCuidadores(frmModificarPrograma formModificarPrograma, frmPlantillaGestion formPlantillaGestion)
        {
            InitializeComponent();
            this.formModificarPrograma = formModificarPrograma;
            this.formPlantillaGestion = formPlantillaGestion;
        }

        private void frmRegistrarAsistenciaCuidadores_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
           
        }

        private void brnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(formModificarPrograma);
        }
    }
}
