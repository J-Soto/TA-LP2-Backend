
namespace InterfaceDATMA
{
    partial class frmAgregarMaterialPsicologo
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
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlinkArchivo = new System.Windows.Forms.TextBox();
            this.btnLinkArchivo = new System.Windows.Forms.Button();
            this.btnGuardarArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(259, 56);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(600, 100);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Video:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtlinkArchivo
            // 
            this.txtlinkArchivo.Location = new System.Drawing.Point(259, 202);
            this.txtlinkArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtlinkArchivo.Name = "txtlinkArchivo";
            this.txtlinkArchivo.Size = new System.Drawing.Size(452, 31);
            this.txtlinkArchivo.TabIndex = 3;
            // 
            // btnLinkArchivo
            // 
            this.btnLinkArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnLinkArchivo.FlatAppearance.BorderSize = 0;
            this.btnLinkArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnLinkArchivo.ForeColor = System.Drawing.Color.White;
            this.btnLinkArchivo.Location = new System.Drawing.Point(759, 196);
            this.btnLinkArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnLinkArchivo.Name = "btnLinkArchivo";
            this.btnLinkArchivo.Size = new System.Drawing.Size(101, 46);
            this.btnLinkArchivo.TabIndex = 4;
            this.btnLinkArchivo.Text = "...";
            this.btnLinkArchivo.UseVisualStyleBackColor = false;
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnGuardarArchivo.FlatAppearance.BorderSize = 0;
            this.btnGuardarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarArchivo.Location = new System.Drawing.Point(292, 296);
            this.btnGuardarArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(357, 55);
            this.btnGuardarArchivo.TabIndex = 5;
            this.btnGuardarArchivo.Text = "GUARDAR";
            this.btnGuardarArchivo.UseVisualStyleBackColor = false;
            // 
            // frmAgregarMaterialPsicologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(921, 421);
            this.Controls.Add(this.btnGuardarArchivo);
            this.Controls.Add(this.btnLinkArchivo);
            this.Controls.Add(this.txtlinkArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAgregarMaterialPsicologo";
            this.Text = "frmAgregarMaterialPsicologo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlinkArchivo;
        private System.Windows.Forms.Button btnGuardarArchivo;
        internal System.Windows.Forms.Button btnLinkArchivo;
    }
}