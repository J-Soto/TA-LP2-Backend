
namespace InterfazDATMA.Administrador
{
    partial class frmInsertarCurso
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
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInscrip = new System.Windows.Forms.DateTimePicker();
            this.textCantSemana = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvReq = new System.Windows.Forms.DataGridView();
            this.IdCursoRequerido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarReq = new System.Windows.Forms.Button();
            this.btnEliminarReq = new System.Windows.Forms.Button();
            this.btnSelaccionarTemas = new System.Windows.Forms.Button();
            this.btnVerGrupos = new System.Windows.Forms.Button();
            this.btnGuardarCurso = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(89, 65);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(177, 29);
            this.lblTutoresUser.TabIndex = 17;
            this.lblTutoresUser.Text = "Nombre Curso:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(62, 285);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(208, 29);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "Fecha Inscripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(140, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(89, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cant. Semanas:";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(272, 69);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(393, 26);
            this.txtNombreCurso.TabIndex = 22;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaInicial.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(272, 127);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(310, 26);
            this.dtpFechaInicial.TabIndex = 23;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaFin.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(272, 183);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(310, 26);
            this.dtpFechaFin.TabIndex = 24;
            // 
            // dtpFechaInscrip
            // 
            this.dtpFechaInscrip.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaInscrip.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaInscrip.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInscrip.Location = new System.Drawing.Point(272, 285);
            this.dtpFechaInscrip.Name = "dtpFechaInscrip";
            this.dtpFechaInscrip.Size = new System.Drawing.Size(310, 26);
            this.dtpFechaInscrip.TabIndex = 25;
            // 
            // textCantSemana
            // 
            this.textCantSemana.Location = new System.Drawing.Point(272, 237);
            this.textCantSemana.Name = "textCantSemana";
            this.textCantSemana.Size = new System.Drawing.Size(94, 26);
            this.textCantSemana.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Requerimientos:";
            // 
            // dgvReq
            // 
            this.dgvReq.AllowUserToAddRows = false;
            this.dgvReq.AllowUserToDeleteRows = false;
            this.dgvReq.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCursoRequerido,
            this.Descripcion});
            this.dgvReq.EnableHeadersVisualStyles = false;
            this.dgvReq.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvReq.Location = new System.Drawing.Point(81, 419);
            this.dgvReq.Name = "dgvReq";
            this.dgvReq.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReq.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReq.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReq.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReq.RowTemplate.Height = 28;
            this.dgvReq.Size = new System.Drawing.Size(756, 357);
            this.dgvReq.TabIndex = 28;
            // 
            // IdCursoRequerido
            // 
            this.IdCursoRequerido.HeaderText = "Id Curso Requerido";
            this.IdCursoRequerido.MinimumWidth = 8;
            this.IdCursoRequerido.Name = "IdCursoRequerido";
            this.IdCursoRequerido.ReadOnly = true;
            this.IdCursoRequerido.Width = 200;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // btnAgregarReq
            // 
            this.btnAgregarReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnAgregarReq.FlatAppearance.BorderSize = 0;
            this.btnAgregarReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregarReq.ForeColor = System.Drawing.Color.White;
            this.btnAgregarReq.Location = new System.Drawing.Point(861, 419);
            this.btnAgregarReq.Name = "btnAgregarReq";
            this.btnAgregarReq.Size = new System.Drawing.Size(50, 45);
            this.btnAgregarReq.TabIndex = 29;
            this.btnAgregarReq.Text = "+";
            this.btnAgregarReq.UseVisualStyleBackColor = false;
            // 
            // btnEliminarReq
            // 
            this.btnEliminarReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnEliminarReq.FlatAppearance.BorderSize = 0;
            this.btnEliminarReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminarReq.ForeColor = System.Drawing.Color.White;
            this.btnEliminarReq.Location = new System.Drawing.Point(861, 485);
            this.btnEliminarReq.Name = "btnEliminarReq";
            this.btnEliminarReq.Size = new System.Drawing.Size(50, 45);
            this.btnEliminarReq.TabIndex = 30;
            this.btnEliminarReq.Text = "-";
            this.btnEliminarReq.UseVisualStyleBackColor = false;
            // 
            // btnSelaccionarTemas
            // 
            this.btnSelaccionarTemas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnSelaccionarTemas.FlatAppearance.BorderSize = 0;
            this.btnSelaccionarTemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelaccionarTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSelaccionarTemas.ForeColor = System.Drawing.Color.White;
            this.btnSelaccionarTemas.Location = new System.Drawing.Point(845, 113);
            this.btnSelaccionarTemas.Name = "btnSelaccionarTemas";
            this.btnSelaccionarTemas.Size = new System.Drawing.Size(269, 55);
            this.btnSelaccionarTemas.TabIndex = 31;
            this.btnSelaccionarTemas.Text = "Seleccionar Temas";
            this.btnSelaccionarTemas.UseVisualStyleBackColor = false;
            this.btnSelaccionarTemas.Click += new System.EventHandler(this.btnSelaccionarTemas_Click);
            // 
            // btnVerGrupos
            // 
            this.btnVerGrupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnVerGrupos.FlatAppearance.BorderSize = 0;
            this.btnVerGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVerGrupos.ForeColor = System.Drawing.Color.White;
            this.btnVerGrupos.Location = new System.Drawing.Point(845, 207);
            this.btnVerGrupos.Name = "btnVerGrupos";
            this.btnVerGrupos.Size = new System.Drawing.Size(269, 55);
            this.btnVerGrupos.TabIndex = 32;
            this.btnVerGrupos.Text = "Ver Grupos";
            this.btnVerGrupos.UseVisualStyleBackColor = false;
            this.btnVerGrupos.Click += new System.EventHandler(this.btnVerGrupos_Click);
            // 
            // btnGuardarCurso
            // 
            this.btnGuardarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnGuardarCurso.FlatAppearance.BorderSize = 0;
            this.btnGuardarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardarCurso.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCurso.Location = new System.Drawing.Point(924, 732);
            this.btnGuardarCurso.Name = "btnGuardarCurso";
            this.btnGuardarCurso.Size = new System.Drawing.Size(269, 44);
            this.btnGuardarCurso.TabIndex = 33;
            this.btnGuardarCurso.Text = "Guardar";
            this.btnGuardarCurso.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(924, 797);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(269, 44);
            this.btnRegresar.TabIndex = 34;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmInsertarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1278, 940);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardarCurso);
            this.Controls.Add(this.btnVerGrupos);
            this.Controls.Add(this.btnSelaccionarTemas);
            this.Controls.Add(this.btnEliminarReq);
            this.Controls.Add(this.btnAgregarReq);
            this.Controls.Add(this.dgvReq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCantSemana);
            this.Controls.Add(this.dtpFechaInscrip);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblTutoresUser);
            this.Name = "frmInsertarCurso";
            this.Text = "frmInsertarCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTutoresUser;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInscrip;
        private System.Windows.Forms.TextBox textCantSemana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCursoRequerido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Button btnAgregarReq;
        private System.Windows.Forms.Button btnEliminarReq;
        private System.Windows.Forms.Button btnSelaccionarTemas;
        private System.Windows.Forms.Button btnVerGrupos;
        private System.Windows.Forms.Button btnGuardarCurso;
        private System.Windows.Forms.Button btnRegresar;
    }
}