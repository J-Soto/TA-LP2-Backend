using InterfazDATMA.plantilla;
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
    public partial class frmInsertarDistrito : Form
    {
        private DistritoWS.DistritoWSClient daoDistrito;
        public frmInsertarDistrito()
        {
            InitializeComponent();
            daoDistrito = new DistritoWS.DistritoWSClient();

            dgvDistrito.AutoGenerateColumns = false;
            dgvDistrito.DataSource = new BindingList<DistritoWS.distrito>(
                daoDistrito.listarDistritos("").ToList());
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {/*
            BindingList<DistritoWS.distrito> distritos = new BindingList<DistritoWS.distrito>(
                daoDistrito.listarDistritos(txtBuscar.Text).ToList());
            dgvDistrito.DataSource = distritos;*/
            BindingList<DistritoWS.distrito> distritos = new BindingList<DistritoWS.distrito>(
                daoDistrito.lisrarTodosDistritos().ToList());
            for (int i = 0; i < distritos.Count; i++)
            {
                if (!distritos[i].nombre.Contains(txtBuscar.Text))
                {
                    distritos.RemoveAt(i);
                    i--;
                }
            }
            dgvDistrito.DataSource = distritos;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DistritoWS.distrito distrito = new DistritoWS.distrito();
            distrito.nombre = txtBuscar.Text;/*
            BindingList<DistritoWS.distrito> distritos = new BindingList<DistritoWS.distrito>(
                daoDistrito.listarDistritos(txtBuscar.Text).ToList());
            foreach (DistritoWS.distrito item in distritos)
            {
                if (distrito.nombre == item.nombre) return;
            }*/
            BindingList<DistritoWS.distrito> distritos = new BindingList<DistritoWS.distrito>(
                daoDistrito.lisrarTodosDistritos().ToList());
            for (int i = 0; i < distritos.Count; i++)
            {
                if (!distritos[i].nombre.Contains(distrito.nombre))
                {
                    distritos.RemoveAt(i);
                    i--;
                }
            }
            daoDistrito.insertarDistrito(distrito);
        }

        private void dgvDistrito_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDistrito.Columns[e.ColumnIndex].Name == "NombreDistrito")
            {
                DistritoWS.distrito distrito = (DistritoWS.distrito)dgvDistrito.Rows[dgvDistrito.SelectedCells[0].RowIndex].DataBoundItem;
                daoDistrito.modificarDistrito(distrito);
            }
        }

    }
}
