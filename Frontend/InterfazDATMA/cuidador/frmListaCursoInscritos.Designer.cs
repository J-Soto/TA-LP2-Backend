
namespace InterfazDATMA
{
    partial class frmListaCursoInscritos
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
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.btnCursosDisponibles = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnModulo1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.pnlContenido.Controls.Add(this.btnCursosDisponibles);
            this.pnlContenido.Controls.Add(this.dataGridView1);
            this.pnlContenido.Controls.Add(this.monthCalendar1);
            this.pnlContenido.Controls.Add(this.button3);
            this.pnlContenido.Controls.Add(this.button2);
            this.pnlContenido.Controls.Add(this.btnModulo1);
            this.pnlContenido.Controls.Add(this.label6);
            this.pnlContenido.Controls.Add(this.label7);
            this.pnlContenido.Controls.Add(this.label4);
            this.pnlContenido.Controls.Add(this.label5);
            this.pnlContenido.Controls.Add(this.label3);
            this.pnlContenido.Controls.Add(this.label2);
            this.pnlContenido.Controls.Add(this.label1);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 0);
            this.pnlContenido.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(872, 553);
            this.pnlContenido.TabIndex = 10;
            // 
            // btnCursosDisponibles
            // 
            this.btnCursosDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnCursosDisponibles.FlatAppearance.BorderSize = 0;
            this.btnCursosDisponibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCursosDisponibles.ForeColor = System.Drawing.Color.White;
            this.btnCursosDisponibles.Location = new System.Drawing.Point(692, 482);
            this.btnCursosDisponibles.Margin = new System.Windows.Forms.Padding(2);
            this.btnCursosDisponibles.Name = "btnCursosDisponibles";
            this.btnCursosDisponibles.Size = new System.Drawing.Size(117, 40);
            this.btnCursosDisponibles.TabIndex = 36;
            this.btnCursosDisponibles.Text = "VER CURSOS DISPONIBLES";
            this.btnCursosDisponibles.UseVisualStyleBackColor = false;
            this.btnCursosDisponibles.Click += new System.EventHandler(this.btnCursosDisponibles_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Fecha});
            this.dataGridView1.Location = new System.Drawing.Point(350, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 431);
            this.dataGridView1.TabIndex = 35;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(46, 298);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 33);
            this.button3.TabIndex = 33;
            this.button3.Text = "Entrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 33);
            this.button2.TabIndex = 32;
            this.button2.Text = "Entrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModulo1
            // 
            this.btnModulo1.Location = new System.Drawing.Point(188, 67);
            this.btnModulo1.Name = "btnModulo1";
            this.btnModulo1.Size = new System.Drawing.Size(97, 33);
            this.btnModulo1.TabIndex = 31;
            this.btnModulo1.Text = "Entrar";
            this.btnModulo1.UseVisualStyleBackColor = true;
            this.btnModulo1.Click += new System.EventHandler(this.btnModulo1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Avance: 0% completado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Curso: Modulo 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Avance: 0% completado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Curso: Modulo 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Avance: 0% completado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Curso: Modulo 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Lista de Cursos Inscritos";
            // 
            // frmListaCursoInscritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(872, 553);
            this.Controls.Add(this.pnlContenido);
            this.Name = "frmListaCursoInscritos";
            this.Text = "DATMA";
            this.Load += new System.EventHandler(this.frmListaCursoInscritos_Load);
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModulo1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCursosDisponibles;
    }
}