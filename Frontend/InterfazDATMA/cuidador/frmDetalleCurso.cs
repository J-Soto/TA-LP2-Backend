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
    public partial class frmDetalleCurso : Form
    {
        public frmInscripcionHecha formAnterior1=null;
        public frmInformacionCurso formAnterior2=null;
        private frmPlantillaGestion plantillaGestion;
        public frmDetalleCurso(frmInscripcionHecha formAnterior,frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            this.formAnterior1 = formAnterior;
            this.plantillaGestion = plantillaGestion;
        }public frmDetalleCurso(frmInformacionCurso formAnterior,frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            this.formAnterior2 = formAnterior;
            this.plantillaGestion = plantillaGestion;
        }



        private void btnRegresar_Click(object sender, EventArgs e)
        {   if(formAnterior1!=null)
                plantillaGestion.abrirFormulario(formAnterior1.formAnterior);
            else plantillaGestion.abrirFormulario(formAnterior2.formAnterior);
        }

    }
}
