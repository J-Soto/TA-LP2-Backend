
namespace InterfazDATMA
{
    partial class frmMenuUsuario
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
            this.lblMisCursos = new System.Windows.Forms.Label();
            this.lblCalendario = new System.Windows.Forms.Label();
            this.lblTotalCursos = new System.Windows.Forms.Label();
            this.dgvCal = new System.Windows.Forms.DataGridView();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.Modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Psicologa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCursosDisponibles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMisCursos
            // 
            this.lblMisCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisCursos.ForeColor = System.Drawing.Color.White;
            this.lblMisCursos.Location = new System.Drawing.Point(148, 46);
            this.lblMisCursos.Name = "lblMisCursos";
            this.lblMisCursos.Size = new System.Drawing.Size(99, 28);
            this.lblMisCursos.TabIndex = 2;
            this.lblMisCursos.Text = "Mis Cursos";
            // 
            // lblCalendario
            // 
            this.lblCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendario.ForeColor = System.Drawing.Color.White;
            this.lblCalendario.Location = new System.Drawing.Point(148, 236);
            this.lblCalendario.Name = "lblCalendario";
            this.lblCalendario.Size = new System.Drawing.Size(99, 28);
            this.lblCalendario.TabIndex = 4;
            this.lblCalendario.Text = "Calendario";
            // 
            // lblTotalCursos
            // 
            this.lblTotalCursos.AutoSize = true;
            this.lblTotalCursos.ForeColor = System.Drawing.Color.White;
            this.lblTotalCursos.Location = new System.Drawing.Point(644, 96);
            this.lblTotalCursos.Name = "lblTotalCursos";
            this.lblTotalCursos.Size = new System.Drawing.Size(92, 13);
            this.lblTotalCursos.TabIndex = 6;
            this.lblTotalCursos.Text = "Total de cursos: 0";
            // 
            // dgvCal
            // 
            this.dgvCal.AllowUserToAddRows = false;
            this.dgvCal.AllowUserToDeleteRows = false;
            this.dgvCal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvCal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Actividad,
            this.Fecha,
            this.HoraIni,
            this.HoraFin,
            this.Eje});
            this.dgvCal.EnableHeadersVisualStyles = false;
            this.dgvCal.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCal.Location = new System.Drawing.Point(152, 274);
            this.dgvCal.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCal.Name = "dgvCal";
            this.dgvCal.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCal.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCal.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCal.RowTemplate.Height = 28;
            this.dgvCal.Size = new System.Drawing.Size(601, 183);
            this.dgvCal.TabIndex = 22;
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "Actividad";
            this.Actividad.Name = "Actividad";
            this.Actividad.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // HoraIni
            // 
            this.HoraIni.HeaderText = "Hora de Inicio";
            this.HoraIni.Name = "HoraIni";
            this.HoraIni.ReadOnly = true;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora de Fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            // 
            // Eje
            // 
            this.Eje.HeaderText = "Eje";
            this.Eje.Name = "Eje";
            this.Eje.ReadOnly = true;
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modulo,
            this.FechaIni,
            this.FechaFin,
            this.Psicologa});
            this.dgvCursos.EnableHeadersVisualStyles = false;
            this.dgvCursos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCursos.Location = new System.Drawing.Point(152, 76);
            this.dgvCursos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCursos.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCursos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCursos.RowTemplate.Height = 28;
            this.dgvCursos.Size = new System.Drawing.Size(458, 154);
            this.dgvCursos.TabIndex = 23;
            // 
            // Modulo
            // 
            this.Modulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Modulo.HeaderText = "Modulo";
            this.Modulo.Name = "Modulo";
            this.Modulo.ReadOnly = true;
            this.Modulo.Width = 89;
            // 
            // FechaIni
            // 
            this.FechaIni.HeaderText = "Fecha de Inicio";
            this.FechaIni.Name = "FechaIni";
            this.FechaIni.ReadOnly = true;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Fecha de Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // Psicologa
            // 
            this.Psicologa.HeaderText = "Encargado(a)";
            this.Psicologa.Name = "Psicologa";
            this.Psicologa.ReadOnly = true;
            // 
            // btnCursosDisponibles
            // 
            this.btnCursosDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnCursosDisponibles.FlatAppearance.BorderSize = 0;
            this.btnCursosDisponibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCursosDisponibles.ForeColor = System.Drawing.Color.White;
            this.btnCursosDisponibles.Location = new System.Drawing.Point(636, 155);
            this.btnCursosDisponibles.Margin = new System.Windows.Forms.Padding(2);
            this.btnCursosDisponibles.Name = "btnCursosDisponibles";
            this.btnCursosDisponibles.Size = new System.Drawing.Size(117, 40);
            this.btnCursosDisponibles.TabIndex = 24;
            this.btnCursosDisponibles.Text = "VER CURSOS DISPONIBLES";
            this.btnCursosDisponibles.UseVisualStyleBackColor = false;
            this.btnCursosDisponibles.Click += new System.EventHandler(this.btnCursosDisponibles_Click_1);
            // 
            // frmMenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(933, 487);
            this.Controls.Add(this.btnCursosDisponibles);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.dgvCal);
            this.Controls.Add(this.lblTotalCursos);
            this.Controls.Add(this.lblCalendario);
            this.Controls.Add(this.lblMisCursos);
            this.Name = "frmMenuUsuario";
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMisCursos;
        private System.Windows.Forms.Label lblCalendario;
        private System.Windows.Forms.Label lblTotalCursos;
        private System.Windows.Forms.DataGridView dgvCal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eje;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Psicologa;
        private System.Windows.Forms.Button btnCursosDisponibles;
    }
}