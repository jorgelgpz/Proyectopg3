namespace UTN.Winform.AppProyectopg3.Layers.UI
{
    partial class frmEventosReclusos
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
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.dgvEventosReclusos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblEventos = new System.Windows.Forms.Label();
            this.lblEventosdeReclusos = new System.Windows.Forms.Label();
            this.IDR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionRecluso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoRecluso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventosReclusos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.Tipo});
            this.dgvEventos.Location = new System.Drawing.Point(12, 37);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.Size = new System.Drawing.Size(447, 414);
            this.dgvEventos.TabIndex = 0;
            this.dgvEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellClick);
            // 
            // dgvEventosReclusos
            // 
            this.dgvEventosReclusos.AllowUserToAddRows = false;
            this.dgvEventosReclusos.AllowUserToDeleteRows = false;
            this.dgvEventosReclusos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventosReclusos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDR,
            this.DescripcionRecluso,
            this.TipoRecluso});
            this.dgvEventosReclusos.Location = new System.Drawing.Point(633, 37);
            this.dgvEventosReclusos.Name = "dgvEventosReclusos";
            this.dgvEventosReclusos.ReadOnly = true;
            this.dgvEventosReclusos.Size = new System.Drawing.Size(447, 414);
            this.dgvEventosReclusos.TabIndex = 1;
            this.dgvEventosReclusos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventosReclusos_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(484, 166);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(127, 49);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar >>";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(484, 274);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(127, 49);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar <<";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.Location = new System.Drawing.Point(198, 21);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(46, 13);
            this.lblEventos.TabIndex = 4;
            this.lblEventos.Text = "Eventos";
            // 
            // lblEventosdeReclusos
            // 
            this.lblEventosdeReclusos.AutoSize = true;
            this.lblEventosdeReclusos.Location = new System.Drawing.Point(828, 21);
            this.lblEventosdeReclusos.Name = "lblEventosdeReclusos";
            this.lblEventosdeReclusos.Size = new System.Drawing.Size(103, 13);
            this.lblEventosdeReclusos.TabIndex = 5;
            this.lblEventosdeReclusos.Text = "Eventos de Recluso";
            // 
            // IDR
            // 
            this.IDR.DataPropertyName = "ID";
            this.IDR.HeaderText = "ID";
            this.IDR.Name = "IDR";
            this.IDR.ReadOnly = true;
            this.IDR.Visible = false;
            // 
            // DescripcionRecluso
            // 
            this.DescripcionRecluso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescripcionRecluso.DataPropertyName = "Descripcion";
            this.DescripcionRecluso.HeaderText = "Descripcion";
            this.DescripcionRecluso.Name = "DescripcionRecluso";
            this.DescripcionRecluso.ReadOnly = true;
            // 
            // TipoRecluso
            // 
            this.TipoRecluso.DataPropertyName = "Tipo";
            this.TipoRecluso.HeaderText = "Tipo";
            this.TipoRecluso.Name = "TipoRecluso";
            this.TipoRecluso.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // frmEventosReclusos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 480);
            this.Controls.Add(this.lblEventosdeReclusos);
            this.Controls.Add(this.lblEventos);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvEventosReclusos);
            this.Controls.Add(this.dgvEventos);
            this.Name = "frmEventosReclusos";
            this.Text = "Eventos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEventosReclusos_FormClosing);
            this.Load += new System.EventHandler(this.frmEventosReclusos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventosReclusos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.DataGridView dgvEventosReclusos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblEventos;
        private System.Windows.Forms.Label lblEventosdeReclusos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionRecluso;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoRecluso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}