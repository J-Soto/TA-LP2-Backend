
namespace InterfazDATMA
{
    partial class frmInscripcionHecha
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
            this.lblFelicitacion = new System.Windows.Forms.Label();
            this.btnIrCurso = new System.Windows.Forms.Button();
            this.btnIrLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFelicitacion
            // 
            this.lblFelicitacion.AutoSize = true;
            this.lblFelicitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFelicitacion.ForeColor = System.Drawing.Color.White;
            this.lblFelicitacion.Location = new System.Drawing.Point(97, 89);
            this.lblFelicitacion.Name = "lblFelicitacion";
            this.lblFelicitacion.Size = new System.Drawing.Size(295, 20);
            this.lblFelicitacion.TabIndex = 0;
            this.lblFelicitacion.Text = "Tu inscripción ha sido realizada con éxito";
            this.lblFelicitacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIrCurso
            // 
            this.btnIrCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnIrCurso.FlatAppearance.BorderSize = 0;
            this.btnIrCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnIrCurso.ForeColor = System.Drawing.Color.White;
            this.btnIrCurso.Location = new System.Drawing.Point(158, 161);
            this.btnIrCurso.Margin = new System.Windows.Forms.Padding(2);
            this.btnIrCurso.Name = "btnIrCurso";
            this.btnIrCurso.Size = new System.Drawing.Size(161, 24);
            this.btnIrCurso.TabIndex = 23;
            this.btnIrCurso.Text = "IR AL CURSO";
            this.btnIrCurso.UseVisualStyleBackColor = false;
            this.btnIrCurso.Click += new System.EventHandler(this.btnIrCurso_Click);
            // 
            // btnIrLista
            // 
            this.btnIrLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnIrLista.FlatAppearance.BorderSize = 0;
            this.btnIrLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnIrLista.ForeColor = System.Drawing.Color.White;
            this.btnIrLista.Location = new System.Drawing.Point(158, 244);
            this.btnIrLista.Margin = new System.Windows.Forms.Padding(2);
            this.btnIrLista.Name = "btnIrLista";
            this.btnIrLista.Size = new System.Drawing.Size(161, 24);
            this.btnIrLista.TabIndex = 24;
            this.btnIrLista.Text = "ACEPTAR";
            this.btnIrLista.UseVisualStyleBackColor = false;
            this.btnIrLista.Click += new System.EventHandler(this.btnIrLista_Click);
            // 
            // frmInscripcionHecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(479, 336);
            this.Controls.Add(this.btnIrLista);
            this.Controls.Add(this.btnIrCurso);
            this.Controls.Add(this.lblFelicitacion);
            this.Name = "frmInscripcionHecha";
            this.Text = "frmInscripcionHecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFelicitacion;
        private System.Windows.Forms.Button btnIrCurso;
        private System.Windows.Forms.Button btnIrLista;
    }
}