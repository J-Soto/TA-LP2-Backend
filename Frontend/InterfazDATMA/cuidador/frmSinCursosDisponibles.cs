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
    public partial class frmSinCursosDisponibles : Form
    {
        private frmPlantillaGestion plantillaGestion;
        private frmListaCursoInscritos formAnterior;
        public frmSinCursosDisponibles(frmListaCursoInscritos formAnterior,frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            this.plantillaGestion = plantillaGestion;
            this.formAnterior = formAnterior;
        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            frmNotificacionActiva formNotificacion = new frmNotificacionActiva();
            if (formNotificacion.ShowDialog() == DialogResult.OK)
            {
                plantillaGestion.abrirFormulario(formAnterior);
            }
        }

    }
}
