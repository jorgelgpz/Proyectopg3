namespace UTN.Winform.AppProyectopg3.Layers.UI
{
    partial class frmMantenimientos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbp = new System.Windows.Forms.TabControl();
            this.tbpNuevoUsuario = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.pBTeclado = new System.Windows.Forms.PictureBox();
            this.gbRolles = new System.Windows.Forms.GroupBox();
            this.tlpRolles = new System.Windows.Forms.TableLayoutPanel();
            this.rbReportador = new System.Windows.Forms.RadioButton();
            this.rbOperador = new System.Windows.Forms.RadioButton();
            this.rbAdministrador = new System.Windows.Forms.RadioButton();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tlpUser = new System.Windows.Forms.TableLayoutPanel();
            this.lblVerificaPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblNuevoUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassV = new System.Windows.Forms.TextBox();
            this.tbpDelitos = new System.Windows.Forms.TabPage();
            this.dgvDelitos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCacelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.rtbDescripcionDelitos = new System.Windows.Forms.RichTextBox();
            this.tbpCentroPenales = new System.Windows.Forms.TabPage();
            this.tbpSalario = new System.Windows.Forms.TabPage();
            this.tbpEventos = new System.Windows.Forms.TabPage();
            this.tbpReclusos = new System.Windows.Forms.TabPage();
            this.sstUser = new System.Windows.Forms.StatusStrip();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblNombre = new System.Windows.Forms.Label();
            this.tlpCentroPenales = new System.Windows.Forms.TableLayoutPanel();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono2 = new System.Windows.Forms.Label();
            this.lblTelefono1 = new System.Windows.Forms.Label();
            this.txtNombreCentroPenales = new System.Windows.Forms.TextBox();
            this.txtDireccionCentroPenales = new System.Windows.Forms.TextBox();
            this.txtTelefono1CentroPenales = new System.Windows.Forms.TextBox();
            this.txtTelefono2CentroPenales = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptarCentroPenales = new System.Windows.Forms.Button();
            this.btnCancelarCentroPenales = new System.Windows.Forms.Button();
            this.dgvCentroPenales = new System.Windows.Forms.DataGridView();
            this.tbp.SuspendLayout();
            this.tbpNuevoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTeclado)).BeginInit();
            this.gbRolles.SuspendLayout();
            this.tlpRolles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpUser.SuspendLayout();
            this.tbpDelitos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelitos)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbpCentroPenales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tlpCentroPenales.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentroPenales)).BeginInit();
            this.SuspendLayout();
            // 
            // tbp
            // 
            this.tbp.Controls.Add(this.tbpNuevoUsuario);
            this.tbp.Controls.Add(this.tbpDelitos);
            this.tbp.Controls.Add(this.tbpCentroPenales);
            this.tbp.Controls.Add(this.tbpSalario);
            this.tbp.Controls.Add(this.tbpEventos);
            this.tbp.Controls.Add(this.tbpReclusos);
            this.tbp.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbp.Location = new System.Drawing.Point(0, 0);
            this.tbp.Name = "tbp";
            this.tbp.SelectedIndex = 0;
            this.tbp.Size = new System.Drawing.Size(931, 558);
            this.tbp.TabIndex = 0;
            this.tbp.SelectedIndexChanged += new System.EventHandler(this.tbp_SelectedIndexChanged);
            // 
            // tbpNuevoUsuario
            // 
            this.tbpNuevoUsuario.Controls.Add(this.dgvUsuarios);
            this.tbpNuevoUsuario.Controls.Add(this.pBTeclado);
            this.tbpNuevoUsuario.Controls.Add(this.gbRolles);
            this.tbpNuevoUsuario.Controls.Add(this.pbFoto);
            this.tbpNuevoUsuario.Controls.Add(this.tableLayoutPanel2);
            this.tbpNuevoUsuario.Controls.Add(this.tlpUser);
            this.tbpNuevoUsuario.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpNuevoUsuario.Location = new System.Drawing.Point(4, 24);
            this.tbpNuevoUsuario.Name = "tbpNuevoUsuario";
            this.tbpNuevoUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNuevoUsuario.Size = new System.Drawing.Size(923, 530);
            this.tbpNuevoUsuario.TabIndex = 0;
            this.tbpNuevoUsuario.Text = "Nuevo Usuario";
            this.tbpNuevoUsuario.UseVisualStyleBackColor = true;
            this.tbpNuevoUsuario.Click += new System.EventHandler(this.tbpNuevoUsuario_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Roll,
            this.Foto});
            this.dgvUsuarios.Location = new System.Drawing.Point(61, 242);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(807, 268);
            this.dgvUsuarios.TabIndex = 8;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Roll
            // 
            this.Roll.DataPropertyName = "Roll";
            this.Roll.HeaderText = "Roll";
            this.Roll.Name = "Roll";
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Foto.Name = "Foto";
            this.Foto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pBTeclado
            // 
            this.pBTeclado.Image = global::UTN.Winform.AppProyectopg3.Properties.Resources.computer7;
            this.pBTeclado.Location = new System.Drawing.Point(61, 161);
            this.pBTeclado.Name = "pBTeclado";
            this.pBTeclado.Size = new System.Drawing.Size(102, 75);
            this.pBTeclado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBTeclado.TabIndex = 7;
            this.pBTeclado.TabStop = false;
            this.toolTip1.SetToolTip(this.pBTeclado, "Ver teclado");
            this.pBTeclado.Click += new System.EventHandler(this.pBTeclado_Click);
            // 
            // gbRolles
            // 
            this.gbRolles.Controls.Add(this.tlpRolles);
            this.gbRolles.Location = new System.Drawing.Point(635, 56);
            this.gbRolles.Name = "gbRolles";
            this.gbRolles.Size = new System.Drawing.Size(243, 116);
            this.gbRolles.TabIndex = 6;
            this.gbRolles.TabStop = false;
            this.gbRolles.Text = "Rolls";
            // 
            // tlpRolles
            // 
            this.tlpRolles.ColumnCount = 1;
            this.tlpRolles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRolles.Controls.Add(this.rbReportador, 0, 2);
            this.tlpRolles.Controls.Add(this.rbOperador, 0, 1);
            this.tlpRolles.Controls.Add(this.rbAdministrador, 0, 0);
            this.tlpRolles.Location = new System.Drawing.Point(6, 13);
            this.tlpRolles.Name = "tlpRolles";
            this.tlpRolles.RowCount = 3;
            this.tlpRolles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRolles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRolles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRolles.Size = new System.Drawing.Size(227, 100);
            this.tlpRolles.TabIndex = 0;
            // 
            // rbReportador
            // 
            this.rbReportador.AutoSize = true;
            this.rbReportador.Location = new System.Drawing.Point(3, 69);
            this.rbReportador.Name = "rbReportador";
            this.rbReportador.Size = new System.Drawing.Size(91, 19);
            this.rbReportador.TabIndex = 2;
            this.rbReportador.TabStop = true;
            this.rbReportador.Text = "Reportador";
            this.rbReportador.UseVisualStyleBackColor = true;
            // 
            // rbOperador
            // 
            this.rbOperador.AutoSize = true;
            this.rbOperador.Location = new System.Drawing.Point(3, 36);
            this.rbOperador.Name = "rbOperador";
            this.rbOperador.Size = new System.Drawing.Size(76, 19);
            this.rbOperador.TabIndex = 1;
            this.rbOperador.TabStop = true;
            this.rbOperador.Text = "Operario";
            this.rbOperador.UseVisualStyleBackColor = true;
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.AutoSize = true;
            this.rbAdministrador.Location = new System.Drawing.Point(3, 3);
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.Size = new System.Drawing.Size(112, 19);
            this.rbAdministrador.TabIndex = 0;
            this.rbAdministrador.TabStop = true;
            this.rbAdministrador.Text = "Administrador";
            this.rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFoto.Image = global::UTN.Winform.AppProyectopg3.Properties.Resources.camera89;
            this.pbFoto.Location = new System.Drawing.Point(486, 53);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(130, 133);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFoto.TabIndex = 5;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pictureBoxFoto_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNuevo, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(213, 183);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(255, 53);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(130, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 37);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(97, 37);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tlpUser
            // 
            this.tlpUser.ColumnCount = 2;
            this.tlpUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUser.Controls.Add(this.lblVerificaPass, 0, 2);
            this.tlpUser.Controls.Add(this.txtPass, 1, 1);
            this.tlpUser.Controls.Add(this.lblNuevoUser, 0, 0);
            this.tlpUser.Controls.Add(this.lblPass, 0, 1);
            this.tlpUser.Controls.Add(this.txtUser, 1, 0);
            this.tlpUser.Controls.Add(this.txtPassV, 1, 2);
            this.tlpUser.Location = new System.Drawing.Point(61, 53);
            this.tlpUser.Name = "tlpUser";
            this.tlpUser.RowCount = 3;
            this.tlpUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpUser.Size = new System.Drawing.Size(407, 102);
            this.tlpUser.TabIndex = 3;
            // 
            // lblVerificaPass
            // 
            this.lblVerificaPass.AutoSize = true;
            this.lblVerificaPass.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificaPass.Location = new System.Drawing.Point(3, 68);
            this.lblVerificaPass.Name = "lblVerificaPass";
            this.lblVerificaPass.Size = new System.Drawing.Size(167, 17);
            this.lblVerificaPass.TabIndex = 4;
            this.lblVerificaPass.Text = "Verifica Contraseña";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(206, 37);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(148, 22);
            this.txtPass.TabIndex = 3;
            // 
            // lblNuevoUser
            // 
            this.lblNuevoUser.AutoSize = true;
            this.lblNuevoUser.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoUser.Location = new System.Drawing.Point(3, 0);
            this.lblNuevoUser.Name = "lblNuevoUser";
            this.lblNuevoUser.Size = new System.Drawing.Size(140, 21);
            this.lblNuevoUser.TabIndex = 0;
            this.lblNuevoUser.Text = "Nuevo Usuario";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(3, 34);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(106, 21);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Contraseña";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(206, 3);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(148, 22);
            this.txtUser.TabIndex = 2;
            // 
            // txtPassV
            // 
            this.txtPassV.Location = new System.Drawing.Point(206, 71);
            this.txtPassV.Name = "txtPassV";
            this.txtPassV.PasswordChar = '*';
            this.txtPassV.Size = new System.Drawing.Size(148, 22);
            this.txtPassV.TabIndex = 5;
            // 
            // tbpDelitos
            // 
            this.tbpDelitos.Controls.Add(this.dgvDelitos);
            this.tbpDelitos.Controls.Add(this.tableLayoutPanel3);
            this.tbpDelitos.Controls.Add(this.tableLayoutPanel1);
            this.tbpDelitos.Location = new System.Drawing.Point(4, 24);
            this.tbpDelitos.Name = "tbpDelitos";
            this.tbpDelitos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDelitos.Size = new System.Drawing.Size(923, 530);
            this.tbpDelitos.TabIndex = 1;
            this.tbpDelitos.Text = "Delitos";
            this.tbpDelitos.UseVisualStyleBackColor = true;
            // 
            // dgvDelitos
            // 
            this.dgvDelitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion});
            this.dgvDelitos.Location = new System.Drawing.Point(22, 266);
            this.dgvDelitos.Name = "dgvDelitos";
            this.dgvDelitos.Size = new System.Drawing.Size(793, 230);
            this.dgvDelitos.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 48;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnCacelar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAgregar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(296, 189);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(519, 59);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnCacelar
            // 
            this.btnCacelar.Location = new System.Drawing.Point(262, 3);
            this.btnCacelar.Name = "btnCacelar";
            this.btnCacelar.Size = new System.Drawing.Size(116, 36);
            this.btnCacelar.TabIndex = 1;
            this.btnCacelar.Text = "Cancelar";
            this.btnCacelar.UseVisualStyleBackColor = true;
            this.btnCacelar.Click += new System.EventHandler(this.btnCacelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 36);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.10593F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.89407F));
            this.tableLayoutPanel1.Controls.Add(this.lblDescripcion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbDescripcionDelitos, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.97436F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 140);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(76, 15);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // rtbDescripcionDelitos
            // 
            this.rtbDescripcionDelitos.Location = new System.Drawing.Point(104, 3);
            this.rtbDescripcionDelitos.Name = "rtbDescripcionDelitos";
            this.rtbDescripcionDelitos.Size = new System.Drawing.Size(691, 125);
            this.rtbDescripcionDelitos.TabIndex = 3;
            this.rtbDescripcionDelitos.Text = "";
            // 
            // tbpCentroPenales
            // 
            this.tbpCentroPenales.Controls.Add(this.dgvCentroPenales);
            this.tbpCentroPenales.Controls.Add(this.tableLayoutPanel4);
            this.tbpCentroPenales.Controls.Add(this.tlpCentroPenales);
            this.tbpCentroPenales.Location = new System.Drawing.Point(4, 24);
            this.tbpCentroPenales.Name = "tbpCentroPenales";
            this.tbpCentroPenales.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCentroPenales.Size = new System.Drawing.Size(923, 530);
            this.tbpCentroPenales.TabIndex = 2;
            this.tbpCentroPenales.Text = "Centros Penales";
            this.tbpCentroPenales.UseVisualStyleBackColor = true;
            // 
            // tbpSalario
            // 
            this.tbpSalario.Location = new System.Drawing.Point(4, 24);
            this.tbpSalario.Name = "tbpSalario";
            this.tbpSalario.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSalario.Size = new System.Drawing.Size(923, 530);
            this.tbpSalario.TabIndex = 3;
            this.tbpSalario.Text = "Salario";
            this.tbpSalario.UseVisualStyleBackColor = true;
            // 
            // tbpEventos
            // 
            this.tbpEventos.Location = new System.Drawing.Point(4, 24);
            this.tbpEventos.Name = "tbpEventos";
            this.tbpEventos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEventos.Size = new System.Drawing.Size(923, 530);
            this.tbpEventos.TabIndex = 4;
            this.tbpEventos.Text = "Eventos";
            this.tbpEventos.UseVisualStyleBackColor = true;
            // 
            // tbpReclusos
            // 
            this.tbpReclusos.Location = new System.Drawing.Point(4, 24);
            this.tbpReclusos.Name = "tbpReclusos";
            this.tbpReclusos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpReclusos.Size = new System.Drawing.Size(923, 530);
            this.tbpReclusos.TabIndex = 5;
            this.tbpReclusos.Text = "Reclusos";
            this.tbpReclusos.UseVisualStyleBackColor = true;
            // 
            // sstUser
            // 
            this.sstUser.Location = new System.Drawing.Point(0, 561);
            this.sstUser.Name = "sstUser";
            this.sstUser.Size = new System.Drawing.Size(942, 22);
            this.sstUser.TabIndex = 1;
            this.sstUser.Text = "statusStrip1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(3, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // tlpCentroPenales
            // 
            this.tlpCentroPenales.ColumnCount = 2;
            this.tlpCentroPenales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.03773F));
            this.tlpCentroPenales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.96227F));
            this.tlpCentroPenales.Controls.Add(this.txtTelefono2CentroPenales, 1, 3);
            this.tlpCentroPenales.Controls.Add(this.txtTelefono1CentroPenales, 1, 2);
            this.tlpCentroPenales.Controls.Add(this.txtDireccionCentroPenales, 1, 1);
            this.tlpCentroPenales.Controls.Add(this.lblNombre, 0, 0);
            this.tlpCentroPenales.Controls.Add(this.lblDireccion, 0, 1);
            this.tlpCentroPenales.Controls.Add(this.lblTelefono2, 0, 3);
            this.tlpCentroPenales.Controls.Add(this.lblTelefono1, 0, 2);
            this.tlpCentroPenales.Controls.Add(this.txtNombreCentroPenales, 1, 0);
            this.tlpCentroPenales.Location = new System.Drawing.Point(23, 35);
            this.tlpCentroPenales.Name = "tlpCentroPenales";
            this.tlpCentroPenales.RowCount = 4;
            this.tlpCentroPenales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCentroPenales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCentroPenales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCentroPenales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCentroPenales.Size = new System.Drawing.Size(742, 100);
            this.tlpCentroPenales.TabIndex = 1;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(3, 25);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 15);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.AutoSize = true;
            this.lblTelefono2.Location = new System.Drawing.Point(3, 75);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(66, 15);
            this.lblTelefono2.TabIndex = 2;
            this.lblTelefono2.Text = "Telefono 2";
            // 
            // lblTelefono1
            // 
            this.lblTelefono1.AutoSize = true;
            this.lblTelefono1.Location = new System.Drawing.Point(3, 50);
            this.lblTelefono1.Name = "lblTelefono1";
            this.lblTelefono1.Size = new System.Drawing.Size(65, 15);
            this.lblTelefono1.TabIndex = 3;
            this.lblTelefono1.Text = "Telefono 1";
            // 
            // txtNombreCentroPenales
            // 
            this.txtNombreCentroPenales.Location = new System.Drawing.Point(121, 3);
            this.txtNombreCentroPenales.Name = "txtNombreCentroPenales";
            this.txtNombreCentroPenales.Size = new System.Drawing.Size(317, 22);
            this.txtNombreCentroPenales.TabIndex = 4;
            // 
            // txtDireccionCentroPenales
            // 
            this.txtDireccionCentroPenales.Location = new System.Drawing.Point(121, 28);
            this.txtDireccionCentroPenales.Name = "txtDireccionCentroPenales";
            this.txtDireccionCentroPenales.Size = new System.Drawing.Size(618, 22);
            this.txtDireccionCentroPenales.TabIndex = 5;
            // 
            // txtTelefono1CentroPenales
            // 
            this.txtTelefono1CentroPenales.Location = new System.Drawing.Point(121, 53);
            this.txtTelefono1CentroPenales.Name = "txtTelefono1CentroPenales";
            this.txtTelefono1CentroPenales.Size = new System.Drawing.Size(166, 22);
            this.txtTelefono1CentroPenales.TabIndex = 6;
            // 
            // txtTelefono2CentroPenales
            // 
            this.txtTelefono2CentroPenales.Location = new System.Drawing.Point(121, 78);
            this.txtTelefono2CentroPenales.Name = "txtTelefono2CentroPenales";
            this.txtTelefono2CentroPenales.Size = new System.Drawing.Size(166, 22);
            this.txtTelefono2CentroPenales.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnCancelarCentroPenales, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAceptarCentroPenales, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(340, 141);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(425, 54);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnAceptarCentroPenales
            // 
            this.btnAceptarCentroPenales.Location = new System.Drawing.Point(3, 3);
            this.btnAceptarCentroPenales.Name = "btnAceptarCentroPenales";
            this.btnAceptarCentroPenales.Size = new System.Drawing.Size(118, 38);
            this.btnAceptarCentroPenales.TabIndex = 0;
            this.btnAceptarCentroPenales.Text = "Aceptar";
            this.btnAceptarCentroPenales.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCentroPenales
            // 
            this.btnCancelarCentroPenales.Location = new System.Drawing.Point(215, 3);
            this.btnCancelarCentroPenales.Name = "btnCancelarCentroPenales";
            this.btnCancelarCentroPenales.Size = new System.Drawing.Size(118, 38);
            this.btnCancelarCentroPenales.TabIndex = 1;
            this.btnCancelarCentroPenales.Text = "Cancelar";
            this.btnCancelarCentroPenales.UseVisualStyleBackColor = true;
            // 
            // dgvCentroPenales
            // 
            this.dgvCentroPenales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCentroPenales.Location = new System.Drawing.Point(23, 226);
            this.dgvCentroPenales.Name = "dgvCentroPenales";
            this.dgvCentroPenales.Size = new System.Drawing.Size(874, 276);
            this.dgvCentroPenales.TabIndex = 3;
            // 
            // frmMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 583);
            this.Controls.Add(this.sstUser);
            this.Controls.Add(this.tbp);
            this.Name = "frmMantenimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimientos";
            this.Load += new System.EventHandler(this.frmMantenimientos_Load);
            this.tbp.ResumeLayout(false);
            this.tbpNuevoUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTeclado)).EndInit();
            this.gbRolles.ResumeLayout(false);
            this.tlpRolles.ResumeLayout(false);
            this.tlpRolles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tlpUser.ResumeLayout(false);
            this.tlpUser.PerformLayout();
            this.tbpDelitos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelitos)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tbpCentroPenales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tlpCentroPenales.ResumeLayout(false);
            this.tlpCentroPenales.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCentroPenales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbp;
        private System.Windows.Forms.TabPage tbpNuevoUsuario;
        private System.Windows.Forms.TabPage tbpDelitos;
        private System.Windows.Forms.StatusStrip sstUser;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TableLayoutPanel tlpUser;
        private System.Windows.Forms.Label lblVerificaPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblNuevoUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassV;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbRolles;
        private System.Windows.Forms.TableLayoutPanel tlpRolles;
        private System.Windows.Forms.RadioButton rbReportador;
        private System.Windows.Forms.RadioButton rbOperador;
        private System.Windows.Forms.RadioButton rbAdministrador;
        private System.Windows.Forms.PictureBox pBTeclado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCacelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.RichTextBox rtbDescripcionDelitos;
        private System.Windows.Forms.TabPage tbpCentroPenales;
        private System.Windows.Forms.TabPage tbpSalario;
        private System.Windows.Forms.TabPage tbpEventos;
        private System.Windows.Forms.TabPage tbpReclusos;
        private System.Windows.Forms.DataGridView dgvDelitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridView dgvCentroPenales;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnCancelarCentroPenales;
        private System.Windows.Forms.Button btnAceptarCentroPenales;
        private System.Windows.Forms.TableLayoutPanel tlpCentroPenales;
        private System.Windows.Forms.TextBox txtTelefono2CentroPenales;
        private System.Windows.Forms.TextBox txtTelefono1CentroPenales;
        private System.Windows.Forms.TextBox txtDireccionCentroPenales;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono2;
        private System.Windows.Forms.Label lblTelefono1;
        private System.Windows.Forms.TextBox txtNombreCentroPenales;
    }
}