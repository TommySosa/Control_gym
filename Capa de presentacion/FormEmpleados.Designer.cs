﻿namespace Control_Gym.Capa_de_presentacion
{
    partial class FormEmpleados
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
            this.dtvEmpleado = new System.Windows.Forms.DataGridView();
            this.btnGuardarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnCancelarEmpleado = new System.Windows.Forms.Button();
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.txtDomicilioEmpleado = new System.Windows.Forms.TextBox();
            this.txtEmailEmpleado = new System.Windows.Forms.TextBox();
            this.txtContraseñaEmpleado = new System.Windows.Forms.TextBox();
            this.dtpFechNacEmpleado = new System.Windows.Forms.DateTimePicker();
            this.mtxtDniEmpleado = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvEmpleado
            // 
            this.dtvEmpleado.AllowUserToAddRows = false;
            this.dtvEmpleado.AllowUserToDeleteRows = false;
            this.dtvEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvEmpleado.Location = new System.Drawing.Point(5, 28);
            this.dtvEmpleado.Name = "dtvEmpleado";
            this.dtvEmpleado.ReadOnly = true;
            this.dtvEmpleado.Size = new System.Drawing.Size(698, 394);
            this.dtvEmpleado.TabIndex = 100;
            this.dtvEmpleado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtvEmpleado_CellFormatting);
            this.dtvEmpleado.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtvEmpleado_RowHeaderMouseClick);
            // 
            // btnGuardarEmpleado
            // 
            this.btnGuardarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGuardarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEmpleado.Location = new System.Drawing.Point(802, 329);
            this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            this.btnGuardarEmpleado.Size = new System.Drawing.Size(75, 30);
            this.btnGuardarEmpleado.TabIndex = 8;
            this.btnGuardarEmpleado.Text = "Agregar";
            this.btnGuardarEmpleado.UseVisualStyleBackColor = false;
            this.btnGuardarEmpleado.Click += new System.EventHandler(this.btnGuardarEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(883, 329);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(75, 30);
            this.btnEliminarEmpleado.TabIndex = 9;
            this.btnEliminarEmpleado.Text = "Eliminar";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnCancelarEmpleado
            // 
            this.btnCancelarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelarEmpleado.BackColor = System.Drawing.Color.Gray;
            this.btnCancelarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarEmpleado.Location = new System.Drawing.Point(802, 365);
            this.btnCancelarEmpleado.Name = "btnCancelarEmpleado";
            this.btnCancelarEmpleado.Size = new System.Drawing.Size(75, 30);
            this.btnCancelarEmpleado.TabIndex = 10;
            this.btnCancelarEmpleado.Text = "Cancelar";
            this.btnCancelarEmpleado.UseVisualStyleBackColor = false;
            this.btnCancelarEmpleado.Click += new System.EventHandler(this.btnCancelarEmpleado_Click);
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizarEmpleado.BackColor = System.Drawing.Color.ForestGreen;
            this.btnActualizarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(802, 329);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(75, 30);
            this.btnActualizarEmpleado.TabIndex = 11;
            this.btnActualizarEmpleado.Text = "Modificar";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = false;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(732, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(732, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(732, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Télefono:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(732, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fech. Nac:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(732, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Domicilio:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(732, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "E-Mail:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(732, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Contraseña:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(802, 66);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(156, 20);
            this.txtNombreEmpleado.TabIndex = 1;
            this.txtNombreEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreEmpleado_KeyDown);
            this.txtNombreEmpleado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtNombreEmpleado_MouseDown);
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(802, 105);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(156, 20);
            this.txtApellidoEmpleado.TabIndex = 2;
            this.txtApellidoEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApellidoEmpleado_KeyDown);
            this.txtApellidoEmpleado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtApellidoEmpleado_MouseDown);
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(802, 138);
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(156, 20);
            this.txtTelefonoEmpleado.TabIndex = 3;
            this.txtTelefonoEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefonoEmpleado_KeyDown);
            this.txtTelefonoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoEmpleado_KeyPress);
            this.txtTelefonoEmpleado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTelefonoEmpleado_MouseDown);
            // 
            // txtDomicilioEmpleado
            // 
            this.txtDomicilioEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDomicilioEmpleado.Location = new System.Drawing.Point(802, 209);
            this.txtDomicilioEmpleado.Name = "txtDomicilioEmpleado";
            this.txtDomicilioEmpleado.Size = new System.Drawing.Size(156, 20);
            this.txtDomicilioEmpleado.TabIndex = 5;
            this.txtDomicilioEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDomicilioEmpleado_KeyDown);
            this.txtDomicilioEmpleado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtDomicilioEmpleado_MouseDown);
            // 
            // txtEmailEmpleado
            // 
            this.txtEmailEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailEmpleado.Location = new System.Drawing.Point(802, 245);
            this.txtEmailEmpleado.Name = "txtEmailEmpleado";
            this.txtEmailEmpleado.Size = new System.Drawing.Size(156, 20);
            this.txtEmailEmpleado.TabIndex = 6;
            this.txtEmailEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmailEmpleado_KeyDown);
            this.txtEmailEmpleado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtEmailEmpleado_MouseDown);
            // 
            // txtContraseñaEmpleado
            // 
            this.txtContraseñaEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContraseñaEmpleado.Location = new System.Drawing.Point(802, 285);
            this.txtContraseñaEmpleado.Name = "txtContraseñaEmpleado";
            this.txtContraseñaEmpleado.Size = new System.Drawing.Size(156, 20);
            this.txtContraseñaEmpleado.TabIndex = 7;
            this.txtContraseñaEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraseñaEmpleado_KeyDown);
            this.txtContraseñaEmpleado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtContraseñaEmpleado_MouseDown);
            // 
            // dtpFechNacEmpleado
            // 
            this.dtpFechNacEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechNacEmpleado.Location = new System.Drawing.Point(802, 174);
            this.dtpFechNacEmpleado.Name = "dtpFechNacEmpleado";
            this.dtpFechNacEmpleado.Size = new System.Drawing.Size(156, 20);
            this.dtpFechNacEmpleado.TabIndex = 4;
            // 
            // mtxtDniEmpleado
            // 
            this.mtxtDniEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtDniEmpleado.Location = new System.Drawing.Point(802, 28);
            this.mtxtDniEmpleado.Name = "mtxtDniEmpleado";
            this.mtxtDniEmpleado.Size = new System.Drawing.Size(156, 20);
            this.mtxtDniEmpleado.TabIndex = 0;
            this.mtxtDniEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtDniEmpleado_KeyDown);
            this.mtxtDniEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtDniEmpleado_KeyPress);
            this.mtxtDniEmpleado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mtxtDniEmpleado_MouseDown);
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(974, 448);
            this.Controls.Add(this.mtxtDniEmpleado);
            this.Controls.Add(this.dtpFechNacEmpleado);
            this.Controls.Add(this.txtContraseñaEmpleado);
            this.Controls.Add(this.txtEmailEmpleado);
            this.Controls.Add(this.txtDomicilioEmpleado);
            this.Controls.Add(this.txtTelefonoEmpleado);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarEmpleado);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.dtvEmpleado);
            this.Controls.Add(this.btnGuardarEmpleado);
            this.Controls.Add(this.btnActualizarEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpleados";
            this.Text = "FormEmpleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvEmpleado;
        private System.Windows.Forms.Button btnGuardarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnCancelarEmpleado;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.TextBox txtTelefonoEmpleado;
        private System.Windows.Forms.TextBox txtDomicilioEmpleado;
        private System.Windows.Forms.TextBox txtEmailEmpleado;
        private System.Windows.Forms.TextBox txtContraseñaEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFechNacEmpleado;
        private System.Windows.Forms.MaskedTextBox mtxtDniEmpleado;
    }
}