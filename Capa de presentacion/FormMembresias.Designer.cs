namespace Control_Gym.Capa_de_presentacion
{
    partial class FormMembresias
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
            this.txtDniMembresia = new System.Windows.Forms.TextBox();
            this.lblDniMembresia = new System.Windows.Forms.Label();
            this.btnActualizarMembresia = new System.Windows.Forms.Button();
            this.btnEliminarMembresia = new System.Windows.Forms.Button();
            this.btnCancelarMembresia = new System.Windows.Forms.Button();
            this.btnCrearMembresia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvgMembresias = new System.Windows.Forms.DataGridView();
            this.txtBuscarDni = new System.Windows.Forms.TextBox();
            this.btnBuscarMembresia = new System.Windows.Forms.Button();
            this.lblDni2Membresia = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTipoMembresia = new System.Windows.Forms.ComboBox();
            this.lblTipoMembresia = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinMembresia = new System.Windows.Forms.Label();
            this.lblFechaInicioMembresia = new System.Windows.Forms.Label();
            this.txtCodMembresia = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMembresias)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDniMembresia
            // 
            this.txtDniMembresia.Location = new System.Drawing.Point(137, 26);
            this.txtDniMembresia.Name = "txtDniMembresia";
            this.txtDniMembresia.Size = new System.Drawing.Size(200, 20);
            this.txtDniMembresia.TabIndex = 1;
            // 
            // lblDniMembresia
            // 
            this.lblDniMembresia.AutoSize = true;
            this.lblDniMembresia.Location = new System.Drawing.Point(19, 29);
            this.lblDniMembresia.Name = "lblDniMembresia";
            this.lblDniMembresia.Size = new System.Drawing.Size(26, 13);
            this.lblDniMembresia.TabIndex = 7;
            this.lblDniMembresia.Text = "DNI";
            // 
            // btnActualizarMembresia
            // 
            this.btnActualizarMembresia.Location = new System.Drawing.Point(3, 27);
            this.btnActualizarMembresia.Name = "btnActualizarMembresia";
            this.btnActualizarMembresia.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarMembresia.TabIndex = 8;
            this.btnActualizarMembresia.Text = "Actualizar";
            this.btnActualizarMembresia.UseVisualStyleBackColor = true;
            this.btnActualizarMembresia.Click += new System.EventHandler(this.btnActualizarMembresia_Click);
            // 
            // btnEliminarMembresia
            // 
            this.btnEliminarMembresia.Location = new System.Drawing.Point(106, 27);
            this.btnEliminarMembresia.Name = "btnEliminarMembresia";
            this.btnEliminarMembresia.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMembresia.TabIndex = 6;
            this.btnEliminarMembresia.Text = "Eliminar";
            this.btnEliminarMembresia.UseVisualStyleBackColor = true;
            this.btnEliminarMembresia.Click += new System.EventHandler(this.btnEliminarMembresia_Click);
            // 
            // btnCancelarMembresia
            // 
            this.btnCancelarMembresia.Location = new System.Drawing.Point(218, 27);
            this.btnCancelarMembresia.Name = "btnCancelarMembresia";
            this.btnCancelarMembresia.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMembresia.TabIndex = 7;
            this.btnCancelarMembresia.Text = "Cancelar";
            this.btnCancelarMembresia.UseVisualStyleBackColor = true;
            this.btnCancelarMembresia.Click += new System.EventHandler(this.btnCancelarMembresia_Click);
            // 
            // btnCrearMembresia
            // 
            this.btnCrearMembresia.Location = new System.Drawing.Point(3, 27);
            this.btnCrearMembresia.Name = "btnCrearMembresia";
            this.btnCrearMembresia.Size = new System.Drawing.Size(75, 23);
            this.btnCrearMembresia.TabIndex = 5;
            this.btnCrearMembresia.Text = "Crear";
            this.btnCrearMembresia.UseVisualStyleBackColor = true;
            this.btnCrearMembresia.Click += new System.EventHandler(this.btnCrearMembresia_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCrearMembresia);
            this.panel1.Controls.Add(this.btnActualizarMembresia);
            this.panel1.Controls.Add(this.btnEliminarMembresia);
            this.panel1.Controls.Add(this.btnCancelarMembresia);
            this.panel1.Location = new System.Drawing.Point(585, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 111);
            this.panel1.TabIndex = 19;
            // 
            // dvgMembresias
            // 
            this.dvgMembresias.AllowUserToAddRows = false;
            this.dvgMembresias.AllowUserToDeleteRows = false;
            this.dvgMembresias.AllowUserToOrderColumns = true;
            this.dvgMembresias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgMembresias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMembresias.Location = new System.Drawing.Point(65, 343);
            this.dvgMembresias.MultiSelect = false;
            this.dvgMembresias.Name = "dvgMembresias";
            this.dvgMembresias.ReadOnly = true;
            this.dvgMembresias.Size = new System.Drawing.Size(921, 211);
            this.dvgMembresias.TabIndex = 11;
            this.dvgMembresias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMembresias_CellClick);
            this.dvgMembresias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dvgMembresias_CellFormatting);
            // 
            // txtBuscarDni
            // 
            this.txtBuscarDni.Location = new System.Drawing.Point(65, 303);
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.Size = new System.Drawing.Size(189, 20);
            this.txtBuscarDni.TabIndex = 9;
            // 
            // btnBuscarMembresia
            // 
            this.btnBuscarMembresia.Location = new System.Drawing.Point(270, 301);
            this.btnBuscarMembresia.Name = "btnBuscarMembresia";
            this.btnBuscarMembresia.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMembresia.TabIndex = 10;
            this.btnBuscarMembresia.Text = "Buscar";
            this.btnBuscarMembresia.UseVisualStyleBackColor = true;
            this.btnBuscarMembresia.Click += new System.EventHandler(this.btnBuscarMembresia_Click);
            // 
            // lblDni2Membresia
            // 
            this.lblDni2Membresia.AutoSize = true;
            this.lblDni2Membresia.Location = new System.Drawing.Point(62, 287);
            this.lblDni2Membresia.Name = "lblDni2Membresia";
            this.lblDni2Membresia.Size = new System.Drawing.Size(26, 13);
            this.lblDni2Membresia.TabIndex = 14;
            this.lblDni2Membresia.Text = "DNI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTipoMembresia);
            this.groupBox2.Controls.Add(this.lblTipoMembresia);
            this.groupBox2.Controls.Add(this.dtpFechaFin);
            this.groupBox2.Controls.Add(this.dtpFechaInicio);
            this.groupBox2.Controls.Add(this.lblFechaFinMembresia);
            this.groupBox2.Controls.Add(this.lblFechaInicioMembresia);
            this.groupBox2.Controls.Add(this.txtDniMembresia);
            this.groupBox2.Controls.Add(this.lblDniMembresia);
            this.groupBox2.Location = new System.Drawing.Point(133, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 157);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del socio";
            // 
            // cbTipoMembresia
            // 
            this.cbTipoMembresia.FormattingEnabled = true;
            this.cbTipoMembresia.Location = new System.Drawing.Point(137, 57);
            this.cbTipoMembresia.Name = "cbTipoMembresia";
            this.cbTipoMembresia.Size = new System.Drawing.Size(200, 21);
            this.cbTipoMembresia.TabIndex = 2;
            this.cbTipoMembresia.SelectedIndexChanged += new System.EventHandler(this.cbTipoMembresia_SelectedIndexChanged);
            // 
            // lblTipoMembresia
            // 
            this.lblTipoMembresia.AutoSize = true;
            this.lblTipoMembresia.Location = new System.Drawing.Point(19, 62);
            this.lblTipoMembresia.Name = "lblTipoMembresia";
            this.lblTipoMembresia.Size = new System.Drawing.Size(96, 13);
            this.lblTipoMembresia.TabIndex = 24;
            this.lblTipoMembresia.Text = "Tipo de membresia";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaFin.Location = new System.Drawing.Point(137, 123);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 4;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(137, 91);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 3;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // lblFechaFinMembresia
            // 
            this.lblFechaFinMembresia.AutoSize = true;
            this.lblFechaFinMembresia.Location = new System.Drawing.Point(19, 123);
            this.lblFechaFinMembresia.Name = "lblFechaFinMembresia";
            this.lblFechaFinMembresia.Size = new System.Drawing.Size(54, 13);
            this.lblFechaFinMembresia.TabIndex = 10;
            this.lblFechaFinMembresia.Text = "Fecha Fin";
            // 
            // lblFechaInicioMembresia
            // 
            this.lblFechaInicioMembresia.AutoSize = true;
            this.lblFechaInicioMembresia.Location = new System.Drawing.Point(19, 91);
            this.lblFechaInicioMembresia.Name = "lblFechaInicioMembresia";
            this.lblFechaInicioMembresia.Size = new System.Drawing.Size(65, 13);
            this.lblFechaInicioMembresia.TabIndex = 8;
            this.lblFechaInicioMembresia.Text = "Fecha Inicio";
            // 
            // txtCodMembresia
            // 
            this.txtCodMembresia.Location = new System.Drawing.Point(155, 231);
            this.txtCodMembresia.Name = "txtCodMembresia";
            this.txtCodMembresia.Size = new System.Drawing.Size(100, 20);
            this.txtCodMembresia.TabIndex = 22;
            this.txtCodMembresia.Visible = false;
            // 
            // FormMembresias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 584);
            this.Controls.Add(this.txtCodMembresia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblDni2Membresia);
            this.Controls.Add(this.btnBuscarMembresia);
            this.Controls.Add(this.txtBuscarDni);
            this.Controls.Add(this.dvgMembresias);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMembresias";
            this.Text = "FormMembresias";
            this.Load += new System.EventHandler(this.FormMembresias_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMembresias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDniMembresia;
        private System.Windows.Forms.Label lblDniMembresia;
        private System.Windows.Forms.Button btnActualizarMembresia;
        private System.Windows.Forms.Button btnEliminarMembresia;
        private System.Windows.Forms.Button btnCancelarMembresia;
        private System.Windows.Forms.Button btnCrearMembresia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dvgMembresias;
        private System.Windows.Forms.TextBox txtBuscarDni;
        private System.Windows.Forms.Button btnBuscarMembresia;
        private System.Windows.Forms.Label lblDni2Membresia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFechaFinMembresia;
        private System.Windows.Forms.Label lblFechaInicioMembresia;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.ComboBox cbTipoMembresia;
        private System.Windows.Forms.Label lblTipoMembresia;
        private System.Windows.Forms.TextBox txtCodMembresia;
    }
}