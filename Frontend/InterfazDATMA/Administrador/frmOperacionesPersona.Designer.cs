
namespace InterfazDATMA.Administrador
{
    partial class frmOperacionesPersona
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnListarUsuarios = new System.Windows.Forms.Button();
            this.btnInsertarPsi = new System.Windows.Forms.Button();
            this.btnInsertarTutor = new System.Windows.Forms.Button();
            this.lblTutores = new System.Windows.Forms.Label();
            this.lblPsicologo = new System.Windows.Forms.Label();
            this.btnModificarTutor = new System.Windows.Forms.Button();
            this.btnModificarPsi = new System.Windows.Forms.Button();
            this.dgvTutores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pict = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPsicologos = new System.Windows.Forms.DataGridView();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBusqTutor = new System.Windows.Forms.TextBox();
            this.txtBusqPsi = new System.Windows.Forms.TextBox();
            this.btnBuscarTutor = new System.Windows.Forms.Button();
            this.btnBuscarPsi = new System.Windows.Forms.Button();
            this.btnListarTut = new System.Windows.Forms.Button();
            this.btnListarPsi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnDeshabilitar.FlatAppearance.BorderSize = 0;
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeshabilitar.ForeColor = System.Drawing.Color.White;
            this.btnDeshabilitar.Location = new System.Drawing.Point(595, 398);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(179, 29);
            this.btnDeshabilitar.TabIndex = 8;
            this.btnDeshabilitar.Text = "Deshabilitar Persona";
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            // 
            // btnListarUsuarios
            // 
            this.btnListarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnListarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnListarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnListarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnListarUsuarios.Location = new System.Drawing.Point(28, 398);
            this.btnListarUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarUsuarios.Name = "btnListarUsuarios";
            this.btnListarUsuarios.Size = new System.Drawing.Size(179, 29);
            this.btnListarUsuarios.TabIndex = 9;
            this.btnListarUsuarios.Text = "Listar Usuarios";
            this.btnListarUsuarios.UseVisualStyleBackColor = false;
            this.btnListarUsuarios.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnInsertarPsi
            // 
            this.btnInsertarPsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnInsertarPsi.FlatAppearance.BorderSize = 0;
            this.btnInsertarPsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarPsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnInsertarPsi.ForeColor = System.Drawing.Color.White;
            this.btnInsertarPsi.Location = new System.Drawing.Point(657, 248);
            this.btnInsertarPsi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertarPsi.Name = "btnInsertarPsi";
            this.btnInsertarPsi.Size = new System.Drawing.Size(117, 29);
            this.btnInsertarPsi.TabIndex = 12;
            this.btnInsertarPsi.Text = "Insertar Psicólogo";
            this.btnInsertarPsi.UseVisualStyleBackColor = false;
            this.btnInsertarPsi.Click += new System.EventHandler(this.btnInsertarPsi_Click);
            // 
            // btnInsertarTutor
            // 
            this.btnInsertarTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnInsertarTutor.FlatAppearance.BorderSize = 0;
            this.btnInsertarTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnInsertarTutor.ForeColor = System.Drawing.Color.White;
            this.btnInsertarTutor.Location = new System.Drawing.Point(657, 57);
            this.btnInsertarTutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertarTutor.Name = "btnInsertarTutor";
            this.btnInsertarTutor.Size = new System.Drawing.Size(117, 29);
            this.btnInsertarTutor.TabIndex = 13;
            this.btnInsertarTutor.Text = "Insertar Tutor";
            this.btnInsertarTutor.UseVisualStyleBackColor = false;
            this.btnInsertarTutor.Click += new System.EventHandler(this.btnInsertarTutor_Click);
            // 
            // lblTutores
            // 
            this.lblTutores.AutoSize = true;
            this.lblTutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTutores.ForeColor = System.Drawing.Color.White;
            this.lblTutores.Location = new System.Drawing.Point(25, 26);
            this.lblTutores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTutores.Name = "lblTutores";
            this.lblTutores.Size = new System.Drawing.Size(57, 17);
            this.lblTutores.TabIndex = 14;
            this.lblTutores.Text = "Tutores";
            // 
            // lblPsicologo
            // 
            this.lblPsicologo.AutoSize = true;
            this.lblPsicologo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPsicologo.ForeColor = System.Drawing.Color.White;
            this.lblPsicologo.Location = new System.Drawing.Point(25, 220);
            this.lblPsicologo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPsicologo.Name = "lblPsicologo";
            this.lblPsicologo.Size = new System.Drawing.Size(76, 17);
            this.lblPsicologo.TabIndex = 18;
            this.lblPsicologo.Text = "Psicólogos";
            // 
            // btnModificarTutor
            // 
            this.btnModificarTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnModificarTutor.FlatAppearance.BorderSize = 0;
            this.btnModificarTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnModificarTutor.ForeColor = System.Drawing.Color.White;
            this.btnModificarTutor.Location = new System.Drawing.Point(657, 102);
            this.btnModificarTutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarTutor.Name = "btnModificarTutor";
            this.btnModificarTutor.Size = new System.Drawing.Size(117, 29);
            this.btnModificarTutor.TabIndex = 17;
            this.btnModificarTutor.Text = "Modificar Tutor";
            this.btnModificarTutor.UseVisualStyleBackColor = false;
            this.btnModificarTutor.Click += new System.EventHandler(this.btnModificarTutor_Click);
            // 
            // btnModificarPsi
            // 
            this.btnModificarPsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnModificarPsi.FlatAppearance.BorderSize = 0;
            this.btnModificarPsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnModificarPsi.ForeColor = System.Drawing.Color.White;
            this.btnModificarPsi.Location = new System.Drawing.Point(657, 293);
            this.btnModificarPsi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarPsi.Name = "btnModificarPsi";
            this.btnModificarPsi.Size = new System.Drawing.Size(117, 29);
            this.btnModificarPsi.TabIndex = 16;
            this.btnModificarPsi.Text = "Modificar Psicólogo";
            this.btnModificarPsi.UseVisualStyleBackColor = false;
            this.btnModificarPsi.Click += new System.EventHandler(this.btnModificarPsi_Click);
            // 
            // dgvTutores
            // 
            this.dgvTutores.AllowUserToAddRows = false;
            this.dgvTutores.AllowUserToDeleteRows = false;
            this.dgvTutores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvTutores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTutores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.pict,
            this.dataGridViewTextBoxColumn2});
            this.dgvTutores.EnableHeadersVisualStyles = false;
            this.dgvTutores.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTutores.Location = new System.Drawing.Point(28, 57);
            this.dgvTutores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTutores.Name = "dgvTutores";
            this.dgvTutores.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTutores.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTutores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTutores.RowTemplate.Height = 28;
            this.dgvTutores.Size = new System.Drawing.Size(623, 138);
            this.dgvTutores.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre Completo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // pict
            // 
            this.pict.HeaderText = "Foto";
            this.pict.MinimumWidth = 8;
            this.pict.Name = "pict";
            this.pict.ReadOnly = true;
            this.pict.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Activo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dgvPsicologos
            // 
            this.dgvPsicologos.AllowUserToAddRows = false;
            this.dgvPsicologos.AllowUserToDeleteRows = false;
            this.dgvPsicologos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPsicologos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPsicologos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPsicologos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPsicologos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPsicologos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCompleto,
            this.dataGridViewImageColumn1,
            this.Activo});
            this.dgvPsicologos.EnableHeadersVisualStyles = false;
            this.dgvPsicologos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPsicologos.Location = new System.Drawing.Point(28, 248);
            this.dgvPsicologos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPsicologos.Name = "dgvPsicologos";
            this.dgvPsicologos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPsicologos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPsicologos.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPsicologos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPsicologos.RowTemplate.Height = 28;
            this.dgvPsicologos.Size = new System.Drawing.Size(623, 138);
            this.dgvPsicologos.TabIndex = 20;
            this.dgvPsicologos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPsicologos_CellFormatting);
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.MinimumWidth = 8;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 150;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Foto";
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 8;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 150;
            // 
            // txtBusqTutor
            // 
            this.txtBusqTutor.Location = new System.Drawing.Point(362, 25);
            this.txtBusqTutor.Name = "txtBusqTutor";
            this.txtBusqTutor.Size = new System.Drawing.Size(289, 20);
            this.txtBusqTutor.TabIndex = 21;
            this.txtBusqTutor.Text = "Nombres y Apellidos";
            this.txtBusqTutor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBusqTutor_MouseClick);
            // 
            // txtBusqPsi
            // 
            this.txtBusqPsi.Location = new System.Drawing.Point(362, 219);
            this.txtBusqPsi.Name = "txtBusqPsi";
            this.txtBusqPsi.Size = new System.Drawing.Size(289, 20);
            this.txtBusqPsi.TabIndex = 22;
            this.txtBusqPsi.Text = "Nombres y Apellidos";
            this.txtBusqPsi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBusqPsi_MouseClick);
            // 
            // btnBuscarTutor
            // 
            this.btnBuscarTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnBuscarTutor.FlatAppearance.BorderSize = 0;
            this.btnBuscarTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBuscarTutor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarTutor.Location = new System.Drawing.Point(657, 25);
            this.btnBuscarTutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarTutor.Name = "btnBuscarTutor";
            this.btnBuscarTutor.Size = new System.Drawing.Size(117, 20);
            this.btnBuscarTutor.TabIndex = 23;
            this.btnBuscarTutor.Text = "Buscar";
            this.btnBuscarTutor.UseVisualStyleBackColor = false;
            this.btnBuscarTutor.Click += new System.EventHandler(this.btnBuscarTutor_Click);
            // 
            // btnBuscarPsi
            // 
            this.btnBuscarPsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnBuscarPsi.FlatAppearance.BorderSize = 0;
            this.btnBuscarPsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBuscarPsi.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPsi.Location = new System.Drawing.Point(657, 220);
            this.btnBuscarPsi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarPsi.Name = "btnBuscarPsi";
            this.btnBuscarPsi.Size = new System.Drawing.Size(117, 20);
            this.btnBuscarPsi.TabIndex = 24;
            this.btnBuscarPsi.Text = "Buscar";
            this.btnBuscarPsi.UseVisualStyleBackColor = false;
            this.btnBuscarPsi.Click += new System.EventHandler(this.btnBuscarPsi_Click);
            // 
            // btnListarTut
            // 
            this.btnListarTut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnListarTut.FlatAppearance.BorderSize = 0;
            this.btnListarTut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarTut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnListarTut.ForeColor = System.Drawing.Color.White;
            this.btnListarTut.Location = new System.Drawing.Point(218, 398);
            this.btnListarTut.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarTut.Name = "btnListarTut";
            this.btnListarTut.Size = new System.Drawing.Size(179, 29);
            this.btnListarTut.TabIndex = 25;
            this.btnListarTut.Text = "Listar Tutores";
            this.btnListarTut.UseVisualStyleBackColor = false;
            // 
            // btnListarPsi
            // 
            this.btnListarPsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnListarPsi.FlatAppearance.BorderSize = 0;
            this.btnListarPsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnListarPsi.ForeColor = System.Drawing.Color.White;
            this.btnListarPsi.Location = new System.Drawing.Point(407, 398);
            this.btnListarPsi.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarPsi.Name = "btnListarPsi";
            this.btnListarPsi.Size = new System.Drawing.Size(179, 29);
            this.btnListarPsi.TabIndex = 26;
            this.btnListarPsi.Text = "Listar Psicologos";
            this.btnListarPsi.UseVisualStyleBackColor = false;
            this.btnListarPsi.Click += new System.EventHandler(this.btnListarPsi_Click);
            // 
            // frmOperacionesPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarPsi);
            this.Controls.Add(this.btnListarTut);
            this.Controls.Add(this.btnBuscarPsi);
            this.Controls.Add(this.btnBuscarTutor);
            this.Controls.Add(this.txtBusqPsi);
            this.Controls.Add(this.txtBusqTutor);
            this.Controls.Add(this.dgvPsicologos);
            this.Controls.Add(this.dgvTutores);
            this.Controls.Add(this.lblPsicologo);
            this.Controls.Add(this.btnModificarTutor);
            this.Controls.Add(this.btnModificarPsi);
            this.Controls.Add(this.lblTutores);
            this.Controls.Add(this.btnInsertarTutor);
            this.Controls.Add(this.btnInsertarPsi);
            this.Controls.Add(this.btnListarUsuarios);
            this.Controls.Add(this.btnDeshabilitar);
            this.Name = "frmOperacionesPersona";
            this.Text = "Operaciones Persona";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnListarUsuarios;
        private System.Windows.Forms.Button btnInsertarPsi;
        private System.Windows.Forms.Button btnInsertarTutor;
        private System.Windows.Forms.Label lblTutores;
        private System.Windows.Forms.Label lblPsicologo;
        private System.Windows.Forms.Button btnModificarTutor;
        private System.Windows.Forms.Button btnModificarPsi;
        private System.Windows.Forms.DataGridView dgvTutores;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn pict;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgvPsicologos;
        private System.Windows.Forms.TextBox txtBusqTutor;
        private System.Windows.Forms.TextBox txtBusqPsi;
        private System.Windows.Forms.Button btnBuscarTutor;
        private System.Windows.Forms.Button btnBuscarPsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.Button btnListarTut;
        private System.Windows.Forms.Button btnListarPsi;
    }
}