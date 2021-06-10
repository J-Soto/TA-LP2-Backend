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
    public partial class frmDetalleCursoInscritoMaterial : Form
    {
        public frmDetalleCursoInscrito formAnterior;
        private frmPlantillaGestion plantillaGestion;
        public frmDetalleCursoInscritoMaterial(frmDetalleCursoInscrito formAnterior,frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            this.formAnterior = formAnterior;
            this.plantillaGestion = plantillaGestion;
        }

        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=QHRuTYtSbJQ");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(formAnterior);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
    }
}
