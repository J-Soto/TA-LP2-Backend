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

namespace InterfazDATMA
{
    public partial class frmInscripcionHecha : Form
    {
        public frmCursosDisponibles formAnterior;
        private frmPlantillaGestion plantillaGestion;
        public frmInscripcionHecha(frmCursosDisponibles formAnterior,frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            this.formAnterior = formAnterior;
            this.plantillaGestion = plantillaGestion;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIrLista_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(formAnterior);
        }

        private void btnIrCurso_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCurso(this, plantillaGestion));
        }
    }
}
