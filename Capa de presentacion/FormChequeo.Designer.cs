namespace Control_Gym.Capa_de_presentacion
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
            this.label7 = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.pbAdministradores = new System.Windows.Forms.PictureBox();
            this.btnlogoInicio = new System.Windows.Forms.PictureBox();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.iconmaximizar = new System.Windows.Forms.PictureBox();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.pbNeutro = new System.Windows.Forms.PictureBox();
            this.pbNo = new System.Windows.Forms.PictureBox();
            this.pbYes = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoMembresia = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeutro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(290, 116);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 38);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDni
            // 
            this.txtDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(31, 99);
            this.txtDni.Multiline = true;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(253, 72);
            this.txtDni.TabIndex = 1;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(413, 223);
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
            this.lblInicio.Location = new System.Drawing.Point(493, 223);
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
            this.label3.Location = new System.Drawing.Point(598, 223);
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
            this.lblFin.Location = new System.Drawing.Point(655, 223);
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
            this.label5.Location = new System.Drawing.Point(410, 272);
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
            this.lblDiasRestantes.Location = new System.Drawing.Point(575, 272);
            this.lblDiasRestantes.Name = "lblDiasRestantes";
            this.lblDiasRestantes.Size = new System.Drawing.Size(24, 30);
            this.lblDiasRestantes.TabIndex = 10;
            this.lblDiasRestantes.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(410, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tipo de Membresía :";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BarraTitulo.Controls.Add(this.btnlogoInicio);
            this.BarraTitulo.Controls.Add(this.iconminimizar);
            this.BarraTitulo.Controls.Add(this.iconcerrar);
            this.BarraTitulo.Controls.Add(this.iconmaximizar);
            this.BarraTitulo.Controls.Add(this.iconrestaurar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(800, 45);
            this.BarraTitulo.TabIndex = 12;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // pbAdministradores
            // 
            this.pbAdministradores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAdministradores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdministradores.Image = global::Control_Gym.Properties.Resources.Settings;
            this.pbAdministradores.Location = new System.Drawing.Point(31, 392);
            this.pbAdministradores.Name = "pbAdministradores";
            this.pbAdministradores.Size = new System.Drawing.Size(100, 50);
            this.pbAdministradores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdministradores.TabIndex = 13;
            this.pbAdministradores.TabStop = false;
            this.pbAdministradores.Click += new System.EventHandler(this.pbAdministradores_Click);
            // 
            // btnlogoInicio
            // 
            this.btnlogoInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogoInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnlogoInicio.Image")));
            this.btnlogoInicio.Location = new System.Drawing.Point(3, 3);
            this.btnlogoInicio.Name = "btnlogoInicio";
            this.btnlogoInicio.Size = new System.Drawing.Size(240, 39);
            this.btnlogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlogoInicio.TabIndex = 13;
            this.btnlogoInicio.TabStop = false;
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconminimizar.Image")));
            this.iconminimizar.Location = new System.Drawing.Point(721, 5);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(18, 18);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 4;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(771, 5);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(18, 18);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 1;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // iconmaximizar
            // 
            this.iconmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconmaximizar.Image")));
            this.iconmaximizar.Location = new System.Drawing.Point(745, 5);
            this.iconmaximizar.Name = "iconmaximizar";
            this.iconmaximizar.Size = new System.Drawing.Size(18, 18);
            this.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmaximizar.TabIndex = 2;
            this.iconmaximizar.TabStop = false;
            this.iconmaximizar.Click += new System.EventHandler(this.iconmaximizar_Click);
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconrestaurar.Image")));
            this.iconrestaurar.Location = new System.Drawing.Point(745, 5);
            this.iconrestaurar.Name = "iconrestaurar";
            this.iconrestaurar.Size = new System.Drawing.Size(18, 18);
            this.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconrestaurar.TabIndex = 3;
            this.iconrestaurar.TabStop = false;
            this.iconrestaurar.Visible = false;
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // pbNeutro
            // 
            this.pbNeutro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbNeutro.Image = global::Control_Gym.Properties.Resources.NEUTRO1;
            this.pbNeutro.Location = new System.Drawing.Point(459, 71);
            this.pbNeutro.Name = "pbNeutro";
            this.pbNeutro.Size = new System.Drawing.Size(220, 134);
            this.pbNeutro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNeutro.TabIndex = 4;
            this.pbNeutro.TabStop = false;
            // 
            // pbNo
            // 
            this.pbNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbNo.Image = global::Control_Gym.Properties.Resources.NO;
            this.pbNo.Location = new System.Drawing.Point(459, 71);
            this.pbNo.Name = "pbNo";
            this.pbNo.Size = new System.Drawing.Size(220, 134);
            this.pbNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNo.TabIndex = 3;
            this.pbNo.TabStop = false;
            // 
            // pbYes
            // 
            this.pbYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbYes.Image = global::Control_Gym.Properties.Resources.YES;
            this.pbYes.Location = new System.Drawing.Point(459, 71);
            this.pbYes.Name = "pbYes";
            this.pbYes.Size = new System.Drawing.Size(220, 134);
            this.pbYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbYes.TabIndex = 2;
            this.pbYes.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(12, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Administradores";
            // 
            // cmbTipoMembresia
            // 
            this.cmbTipoMembresia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoMembresia.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoMembresia.FormattingEnabled = true;
            this.cmbTipoMembresia.Location = new System.Drawing.Point(415, 351);
            this.cmbTipoMembresia.Name = "cmbTipoMembresia";
            this.cmbTipoMembresia.Size = new System.Drawing.Size(176, 36);
            this.cmbTipoMembresia.TabIndex = 15;
            this.cmbTipoMembresia.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMembresia_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormChequeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTipoMembresia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbAdministradores);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDiasRestantes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbNeutro);
            this.Controls.Add(this.pbNo);
            this.Controls.Add(this.pbYes);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnBuscar);
            this.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FormChequeo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChequeo";
            this.Load += new System.EventHandler(this.FormChequeo_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeutro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNo)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.PictureBox iconmaximizar;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.PictureBox btnlogoInicio;
        private System.Windows.Forms.PictureBox pbAdministradores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoMembresia;
        private System.Windows.Forms.Timer timer1;
    }
}