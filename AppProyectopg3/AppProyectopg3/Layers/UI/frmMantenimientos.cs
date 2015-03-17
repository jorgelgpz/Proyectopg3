using InterfaceWebCam;
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
using UTN.Winform.AppProyectopg3.Layers.Entities;
using UTN.Winform.AppProyectopg3.Layers.Entities.DTO;
using UTN.Winform.AppProyectopg3.Layers.Entities.Factories;
using UTN.Winform.AppProyectopg3.Layers.Singleton;
using UTN.Winform.AppProyectopg3.Layers.Singleton.GestorMantenimientos;
using UTN.Winform.AppProyectopg3.Layers.Util;


namespace UTN.Winform.AppProyectopg3.Layers.UI
{
    public partial class frmMantenimientos : Form
    {

        private bool ValidacionesOK = false;
        private byte[] cadenaBytes;


        public frmMantenimientos()
        {
            InitializeComponent();
        }

        private void frmMantenimientos_Load(object sender, EventArgs e)
        {
            this.CargarDGV();
    
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;

        }

        private void tbpNuevoUsuario_Click(object sender, EventArgs e)
        {
            this.txtUser.Focus();
        }
      


        #region pobla el dgv con los usuarios
        private void CargarDGV()
        {
            dgvUsuarios.RowTemplate.Height = 100;
            dgvUsuarios.DataSource = GestorMantenimientos.GetInstacia().GetUsuarios();

        }
        
        #endregion

        #region nuevo usuario
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.ValidarCampos();

            if (ValidacionesOK && (this.txtPass.Text.Equals(this.txtPassV.Text)))
            {


                Usuario oUsuario = Usuario.GetInstance();

                if (rbAdministrador.Checked)
                {
                    oUsuario.RollNew = FactoriaUsuario.GetRoll(TipoUsuario.administrador);
                }

                if (rbOperador.Checked)
                {
                    oUsuario.RollNew = FactoriaUsuario.GetRoll(TipoUsuario.operador);
                }

                if (rbReportador.Checked)
                {
                    oUsuario.RollNew = FactoriaUsuario.GetRoll(TipoUsuario.reportador);
                }

                oUsuario.NombreNew = this.txtUser.Text;
                oUsuario.ContrasenaNew = this.txtPass.Text;
                oUsuario.Foto = cadenaBytes;

                GestorNewUser.GetInstacia().NewUser(oUsuario);
                this.CargarDGV();
                this.LimpiaCampos();

            }
            else
            {
                if (ValidacionesOK)
                {
                    MessageBox.Show("Las Contraseñas no coinciden");
                    this.txtPass.Text = "";
                    this.txtPassV.Text = "";
                    this.txtPass.Focus();
                }

            }
        }
        
        #endregion

        #region limpia todos los campos
        private void LimpiaCampos()
        {

            this.txtUser.Text = "";
            this.txtPass.Text = "";
            this.txtPassV.Text = "";
            this.rbAdministrador.Checked = false;
            this.rbOperador.Checked = false;
            this.rbReportador.Checked = false;
            this.pbFoto.Tag = null;
            this.pbFoto.Image = global::UTN.Winform.AppProyectopg3.Properties.Resources.camera89;
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;



            MessageBox.Show("El usuario ha sido agregado");
        }
        
        #endregion

        #region validar los campos
        private void ValidarCampos()
        {

            errorProvider1.Clear();

            if (Validaciones.GetInstancia().CampoRequerido(this.txtUser.Text))
            {
                errorProvider1.SetError(this.txtUser, Validaciones.GetInstancia().descripcion());
                return;
            }

            if (Validaciones.GetInstancia().CampoRequerido(this.txtPass.Text))
            {
                errorProvider1.SetError(this.txtPass, Validaciones.GetInstancia().descripcion());
                return;
            }

            if (Validaciones.GetInstancia().CampoRequerido(this.txtPassV.Text))
            {
                errorProvider1.SetError(this.txtPassV, Validaciones.GetInstancia().descripcion());
                return;
            }

            if (!rbAdministrador.Checked && !rbOperador.Checked && !rbReportador.Checked)
            {
                errorProvider1.SetError(this.gbRolles, "Opcion requerida");
                return;
            }

            if (this.pbFoto.Tag == null)
            {
                errorProvider1.SetError(this.pbFoto, "Foto requerida");
                return;
            }

            ValidacionesOK = true;

        }
        
        #endregion

        #region muestra el teclado en pantalla
        private void pBTeclado_Click(object sender, EventArgs e)
        {
            if (!ExternalApp.GetInstacia().TecladoIslive())
            {
                ExternalApp.GetInstacia().Teclado();
            }
        }
        
        #endregion
       
        #region captura foto
        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {

            try
            {
                frmExibeWebCam ofrmExibeWebCam = new frmExibeWebCam();
                ofrmExibeWebCam.ShowDialog(this);


                if (ofrmExibeWebCam.DialogResult == DialogResult.OK)
                {
                    ofrmExibeWebCam.Close();
                    pbFoto.ImageLocation = (@"C:\\temp\Foto.bmp");
                    pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;

                    OpenFileDialog opt = new OpenFileDialog();
                    //extrae la imagen tomada
                    opt.FileName = (@"C:\\temp\Foto.bmp");
                    //convierte la imagen a una cadena de bytes
                    cadenaBytes = File.ReadAllBytes(opt.FileName);

                    pbFoto.Tag = (byte[])cadenaBytes;

                }

            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }
        
        #endregion




    }//fin class
}
