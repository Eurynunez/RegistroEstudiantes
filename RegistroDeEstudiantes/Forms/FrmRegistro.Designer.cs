
namespace RegistroDeEstudiantes
{
    partial class FrmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GbDatos = new System.Windows.Forms.GroupBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.GbFiltrado = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtFiltradoEstudiante = new System.Windows.Forms.TextBox();
            this.LblFiltradoCodigo = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Label();
            this.BtnDeseleccionar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstudiantes)).BeginInit();
            this.GbDatos.SuspendLayout();
            this.GbFiltrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvEstudiantes
            // 
            this.DgvEstudiantes.AllowUserToAddRows = false;
            this.DgvEstudiantes.AllowUserToDeleteRows = false;
            this.DgvEstudiantes.AllowUserToResizeRows = false;
            this.DgvEstudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstudiantes.Location = new System.Drawing.Point(12, 419);
            this.DgvEstudiantes.MultiSelect = false;
            this.DgvEstudiantes.Name = "DgvEstudiantes";
            this.DgvEstudiantes.ReadOnly = true;
            this.DgvEstudiantes.RowHeadersWidth = 82;
            this.DgvEstudiantes.RowTemplate.Height = 41;
            this.DgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEstudiantes.Size = new System.Drawing.Size(1361, 557);
            this.DgvEstudiantes.TabIndex = 0;
            this.DgvEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEstudiantes_CellClick);
            // 
            // GbDatos
            // 
            this.GbDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GbDatos.Controls.Add(this.TxtDireccion);
            this.GbDatos.Controls.Add(this.TxtApellido);
            this.GbDatos.Controls.Add(this.TxtNombre);
            this.GbDatos.Controls.Add(this.TxtCodigo);
            this.GbDatos.Controls.Add(this.LblDireccion);
            this.GbDatos.Controls.Add(this.LblApellido);
            this.GbDatos.Controls.Add(this.LblCodigo);
            this.GbDatos.Controls.Add(this.LblNombre);
            this.GbDatos.Font = new System.Drawing.Font("Microsoft JhengHei", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GbDatos.Location = new System.Drawing.Point(12, 160);
            this.GbDatos.Name = "GbDatos";
            this.GbDatos.Size = new System.Drawing.Size(1361, 194);
            this.GbDatos.TabIndex = 1;
            this.GbDatos.TabStop = false;
            this.GbDatos.Text = "🎓";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.Color.White;
            this.TxtDireccion.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtDireccion.Location = new System.Drawing.Point(926, 123);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(352, 32);
            this.TxtDireccion.TabIndex = 7;
            this.TxtDireccion.Enter += new System.EventHandler(this.TxtDireccion_Enter);
            this.TxtDireccion.Leave += new System.EventHandler(this.TxtDireccion_Leave);
            // 
            // TxtApellido
            // 
            this.TxtApellido.BackColor = System.Drawing.Color.White;
            this.TxtApellido.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtApellido.Location = new System.Drawing.Point(926, 58);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(352, 32);
            this.TxtApellido.TabIndex = 6;
            this.TxtApellido.Enter += new System.EventHandler(this.TxtApellido_Enter);
            this.TxtApellido.Leave += new System.EventHandler(this.TxtApellido_Leave);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.White;
            this.TxtNombre.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtNombre.Location = new System.Drawing.Point(169, 123);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(352, 32);
            this.TxtNombre.TabIndex = 5;
            this.TxtNombre.Enter += new System.EventHandler(this.TxtNombre_Enter);
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.Color.White;
            this.TxtCodigo.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtCodigo.Location = new System.Drawing.Point(169, 58);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(352, 32);
            this.TxtCodigo.TabIndex = 4;
            this.TxtCodigo.Enter += new System.EventHandler(this.TxtCodigo_Enter);
            this.TxtCodigo.Leave += new System.EventHandler(this.TxtCodigo_Leave);
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDireccion.Location = new System.Drawing.Point(796, 126);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(124, 24);
            this.LblDireccion.TabIndex = 3;
            this.LblDireccion.Text = "DIRECCIÓN";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblApellido.Location = new System.Drawing.Point(805, 61);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(115, 24);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "APELLIDO";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCodigo.Location = new System.Drawing.Point(70, 61);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(93, 24);
            this.LblCodigo.TabIndex = 1;
            this.LblCodigo.Text = "CODIGO";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNombre.Location = new System.Drawing.Point(62, 126);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(101, 24);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "NOMBRE";
            // 
            // GbFiltrado
            // 
            this.GbFiltrado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbFiltrado.Controls.Add(this.BtnBuscar);
            this.GbFiltrado.Controls.Add(this.TxtFiltradoEstudiante);
            this.GbFiltrado.Controls.Add(this.LblFiltradoCodigo);
            this.GbFiltrado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GbFiltrado.Location = new System.Drawing.Point(12, 12);
            this.GbFiltrado.Name = "GbFiltrado";
            this.GbFiltrado.Size = new System.Drawing.Size(1361, 142);
            this.GbFiltrado.TabIndex = 2;
            this.GbFiltrado.TabStop = false;
            this.GbFiltrado.Text = "🔎";
            this.GbFiltrado.Enter += new System.EventHandler(this.GbFiltrado_Enter);
            this.GbFiltrado.Leave += new System.EventHandler(this.GbFiltrado_Leave);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscar.Location = new System.Drawing.Point(527, 43);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(150, 32);
            this.BtnBuscar.TabIndex = 6;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtFiltradoEstudiante
            // 
            this.TxtFiltradoEstudiante.BackColor = System.Drawing.Color.White;
            this.TxtFiltradoEstudiante.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtFiltradoEstudiante.Location = new System.Drawing.Point(169, 43);
            this.TxtFiltradoEstudiante.Name = "TxtFiltradoEstudiante";
            this.TxtFiltradoEstudiante.PlaceholderText = "🔎 Search";
            this.TxtFiltradoEstudiante.Size = new System.Drawing.Size(352, 32);
            this.TxtFiltradoEstudiante.TabIndex = 5;
            // 
            // LblFiltradoCodigo
            // 
            this.LblFiltradoCodigo.AutoSize = true;
            this.LblFiltradoCodigo.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFiltradoCodigo.Location = new System.Drawing.Point(70, 46);
            this.LblFiltradoCodigo.Name = "LblFiltradoCodigo";
            this.LblFiltradoCodigo.Size = new System.Drawing.Size(93, 24);
            this.LblFiltradoCodigo.TabIndex = 2;
            this.LblFiltradoCodigo.Text = "CODIGO";
            // 
            // BtnModificar
            // 
            this.BtnModificar.AutoSize = true;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.Enabled = false;
            this.BtnModificar.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnModificar.Location = new System.Drawing.Point(181, 357);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(64, 44);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "🛠";
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            this.BtnModificar.MouseEnter += new System.EventHandler(this.BtnModificar_MouseEnter);
            this.BtnModificar.MouseLeave += new System.EventHandler(this.BtnModificar_MouseLeave);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminar.Location = new System.Drawing.Point(251, 357);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(64, 44);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "🗑️";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            this.BtnEliminar.MouseEnter += new System.EventHandler(this.BtnEliminar_MouseEnter);
            this.BtnEliminar.MouseLeave += new System.EventHandler(this.BtnEliminar_MouseLeave);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.AutoSize = true;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregar.Location = new System.Drawing.Point(18, 357);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(64, 44);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "➕";
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            this.BtnAgregar.MouseEnter += new System.EventHandler(this.BtnAgregar_MouseEnter);
            this.BtnAgregar.MouseLeave += new System.EventHandler(this.BtnAgregar_MouseLeave);
            // 
            // BtnDeseleccionar
            // 
            this.BtnDeseleccionar.AutoSize = true;
            this.BtnDeseleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeseleccionar.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeseleccionar.Location = new System.Drawing.Point(88, 357);
            this.BtnDeseleccionar.Name = "BtnDeseleccionar";
            this.BtnDeseleccionar.Size = new System.Drawing.Size(64, 44);
            this.BtnDeseleccionar.TabIndex = 6;
            this.BtnDeseleccionar.Text = "➖";
            this.BtnDeseleccionar.Visible = false;
            this.BtnDeseleccionar.Click += new System.EventHandler(this.BtnDeseleccionar_Click);
            this.BtnDeseleccionar.MouseEnter += new System.EventHandler(this.BtnDeseleccionar_MouseEnter);
            this.BtnDeseleccionar.MouseLeave += new System.EventHandler(this.BtnDeseleccionar_MouseLeave);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1385, 991);
            this.Controls.Add(this.BtnDeseleccionar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.GbFiltrado);
            this.Controls.Add(this.GbDatos);
            this.Controls.Add(this.DgvEstudiantes);
            this.Name = "FrmRegistro";
            this.Text = "Registro de estudiantes";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstudiantes)).EndInit();
            this.GbDatos.ResumeLayout(false);
            this.GbDatos.PerformLayout();
            this.GbFiltrado.ResumeLayout(false);
            this.GbFiltrado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEstudiantes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox GbDatos;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox GbFiltrado;
        private System.Windows.Forms.TextBox TxtFiltradoEstudiante;
        private System.Windows.Forms.Label LblFiltradoCodigo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label BtnModificar;
        private System.Windows.Forms.Label BtnEliminar;
        private System.Windows.Forms.Label BtnAgregar;
        private System.Windows.Forms.Label BtnDeseleccionar;
    }
}

