
namespace InterfazDATMA.plantilla
{
    partial class frmPlantillaV2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.aside = new System.Windows.Forms.Panel();
            this.Ayuda = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.Button();
            this.ImagenDATMA = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.Button();
            this.Perfil = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.ImagenPerfil = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TipoUsuario = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.aside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenDATMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPerfil)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aside
            // 
            this.aside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.aside.Controls.Add(this.Ayuda);
            this.aside.Controls.Add(this.Calendar);
            this.aside.Controls.Add(this.ImagenDATMA);
            this.aside.Controls.Add(this.Salir);
            this.aside.Controls.Add(this.Perfil);
            this.aside.Controls.Add(this.home);
            this.aside.Dock = System.Windows.Forms.DockStyle.Left;
            this.aside.Location = new System.Drawing.Point(0, 0);
            this.aside.Name = "aside";
            this.aside.Size = new System.Drawing.Size(281, 1217);
            this.aside.TabIndex = 0;
            // 
            // Ayuda
            // 
            this.Ayuda.FlatAppearance.BorderSize = 0;
            this.Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ayuda.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ayuda.ForeColor = System.Drawing.Color.White;
            this.Ayuda.Location = new System.Drawing.Point(4, 625);
            this.Ayuda.Margin = new System.Windows.Forms.Padding(0);
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(277, 60);
            this.Ayuda.TabIndex = 5;
            this.Ayuda.Text = "Ayuda";
            this.Ayuda.UseVisualStyleBackColor = true;
            this.Ayuda.Click += new System.EventHandler(this.Ayuda_Click);
            // 
            // Calendar
            // 
            this.Calendar.FlatAppearance.BorderSize = 0;
            this.Calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calendar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.ForeColor = System.Drawing.Color.White;
            this.Calendar.Location = new System.Drawing.Point(4, 512);
            this.Calendar.Margin = new System.Windows.Forms.Padding(0);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(277, 60);
            this.Calendar.TabIndex = 4;
            this.Calendar.Text = "Calendario";
            this.Calendar.UseVisualStyleBackColor = true;
            this.Calendar.Click += new System.EventHandler(this.Calendar_Click);
            // 
            // ImagenDATMA
            // 
            this.ImagenDATMA.BackColor = System.Drawing.Color.White;
            this.ImagenDATMA.Location = new System.Drawing.Point(30, 30);
            this.ImagenDATMA.Name = "ImagenDATMA";
            this.ImagenDATMA.Size = new System.Drawing.Size(229, 193);
            this.ImagenDATMA.TabIndex = 3;
            this.ImagenDATMA.TabStop = false;
            this.ImagenDATMA.Click += new System.EventHandler(this.ImagenDATMA_Click);
            // 
            // Salir
            // 
            this.Salir.FlatAppearance.BorderSize = 0;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.Color.White;
            this.Salir.Location = new System.Drawing.Point(0, 880);
            this.Salir.Margin = new System.Windows.Forms.Padding(0);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(277, 60);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Perfil
            // 
            this.Perfil.FlatAppearance.BorderSize = 0;
            this.Perfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Perfil.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perfil.ForeColor = System.Drawing.Color.White;
            this.Perfil.Location = new System.Drawing.Point(4, 393);
            this.Perfil.Margin = new System.Windows.Forms.Padding(0);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(277, 60);
            this.Perfil.TabIndex = 1;
            this.Perfil.Text = "Perfil";
            this.Perfil.UseVisualStyleBackColor = true;
            this.Perfil.Click += new System.EventHandler(this.button1_Click);
            // 
            // home
            // 
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(9, 285);
            this.home.Margin = new System.Windows.Forms.Padding(0);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(277, 60);
            this.home.TabIndex = 0;
            this.home.Text = "Inicio";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserName.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.UserName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.UserName.Location = new System.Drawing.Point(1542, 106);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(334, 49);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Nombre Usuario";
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // ImagenPerfil
            // 
            this.ImagenPerfil.BackColor = System.Drawing.Color.White;
            this.ImagenPerfil.Location = new System.Drawing.Point(1416, 71);
            this.ImagenPerfil.Name = "ImagenPerfil";
            this.ImagenPerfil.Size = new System.Drawing.Size(104, 84);
            this.ImagenPerfil.TabIndex = 1;
            this.ImagenPerfil.TabStop = false;
            this.ImagenPerfil.Click += new System.EventHandler(this.ImagenPerfil_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.TipoUsuario);
            this.panel1.Controls.Add(this.ImagenPerfil);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(281, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1897, 183);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 31);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Aqui puede ir la hora xD";
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.AutoSize = true;
            this.TipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoUsuario.ForeColor = System.Drawing.Color.White;
            this.TipoUsuario.Location = new System.Drawing.Point(18, 30);
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.Size = new System.Drawing.Size(146, 29);
            this.TipoUsuario.TabIndex = 2;
            this.TipoUsuario.Text = "TipoUsuario";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(281, 183);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1897, 1034);
            this.pnlContenedor.TabIndex = 2;
            // 
            // frmPlantillaV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(2178, 1217);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.aside);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPlantillaV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.aside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenDATMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPerfil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel aside;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button Perfil;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.PictureBox ImagenPerfil;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TipoUsuario;
        private System.Windows.Forms.Button Ayuda;
        private System.Windows.Forms.Button Calendar;
        private System.Windows.Forms.PictureBox ImagenDATMA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}

