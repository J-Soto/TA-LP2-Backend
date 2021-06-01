
namespace InterfaceDATMA
{
    partial class frmRegistrarAsistenciaCuidadores
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
            this.dgvReuniones = new System.Windows.Forms.DataGridView();
            this.btnGuardarAsistencia = new System.Windows.Forms.Button();
            this.brnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReuniones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReuniones
            // 
            this.dgvReuniones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvReuniones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReuniones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReuniones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReuniones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReuniones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellidos,
            this.Asistencia});
            this.dgvReuniones.EnableHeadersVisualStyles = false;
            this.dgvReuniones.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvReuniones.Location = new System.Drawing.Point(95, 176);
            this.dgvReuniones.Name = "dgvReuniones";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReuniones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReuniones.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReuniones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReuniones.RowTemplate.Height = 28;
            this.dgvReuniones.Size = new System.Drawing.Size(958, 597);
            this.dgvReuniones.TabIndex = 22;
            // 
            // btnGuardarAsistencia
            // 
            this.btnGuardarAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnGuardarAsistencia.FlatAppearance.BorderSize = 0;
            this.btnGuardarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAsistencia.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnGuardarAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnGuardarAsistencia.Location = new System.Drawing.Point(366, 797);
            this.btnGuardarAsistencia.Name = "btnGuardarAsistencia";
            this.btnGuardarAsistencia.Size = new System.Drawing.Size(345, 45);
            this.btnGuardarAsistencia.TabIndex = 23;
            this.btnGuardarAsistencia.Text = "Guardar Asistencia";
            this.btnGuardarAsistencia.UseVisualStyleBackColor = false;
            // 
            // brnRegresar
            // 
            this.brnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.brnRegresar.FlatAppearance.BorderSize = 0;
            this.brnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnRegresar.Font = new System.Drawing.Font("Montserrat", 10F);
            this.brnRegresar.ForeColor = System.Drawing.Color.White;
            this.brnRegresar.Location = new System.Drawing.Point(836, 847);
            this.brnRegresar.Name = "brnRegresar";
            this.brnRegresar.Size = new System.Drawing.Size(217, 40);
            this.brnRegresar.TabIndex = 24;
            this.brnRegresar.Text = "Regresar";
            this.brnRegresar.UseVisualStyleBackColor = false;
            this.brnRegresar.Click += new System.EventHandler(this.brnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 49);
            this.label1.TabIndex = 25;
            this.label1.Text = "Asistencia de Cuidadores";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(793, 116);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(260, 40);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Densmarcar Todo";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 210;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 8;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Width = 280;
            // 
            // Asistencia
            // 
            this.Asistencia.HeaderText = "Asistencia";
            this.Asistencia.MinimumWidth = 8;
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.Width = 90;
            // 
            // frmRegistrarAsistenciaCuidadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1128, 936);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brnRegresar);
            this.Controls.Add(this.btnGuardarAsistencia);
            this.Controls.Add(this.dgvReuniones);
            this.Name = "frmRegistrarAsistenciaCuidadores";
            this.Text = "frmRegistrarAsistenciaCuidadores";
            this.Load += new System.EventHandler(this.frmRegistrarAsistenciaCuidadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReuniones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvReuniones;
        private System.Windows.Forms.Button btnGuardarAsistencia;
        private System.Windows.Forms.Button brnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Asistencia;
    }
}