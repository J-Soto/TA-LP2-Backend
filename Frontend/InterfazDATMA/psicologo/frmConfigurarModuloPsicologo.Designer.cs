
namespace InterfaceDATMA
{
    partial class frmConfigurarModuloPsicologo
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
            this.lblNombreModulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarPrograma = new System.Windows.Forms.Button();
            this.btnListaCuidadores = new System.Windows.Forms.Button();
            this.btnListaCursos = new System.Windows.Forms.Button();
            this.dgvPrograma = new System.Windows.Forms.DataGridView();
            this.Semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograma)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreModulo
            // 
            this.lblNombreModulo.AutoSize = true;
            this.lblNombreModulo.Font = new System.Drawing.Font("Montserrat", 20F);
            this.lblNombreModulo.ForeColor = System.Drawing.Color.White;
            this.lblNombreModulo.Location = new System.Drawing.Point(133, 24);
            this.lblNombreModulo.Name = "lblNombreModulo";
            this.lblNombreModulo.Size = new System.Drawing.Size(203, 49);
            this.lblNombreModulo.TabIndex = 0;
            this.lblNombreModulo.Text = "Modulo 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 17F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(220, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Programa:";
            // 
            // btnModificarPrograma
            // 
            this.btnModificarPrograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnModificarPrograma.FlatAppearance.BorderSize = 0;
            this.btnModificarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPrograma.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnModificarPrograma.ForeColor = System.Drawing.Color.White;
            this.btnModificarPrograma.Location = new System.Drawing.Point(715, 707);
            this.btnModificarPrograma.Name = "btnModificarPrograma";
            this.btnModificarPrograma.Size = new System.Drawing.Size(313, 44);
            this.btnModificarPrograma.TabIndex = 3;
            this.btnModificarPrograma.Text = "Modificar Semana";
            this.btnModificarPrograma.UseVisualStyleBackColor = false;
            this.btnModificarPrograma.Click += new System.EventHandler(this.btnModificarPrograma_Click);
            // 
            // btnListaCuidadores
            // 
            this.btnListaCuidadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnListaCuidadores.FlatAppearance.BorderSize = 0;
            this.btnListaCuidadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaCuidadores.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnListaCuidadores.ForeColor = System.Drawing.Color.White;
            this.btnListaCuidadores.Location = new System.Drawing.Point(715, 140);
            this.btnListaCuidadores.Name = "btnListaCuidadores";
            this.btnListaCuidadores.Size = new System.Drawing.Size(313, 44);
            this.btnListaCuidadores.TabIndex = 4;
            this.btnListaCuidadores.Text = "Lista de Cuidadores";
            this.btnListaCuidadores.UseVisualStyleBackColor = false;
            this.btnListaCuidadores.Click += new System.EventHandler(this.btnListaCuidadores_Click);
            // 
            // btnListaCursos
            // 
            this.btnListaCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnListaCursos.FlatAppearance.BorderSize = 0;
            this.btnListaCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaCursos.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnListaCursos.ForeColor = System.Drawing.Color.White;
            this.btnListaCursos.Location = new System.Drawing.Point(805, 829);
            this.btnListaCursos.Name = "btnListaCursos";
            this.btnListaCursos.Size = new System.Drawing.Size(370, 44);
            this.btnListaCursos.TabIndex = 5;
            this.btnListaCursos.Text = "Volver a la lista de modulos";
            this.btnListaCursos.UseVisualStyleBackColor = false;
            this.btnListaCursos.Click += new System.EventHandler(this.btnListaCursos_Click);
            // 
            // dgvPrograma
            // 
            this.dgvPrograma.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPrograma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrograma.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrograma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrograma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Semana,
            this.Tema});
            this.dgvPrograma.EnableHeadersVisualStyles = false;
            this.dgvPrograma.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPrograma.Location = new System.Drawing.Point(227, 202);
            this.dgvPrograma.Name = "dgvPrograma";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrograma.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrograma.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPrograma.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrograma.RowTemplate.Height = 28;
            this.dgvPrograma.Size = new System.Drawing.Size(801, 484);
            this.dgvPrograma.TabIndex = 9;
            // 
            // Semana
            // 
            this.Semana.HeaderText = "Semana";
            this.Semana.MinimumWidth = 8;
            this.Semana.Name = "Semana";
            this.Semana.Width = 150;
            // 
            // Tema
            // 
            this.Tema.HeaderText = "Tema";
            this.Tema.MinimumWidth = 8;
            this.Tema.Name = "Tema";
            this.Tema.Width = 290;
            // 
            // frmConfigurarModuloPsicologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1234, 935);
            this.Controls.Add(this.dgvPrograma);
            this.Controls.Add(this.btnListaCursos);
            this.Controls.Add(this.btnListaCuidadores);
            this.Controls.Add(this.btnModificarPrograma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreModulo);
            this.Name = "frmConfigurarModuloPsicologo";
            this.Text = "frmConfigurarModuloPsicologo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreModulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificarPrograma;
        private System.Windows.Forms.Button btnListaCuidadores;
        private System.Windows.Forms.Button btnListaCursos;
        private System.Windows.Forms.DataGridView dgvPrograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tema;
    }
}