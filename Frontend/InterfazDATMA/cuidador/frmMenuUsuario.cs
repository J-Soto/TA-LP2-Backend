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
    public partial class frmMenuUsuario : Form
    {
        private ImageList walkthrough = new ImageList();
        //private frmPlantillaGestion plantillaGestion;
        private frmPlantillaV2 plantillaGestion;
        public frmMenuUsuario(frmPlantillaV2 plantilla)
        {
            InitializeComponent();
            plantillaGestion = plantilla;
        }

        private void ayudaToolStripButton_Click(object sender, EventArgs e)
        {
            Form formularioMostrar = new frmWalkthrough();
            formularioMostrar.Show();
            this.Hide();
        }


        private bool verificarCursosDisponibles()
        {
            Random rd = new Random();
            if (rd.Next(2) == 1) return true;
            else return false;
        }

        private void btnCursosDisponibles_Click_1(object sender, EventArgs e)
        {
            bool hayCursos = verificarCursosDisponibles();
            Form formularioMostrar;
            if (hayCursos) formularioMostrar = new frmCursosDisponibles();
            else formularioMostrar = new frmSinCursosDisponibles();

            formularioMostrar.Show();
            this.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }
    }
}
