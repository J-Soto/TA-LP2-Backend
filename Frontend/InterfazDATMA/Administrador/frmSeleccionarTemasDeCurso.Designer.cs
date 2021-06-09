
namespace InterfazDATMA.Administrador
{
    partial class frmSeleccionarTemasDeCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTema = new System.Windows.Forms.ComboBox();
            this.dgvTemas = new System.Windows.Forms.DataGridView();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarTema = new System.Windows.Forms.Button();
            this.btnQuitarTema = new System.Windows.Forms.Button();
            this.btnCrearTema = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaInicial.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(266, 75);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(310, 26);
            this.dtpFechaInicial.TabIndex = 11;
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(96, 72);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(154, 29);
            this.lblTutoresUser.TabIndex = 13;
            this.lblTutoresUser.Text = "Fecha Inicial:";
            this.lblTutoresUser.Click += new System.EventHandler(this.lblTutoresUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha de Fin:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaFin.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(266, 133);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(310, 26);
            this.dtpFechaFin.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(168, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tema:";
            // 
            // cbTema
            // 
            this.cbTema.FormattingEnabled = true;
            this.cbTema.Location = new System.Drawing.Point(265, 188);
            this.cbTema.Name = "cbTema";
            this.cbTema.Size = new System.Drawing.Size(363, 28);
            this.cbTema.TabIndex = 17;
            // 
            // dgvTemas
            // 
            this.dgvTemas.AllowUserToAddRows = false;
            this.dgvTemas.AllowUserToDeleteRows = false;
            this.dgvTemas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvTemas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTemas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTemas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCompleto,
            this.Descripcion,
            this.FechaInicio,
            this.FechaFin});
            this.dgvTemas.EnableHeadersVisualStyles = false;
            this.dgvTemas.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTemas.Location = new System.Drawing.Point(95, 239);
            this.dgvTemas.Name = "dgvTemas";
            this.dgvTemas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTemas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTemas.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTemas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTemas.RowTemplate.Height = 28;
            this.dgvTemas.Size = new System.Drawing.Size(770, 339);
            this.dgvTemas.TabIndex = 18;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Tema";
            this.NombreCompleto.MinimumWidth = 8;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 200;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // FechaInicio
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.FechaInicio.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.MinimumWidth = 8;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 150;
            // 
            // FechaFin
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.FechaFin.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.MinimumWidth = 8;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 150;
            // 
            // btnAgregarTema
            // 
            this.btnAgregarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnAgregarTema.FlatAppearance.BorderSize = 0;
            this.btnAgregarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregarTema.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTema.Location = new System.Drawing.Point(889, 239);
            this.btnAgregarTema.Name = "btnAgregarTema";
            this.btnAgregarTema.Size = new System.Drawing.Size(50, 45);
            this.btnAgregarTema.TabIndex = 19;
            this.btnAgregarTema.Text = "+";
            this.btnAgregarTema.UseVisualStyleBackColor = false;
            // 
            // btnQuitarTema
            // 
            this.btnQuitarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnQuitarTema.FlatAppearance.BorderSize = 0;
            this.btnQuitarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnQuitarTema.ForeColor = System.Drawing.Color.White;
            this.btnQuitarTema.Location = new System.Drawing.Point(889, 302);
            this.btnQuitarTema.Name = "btnQuitarTema";
            this.btnQuitarTema.Size = new System.Drawing.Size(50, 45);
            this.btnQuitarTema.TabIndex = 20;
            this.btnQuitarTema.Text = "-";
            this.btnQuitarTema.UseVisualStyleBackColor = false;
            // 
            // btnCrearTema
            // 
            this.btnCrearTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnCrearTema.FlatAppearance.BorderSize = 0;
            this.btnCrearTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCrearTema.ForeColor = System.Drawing.Color.White;
            this.btnCrearTema.Location = new System.Drawing.Point(662, 184);
            this.btnCrearTema.Name = "btnCrearTema";
            this.btnCrearTema.Size = new System.Drawing.Size(161, 32);
            this.btnCrearTema.TabIndex = 21;
            this.btnCrearTema.Text = "Crear Tema";
            this.btnCrearTema.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(867, 584);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(161, 39);
            this.btnRegresar.TabIndex = 22;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            // 
            // frmSeleccionarTemasDeCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1054, 644);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCrearTema);
            this.Controls.Add(this.btnQuitarTema);
            this.Controls.Add(this.btnAgregarTema);
            this.Controls.Add(this.dgvTemas);
            this.Controls.Add(this.cbTema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTutoresUser);
            this.Controls.Add(this.dtpFechaInicial);
            this.Name = "frmSeleccionarTemasDeCurso";
            this.Text = "Seleccionar Temas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label lblTutoresUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTema;
        private System.Windows.Forms.DataGridView dgvTemas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.Button btnAgregarTema;
        private System.Windows.Forms.Button btnQuitarTema;
        private System.Windows.Forms.Button btnCrearTema;
        private System.Windows.Forms.Button btnRegresar;
    }
}