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
    public partial class frmOperacionesPersona : Form
    {
        private frmPlantillaGestion formPlantilla;
        private frmGestionarModuloAdmin formGestionarModulos;

        private TutorWS.TutorWSClient daoTutor;
        private PsicologoWS.PsicologoWSClient daoPsicologo;

        public frmOperacionesPersona(frmGestionarModuloAdmin formGestionarModulos, frmPlantillaGestion formPlantilla)
        {
            InitializeComponent();
            daoTutor = new TutorWS.TutorWSClient();
            daoPsicologo = new PsicologoWS.PsicologoWSClient();
            this.formPlantilla = formPlantilla;
            this.formGestionarModulos = formGestionarModulos;

            dgvTutores.AutoGenerateColumns = false;
            //dgvTutores.DataSource = new BindingList<TutorWS.tutor>(
            //    daoTutor.listarTutoresPorNombre("").ToList());
            dgvPsicologos.AutoGenerateColumns = false;
            //dgvPsicologos.DataSource = new BindingList<PsicologoWS.psicologo>(
            //    daoPsicologo.listarPsicologosPorNombre("").ToList());
        }

        private void btnInsertarTutor_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(new frmInsertarTutor(this, formPlantilla));
        }

        private void btnInsertarPsi_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(new frmInsertarPsicologo(this, formPlantilla));
        }

        private void btnModificarPsi_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(new frmModificarPsicologo(this, formPlantilla));
        }

        private void btnModificarTutor_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(new frmModificarTutor(this, formPlantilla));
        }

        private void txtBusqTutor_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtBusqTutor.Text=="Nombres y Apellidos")
                txtBusqTutor.Text = "";
        }

        private void txtBusqPsi_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBusqPsi.Text == "Nombres y Apellidos")
                txtBusqPsi.Text = "";
        }

        private void btnBuscarTutor_Click(object sender, EventArgs e)
        {/*
            dgvTutores.DataSource = new BindingList<TutorWS.tutor>(
                daoTutor.listarTutoresPorNombre(txtBusqTutor.Text).ToList());*/
        }

        private void btnBuscarPsi_Click(object sender, EventArgs e)
        {/*
            dgvPsicologos.DataSource = new BindingList<PsicologoWS.psicologo>(
                daoPsicologo.listarPsicologosPorNombre(txtBusqPsi.Text).ToList());*/
        }
    }
}
