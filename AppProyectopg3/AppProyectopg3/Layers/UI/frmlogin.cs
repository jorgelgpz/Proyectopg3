using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.AppProyectopg3.Layers.Entities;
using UTN.Winform.AppProyectopg3.Layers.Singleton;
using UTN.Winform.AppProyectopg3.Layers.Util;


namespace UTN.Winform.AppProyectopg3.Layers.UI
{
    public partial class frmLoging : Form
    {

        private int contador = 0;

        public frmLoging()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {


            errorProvider1.Clear();

        }


        private void pictureBoxEntrar_Click(object sender, EventArgs e)
        {
            ValidaUser();

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                ValidaUser();

            }

        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtPass.Text.Length == 0)
                {

                    txtPass.Focus();
                }
                else
                {
                    ValidaUser();
                }

            }

        }

        #region Valida el Usuario
        private void ValidaUser()
        {
            errorProvider1.Clear();

            try
            {


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



                Usuario oUsuario = Usuario.GetInstance();

                oUsuario.Nombre = this.txtUser.Text;
                oUsuario.Contrasena = this.txtPass.Text;


                GestorLoging.GetInstacia().Loging(oUsuario);


                this.DialogResult = DialogResult.OK;
                Close();



            }
            catch (Exception error)
            {

                // Incrementar el contador
                contador++;

                // Si el mensaje es "Error de inicio de sesión del usuario" es un error de usuario inválido 
                if (error.Message.Trim().Contains("Error de inicio de sesión del usuario") == true || error.Message.Trim().Contains("Login failed") == true)
                    MessageBox.Show("Usuario inválido, intento No " + contador, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    // otro Error
                    MessageBox.Show("Error ->" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Si el contador es 3 cierre la aplicación
                if (contador == 3)
                {
                    // se devuelve Cancel
                    this.DialogResult = DialogResult.Cancel;
                    Application.Exit();
                }

            }
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!ExternalApp.GetInstacia().TecladoIslive())
            {
                ExternalApp.GetInstacia().Teclado();
            }

        }



    }//fin class
}
