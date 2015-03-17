﻿namespace UTN.Winform.AppProyectopg3.Layers.UI
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sstUser = new System.Windows.Forms.StatusStrip();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbp.SuspendLayout();
            this.tbpNuevoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBTeclado)).BeginInit();
            this.gbRolles.SuspendLayout();
            this.tlpRolles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tbp
            // 
            this.tbp.Controls.Add(this.tbpNuevoUsuario);
            this.tbp.Controls.Add(this.tabPage2);
            this.tbp.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbp.Location = new System.Drawing.Point(0, 0);
            this.tbp.Name = "tbp";
            this.tbp.SelectedIndex = 0;
            this.tbp.Size = new System.Drawing.Size(931, 558);
            this.tbp.TabIndex = 0;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sstUser
            // 
            this.sstUser.Location = new System.Drawing.Point(0, 561);
            this.sstUser.Name = "sstUser";
            this.sstUser.Size = new System.Drawing.Size(943, 22);
            this.sstUser.TabIndex = 1;
            this.sstUser.Text = "statusStrip1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // frmMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 583);
            this.Controls.Add(this.sstUser);
            this.Controls.Add(this.tbp);
            this.Name = "frmMantenimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimientos";
            this.Load += new System.EventHandler(this.frmMantenimientos_Load);
            this.tbp.ResumeLayout(false);
            this.tbpNuevoUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBTeclado)).EndInit();
            this.gbRolles.ResumeLayout(false);
            this.tlpRolles.ResumeLayout(false);
            this.tlpRolles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tlpUser.ResumeLayout(false);
            this.tlpUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbp;
        private System.Windows.Forms.TabPage tbpNuevoUsuario;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}