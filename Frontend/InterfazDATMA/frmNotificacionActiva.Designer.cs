﻿
namespace InterfaceDATMA
{
    partial class frmNotificacionActiva
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
            this.lblNotificacionActiva = new System.Windows.Forms.Label();
            this.lblAgradecimiento = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNotificacionActiva
            // 
            this.lblNotificacionActiva.AutoSize = true;
            this.lblNotificacionActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacionActiva.ForeColor = System.Drawing.Color.White;
            this.lblNotificacionActiva.Location = new System.Drawing.Point(74, 50);
            this.lblNotificacionActiva.Name = "lblNotificacionActiva";
            this.lblNotificacionActiva.Size = new System.Drawing.Size(138, 20);
            this.lblNotificacionActiva.TabIndex = 0;
            this.lblNotificacionActiva.Text = "Notificacion Activa";
            // 
            // lblAgradecimiento
            // 
            this.lblAgradecimiento.AutoSize = true;
            this.lblAgradecimiento.ForeColor = System.Drawing.Color.White;
            this.lblAgradecimiento.Location = new System.Drawing.Point(75, 103);
            this.lblAgradecimiento.Name = "lblAgradecimiento";
            this.lblAgradecimiento.Size = new System.Drawing.Size(144, 13);
            this.lblAgradecimiento.TabIndex = 1;
            this.lblAgradecimiento.Text = "Tu notificacion esta activada";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(71, 151);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(148, 24);
            this.btnDashboard.TabIndex = 22;
            this.btnDashboard.Text = "IR AL DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // frmNotificacionActiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(286, 226);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.lblAgradecimiento);
            this.Controls.Add(this.lblNotificacionActiva);
            this.Name = "frmNotificacionActiva";
            this.Text = "Notificacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotificacionActiva;
        private System.Windows.Forms.Label lblAgradecimiento;
        private System.Windows.Forms.Button btnDashboard;
    }
}