﻿using InterfazDATMA.plantilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDATMA.Administrador
{
    public partial class frmConfigurarModuloAdmin : Form
    {
        private frmPlantillaGestion plantillaGestion;
        public frmConfigurarModuloAdmin(frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            dgvTutores.AutoGenerateColumns = false;
            dgvPsicologos.AutoGenerateColumns = false;
            plantillaGestion = plantilla;
        }



        private void btnOpPersona_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmConfigurarModuloPsicologo(this, plantillaGestion));
        }
    }
}
