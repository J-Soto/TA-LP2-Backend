
namespace InterfazDATMA.Administrador
{
    partial class frmOperacionesCursos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantSemanas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.btnInsertarCurso = new System.Windows.Forms.Button();
            this.btnEliminarCurso = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.FechaInicial,
            this.FechaFinal,
            this.FechaInscripcion,
            this.CantSemanas});
            this.dgvCursos.EnableHeadersVisualStyles = false;
            this.dgvCursos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCursos.Location = new System.Drawing.Point(71, 99);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCursos.RowHeadersWidth = 62;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCursos.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCursos.RowTemplate.Height = 28;
            this.dgvCursos.Size = new System.Drawing.Size(846, 466);
            this.dgvCursos.TabIndex = 19;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // FechaInicial
            // 
            dataGridViewCellStyle14.Format = "d";
            dataGridViewCellStyle14.NullValue = null;
            this.FechaInicial.DefaultCellStyle = dataGridViewCellStyle14;
            this.FechaInicial.HeaderText = "FechaInicial";
            this.FechaInicial.MinimumWidth = 8;
            this.FechaInicial.Name = "FechaInicial";
            this.FechaInicial.ReadOnly = true;
            this.FechaInicial.Width = 150;
            // 
            // FechaFinal
            // 
            dataGridViewCellStyle15.Format = "d";
            dataGridViewCellStyle15.NullValue = null;
            this.FechaFinal.DefaultCellStyle = dataGridViewCellStyle15;
            this.FechaFinal.HeaderText = "Fecha Final";
            this.FechaFinal.MinimumWidth = 8;
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.ReadOnly = true;
            this.FechaFinal.Width = 150;
            // 
            // FechaInscripcion
            // 
            dataGridViewCellStyle16.Format = "d";
            dataGridViewCellStyle16.NullValue = null;
            this.FechaInscripcion.DefaultCellStyle = dataGridViewCellStyle16;
            this.FechaInscripcion.HeaderText = "Fecha Inscripcion";
            this.FechaInscripcion.MinimumWidth = 8;
            this.FechaInscripcion.Name = "FechaInscripcion";
            this.FechaInscripcion.ReadOnly = true;
            this.FechaInscripcion.Width = 150;
            // 
            // CantSemanas
            // 
            this.CantSemanas.HeaderText = "Cant. Semanas";
            this.CantSemanas.MinimumWidth = 8;
            this.CantSemanas.Name = "CantSemanas";
            this.CantSemanas.ReadOnly = true;
            this.CantSemanas.Width = 150;
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(65, 42);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(282, 36);
            this.lblTutoresUser.TabIndex = 20;
            this.lblTutoresUser.Text = "Cursos Disponibles:";
            // 
            // btnInsertarCurso
            // 
            this.btnInsertarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnInsertarCurso.FlatAppearance.BorderSize = 0;
            this.btnInsertarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInsertarCurso.ForeColor = System.Drawing.Color.White;
            this.btnInsertarCurso.Location = new System.Drawing.Point(936, 99);
            this.btnInsertarCurso.Name = "btnInsertarCurso";
            this.btnInsertarCurso.Size = new System.Drawing.Size(168, 45);
            this.btnInsertarCurso.TabIndex = 21;
            this.btnInsertarCurso.Text = "Insertar Curso";
            this.btnInsertarCurso.UseVisualStyleBackColor = false;
            this.btnInsertarCurso.Click += new System.EventHandler(this.btnInsertarCurso_Click);
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnEliminarCurso.FlatAppearance.BorderSize = 0;
            this.btnEliminarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminarCurso.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCurso.Location = new System.Drawing.Point(936, 166);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(168, 45);
            this.btnEliminarCurso.TabIndex = 22;
            this.btnEliminarCurso.Text = "Eliminar Curso";
            this.btnEliminarCurso.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(943, 603);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(161, 39);
            this.btnRegresar.TabIndex = 24;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmOperacionesCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1165, 692);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminarCurso);
            this.Controls.Add(this.btnInsertarCurso);
            this.Controls.Add(this.lblTutoresUser);
            this.Controls.Add(this.dgvCursos);
            this.Name = "frmOperacionesCursos";
            this.Text = "frmOperacionesCursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Label lblTutoresUser;
        private System.Windows.Forms.Button btnInsertarCurso;
        private System.Windows.Forms.Button btnEliminarCurso;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantSemanas;
    }
}