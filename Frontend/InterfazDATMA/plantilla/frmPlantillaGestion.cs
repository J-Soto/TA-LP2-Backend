using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceDATMA;
using InterfazDATMA.Administrador;

namespace InterfazDATMA.plantilla
{
    public partial class frmPlantillaGestion : Form
    {
        private Form formularioActivo = null;
        private Form formInicial;

        public frmPlantillaGestion(int tipoUser)
        {
            InitializeComponent();
            //Psicologo
            if(tipoUser == 1)
            {
                //formInicial = new frmGestionarModulosPsicologo(this);
                //abrirFormulario(formInicial);
            }
            //Administrador
            else if (tipoUser == 2)
            {
                //formInicial = new frmGestionarModuloAdmin(this);
                //abrirFormulario(formInicial);
            }
            //Tutor
            else
            {

            }



        }

        /*
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
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        */
        private void frmPlantillaGestion_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //abrirFormulario(formInicial);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
