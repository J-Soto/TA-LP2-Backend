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
    public partial class frmDetalleCursoInscrito : Form
    {
        public static Form current;

        public frmDetalleCursoInscrito()
        {
            current = this;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmDetalleCursoInscrito_Load(object sender, EventArgs e)
        {
           
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Hide();
            frmListaCursoInscritos.current.Show();
        }

        private void btnVideos_Click(object sender, EventArgs e)
        {
            Form next = new frmDetalleCursoInscritoMaterial();
            Hide();
            next.Show();
        }

        private void btnReuniones_Click(object sender, EventArgs e)
        {
            Form next = new frmDetalleCursoInscritoReunion();
            Hide();
            next.Show();
        }
    }
}
