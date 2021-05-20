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
    public partial class frmLogin : Form
    {
        private string _user = null;
        private string _password = null;
        private Form formularioActivo = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void clickUsuario(object sender, MouseEventArgs e)
        {
            txtUsuario.Text = "";
        }

        private void ClickContraseña(object sender, MouseEventArgs e)
        {
            txtContraseña.Text = "";
        }

        public void abrirFormulario(Form formularioMostrar)
        {
            //formularioActivo.Close();
            formularioActivo = formularioMostrar;/*
            formularioMostrar.TopLevel = false;
            formularioMostrar.FormBorderStyle = FormBorderStyle.None;
            formularioMostrar.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioMostrar);
            panelContenedor.Tag = formularioMostrar;*/
            formularioMostrar.Show();
            this.Hide();
            if (checkBoxRecordarme.Checked)
            {
                _user = txtUsuario.Text;
                _password = txtContraseña.Text;
            }
        }

        private int verificarLogin(string user,string password)
        {
            return 1;
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            if (verificarLogin(txtUsuario.Text, txtContraseña.Text) > 0)
                abrirFormulario(new frmWalkthrough());
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
