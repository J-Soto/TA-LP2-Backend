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
using InterfazDATMA;
using System.ServiceModel;


namespace InterfazDATMA
{
    public partial class frmLogin : Form
    {
        private string _user = null;
        private string _password = null;
        private Form formularioActivo = null;

        //private UsuarioWSClient daoUsuario;
        private UsuarioWS.UsuarioWSClient daoUsuario;
        public frmLogin()
        {
            InitializeComponent();
            

           daoUsuario = new UsuarioWS.UsuarioWSClient();
        }

        private void clickUsuario(object sender, MouseEventArgs e)
        {
            if(txtUsuario.Text=="Usuario")
                txtUsuario.Text = "";
        }

        private void ClickContraseña(object sender, MouseEventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
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
          
            BindingList<UsuarioWS.usuario> usuarios = new BindingList<UsuarioWS.usuario>(
                daoUsuario.listarUsuarios().ToList());
            
            foreach (UsuarioWS.usuario item in usuarios)
            {
                if (item.user.Contains(user) && item.password.Contains(password))
                    return item.tipo;
            }
            return -1;
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            int tipo = verificarLogin(txtUsuario.Text, txtContraseña.Text);
            if (tipo >= 0)
            {
                abrirFormulario(new frmPlantillaGestion(tipo));
            }
            else MessageBox.Show("Datos incorrectos","Mensaje de Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //abrirFormulario(new frmWalkthrough());
            //0->cuidador
            //1->psicologo
            //2->admin
            
        }
    }
}
