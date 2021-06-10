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
    public partial class frmInformacionCurso : Form
    {
        public frmCursosDisponibles formAnterior;
        private frmPlantillaGestion plantillaGestion;
        public frmInformacionCurso(frmCursosDisponibles formAnterior, frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            this.formAnterior = formAnterior;
            this.plantillaGestion = plantillaGestion;
        }



        private void btnVerMas_Click_1(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCurso(this, plantillaGestion));
        }

        private void frmInformacionCurso_Load(object sender, EventArgs e)
        {

        }
    }
}
