
namespace InterfaceDATMA
{
    partial class frmInformacionCurso
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
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInfCurso = new System.Windows.Forms.DataGridView();
            this.lblTituloDescripcion = new System.Windows.Forms.Label();
            this.lblDescripcionCurso = new System.Windows.Forms.Label();
            this.lblTituloEncargado = new System.Windows.Forms.Label();
            this.lblInformacionEncargada = new System.Windows.Forms.Label();
            this.txtBoxFechaIni = new System.Windows.Forms.TextBox();
            this.txtBoxFechaFin = new System.Windows.Forms.TextBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblNumeroModulo = new System.Windows.Forms.Label();
            this.lblTituloGeneral = new System.Windows.Forms.Label();
            this.lblNombreModulo = new System.Windows.Forms.Label();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictBoxEncargada = new System.Windows.Forms.PictureBox();
            this.btnVerMas = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfCurso)).BeginInit();
            this.pnlMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxEncargada)).BeginInit();
            this.SuspendLayout();
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 150;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora de Fin";
            this.HoraFin.MinimumWidth = 8;
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.Width = 150;
            // 
            // HoraIni
            // 
            this.HoraIni.HeaderText = "Hora de Inicio";
            this.HoraIni.MinimumWidth = 8;
            this.HoraIni.Name = "HoraIni";
            this.HoraIni.Width = 150;
            // 
            // TipoActividad
            // 
            this.TipoActividad.HeaderText = "Tipo de Actividad";
            this.TipoActividad.MinimumWidth = 8;
            this.TipoActividad.Name = "TipoActividad";
            this.TipoActividad.Width = 150;
            // 
            // dgvInfCurso
            // 
            this.dgvInfCurso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvInfCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInfCurso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoActividad,
            this.HoraIni,
            this.HoraFin,
            this.Fecha});
            this.dgvInfCurso.EnableHeadersVisualStyles = false;
            this.dgvInfCurso.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvInfCurso.Location = new System.Drawing.Point(514, 458);
            this.dgvInfCurso.Name = "dgvInfCurso";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfCurso.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInfCurso.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInfCurso.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInfCurso.RowTemplate.Height = 28;
            this.dgvInfCurso.Size = new System.Drawing.Size(933, 248);
            this.dgvInfCurso.TabIndex = 18;
            // 
            // lblTituloDescripcion
            // 
            this.lblTituloDescripcion.AutoSize = true;
            this.lblTituloDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblTituloDescripcion.Location = new System.Drawing.Point(969, 77);
            this.lblTituloDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloDescripcion.Name = "lblTituloDescripcion";
            this.lblTituloDescripcion.Size = new System.Drawing.Size(162, 20);
            this.lblTituloDescripcion.TabIndex = 8;
            this.lblTituloDescripcion.Text = "Acerca de este Curso";
            // 
            // lblDescripcionCurso
            // 
            this.lblDescripcionCurso.ForeColor = System.Drawing.Color.White;
            this.lblDescripcionCurso.Location = new System.Drawing.Point(996, 117);
            this.lblDescripcionCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionCurso.Name = "lblDescripcionCurso";
            this.lblDescripcionCurso.Size = new System.Drawing.Size(453, 111);
            this.lblDescripcionCurso.TabIndex = 9;
            this.lblDescripcionCurso.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vulputate fringil" +
    "la ante, id varius purus mollis non.";
            // 
            // lblTituloEncargado
            // 
            this.lblTituloEncargado.AutoSize = true;
            this.lblTituloEncargado.ForeColor = System.Drawing.Color.White;
            this.lblTituloEncargado.Location = new System.Drawing.Point(974, 195);
            this.lblTituloEncargado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloEncargado.Name = "lblTituloEncargado";
            this.lblTituloEncargado.Size = new System.Drawing.Size(177, 20);
            this.lblTituloEncargado.TabIndex = 10;
            this.lblTituloEncargado.Text = "Encargado(a) del Curso";
            // 
            // lblInformacionEncargada
            // 
            this.lblInformacionEncargada.ForeColor = System.Drawing.Color.White;
            this.lblInformacionEncargada.Location = new System.Drawing.Point(1154, 254);
            this.lblInformacionEncargada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInformacionEncargada.Name = "lblInformacionEncargada";
            this.lblInformacionEncargada.Size = new System.Drawing.Size(356, 52);
            this.lblInformacionEncargada.TabIndex = 11;
            this.lblInformacionEncargada.Text = "Caballera Mellanois\nEducación: Abogada Penalista";
            // 
            // txtBoxFechaIni
            // 
            this.txtBoxFechaIni.Location = new System.Drawing.Point(658, 220);
            this.txtBoxFechaIni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxFechaIni.Name = "txtBoxFechaIni";
            this.txtBoxFechaIni.Size = new System.Drawing.Size(148, 26);
            this.txtBoxFechaIni.TabIndex = 6;
            // 
            // txtBoxFechaFin
            // 
            this.txtBoxFechaFin.Location = new System.Drawing.Point(658, 272);
            this.txtBoxFechaFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxFechaFin.Name = "txtBoxFechaFin";
            this.txtBoxFechaFin.Size = new System.Drawing.Size(148, 26);
            this.txtBoxFechaFin.TabIndex = 7;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.ForeColor = System.Drawing.Color.White;
            this.lblMes.Location = new System.Drawing.Point(684, 400);
            this.lblMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(96, 20);
            this.lblMes.TabIndex = 17;
            this.lblMes.Text = "MAYO 2021";
            // 
            // lblNumeroModulo
            // 
            this.lblNumeroModulo.AutoSize = true;
            this.lblNumeroModulo.ForeColor = System.Drawing.Color.White;
            this.lblNumeroModulo.Location = new System.Drawing.Point(432, 78);
            this.lblNumeroModulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroModulo.Name = "lblNumeroModulo";
            this.lblNumeroModulo.Size = new System.Drawing.Size(74, 20);
            this.lblNumeroModulo.TabIndex = 3;
            this.lblNumeroModulo.Text = "Modulo 1";
            // 
            // lblTituloGeneral
            // 
            this.lblTituloGeneral.AutoSize = true;
            this.lblTituloGeneral.ForeColor = System.Drawing.Color.White;
            this.lblTituloGeneral.Location = new System.Drawing.Point(426, 129);
            this.lblTituloGeneral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloGeneral.Name = "lblTituloGeneral";
            this.lblTituloGeneral.Size = new System.Drawing.Size(164, 20);
            this.lblTituloGeneral.TabIndex = 2;
            this.lblTituloGeneral.Text = "Información del Curso";
            // 
            // lblNombreModulo
            // 
            this.lblNombreModulo.AutoSize = true;
            this.lblNombreModulo.ForeColor = System.Drawing.Color.White;
            this.lblNombreModulo.Location = new System.Drawing.Point(510, 175);
            this.lblNombreModulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreModulo.Name = "lblNombreModulo";
            this.lblNombreModulo.Size = new System.Drawing.Size(133, 20);
            this.lblNombreModulo.TabIndex = 0;
            this.lblNombreModulo.Text = "Modulo nro1-3.52";
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.ForeColor = System.Drawing.Color.White;
            this.lblFechaIni.Location = new System.Drawing.Point(510, 220);
            this.lblFechaIni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(117, 20);
            this.lblFechaIni.TabIndex = 5;
            this.lblFechaIni.Text = "Fecha de Inicio";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.ForeColor = System.Drawing.Color.White;
            this.lblFechaFin.Location = new System.Drawing.Point(510, 272);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(102, 20);
            this.lblFechaFin.TabIndex = 4;
            this.lblFechaFin.Text = "Fecha de Fin";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(432, 400);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(61, 20);
            this.lblHorario.TabIndex = 14;
            this.lblHorario.Text = "Horario";
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.pnlMenuVertical.Controls.Add(this.panel4);
            this.pnlMenuVertical.Controls.Add(this.btnSalir);
            this.pnlMenuVertical.Controls.Add(this.panel3);
            this.pnlMenuVertical.Controls.Add(this.panel2);
            this.pnlMenuVertical.Controls.Add(this.btnPerfil);
            this.pnlMenuVertical.Controls.Add(this.panel1);
            this.pnlMenuVertical.Controls.Add(this.btnInicio);
            this.pnlMenuVertical.Controls.Add(this.pictureBox1);
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(381, 723);
            this.pnlMenuVertical.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(3, 789);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 55);
            this.panel4.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(22, 789);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(356, 55);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(3, 438);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 55);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(3, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 55);
            this.panel2.TabIndex = 4;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Image = global::InterfazDATMA.Properties.Resources.empleados;
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(22, 378);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(356, 55);
            this.btnPerfil.TabIndex = 3;
            this.btnPerfil.Text = "PERFIL";
            this.btnPerfil.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(3, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 55);
            this.panel1.TabIndex = 2;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = global::InterfazDATMA.Properties.Resources.producto;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(22, 315);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(356, 55);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfazDATMA.Properties.Resources.DATMA_logo;
            this.pictureBox1.Location = new System.Drawing.Point(46, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictBoxEncargada
            // 
            this.pictBoxEncargada.Image = global::InterfaceDATMA.Properties.Resources._1;
            this.pictBoxEncargada.Location = new System.Drawing.Point(1000, 232);
            this.pictBoxEncargada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictBoxEncargada.Name = "pictBoxEncargada";
            this.pictBoxEncargada.Size = new System.Drawing.Size(117, 92);
            this.pictBoxEncargada.TabIndex = 12;
            this.pictBoxEncargada.TabStop = false;
            // 
            // btnVerMas
            // 
            this.btnVerMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnVerMas.FlatAppearance.BorderSize = 0;
            this.btnVerMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnVerMas.ForeColor = System.Drawing.Color.White;
            this.btnVerMas.Location = new System.Drawing.Point(582, 69);
            this.btnVerMas.Name = "btnVerMas";
            this.btnVerMas.Size = new System.Drawing.Size(136, 37);
            this.btnVerMas.TabIndex = 20;
            this.btnVerMas.Text = "VER MÁS";
            this.btnVerMas.UseVisualStyleBackColor = false;
            this.btnVerMas.Click += new System.EventHandler(this.btnVerMas_Click_1);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(514, 392);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(136, 37);
            this.btnAnterior.TabIndex = 21;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnSig
            // 
            this.btnSig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnSig.FlatAppearance.BorderSize = 0;
            this.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSig.ForeColor = System.Drawing.Color.White;
            this.btnSig.Location = new System.Drawing.Point(802, 391);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(136, 37);
            this.btnSig.TabIndex = 22;
            this.btnSig.Text = "Siguiente";
            this.btnSig.UseVisualStyleBackColor = false;
            // 
            // frmInformacionCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1544, 723);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnVerMas);
            this.Controls.Add(this.pnlMenuVertical);
            this.Controls.Add(this.dgvInfCurso);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.pictBoxEncargada);
            this.Controls.Add(this.lblInformacionEncargada);
            this.Controls.Add(this.lblTituloEncargado);
            this.Controls.Add(this.lblDescripcionCurso);
            this.Controls.Add(this.lblTituloDescripcion);
            this.Controls.Add(this.txtBoxFechaFin);
            this.Controls.Add(this.txtBoxFechaIni);
            this.Controls.Add(this.lblFechaIni);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblNumeroModulo);
            this.Controls.Add(this.lblTituloGeneral);
            this.Controls.Add(this.lblNombreModulo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInformacionCurso";
            this.Text = "Informacion del Curso";
            this.Load += new System.EventHandler(this.frmInformacionCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfCurso)).EndInit();
            this.pnlMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxEncargada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoActividad;
        private System.Windows.Forms.DataGridView dgvInfCurso;
        private System.Windows.Forms.Label lblTituloDescripcion;
        private System.Windows.Forms.Label lblDescripcionCurso;
        private System.Windows.Forms.Label lblTituloEncargado;
        private System.Windows.Forms.Label lblInformacionEncargada;
        private System.Windows.Forms.PictureBox pictBoxEncargada;
        private System.Windows.Forms.TextBox txtBoxFechaIni;
        private System.Windows.Forms.TextBox txtBoxFechaFin;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblNumeroModulo;
        private System.Windows.Forms.Label lblTituloGeneral;
        private System.Windows.Forms.Label lblNombreModulo;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Panel pnlMenuVertical;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVerMas;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSig;
    }
}