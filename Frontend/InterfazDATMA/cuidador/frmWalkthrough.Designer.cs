
namespace InterfazDATMA
{
    partial class frmWalkthrough
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureboxWalk = new System.Windows.Forms.PictureBox();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxWalk)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureboxWalk
            // 
            this.pictureboxWalk.Image = global::InterfazDATMA.Properties.Resources.canon1;
            this.pictureboxWalk.Location = new System.Drawing.Point(159, 35);
            this.pictureboxWalk.Name = "pictureboxWalk";
            this.pictureboxWalk.Size = new System.Drawing.Size(445, 265);
            this.pictureboxWalk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxWalk.TabIndex = 2;
            this.pictureboxWalk.TabStop = false;
            // 
            // btnAnt
            // 
            this.btnAnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnAnt.FlatAppearance.BorderSize = 0;
            this.btnAnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAnt.ForeColor = System.Drawing.Color.White;
            this.btnAnt.Location = new System.Drawing.Point(248, 328);
            this.btnAnt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(91, 24);
            this.btnAnt.TabIndex = 21;
            this.btnAnt.Text = "Anterior";
            this.btnAnt.UseVisualStyleBackColor = false;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click_1);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(332, 377);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(91, 24);
            this.btnFinalizar.TabIndex = 22;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(419, 328);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(91, 24);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = "Siguiente";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // frmWalkthrough
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.pictureboxWalk);
            this.Name = "frmWalkthrough";
            this.Text = "Tutorial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxWalk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureboxWalk;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnNext;
    }
}