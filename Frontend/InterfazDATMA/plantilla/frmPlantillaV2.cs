using InterfaceDATMA;
using InterfazDATMA.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDATMA.plantilla
{
    public partial class frmPlantillaV2 : Form
    {
        private Form formularioActivo = null;
        private Form formInicial;
        public frmPlantillaV2(int tipoUser)
        {
            InitializeComponent();
            
            //Psicologo
            if (tipoUser == 1)
            {
                //formInicial = new frmGestionarModulosPsicologo(this);
                abrirFormulario(formInicial);
            }
            //Administrador
            else if (tipoUser == 2)
            {
                //formInicial = new frmGestionarModuloAdmin(this);
                abrirFormulario(formInicial);
            }
            //Tutor
            else
            {
                formInicial = new frmMenuUsuario(this);
                abrirFormulario(formInicial);
            }
        }
        public void abrirFormulario(Form formularioAbrir)
        {
            if (formularioActivo != null) formularioActivo.Hide();
            formularioActivo = formularioAbrir;
            pnlContenedor.Controls.Clear();
            formularioAbrir.TopLevel = false;
            formularioAbrir.FormBorderStyle = FormBorderStyle.None;
            formularioAbrir.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formularioAbrir);

            try
            {
                formularioAbrir.Show();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void home_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calendar_Click(object sender, EventArgs e)
        {

        }

        private void Ayuda_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {

        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void ImagenPerfil_Click(object sender, EventArgs e)
        {

        }

        private void ImagenDATMA_Click(object sender, EventArgs e)
        {

        }
    }
}
