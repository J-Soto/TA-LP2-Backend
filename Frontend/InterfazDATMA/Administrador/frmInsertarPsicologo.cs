using InterfazDATMA.plantilla;
using InterfazDATMA.validacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDATMA.Administrador
{
    public partial class frmInsertarPsicologo : Form
    {
        private frmPlantillaGestion formPlantilla;
        public frmOperacionesPersona formOperacionPersona;

        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private string rutaFoto = "";

        public frmInsertarPsicologo(frmOperacionesPersona formOperacionPersona, frmPlantillaGestion formPlantilla)
        {
            InitializeComponent();
            this.formPlantilla = formPlantilla;
            this.formOperacionPersona = formOperacionPersona;
            daoPsicologo = new PsicologoWS.PsicologoWSClient();


            //Inicializar el combo box para distrito
            DistritoWS.DistritoWSClient daoDistrito = new DistritoWS.DistritoWSClient();
            BindingList<DistritoWS.distrito> distritos = new BindingList<DistritoWS.distrito>(daoDistrito.lisrarTodosDistritos().ToList());
            cboDistrito.DataSource = distritos;
            cboDistrito.DisplayMember = "nombre";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formOperacionPersona);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PsicologoWS.psicologo psicologo = new PsicologoWS.psicologo();

            psicologo.nombre = txtNombre.Text.Trim();
            psicologo.apellidoPaterno = txtApellidoPat.Text.Trim();
            psicologo.fechaNacimiento = dtpFechaNacimiento.Value;
            psicologo.distrito = new PsicologoWS.distrito();
            DistritoWS.distrito distritoSelected = cboDistrito.SelectedItem as DistritoWS.distrito;
            psicologo.distrito = new PsicologoWS.distrito();
            psicologo.distrito.idDistrito = distritoSelected.idDistrito;
            psicologo.correo = txtCorreo.Text.Trim();

            psicologo.DNI = txtDni.Text.Trim();

            psicologo.telefono = txtTelf.Text.Trim();
            psicologo.celular = txtCelular.Text.Trim();
            if (rbtnHombre.Checked == true) psicologo.genero = 'M';
            else psicologo.genero = 'F';


            //Foto es opcional:
            if (rutaFoto.Equals("") != true)
            {
                FileStream fs = new FileStream(rutaFoto, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                psicologo.fotoPerfil = br.ReadBytes((int)fs.Length);
            }

            psicologo.password = txtPass.Text;

            //Validaciones:
            if (psicologo.DNI.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 digitos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (psicologo.password != txtConfirmarPass.Text)
            {
                MessageBox.Show("Las contraseñas deben coincidir", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (psicologo.correo.Contains("@") != true)
            {
                MessageBox.Show("Correo no valido", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    
                    int idPsicologo = daoPsicologo.insertarPsicologo(psicologo);
                    MessageBox.Show(idPsicologo.ToString());
                    if (idPsicologo != 0)
                    {
                        MessageBox.Show("Se ha registrado con exito", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        psicologo.idPersona = idPsicologo;
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception();
                }
            }

        }

        private void rbtnHombre_Click(object sender, EventArgs e)
        {
            rbtnMujer.Checked = false;
            rbtnHombre.Checked = true;
        }

        private void rbtnMujer_Click(object sender, EventArgs e)
        {
            rbtnHombre.Checked = false;
            rbtnMujer.Checked = true;
        }

        private void btnNuevoDistrito_Click(object sender, EventArgs e)
        {
            frmInsertarDistrito frmDistrito = new frmInsertarDistrito();
            if (frmDistrito.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if(ofdSubirFoto.ShowDialog() == DialogResult.OK)
                {
                    rutaFoto = ofdSubirFoto.FileName;
                    pbFoto.Image = Image.FromFile(rutaFoto);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Seleccionar una imagen valida", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
