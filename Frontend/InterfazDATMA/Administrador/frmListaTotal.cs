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
        }

        private static bool pertenece(UsuarioWS.persona persona, string key)
        {
            int res = string.Compare(persona.nombre, key);
            if (res > 0) return true;
            else return false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            UsuarioWS.persona temp = new UsuarioWS.persona();
            BindingList<UsuarioWS.usuario> usuarios = new BindingList<UsuarioWS.usuario>(daoUsuario.listarUsuarios().ToList());
            /*
            foreach (var item in usuarios)
            {   
                
            }
            BindingList<UsuarioWS.persona> personas;
            */
            dgvLista.DataSource = usuarios;
        }
    }
}
