﻿using InterfaceWebCam;
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
        private int x;

        public frmMantenimientos()
        {
            InitializeComponent();
        }

        private void frmMantenimientos_Load(object sender, EventArgs e)
        {
            try
            {

                this.CargarDGV();

            }

            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void tbp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (tbpNuevoUsuario.Focus())
                {
                    this.CargarDGV();
                }

                if (tbpDelitos.Focus())
                {
                    this.CargarDGVDelitos();
                }

                if (tbpCentroPenales.Focus())
                {
                    this.CargarDGVCentroPenales();
                }



            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Cancelar()
        {
            this.DialogResult = DialogResult.Abort;
        }


        #region pestana new Usuarios

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }



        private void tbpNuevoUsuario_Click(object sender, EventArgs e)
        {
            this.txtUser.Focus();
        }



        #region pobla el dgv con los usuarios
        private void CargarDGV()
        {
            try
            {

                dgvUsuarios.RowTemplate.Height = 100;

                dgvUsuarios.DataSource = GestorMantenimientos.GetInstacia().GetUsuarios();

            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region nuevo usuario
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.ValidarCampos();

            if (ValidacionesOK && (this.txtPass.Text.Equals(this.txtPassV.Text)))
            {

                try
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
                    //oUsuario.Foto = cadenaBytes;
                    oUsuario.Foto = (Byte[])Foto.Tag;

                    GestorNewUser.GetInstacia().NewUser(oUsuario);
                    this.CargarDGV();
                    this.LimpiaCampos();

                }
                catch (Exception er)
                {

                    StringBuilder msg = new StringBuilder();
                    msg.AppendFormat("Message        {0}\n", er.Message);
                    msg.AppendFormat("Source         {0}\n", er.Source);

                    MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


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
            try
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
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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


        #endregion



        #region pestana Delitos
        private void CargarDGVDelitos()
        {

            dgvDelitos.DataSource = GestorMantenimientos.GetInstacia().GetListaDelitos();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (Validaciones.GetInstancia().CampoRequerido(this.rtbDescripcionDelitos.Text) || Validaciones.GetInstancia().CampoMuyLargo500(this.rtbDescripcionDelitos.Text))
            {
                errorProvider1.SetError(this.rtbDescripcionDelitos, Validaciones.GetInstancia().descripcion());
                return;
            }

            Delitos oDelitos = new Delitos();
            oDelitos.descripcion = this.rtbDescripcionDelitos.Text;

            GestorMantenimientos.GetInstacia().InsertNewDelito(oDelitos);
            this.CargarDGVDelitos();
            this.rtbDescripcionDelitos.Text = "";
        }

        private void btnCacelar_Click(object sender, EventArgs e)
        {
            this.Cancelar();

        }


        #endregion


        private void CargarDGVCentroPenales()
        {
            dgvCentroPenales.DataSource = GestorMantenimientos.GetInstacia().GetListaPenales();

        }

        private void btnAceptarCentroPenales_Click(object sender, EventArgs e)
        {


            try
            {

                #region validaciones de campo de centro penales
                this.errorProvider1.Clear();

                if (Validaciones.GetInstancia().CampoRequerido(this.txtNombreCentroPenales.Text) || Validaciones.GetInstancia().CampoMuyLargo1000(this.txtNombreCentroPenales.Text))
                {

                    this.errorProvider1.SetError(this.txtNombreCentroPenales, Validaciones.GetInstancia().descripcion());
                    return;
                }

                if (Validaciones.GetInstancia().CampoRequerido(this.txtDireccionCentroPenales.Text) || Validaciones.GetInstancia().CampoMuyLargo1000(this.txtDireccionCentroPenales.Text))
                {

                    this.errorProvider1.SetError(this.txtDireccionCentroPenales, Validaciones.GetInstancia().descripcion());
                    return;
                }

                if (Validaciones.GetInstancia().CampoRequerido(this.txtTelefono1CentroPenales.Text) || Validaciones.GetInstancia().CampoNumerico(this.txtTelefono1CentroPenales.Text))
                {

                    this.errorProvider1.SetError(this.txtTelefono1CentroPenales, Validaciones.GetInstancia().descripcion());
                    return;
                }

                if (Validaciones.GetInstancia().CampoNumerico(this.txtTelefono2CentroPenales.Text))
                {

                    this.errorProvider1.SetError(this.txtTelefono2CentroPenales, Validaciones.GetInstancia().descripcion());
                    return;
                }

                #endregion

                CentroPenales oCentroPenales = new CentroPenales();

                oCentroPenales.Nombre = this.txtNombreCentroPenales.Text.Trim();
                oCentroPenales.Direccion = this.txtDireccionCentroPenales.Text.Trim();
                oCentroPenales.Telefono1 = Convert.ToInt32(this.txtTelefono1CentroPenales.Text.Trim());
                oCentroPenales.Telefono2 = Convert.ToInt32(this.txtTelefono2CentroPenales.Text.Trim());

                GestorMantenimientos.GetInstacia().InsertNewCentroPenales(oCentroPenales);

                this.CargarDGVCentroPenales();

                this.txtNombreCentroPenales.Text = "";
                this.txtDireccionCentroPenales.Text = "";
                this.txtTelefono1CentroPenales.Text = "";
                this.txtTelefono2CentroPenales.Text = "";

            }

            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




        private void btnCancelarCentroPenales_Click(object sender, EventArgs e)
        {
            this.Cancelar();
        }

        private void dgvCentroPenales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CentroPenales oCentroPenales = new CentroPenales();

                if (e.RowIndex >= 0 && this.dgvCentroPenales.SelectedRows.Count > 0)
                {

                    if (e.RowIndex >= 0)
                    {

                        oCentroPenales = this.dgvCentroPenales.SelectedRows[0].DataBoundItem as CentroPenales;

                        this.txtNombreCentroPenales.Text = oCentroPenales.Nombre.ToString();
                        this.txtDireccionCentroPenales.Text = oCentroPenales.Direccion.ToString();
                        this.txtTelefono1CentroPenales.Text = Convert.ToString(oCentroPenales.Telefono1.ToString());
                        this.txtTelefono2CentroPenales.Text = Convert.ToString(oCentroPenales.Telefono2.ToString());

                    }

                }


            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void dgvCentroPenales_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyData == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    this.dgvCentroPenales.BeginEdit(true);
                    x = this.dgvCentroPenales.SelectedCells[0].RowIndex;
                    ActualizaCentroPenalDesdeCelda();

                }
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ActualizaCentroPenalDesdeCelda()
        {
            try
            {

                CentroPenales oCentroPenales = new CentroPenales();

                oCentroPenales = this.dgvCentroPenales.Rows[x].DataBoundItem as CentroPenales;

                this.txtNombreCentroPenales.Text = oCentroPenales.Nombre.ToString();
                this.txtDireccionCentroPenales.Text = oCentroPenales.Direccion.ToString();
                this.txtTelefono1CentroPenales.Text = Convert.ToString(oCentroPenales.Telefono1.ToString());
                this.txtTelefono2CentroPenales.Text = Convert.ToString(oCentroPenales.Telefono2.ToString());

            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void dgvCentroPenales_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {

                ActualizaCentroPenalDesdeCelda();

            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCentroPenales_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                x = this.dgvCentroPenales.SelectedCells[0].RowIndex;
                ActualizaCentroPenalDesdeCelda();
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        //try{

        //    }
        // catch (Exception er)
        //    {

        //        StringBuilder msg = new StringBuilder();
        //        msg.AppendFormat("Message        {0}\n", er.Message);
        //        msg.AppendFormat("Source         {0}\n", er.Source);

        //        MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }



    }//fin class
}
