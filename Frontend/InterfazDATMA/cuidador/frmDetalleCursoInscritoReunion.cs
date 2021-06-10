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
    public partial class frmDetalleCursoInscritoReunion : Form
    {
        public frmDetalleCursoInscrito formAnterior;
        private frmPlantillaGestion plantillaGestion;
        public frmDetalleCursoInscritoReunion(frmDetalleCursoInscrito formAnterior, frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            this.plantillaGestion = plantillaGestion;
            this.formAnterior = formAnterior;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(formAnterior);
        }
    }
}
