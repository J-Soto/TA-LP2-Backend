
namespace InterfazDATMA.Administrador
{
    partial class frmCrearTemaDeCurso
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
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreTema = new System.Windows.Forms.TextBox();
            this.txtDescripcionTema = new System.Windows.Forms.RichTextBox();
            this.btnGuardarTema = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(52, 70);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(216, 29);
            this.lblTutoresUser.TabIndex = 14;
            this.lblTutoresUser.Text = "Nombre del Tema:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Descripcion:";
            // 
            // txtNombreTema
            // 
            this.txtNombreTema.Location = new System.Drawing.Point(287, 74);
            this.txtNombreTema.Name = "txtNombreTema";
            this.txtNombreTema.Size = new System.Drawing.Size(363, 26);
            this.txtNombreTema.TabIndex = 16;
            // 
            // txtDescripcionTema
            // 
            this.txtDescripcionTema.Location = new System.Drawing.Point(289, 135);
            this.txtDescripcionTema.Name = "txtDescripcionTema";
            this.txtDescripcionTema.Size = new System.Drawing.Size(360, 123);
            this.txtDescripcionTema.TabIndex = 17;
            this.txtDescripcionTema.Text = "";
            // 
            // btnGuardarTema
            // 
            this.btnGuardarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnGuardarTema.FlatAppearance.BorderSize = 0;
            this.btnGuardarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardarTema.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTema.Location = new System.Drawing.Point(213, 317);
            this.btnGuardarTema.Name = "btnGuardarTema";
            this.btnGuardarTema.Size = new System.Drawing.Size(161, 32);
            this.btnGuardarTema.TabIndex = 22;
            this.btnGuardarTema.Text = "Guardar";
            this.btnGuardarTema.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(437, 317);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 32);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmCrearTemaDeCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(803, 385);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarTema);
            this.Controls.Add(this.txtDescripcionTema);
            this.Controls.Add(this.txtNombreTema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTutoresUser);
            this.Name = "frmCrearTemaDeCurso";
            this.Text = "frmCrearTemaDeCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTutoresUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreTema;
        private System.Windows.Forms.RichTextBox txtDescripcionTema;
        private System.Windows.Forms.Button btnGuardarTema;
        private System.Windows.Forms.Button btnCancelar;
    }
}