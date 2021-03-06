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
using UTN.Winform.AppProyectopg3.Layers.Singleton.GestorMantenimientos.MetodosEstaticos;
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



        #region carga los dgv de diferentes pestanas

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
                    this.btnBorrarDelito.Visible = false;
                    this.btnEditarDelito.Visible = false;
                    this.rtbDescripcionDelitos.Text = "";
                }

                if (tbpCentroPenales.Focus())
                {
                    this.CargarDGVCentroPenales();
                    this.LimpiaCampoCentroPenal();
                    this.btnEditarCentroPenales.Visible = false;
                    this.btnBorrarCentroPenal.Visible = false;
                }

                if (tbpSalario.Focus())
                {
                    this.CargarDGVSalarioBase();
                    this.LimpiaCamposSalarioBase();
                    this.btnEditarSalario.Visible = false;
                    this.btnBorrarSalario.Visible = false;

                }

                if (tbpEventos.Focus())
                {

                    this.CargaDGVEventos();
                    this.LimpiaEvento();
                    this.btnEditarEvento.Visible = false;
                    this.btnBorrarEvento.Visible = false;
                    this.rbPositvoEvento.Checked = false;
                    this.rbNegativoEvento.Checked = false;

                }

                if (tbpReclusos.Focus())
                {

                    this.txtIdentificacionReclusos.Text = "";
                    this.txtNacionalidadReclusos.Text = "";
                    this.txtNombreReclusos.Text = "";
                    this.txtApellidoReclusos.Text = "";
                    this.txtEmailReclusos.Text = "";
                    this.txtSimpeReclusos.Text = "";
                    this.txtSanguineoReclusos.Text = "";
                    this.txtCivilReclusos.Text = "";
                    this.txtTelefonoContactoReclusos.Text = "";
                    this.txtNombreReclusos.Text = "";
                    this.rbNoficacionesSiReclusos.Checked = false;
                    this.rbNoficacionesNoReclusos.Checked = false;
                    this.rbMedicoNoRecluso.Checked = false;
                    this.rbMedicoSiRecluso.Checked = false;
                    this.rbTrabajaNoRecluso.Checked = false;
                    this.rbTrabajaSiRecluso.Checked = false;
                    this.rbFotoReclusos.Checked = false;
                    this.rbFotoHuellasReclusos.Checked = false;
                    this.rbFotoVarias.Checked = false;
                    this.txtSeccionReclusos.Text = "";
                    this.txtCentroPenalReclusos.Text = "";
                    this.rtbNotasReclusos.Text = "";
                    Estaticos.GetInstacia().LimpiaListaEventos();

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
        #endregion

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

        #region carga lista de delitos

        private void CargarDGVDelitos()
        {

            dgvDelitos.DataSource = GestorMantenimientos.GetInstacia().GetListaDelitos();

        }
        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            try
            {

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
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCacelar_Click(object sender, EventArgs e)
        {
            this.Cancelar();

        }


        #region actualiza delito
        private void btnEditarDelito_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                if (Validaciones.GetInstancia().CampoRequerido(this.rtbDescripcionDelitos.Text) || Validaciones.GetInstancia().CampoMuyLargo500(this.rtbDescripcionDelitos.Text))
                {
                    errorProvider1.SetError(this.rtbDescripcionDelitos, Validaciones.GetInstancia().descripcion());
                    return;
                }

                x = this.dgvDelitos.SelectedCells[0].RowIndex;

                Delitos oDelitos = new Delitos();
                oDelitos = this.dgvDelitos.Rows[x].DataBoundItem as Delitos;

                oDelitos.descripcion = this.rtbDescripcionDelitos.Text;

                GestorMantenimientos.GetInstacia().ActualizaDelitos(oDelitos);
                this.CargarDGVDelitos();

                MessageBox.Show("Se ha actualizado los datos");
                this.rtbDescripcionDelitos.Text = "";

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


        private void btnBorrarDelito_Click(object sender, EventArgs e)
        {

            try
            {


                if (MessageBox.Show("Esta seguro que desea borrar este delito?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    x = this.dgvDelitos.SelectedCells[0].RowIndex;

                    Delitos oDelitos = new Delitos();
                    oDelitos = this.dgvDelitos.Rows[x].DataBoundItem as Delitos;

                    GestorMantenimientos.GetInstacia().DeleteLogicalDelitos(oDelitos);
                    this.CargarDGVDelitos();

                    MessageBox.Show("Se ha eliminado los datos");
                    this.rtbDescripcionDelitos.Text = "";

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

        #region seleccion del objeto dvg delito
        private void dgvDelitos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                Delitos oDelitos = new Delitos();


                if (e.RowIndex >= 0 && this.dgvDelitos.SelectedRows.Count > 0)
                {

                    if (e.RowIndex >= 0)
                    {

                        oDelitos = this.dgvDelitos.SelectedRows[0].DataBoundItem as Delitos;

                        this.rtbDescripcionDelitos.Text = oDelitos.descripcion;

                        this.btnEditarDelito.Visible = true;
                        this.btnBorrarDelito.Visible = true;

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
        #endregion

        private void dgvDelitos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.dgvDelitos.RowCount > 0)
                {

                    x = this.dgvDelitos.SelectedCells[0].RowIndex;
                    Delitos oDelitos = new Delitos();

                    oDelitos = this.dgvDelitos.Rows[x].DataBoundItem as Delitos;

                    this.rtbDescripcionDelitos.Text = oDelitos.descripcion;
                    this.btnBorrarDelito.Visible = true;
                    this.btnEditarDelito.Visible = true;
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




        #endregion


        #region pestana centro penales

        #region carga lista de centro penales

        private void CargarDGVCentroPenales()
        {
            dgvCentroPenales.DataSource = GestorMantenimientos.GetInstacia().GetListaPenales();

        }
        #endregion

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


                if (Validaciones.GetInstancia().CampoRequerido(this.txtTelefono2CentroPenales.Text) || Validaciones.GetInstancia().CampoNumerico(this.txtTelefono2CentroPenales.Text))
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

        #region seleccion el objeto del dgv de centro penales

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
        #endregion

        #region centro penales con la tecla enter
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
        #endregion

        #region actualiza las celdas de centro penales

        private void ActualizaCentroPenalDesdeCelda()
        {
            try
            {

                CentroPenales oCentroPenales = new CentroPenales();
                x = this.dgvCentroPenales.SelectedCells[0].RowIndex;

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
        #endregion

        #region limpia campos txt de centro penales

        private void LimpiaCampoCentroPenal()
        {

            this.txtNombreCentroPenales.Text = "";
            this.txtDireccionCentroPenales.Text = "";
            this.txtTelefono1CentroPenales.Text = "";
            this.txtTelefono2CentroPenales.Text = "";

        }
        #endregion

        #region actualiza la fila del dgv centro penal cuando cambia de foco

        private void dgvCentroPenales_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCentroPenales.Focused)
                {
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
        #endregion

        #region seleccion una fila del dgv de centro penales con un click
        private void dgvCentroPenales_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                if (this.dgvDelitos.RowCount > 0)
                {
                    ActualizaCentroPenalDesdeCelda();
                    this.btnEditarCentroPenales.Visible = true;
                    this.btnBorrarCentroPenal.Visible = true;
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

        #endregion

        #region actualiza centro penales
        private void btnEditarCentroPenales_Click(object sender, EventArgs e)
        {

            try
            {

                CentroPenales oCentroPenales = new CentroPenales();

                oCentroPenales = this.dgvCentroPenales.Rows[x].DataBoundItem as CentroPenales;

                this.txtNombreCentroPenales.Text = oCentroPenales.Nombre.ToString();
                this.txtDireccionCentroPenales.Text = oCentroPenales.Direccion.ToString();
                this.txtTelefono1CentroPenales.Text = Convert.ToString(oCentroPenales.Telefono1.ToString());
                this.txtTelefono2CentroPenales.Text = Convert.ToString(oCentroPenales.Telefono2.ToString());

                GestorMantenimientos.GetInstacia().ActualizaCentroPenales(oCentroPenales);
                this.CargarDGVCentroPenales();
                this.ActualizaCentroPenalDesdeCelda();

                MessageBox.Show("Se ha modificado los campos");

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

        #region Borrado logico centro penales
        private void btnBorrarCentroPenal_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Esta seguro que desea borrar este centro penal?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    CentroPenales oCentroPenales = new CentroPenales();

                    oCentroPenales = this.dgvCentroPenales.Rows[x].DataBoundItem as CentroPenales;

                    this.txtNombreCentroPenales.Text = oCentroPenales.Nombre.ToString();
                    this.txtDireccionCentroPenales.Text = oCentroPenales.Direccion.ToString();
                    this.txtTelefono1CentroPenales.Text = Convert.ToString(oCentroPenales.Telefono1.ToString());
                    this.txtTelefono2CentroPenales.Text = Convert.ToString(oCentroPenales.Telefono2.ToString());


                    GestorMantenimientos.GetInstacia().DeleteLogicalCentroPenales(oCentroPenales);
                    this.CargarDGVCentroPenales();
                    this.LimpiaCampoCentroPenal();
                    x = 0;

                    MessageBox.Show("Se ha eliminado el centro penal");

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
        #endregion



        #endregion


        #region pestana salario base

        #region carga lista de Salario base

        private void CargarDGVSalarioBase()
        {
            this.dgvSalarioBase.DataSource = GestorMantenimientos.GetInstacia().GetListaSalarioBase();

        }
        #endregion

        private void LimpiaCamposSalarioBase()
        {

            this.txtSalario.Text = "";
        }

        #region actualiza campos salario base
        private void ActualizaCampoSalarioBase()
        {

            SalarioBase oSalarioBase = new SalarioBase();

            x = this.dgvSalarioBase.SelectedCells[0].RowIndex;

            oSalarioBase = this.dgvSalarioBase.Rows[0].DataBoundItem as SalarioBase;

            this.txtSalario.Text = Convert.ToString(oSalarioBase.Monto);
        }
        #endregion

        #region actualiza campos salario base y retorna objeto
        private SalarioBase ActualizaSalarioBase()
        {

            SalarioBase oSalarioBase = new SalarioBase();

            x = this.dgvSalarioBase.SelectedCells[0].RowIndex;

            oSalarioBase = this.dgvSalarioBase.Rows[x].DataBoundItem as SalarioBase;

            this.txtSalario.Text = Convert.ToString(oSalarioBase.Monto);

            return oSalarioBase;
        }

        #endregion

        #region inserta salario base
        private void btnAgregarSalario_Click(object sender, EventArgs e)
        {

            try
            {
                errorProvider1.Clear();

                if (Validaciones.GetInstancia().CampoRequerido(this.txtSalario.Text) || Validaciones.GetInstancia().CampoNumericoDouble(this.txtSalario.Text))
                {
                    errorProvider1.SetError(this.txtSalario, Validaciones.GetInstancia().descripcion());
                    return;
                }

                SalarioBase oSalarioBase = new SalarioBase();
                oSalarioBase.Monto = Convert.ToDouble(this.txtSalario.Text);

                GestorMantenimientos.GetInstacia().InsertNewSalarioBase(oSalarioBase);
                this.CargarDGVSalarioBase();
                this.LimpiaCamposSalarioBase();

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

        private void btnCancelarSalario_Click(object sender, EventArgs e)
        {
            this.Cancelar();
        }

        #region edita salario base
        private void btnEditarSalario_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                if (Validaciones.GetInstancia().CampoRequerido(this.txtSalario.Text) || Validaciones.GetInstancia().CampoNumericoDouble(this.txtSalario.Text))
                {
                    errorProvider1.SetError(this.txtSalario, Validaciones.GetInstancia().descripcion());
                    return;
                }

                SalarioBase oSalarioBase = new SalarioBase();

                x = this.dgvSalarioBase.SelectedCells[0].RowIndex;

                oSalarioBase = this.dgvSalarioBase.Rows[x].DataBoundItem as SalarioBase;
                oSalarioBase.Monto = Convert.ToDouble(this.txtSalario.Text);

                GestorMantenimientos.GetInstacia().ActualizaSalarioBase(oSalarioBase);
                this.CargarDGVSalarioBase();


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

        #region delete logico salario base
        private void btnBorrarSalario_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Esta seguro que desea borrar este salario base?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    SalarioBase oSalarioBase = this.ActualizaSalarioBase();

                    GestorMantenimientos.GetInstacia().DeleteLogicalSalarioBase(oSalarioBase);
                    this.CargarDGVSalarioBase();

                    MessageBox.Show("Se ha eliminado los datos");
                    this.txtSalario.Text = "";

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
        #endregion

        #region selecciona salario desde dgv
        private void dgvSalarioBase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SalarioBase oSalarioBase = new SalarioBase();


                if (e.RowIndex >= 0 && this.dgvSalarioBase.SelectedRows.Count > 0)
                {

                    if (e.RowIndex >= 0)
                    {

                        oSalarioBase = this.dgvSalarioBase.SelectedRows[0].DataBoundItem as SalarioBase;

                        this.txtSalario.Text = Convert.ToString(oSalarioBase.Monto);

                        this.btnEditarSalario.Visible = true;
                        this.btnBorrarSalario.Visible = true;

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
        #endregion

        #region seleccion salario desde celda con el mouse
        private void dgvSalarioBase_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.dgvSalarioBase.RowCount > 0)
                {
                    this.ActualizaSalarioBase();
                    this.btnEditarSalario.Visible = true;
                    this.btnBorrarSalario.Visible = true;
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
        #endregion


        #endregion


        #region pestana eventos


        #region Get lista eventos
        private void CargaDGVEventos()
        {

            this.dgvEventos.DataSource = GestorMantenimientos.GetInstacia().GetListaEventos();

        }
        #endregion

        #region inserta evento
        private void btnAgregarEvento_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (Validaciones.GetInstancia().CampoRequerido(this.rtbEvento.Text))
                {
                    this.errorProvider1.SetError(this.rtbEvento, Validaciones.GetInstancia().descripcion());
                    return;
                }

                if (!this.rbNegativoEvento.Checked && !this.rbPositvoEvento.Checked)
                {
                    this.errorProvider1.SetError(this.gbEventos, "Campo requerido");
                    return;
                }



                Eventos oEventos = new Eventos();

                oEventos.Descripcion = this.rtbEvento.Text;


                if (this.rbPositvoEvento.Checked)
                {
                    oEventos.Tipo = FactoriaTipoEventos.GetTipoEvento(TipoEventos.Positivo);
                }
                else
                {
                    oEventos.Tipo = FactoriaTipoEventos.GetTipoEvento(TipoEventos.Negativo);
                }

                GestorMantenimientos.GetInstacia().InsertNewEvento(oEventos);
                this.CargaDGVEventos();
                this.LimpiaEvento();



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

        private void btnCancelarEvento_Click(object sender, EventArgs e)
        {
            this.Cancelar();
        }

        #region edita evento
        private void btnEditarEvento_Click(object sender, EventArgs e)
        {
            try
            {


                errorProvider1.Clear();

                x = this.dgvEventos.SelectedCells[0].RowIndex;

                Eventos oEventos = this.dgvEventos.Rows[x].DataBoundItem as Eventos;


                if (Validaciones.GetInstancia().CampoRequerido(this.rtbEvento.Text))
                {
                    this.errorProvider1.SetError(this.rtbEvento, Validaciones.GetInstancia().descripcion());
                    return;
                }


                if (this.rbPositvoEvento.Checked)
                {
                    oEventos.Tipo = FactoriaTipoEventos.GetTipoEvento(TipoEventos.Positivo);
                }
                else
                {
                    oEventos.Tipo = FactoriaTipoEventos.GetTipoEvento(TipoEventos.Negativo);
                }


                oEventos.Descripcion = this.rtbEvento.Text;

                GestorMantenimientos.GetInstacia().ActualizaEvento(oEventos);

                this.CargaDGVEventos();
                this.LimpiaEvento();
                MessageBox.Show("Se ha modificado los datos");

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

        #region borrar evento
        private void btnBorrarEvento_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Esta seguro que desea borrar este evento?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Eventos oEventos = this.ActualizaEventos();

                    GestorMantenimientos.GetInstacia().DeleteLogicalEventos(oEventos);
                    this.CargaDGVEventos();

                    MessageBox.Show("Se ha eliminado los datos");
                    this.LimpiaEvento();

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
        #endregion

        #region seleccion evento del dgv
        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Eventos oEventos = new Eventos();


                if (e.RowIndex >= 0 && this.dgvEventos.SelectedRows.Count > 0)
                {

                    if (e.RowIndex >= 0)
                    {

                        oEventos = this.dgvEventos.SelectedRows[0].DataBoundItem as Eventos;


                        this.rtbEvento.Text = oEventos.Descripcion;

                        this.btnBorrarEvento.Visible = true;
                        this.btnEditarEvento.Visible = true;
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

        #endregion

        #region seleccion evento desde celda con click
        private void dgvEventos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.dgvEventos.RowCount > 0)
                {
                    this.ActualizaEventos();
                    this.btnBorrarEvento.Visible = true;
                    this.btnEditarEvento.Visible = true;
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
        #endregion

        #region actualiza evento
        private Eventos ActualizaEventos()
        {
            Eventos oEventos = new Eventos();

            try
            {


                x = this.dgvEventos.SelectedCells[0].RowIndex;

                oEventos = this.dgvEventos.Rows[x].DataBoundItem as Eventos;

                this.rtbEvento.Text = oEventos.Descripcion;

                if (oEventos.Tipo.Equals("Positivo"))
                {
                    this.rbPositvoEvento.Checked = true;
                }
                else
                {
                    this.rbNegativoEvento.Checked = true;
                }



            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return oEventos;
        }

        #endregion

        #region limpia evento
        private void LimpiaEvento()
        {

            this.rtbEvento.Text = "";
            this.rbPositvoEvento.Checked = false;
            this.rbNegativoEvento.Checked = false;
        }
        #endregion



        #endregion




















        #region validaciones de campos de reclusos
        private void ValidacionesCamposReclusos()
        {

            try
            {

                errorProvider1.Clear();

                if (Validaciones.GetInstancia().CampoRequerido(this.txtIdentificacionReclusos.Text) || Validaciones.GetInstancia().CampoNumerico(this.txtIdentificacionReclusos.Text))
                {
                    errorProvider1.SetError(this.txtIdentificacionReclusos, Validaciones.GetInstancia().descripcion());
                    return;
                }

                if (Validaciones.GetInstancia().CampoRequerido(this.txtNacionalidadReclusos.Text))
                {
                    errorProvider1.SetError(this.txtNacionalidadReclusos, Validaciones.GetInstancia().descripcion());
                    return;
                }

                if (Validaciones.GetInstancia().CampoRequerido(this.txtNombreReclusos.Text))
                {
                    errorProvider1.SetError(this.txtNombreReclusos, Validaciones.GetInstancia().descripcion());
                    return;
                }

                if (Validaciones.GetInstancia().CampoRequerido(this.txtApellidoReclusos.Text))
                {
                    errorProvider1.SetError(this.txtApellidoReclusos, Validaciones.GetInstancia().descripcion());
                    return;
                }

                if (Validaciones.GetInstancia().CampoRequerido(this.txtEmailReclusos.Text))
                {
                    errorProvider1.SetError(this.txtEmailReclusos, Validaciones.GetInstancia().descripcion());
                    return;
                }

                if (Validaciones.GetInstancia().CampoRequerido(this.txtSimpeReclusos.Text))
                {
                    errorProvider1.SetError(this.txtSimpeReclusos, Validaciones.GetInstancia().descripcion());
                    return;
                }

                if (Validaciones.GetInstancia().CampoRequerido(this.txtSanguineoReclusos.Text))
                {
                    errorProvider1.SetError(this.txtSanguineoReclusos, Validaciones.GetInstancia().descripcion());
                    return;
                }

                if (Validaciones.GetInstancia().CampoRequerido(this.txtCivilReclusos.Text))
                {
                    errorProvider1.SetError(this.txtCivilReclusos, Validaciones.GetInstancia().descripcion());
                    return;
                }

                if (Validaciones.GetInstancia().CampoRequerido(this.txtTelefonoContactoReclusos.Text))
                {
                    errorProvider1.SetError(this.txtTelefonoContactoReclusos, Validaciones.GetInstancia().descripcion());
                    return;
                }

                if (Validaciones.GetInstancia().CampoRequerido(this.txtCentroPenalReclusos.Text))
                {
                    errorProvider1.SetError(this.txtCentroPenalReclusos, Validaciones.GetInstancia().descripcion());
                    return;
                }

                if (Validaciones.GetInstancia().CampoRequerido(this.txtSeccionReclusos.Text))
                {
                    errorProvider1.SetError(this.txtSeccionReclusos, Validaciones.GetInstancia().descripcion());
                    return;
                }

                if (Validaciones.GetInstancia().CampoRequerido(this.txtNombreContactoReclusos.Text))
                {
                    errorProvider1.SetError(this.txtNombreContactoReclusos, Validaciones.GetInstancia().descripcion());
                    return;
                }

                if (!rbNoficacionesSiReclusos.Checked && !rbNoficacionesNoReclusos.Checked)
                {
                    errorProvider1.SetError(this.gbNoficacionesReclusos, "Campo requerido");
                    return;
                }

                if (!this.rbMedicoSiRecluso.Checked && !this.rbMedicoNoRecluso.Checked)
                {
                    errorProvider1.SetError(this.gbNoficacionesReclusos, "Campo requerido");
                    return;
                }

                if (!this.rbTrabajaSiRecluso.Checked && !this.rbTrabajaNoRecluso.Checked)
                {
                    errorProvider1.SetError(this.gbNoficacionesReclusos, "Campo requerido");
                    return;
                }

                if (this.rbFotoReclusos.Tag == null)
                {
                    errorProvider1.SetError(this.rbFotoReclusos, "Foto requerida");
                    return;
                }

                if (this.rbFotoHuellasReclusos.Tag == null)
                {
                    errorProvider1.SetError(this.rbFotoReclusos, "Foto requerida");
                    return;
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
        #endregion

        private void btnAgregarReclusos_Click(object sender, EventArgs e)
        {
            this.ValidacionesCamposReclusos();
        }

        private void btnCancelarReclusos_Click(object sender, EventArgs e)
        {
            this.Cancelar();
        }

        private void btnEditarReclusos_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarReclusos_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarEventoReclusos_Click(object sender, EventArgs e)
        {
            try
            {

                frmEventosReclusos ofrmEventosReclusos = new frmEventosReclusos();
                ofrmEventosReclusos.ShowDialog(this);
                ofrmEventosReclusos.Close();

                ////if (ofrmEventosReclusos.DialogResult != DialogResult.OK)
                ////{
                CargaDGVDelitosReclusos();




                //}


            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);


                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaDGVDelitosReclusos()
        {
            this.dgvEventosReclusos.DataSource = null;
            this.dgvEventosReclusos.AutoGenerateColumns = false;
            this.dgvEventosReclusos.DataSource = Estaticos.GetInstacia().GetListaEventos();
        }

        private void btnAgregaDelitosReclusos_Click(object sender, EventArgs e)
        {

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
