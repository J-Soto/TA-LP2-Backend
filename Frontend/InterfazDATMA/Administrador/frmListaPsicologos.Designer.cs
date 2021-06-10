
namespace InterfazDATMA.Administrador
{
    partial class Header
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvPsico = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApPat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista Psicologos";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(681, 347);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(816, 38);
            this.txtBuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(1667, 328);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(232, 57);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvPsico
            // 
            this.dgvPsico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPsico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colApPat,
            this.colApMat,
            this.colDNI,
            this.colFechaNac,
            this.colGen,
            this.colEdad,
            this.colTelf,
            this.colCel,
            this.colEmail});
            this.dgvPsico.Location = new System.Drawing.Point(85, 461);
            this.dgvPsico.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPsico.Name = "dgvPsico";
            this.dgvPsico.RowHeadersWidth = 82;
            this.dgvPsico.RowTemplate.Height = 33;
            this.dgvPsico.Size = new System.Drawing.Size(2088, 609);
            this.dgvPsico.TabIndex = 8;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "nombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 10;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 200;
            // 
            // colApPat
            // 
            this.colApPat.DataPropertyName = "apellidoPaterno";
            this.colApPat.HeaderText = "Apellido Paterno";
            this.colApPat.MinimumWidth = 10;
            this.colApPat.Name = "colApPat";
            this.colApPat.ReadOnly = true;
            this.colApPat.Width = 200;
            // 
            // colApMat
            // 
            this.colApMat.DataPropertyName = "apellidoMaterno";
            this.colApMat.HeaderText = "Apellido Materno";
            this.colApMat.MinimumWidth = 10;
            this.colApMat.Name = "colApMat";
            this.colApMat.ReadOnly = true;
            this.colApMat.Width = 200;
            // 
            // colDNI
            // 
            this.colDNI.DataPropertyName = "DNI";
            this.colDNI.HeaderText = "DNI";
            this.colDNI.MinimumWidth = 10;
            this.colDNI.Name = "colDNI";
            this.colDNI.ReadOnly = true;
            this.colDNI.Width = 200;
            // 
            // colFechaNac
            // 
            this.colFechaNac.DataPropertyName = "fechaNacimiento";
            this.colFechaNac.HeaderText = "Fecha de Nacimiento";
            this.colFechaNac.MinimumWidth = 10;
            this.colFechaNac.Name = "colFechaNac";
            this.colFechaNac.ReadOnly = true;
            this.colFechaNac.Width = 200;
            // 
            // colGen
            // 
            this.colGen.DataPropertyName = "genero";
            this.colGen.HeaderText = "Genero";
            this.colGen.MinimumWidth = 10;
            this.colGen.Name = "colGen";
            this.colGen.ReadOnly = true;
            this.colGen.Width = 200;
            // 
            // colEdad
            // 
            this.colEdad.DataPropertyName = "edad";
            this.colEdad.HeaderText = "Edad";
            this.colEdad.MinimumWidth = 10;
            this.colEdad.Name = "colEdad";
            this.colEdad.ReadOnly = true;
            this.colEdad.Width = 200;
            // 
            // colTelf
            // 
            this.colTelf.DataPropertyName = "telefono";
            this.colTelf.HeaderText = "Telefono";
            this.colTelf.MinimumWidth = 10;
            this.colTelf.Name = "colTelf";
            this.colTelf.ReadOnly = true;
            this.colTelf.Width = 200;
            // 
            // colCel
            // 
            this.colCel.DataPropertyName = "celular";
            this.colCel.HeaderText = "Celular";
            this.colCel.MinimumWidth = 10;
            this.colCel.Name = "colCel";
            this.colCel.ReadOnly = true;
            this.colCel.Width = 200;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "correo";
            this.colEmail.HeaderText = "Correo";
            this.colEmail.MinimumWidth = 10;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 200;
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(2495, 1194);
            this.Controls.Add(this.dgvPsico);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Header";
            this.Text = "frmListaPsicologos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvPsico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApPat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    }
}