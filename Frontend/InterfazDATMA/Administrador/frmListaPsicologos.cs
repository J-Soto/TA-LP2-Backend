using InterfazDATMA.PsicologoWS;

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
    public partial class Header : Form
    {
        private PsicologoWS.PsicologoWSClient daoPsicologo;

        public Header()
        { 
            InitializeComponent();
            daoPsicologo = new PsicologoWS.PsicologoWSClient();
            dgvPsico.AutoGenerateColumns = false;
<<<<<<< HEAD
            dgvPsico.DataSource = new BindingList<PsicologoWS.PsicologoWSClient>(daoPsicologo.listarTodosPsicologos().ToList());
=======
            dgvPsico.DataSource = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarTodosPsicologos().ToList());
<<<<<<< HEAD
>>>>>>> c64abb6e965e89588749d66f87ed097c61da94a3
=======
            //HOLA HICE UN PUSH XD 

>>>>>>> 558d4b1d809f4a6241d697411543bf1874f871c1
        }

        private void btnBuscar_Click(object sender, EventArgs e)
{
            BindingList<PsicologoWS.psicologo> psicos = new BindingList<PsicologoWS.psicologo>(daoPsicologo.listarTodosPsicologos().ToList());
            for (int i = 0; i < psicos.Count; i++)
            {
                if (!psicos[i].nombre.Contains(txtBuscar.Text))
                {
                    psicos.RemoveAt(i);
                    i--;
                }
            }
            dgvPsico.DataSource = psicos;
        }

       
    }

}
