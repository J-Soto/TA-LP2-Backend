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
    public partial class frmDetalleCursoInscrito : Form
    {
        public frmListaCursoInscritos formAnterior;
        private frmPlantillaGestion plantillaGestion;

        public frmDetalleCursoInscrito(frmListaCursoInscritos formAnterior,frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            this.formAnterior = formAnterior;
            this.plantillaGestion = plantillaGestion;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(formAnterior);
        }

        private void btnVideos_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCursoInscritoMaterial(this, plantillaGestion));
        }

        private void btnReuniones_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCursoInscritoReunion(this, plantillaGestion));
        }
    }
}
