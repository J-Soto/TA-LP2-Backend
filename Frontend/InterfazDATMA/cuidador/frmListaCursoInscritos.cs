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
    public partial class frmListaCursoInscritos : Form
    {
        private frmWalkthrough formAnterior;
        private frmPlantillaGestion plantillaGestion;

        public frmListaCursoInscritos(frmWalkthrough formAnterior,frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            this.plantillaGestion = plantillaGestion;
            this.formAnterior = formAnterior;
        }

        private void btnModulo1_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCursoInscrito(this, plantillaGestion));
        }

        private void frmListaCursoInscritos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCursosDisponibles_Click(object sender, EventArgs e)
        {
            bool hayCursos = verificarCursosDisponibles();
            if (hayCursos) plantillaGestion.abrirFormulario(new frmCursosDisponibles(this, plantillaGestion));
            else plantillaGestion.abrirFormulario(new frmSinCursosDisponibles(this, plantillaGestion));
        }

        private bool verificarCursosDisponibles()
        {
            Random rd = new Random();
            if (rd.Next(2) == 1) return true;
            else return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCursoInscrito(this, plantillaGestion));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCursoInscrito(this, plantillaGestion));
        }
    }
}
