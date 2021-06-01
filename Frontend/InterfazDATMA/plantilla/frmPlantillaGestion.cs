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

namespace InterfazDATMA.plantilla
{
    public partial class frmPlantillaGestion : Form
    {
        private Form formularioActivo = null;
        private Form formInicial;

        public frmPlantillaGestion(int tipoUser)
        {
            InitializeComponent();
            if(tipoUser == 1)
            {
                formInicial = new frmGestionarModulosPsicologo(this);
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
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void frmPlantillaGestion_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormulario(formInicial);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
