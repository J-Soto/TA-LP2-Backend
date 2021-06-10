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
    public partial class frmListaTotal : Form
    {
        private UsuarioWS.UsuarioWSClient daoUsuario;
        public frmListaTotal()
        {
            InitializeComponent();
            daoUsuario = new UsuarioWS.UsuarioWSClient();
            dgvLista.AutoGenerateColumns = false;
            dgvLista.DataSource = new BindingList<UsuarioWS.usuario>(daoUsuario.listarUsuarios().ToList());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<UsuarioWS.usuario> usuarios = new BindingList<UsuarioWS.usuario>(daoUsuario.listarUsuarios().ToList());
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (!usuarios[i].nombre.Contains(txtBuscar.Text))
                {
                    usuarios.RemoveAt(i);
                    i--;
                }
            }
            dgvLista.DataSource = usuarios;
        }
    }
}
