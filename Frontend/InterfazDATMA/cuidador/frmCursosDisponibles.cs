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
    public partial class frmCursosDisponibles : Form
    {
        public frmListaCursoInscritos formAnterior;
        private frmPlantillaGestion plantilla;
        public frmCursosDisponibles(frmListaCursoInscritos formAnterior,frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            this.formAnterior = formAnterior;
            this.plantilla = plantilla;
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            plantilla.abrirFormulario(new frmInscripcionHecha(this, plantilla));
        }

        private void btnMasInfo_Click(object sender, EventArgs e)
        {
            plantilla.abrirFormulario(new frmInformacionCurso(this, plantilla));
        }
    }
}
