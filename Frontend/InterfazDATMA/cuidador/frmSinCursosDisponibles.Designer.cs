
namespace InterfazDATMA
{
    partial class frmSinCursosDisponibles
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
            this.lblCursosDisponibles = new System.Windows.Forms.Label();
            this.grpBoxJustificacion = new System.Windows.Forms.GroupBox();
            this.lblJustificacion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNotificar = new System.Windows.Forms.Button();
            this.lblNotificacion = new System.Windows.Forms.Label();
            this.grpBoxJustificacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCursosDisponibles
            // 
            this.lblCursosDisponibles.AutoSize = true;
            this.lblCursosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCursosDisponibles.ForeColor = System.Drawing.Color.White;
            this.lblCursosDisponibles.Location = new System.Drawing.Point(227, 45);
            this.lblCursosDisponibles.Name = "lblCursosDisponibles";
            this.lblCursosDisponibles.Size = new System.Drawing.Size(205, 20);
            this.lblCursosDisponibles.TabIndex = 0;
            this.lblCursosDisponibles.Text = "Lista de Cursos Disponibles";
            // 
            // grpBoxJustificacion
            // 
            this.grpBoxJustificacion.Controls.Add(this.lblJustificacion);
            this.grpBoxJustificacion.Location = new System.Drawing.Point(205, 94);
            this.grpBoxJustificacion.Name = "grpBoxJustificacion";
            this.grpBoxJustificacion.Size = new System.Drawing.Size(291, 138);
            this.grpBoxJustificacion.TabIndex = 1;
            this.grpBoxJustificacion.TabStop = false;
            // 
            // lblJustificacion
            // 
            this.lblJustificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblJustificacion.ForeColor = System.Drawing.Color.White;
            this.lblJustificacion.Location = new System.Drawing.Point(50, 44);
            this.lblJustificacion.Name = "lblJustificacion";
            this.lblJustificacion.Size = new System.Drawing.Size(193, 51);
            this.lblJustificacion.TabIndex = 2;
            this.lblJustificacion.Text = "Disculpe, pero actualmente no hay cursos disponibles";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNotificar);
            this.groupBox1.Controls.Add(this.lblNotificacion);
            this.groupBox1.Location = new System.Drawing.Point(205, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 138);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnNotificar
            // 
            this.btnNotificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnNotificar.FlatAppearance.BorderSize = 0;
            this.btnNotificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnNotificar.ForeColor = System.Drawing.Color.White;
            this.btnNotificar.Location = new System.Drawing.Point(53, 77);
            this.btnNotificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnNotificar.Name = "btnNotificar";
            this.btnNotificar.Size = new System.Drawing.Size(178, 24);
            this.btnNotificar.TabIndex = 24;
            this.btnNotificar.Text = "NOTIFICARME";
            this.btnNotificar.UseVisualStyleBackColor = false;
            this.btnNotificar.Click += new System.EventHandler(this.btnNotificar_Click);
            // 
            // lblNotificacion
            // 
            this.lblNotificacion.ForeColor = System.Drawing.Color.White;
            this.lblNotificacion.Location = new System.Drawing.Point(50, 24);
            this.lblNotificacion.Name = "lblNotificacion";
            this.lblNotificacion.Size = new System.Drawing.Size(193, 51);
            this.lblNotificacion.TabIndex = 2;
            this.lblNotificacion.Text = "Te notificaremos cuando haya nuevos cursos";
            // 
            // frmSinCursosDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxJustificacion);
            this.Controls.Add(this.lblCursosDisponibles);
            this.Name = "frmSinCursosDisponibles";
            this.Text = "Cursos Disponibles";
            this.grpBoxJustificacion.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCursosDisponibles;
        private System.Windows.Forms.GroupBox grpBoxJustificacion;
        private System.Windows.Forms.Label lblJustificacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNotificacion;
        private System.Windows.Forms.Button btnNotificar;
    }
}