
namespace InterfazDATMA
{
    partial class frmCursosDisponibles
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.Modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInscribirse = new System.Windows.Forms.Button();
            this.btnMasInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(265, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Lista de Cursos Disponibles";
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modulo,
            this.FechaIni,
            this.FechaFin,
            this.Encargado});
            this.dgvCursos.EnableHeadersVisualStyles = false;
            this.dgvCursos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCursos.Location = new System.Drawing.Point(56, 93);
            this.dgvCursos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCursos.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCursos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCursos.RowTemplate.Height = 28;
            this.dgvCursos.Size = new System.Drawing.Size(550, 225);
            this.dgvCursos.TabIndex = 19;
            // 
            // Modulo
            // 
            this.Modulo.HeaderText = "Modulo";
            this.Modulo.Name = "Modulo";
            this.Modulo.ReadOnly = true;
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
            // Encargado
            // 
            this.Encargado.HeaderText = "Encargado(a)";
            this.Encargado.Name = "Encargado";
            this.Encargado.ReadOnly = true;
            this.Encargado.Width = 120;
            // 
            // btnInscribirse
            // 
            this.btnInscribirse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnInscribirse.FlatAppearance.BorderSize = 0;
            this.btnInscribirse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribirse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnInscribirse.ForeColor = System.Drawing.Color.White;
            this.btnInscribirse.Location = new System.Drawing.Point(627, 136);
            this.btnInscribirse.Margin = new System.Windows.Forms.Padding(2);
            this.btnInscribirse.Name = "btnInscribirse";
            this.btnInscribirse.Size = new System.Drawing.Size(165, 24);
            this.btnInscribirse.TabIndex = 23;
            this.btnInscribirse.Text = "INSCRIBIRSE";
            this.btnInscribirse.UseVisualStyleBackColor = false;
            this.btnInscribirse.Click += new System.EventHandler(this.btnInscribirse_Click);
            // 
            // btnMasInfo
            // 
            this.btnMasInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnMasInfo.FlatAppearance.BorderSize = 0;
            this.btnMasInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMasInfo.ForeColor = System.Drawing.Color.White;
            this.btnMasInfo.Location = new System.Drawing.Point(627, 224);
            this.btnMasInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnMasInfo.Name = "btnMasInfo";
            this.btnMasInfo.Size = new System.Drawing.Size(165, 24);
            this.btnMasInfo.TabIndex = 24;
            this.btnMasInfo.Text = "VER MÁS INFORMACIÓN";
            this.btnMasInfo.UseVisualStyleBackColor = false;
            this.btnMasInfo.Click += new System.EventHandler(this.btnMasInfo_Click);
            // 
            // frmCursosDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(867, 361);
            this.Controls.Add(this.btnMasInfo);
            this.Controls.Add(this.btnInscribirse);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCursosDisponibles";
            this.Text = "Cursos Disponibles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encargado;
        private System.Windows.Forms.Button btnInscribirse;
        private System.Windows.Forms.Button btnMasInfo;
    }
}