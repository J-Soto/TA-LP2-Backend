
namespace InterfaceDATMA
{
    partial class frmModificarPrograma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSemana = new System.Windows.Forms.Label();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.rtxtTema = new System.Windows.Forms.RichTextBox();
            this.btnEditarDescrip = new System.Windows.Forms.Button();
            this.dgvReuniones = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnirseReunion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descargar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAsitencia = new System.Windows.Forms.Button();
            this.bntConfigurarTiempo = new System.Windows.Forms.Button();
            this.btnAgregarReunion = new System.Windows.Forms.Button();
            this.btnEliminarReunion = new System.Windows.Forms.Button();
            this.btnAgregarMaterial = new System.Windows.Forms.Button();
            this.btnEliminarMaterial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReuniones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa: Que aprenderás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Font = new System.Drawing.Font("Montserrat", 17F);
            this.lblSemana.ForeColor = System.Drawing.Color.White;
            this.lblSemana.Location = new System.Drawing.Point(163, 124);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(178, 42);
            this.lblSemana.TabIndex = 2;
            this.lblSemana.Text = "Semana 1";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.rtxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDescripcion.Font = new System.Drawing.Font("Montserrat", 10F);
            this.rtxtDescripcion.ForeColor = System.Drawing.Color.White;
            this.rtxtDescripcion.Location = new System.Drawing.Point(170, 195);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(729, 102);
            this.rtxtDescripcion.TabIndex = 5;
            this.rtxtDescripcion.Text = "Texto de Prueba";
            // 
            // rtxtTema
            // 
            this.rtxtTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.rtxtTema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTema.Font = new System.Drawing.Font("Montserrat", 15F);
            this.rtxtTema.ForeColor = System.Drawing.Color.White;
            this.rtxtTema.Location = new System.Drawing.Point(445, 128);
            this.rtxtTema.Name = "rtxtTema";
            this.rtxtTema.Size = new System.Drawing.Size(454, 48);
            this.rtxtTema.TabIndex = 6;
            this.rtxtTema.Text = "Introduccion";
            // 
            // btnEditarDescrip
            // 
            this.btnEditarDescrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnEditarDescrip.FlatAppearance.BorderSize = 0;
            this.btnEditarDescrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDescrip.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnEditarDescrip.ForeColor = System.Drawing.Color.White;
            this.btnEditarDescrip.Location = new System.Drawing.Point(916, 223);
            this.btnEditarDescrip.Name = "btnEditarDescrip";
            this.btnEditarDescrip.Size = new System.Drawing.Size(168, 34);
            this.btnEditarDescrip.TabIndex = 7;
            this.btnEditarDescrip.Text = "Editar";
            this.btnEditarDescrip.UseVisualStyleBackColor = false;
            // 
            // dgvReuniones
            // 
            this.dgvReuniones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvReuniones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReuniones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReuniones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReuniones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReuniones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.HoraInicio,
            this.HoraFin,
            this.UnirseReunion});
            this.dgvReuniones.EnableHeadersVisualStyles = false;
            this.dgvReuniones.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvReuniones.Location = new System.Drawing.Point(170, 392);
            this.dgvReuniones.Name = "dgvReuniones";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReuniones.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReuniones.RowHeadersWidth = 62;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReuniones.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvReuniones.RowTemplate.Height = 28;
            this.dgvReuniones.Size = new System.Drawing.Size(918, 195);
            this.dgvReuniones.TabIndex = 8;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 150;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.MinimumWidth = 8;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.Width = 150;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.MinimumWidth = 8;
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.Width = 150;
            // 
            // UnirseReunion
            // 
            this.UnirseReunion.HeaderText = "Unirse Reunion";
            this.UnirseReunion.MinimumWidth = 8;
            this.UnirseReunion.Name = "UnirseReunion";
            this.UnirseReunion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnirseReunion.Width = 150;
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvMateriales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMateriales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMateriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Descargar});
            this.dgvMateriales.EnableHeadersVisualStyles = false;
            this.dgvMateriales.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMateriales.Location = new System.Drawing.Point(170, 703);
            this.dgvMateriales.Name = "dgvMateriales";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMateriales.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvMateriales.RowHeadersWidth = 62;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMateriales.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvMateriales.RowTemplate.Height = 28;
            this.dgvMateriales.Size = new System.Drawing.Size(729, 170);
            this.dgvMateriales.TabIndex = 9;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 250;
            // 
            // Descargar
            // 
            this.Descargar.HeaderText = "Descargar";
            this.Descargar.MinimumWidth = 8;
            this.Descargar.Name = "Descargar";
            this.Descargar.Width = 170;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 17F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(167, 658);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "Materiales:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 17F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(167, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 42);
            this.label5.TabIndex = 12;
            this.label5.Text = "Reuniones:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(916, 263);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(168, 34);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnAsitencia
            // 
            this.btnAsitencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnAsitencia.FlatAppearance.BorderSize = 0;
            this.btnAsitencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsitencia.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnAsitencia.ForeColor = System.Drawing.Color.White;
            this.btnAsitencia.Location = new System.Drawing.Point(738, 593);
            this.btnAsitencia.Name = "btnAsitencia";
            this.btnAsitencia.Size = new System.Drawing.Size(172, 40);
            this.btnAsitencia.TabIndex = 14;
            this.btnAsitencia.Text = "Asistencia";
            this.btnAsitencia.UseVisualStyleBackColor = false;
            this.btnAsitencia.Click += new System.EventHandler(this.btnAsitencia_Click);
            // 
            // bntConfigurarTiempo
            // 
            this.bntConfigurarTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.bntConfigurarTiempo.FlatAppearance.BorderSize = 0;
            this.bntConfigurarTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntConfigurarTiempo.Font = new System.Drawing.Font("Montserrat", 10F);
            this.bntConfigurarTiempo.ForeColor = System.Drawing.Color.White;
            this.bntConfigurarTiempo.Location = new System.Drawing.Point(916, 593);
            this.bntConfigurarTiempo.Name = "bntConfigurarTiempo";
            this.bntConfigurarTiempo.Size = new System.Drawing.Size(172, 40);
            this.bntConfigurarTiempo.TabIndex = 15;
            this.bntConfigurarTiempo.Text = "Editar";
            this.bntConfigurarTiempo.UseVisualStyleBackColor = false;
            // 
            // btnAgregarReunion
            // 
            this.btnAgregarReunion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnAgregarReunion.FlatAppearance.BorderSize = 0;
            this.btnAgregarReunion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarReunion.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnAgregarReunion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarReunion.Location = new System.Drawing.Point(1094, 392);
            this.btnAgregarReunion.Name = "btnAgregarReunion";
            this.btnAgregarReunion.Size = new System.Drawing.Size(41, 40);
            this.btnAgregarReunion.TabIndex = 16;
            this.btnAgregarReunion.Text = "+";
            this.btnAgregarReunion.UseVisualStyleBackColor = false;
            this.btnAgregarReunion.Click += new System.EventHandler(this.btnAgregarReunion_Click);
            // 
            // btnEliminarReunion
            // 
            this.btnEliminarReunion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnEliminarReunion.FlatAppearance.BorderSize = 0;
            this.btnEliminarReunion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarReunion.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnEliminarReunion.ForeColor = System.Drawing.Color.White;
            this.btnEliminarReunion.Location = new System.Drawing.Point(1094, 438);
            this.btnEliminarReunion.Name = "btnEliminarReunion";
            this.btnEliminarReunion.Size = new System.Drawing.Size(41, 40);
            this.btnEliminarReunion.TabIndex = 17;
            this.btnEliminarReunion.Text = "-";
            this.btnEliminarReunion.UseVisualStyleBackColor = false;
            // 
            // btnAgregarMaterial
            // 
            this.btnAgregarMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnAgregarMaterial.FlatAppearance.BorderSize = 0;
            this.btnAgregarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMaterial.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnAgregarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMaterial.Location = new System.Drawing.Point(905, 703);
            this.btnAgregarMaterial.Name = "btnAgregarMaterial";
            this.btnAgregarMaterial.Size = new System.Drawing.Size(41, 40);
            this.btnAgregarMaterial.TabIndex = 18;
            this.btnAgregarMaterial.Text = "+";
            this.btnAgregarMaterial.UseVisualStyleBackColor = false;
            this.btnAgregarMaterial.Click += new System.EventHandler(this.btnAgregarMaterial_Click);
            // 
            // btnEliminarMaterial
            // 
            this.btnEliminarMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnEliminarMaterial.FlatAppearance.BorderSize = 0;
            this.btnEliminarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMaterial.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnEliminarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnEliminarMaterial.Location = new System.Drawing.Point(905, 749);
            this.btnEliminarMaterial.Name = "btnEliminarMaterial";
            this.btnEliminarMaterial.Size = new System.Drawing.Size(41, 40);
            this.btnEliminarMaterial.TabIndex = 19;
            this.btnEliminarMaterial.Text = "-";
            this.btnEliminarMaterial.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(966, 861);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmModificarPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1233, 931);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminarMaterial);
            this.Controls.Add(this.btnAgregarMaterial);
            this.Controls.Add(this.btnEliminarReunion);
            this.Controls.Add(this.btnAgregarReunion);
            this.Controls.Add(this.bntConfigurarTiempo);
            this.Controls.Add(this.btnAsitencia);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMateriales);
            this.Controls.Add(this.dgvReuniones);
            this.Controls.Add(this.btnEditarDescrip);
            this.Controls.Add(this.rtxtTema);
            this.Controls.Add(this.rtxtDescripcion);
            this.Controls.Add(this.lblSemana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmModificarPrograma";
            this.Text = "frmModificarPrograma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReuniones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.RichTextBox rtxtTema;
        private System.Windows.Forms.Button btnEditarDescrip;
        private System.Windows.Forms.DataGridView dgvReuniones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewLinkColumn UnirseReunion;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewButtonColumn Descargar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAsitencia;
        private System.Windows.Forms.Button bntConfigurarTiempo;
        private System.Windows.Forms.Button btnAgregarReunion;
        private System.Windows.Forms.Button btnEliminarReunion;
        private System.Windows.Forms.Button btnAgregarMaterial;
        private System.Windows.Forms.Button btnEliminarMaterial;
        private System.Windows.Forms.Button button1;
    }
}