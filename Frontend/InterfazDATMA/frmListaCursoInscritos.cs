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

        private void btnModulo1_Click(object sender, EventArgs e)
        {
            Form next = new frmDetalleCursoInscrito();
            Hide();
            next.Show();
        }

        private void frmListaCursoInscritos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCursosDisponibles_Click(object sender, EventArgs e)
        {
            bool hayCursos = verificarCursosDisponibles();
            Form formularioMostrar;
            if (hayCursos) formularioMostrar = new frmCursosDisponibles();
            else formularioMostrar = new frmSinCursosDisponibles();

            formularioMostrar.Show();
            this.Hide();
        }

        private bool verificarCursosDisponibles()
        {
            Random rd = new Random();
            if (rd.Next(2) == 1) return true;
            else return false;
        }
    }
}
