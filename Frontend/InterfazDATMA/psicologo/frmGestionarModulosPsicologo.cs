using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazDATMA.plantilla;

namespace InterfaceDATMA
{
    public partial class frmGestionarModulosPsicologo : Form
    {
        private frmPlantillaGestion plantillaGestion;

        public frmGestionarModulosPsicologo(frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            plantillaGestion = plantilla;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmConfigurarModuloPsicologo(this,plantillaGestion));
        }

       
    }
}
