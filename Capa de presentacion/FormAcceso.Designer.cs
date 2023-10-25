namespace Control_Gym.Capa_de_presentacion
{
    partial class FormAcceso
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
            this.txtDniEmpleado = new System.Windows.Forms.TextBox();
            this.txtContraseñaEmpleado = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDniEmpleado
            // 
            this.txtDniEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniEmpleado.Location = new System.Drawing.Point(98, 29);
            this.txtDniEmpleado.Name = "txtDniEmpleado";
            this.txtDniEmpleado.Size = new System.Drawing.Size(129, 25);
            this.txtDniEmpleado.TabIndex = 2;
            this.txtDniEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniEmpleado_KeyPress);
            // 
            // txtContraseñaEmpleado
            // 
            this.txtContraseñaEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaEmpleado.Location = new System.Drawing.Point(98, 73);
            this.txtContraseñaEmpleado.Name = "txtContraseñaEmpleado";
            this.txtContraseñaEmpleado.PasswordChar = '*';
            this.txtContraseñaEmpleado.Size = new System.Drawing.Size(129, 25);
            this.txtContraseñaEmpleado.TabIndex = 3;
            this.txtContraseñaEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseñaEmpleado_KeyPress);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.AutoEllipsis = true;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciarSesion.Location = new System.Drawing.Point(110, 113);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(102, 27);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtContraseñaEmpleado);
            this.groupBox1.Controls.Add(this.btnIniciarSesion);
            this.groupBox1.Controls.Add(this.lblDni);
            this.groupBox1.Controls.Add(this.lblContraseña);
            this.groupBox1.Controls.Add(this.txtDniEmpleado);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(330, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 191);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa los datos";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(13, 35);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 17);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(13, 76);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(77, 17);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // FormAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(960, 377);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAcceso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDniEmpleado;
        private System.Windows.Forms.TextBox txtContraseñaEmpleado;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblContraseña;
    }
}