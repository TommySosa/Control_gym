﻿namespace Control_Gym.Capa_de_presentacion
{
    partial class FormChequeo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChequeo));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDiasRestantes = new System.Windows.Forms.Label();
            this.lblTipoMembresia = new System.Windows.Forms.Label();
            this.cmbTipoMembresia = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbWarning = new System.Windows.Forms.PictureBox();
            this.pbNeutro = new System.Windows.Forms.PictureBox();
            this.pbNo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbYes = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeutro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(530, 62);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 38);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDni
            // 
            this.txtDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(12, 12);
            this.txtDni.Multiline = true;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(512, 141);
            this.txtDni.TabIndex = 0;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDni_KeyDown);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            this.txtDni.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtDni_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(12, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inicio :";
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(92, 207);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(24, 30);
            this.lblInicio.TabIndex = 6;
            this.lblInicio.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(226, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fin :";
            // 
            // lblFin
            // 
            this.lblFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(283, 207);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(24, 30);
            this.lblFin.TabIndex = 8;
            this.lblFin.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(12, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dias Restantes :";
            // 
            // lblDiasRestantes
            // 
            this.lblDiasRestantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiasRestantes.AutoSize = true;
            this.lblDiasRestantes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasRestantes.Location = new System.Drawing.Point(177, 249);
            this.lblDiasRestantes.Name = "lblDiasRestantes";
            this.lblDiasRestantes.Size = new System.Drawing.Size(24, 30);
            this.lblDiasRestantes.TabIndex = 10;
            this.lblDiasRestantes.Text = "0";
            // 
            // lblTipoMembresia
            // 
            this.lblTipoMembresia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoMembresia.AutoSize = true;
            this.lblTipoMembresia.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMembresia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTipoMembresia.Location = new System.Drawing.Point(12, 292);
            this.lblTipoMembresia.Name = "lblTipoMembresia";
            this.lblTipoMembresia.Size = new System.Drawing.Size(202, 30);
            this.lblTipoMembresia.TabIndex = 11;
            this.lblTipoMembresia.Text = "Tipo de Membresía :";
            // 
            // cmbTipoMembresia
            // 
            this.cmbTipoMembresia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoMembresia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoMembresia.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoMembresia.FormattingEnabled = true;
            this.cmbTipoMembresia.Location = new System.Drawing.Point(220, 286);
            this.cmbTipoMembresia.Name = "cmbTipoMembresia";
            this.cmbTipoMembresia.Size = new System.Drawing.Size(176, 36);
            this.cmbTipoMembresia.TabIndex = 2;
            this.cmbTipoMembresia.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMembresia_SelectedIndexChanged);
            this.cmbTipoMembresia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTipoMembresia_KeyDown);
            this.cmbTipoMembresia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmbTipoMembresia_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbWarning
            // 
            this.pbWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbWarning.BackColor = System.Drawing.Color.Transparent;
            this.pbWarning.Image = ((System.Drawing.Image)(resources.GetObject("pbWarning.Image")));
            this.pbWarning.Location = new System.Drawing.Point(673, 39);
            this.pbWarning.Name = "pbWarning";
            this.pbWarning.Size = new System.Drawing.Size(230, 230);
            this.pbWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWarning.TabIndex = 17;
            this.pbWarning.TabStop = false;
            // 
            // pbNeutro
            // 
            this.pbNeutro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbNeutro.BackColor = System.Drawing.Color.Transparent;
            this.pbNeutro.Image = ((System.Drawing.Image)(resources.GetObject("pbNeutro.Image")));
            this.pbNeutro.Location = new System.Drawing.Point(673, 39);
            this.pbNeutro.Name = "pbNeutro";
            this.pbNeutro.Size = new System.Drawing.Size(230, 230);
            this.pbNeutro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNeutro.TabIndex = 4;
            this.pbNeutro.TabStop = false;
            // 
            // pbNo
            // 
            this.pbNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbNo.BackColor = System.Drawing.Color.Transparent;
            this.pbNo.Image = ((System.Drawing.Image)(resources.GetObject("pbNo.Image")));
            this.pbNo.Location = new System.Drawing.Point(673, 39);
            this.pbNo.Name = "pbNo";
            this.pbNo.Size = new System.Drawing.Size(230, 230);
            this.pbNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNo.TabIndex = 3;
            this.pbNo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(599, -33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pbYes
            // 
            this.pbYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbYes.BackColor = System.Drawing.Color.Transparent;
            this.pbYes.Image = ((System.Drawing.Image)(resources.GetObject("pbYes.Image")));
            this.pbYes.Location = new System.Drawing.Point(673, 39);
            this.pbYes.Name = "pbYes";
            this.pbYes.Size = new System.Drawing.Size(230, 230);
            this.pbYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbYes.TabIndex = 2;
            this.pbYes.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre y Apellido :";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(216, 167);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(171, 30);
            this.lblNombreCompleto.TabIndex = 19;
            this.lblNombreCompleto.Text = "Nombre Apellido";
            // 
            // FormChequeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(960, 377);
            this.Controls.Add(this.lblNombreCompleto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoMembresia);
            this.Controls.Add(this.lblTipoMembresia);
            this.Controls.Add(this.lblDiasRestantes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pbNeutro);
            this.Controls.Add(this.pbNo);
            this.Controls.Add(this.pbYes);
            this.Controls.Add(this.pbWarning);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FormChequeo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChequeo";
            this.Load += new System.EventHandler(this.FormChequeo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeutro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.PictureBox pbYes;
        private System.Windows.Forms.PictureBox pbNo;
        private System.Windows.Forms.PictureBox pbNeutro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDiasRestantes;
        private System.Windows.Forms.Label lblTipoMembresia;
        private System.Windows.Forms.ComboBox cmbTipoMembresia;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbWarning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreCompleto;
    }
}