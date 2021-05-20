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
    public partial class frmListaCursoInscritos : Form
    {
        public static frmListaCursoInscritos current;

        public frmListaCursoInscritos()
        {
            current = this;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnModulo1_Click(object sender, EventArgs e)
        {
            Form next = new frmDetalleCursoInscrito();
            Hide();
            next.Show();
        }

        private void frmListaCursoInscritos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
