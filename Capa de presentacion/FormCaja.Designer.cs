namespace Control_Gym.Capa_de_presentacion
{
    partial class FormCaja
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
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.dgvCuotas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalHoyCuotasResult = new System.Windows.Forms.Label();
            this.lblTotalMesCuotaResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalCuotasResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalHoyResult = new System.Windows.Forms.Label();
            this.lblTotalMesResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVentasResult = new System.Windows.Forms.Label();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(30, 36);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(563, 193);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVentas_RowHeaderMouseClick);
            // 
            // dgvCuotas
            // 
            this.dgvCuotas.AllowUserToAddRows = false;
            this.dgvCuotas.AllowUserToDeleteRows = false;
            this.dgvCuotas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuotas.Location = new System.Drawing.Point(30, 38);
            this.dgvCuotas.Name = "dgvCuotas";
            this.dgvCuotas.ReadOnly = true;
            this.dgvCuotas.Size = new System.Drawing.Size(563, 193);
            this.dgvCuotas.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalHoyCuotasResult);
            this.groupBox1.Controls.Add(this.lblTotalMesCuotaResult);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblTotalCuotasResult);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvCuotas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1050, 269);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membresias/Cuotas";
            // 
            // lblTotalHoyCuotasResult
            // 
            this.lblTotalHoyCuotasResult.AutoSize = true;
            this.lblTotalHoyCuotasResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHoyCuotasResult.Location = new System.Drawing.Point(804, 135);
            this.lblTotalHoyCuotasResult.Name = "lblTotalHoyCuotasResult";
            this.lblTotalHoyCuotasResult.Size = new System.Drawing.Size(40, 20);
            this.lblTotalHoyCuotasResult.TabIndex = 9;
            this.lblTotalHoyCuotasResult.Text = "0.00";
            // 
            // lblTotalMesCuotaResult
            // 
            this.lblTotalMesCuotaResult.AutoSize = true;
            this.lblTotalMesCuotaResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMesCuotaResult.Location = new System.Drawing.Point(804, 99);
            this.lblTotalMesCuotaResult.Name = "lblTotalMesCuotaResult";
            this.lblTotalMesCuotaResult.Size = new System.Drawing.Size(40, 20);
            this.lblTotalMesCuotaResult.TabIndex = 7;
            this.lblTotalMesCuotaResult.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(683, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "TOTAL HOY: $";
            // 
            // lblTotalCuotasResult
            // 
            this.lblTotalCuotasResult.AutoSize = true;
            this.lblTotalCuotasResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCuotasResult.Location = new System.Drawing.Point(804, 65);
            this.lblTotalCuotasResult.Name = "lblTotalCuotasResult";
            this.lblTotalCuotasResult.Size = new System.Drawing.Size(40, 20);
            this.lblTotalCuotasResult.TabIndex = 9;
            this.lblTotalCuotasResult.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(637, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "TOTAL ESTE MES: $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(722, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "TOTAL: $";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVerDetalle);
            this.groupBox2.Controls.Add(this.lblTotalHoyResult);
            this.groupBox2.Controls.Add(this.lblTotalMesResult);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblVentasResult);
            this.groupBox2.Controls.Add(this.lblTotalVentas);
            this.groupBox2.Controls.Add(this.dgvVentas);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1050, 269);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ventas realizadas";
            // 
            // lblTotalHoyResult
            // 
            this.lblTotalHoyResult.AutoSize = true;
            this.lblTotalHoyResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHoyResult.Location = new System.Drawing.Point(804, 153);
            this.lblTotalHoyResult.Name = "lblTotalHoyResult";
            this.lblTotalHoyResult.Size = new System.Drawing.Size(40, 20);
            this.lblTotalHoyResult.TabIndex = 7;
            this.lblTotalHoyResult.Text = "0.00";
            // 
            // lblTotalMesResult
            // 
            this.lblTotalMesResult.AutoSize = true;
            this.lblTotalMesResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMesResult.Location = new System.Drawing.Point(804, 121);
            this.lblTotalMesResult.Name = "lblTotalMesResult";
            this.lblTotalMesResult.Size = new System.Drawing.Size(40, 20);
            this.lblTotalMesResult.TabIndex = 4;
            this.lblTotalMesResult.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(683, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "TOTAL HOY: $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "TOTAL ESTE MES: $";
            // 
            // lblVentasResult
            // 
            this.lblVentasResult.AutoSize = true;
            this.lblVentasResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasResult.Location = new System.Drawing.Point(804, 88);
            this.lblVentasResult.Name = "lblVentasResult";
            this.lblVentasResult.Size = new System.Drawing.Size(40, 20);
            this.lblVentasResult.TabIndex = 2;
            this.lblVentasResult.Text = "0.00";
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.Location = new System.Drawing.Point(722, 88);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(76, 20);
            this.lblTotalVentas.TabIndex = 1;
            this.lblTotalVentas.Text = "TOTAL: $";
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnVerDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerDetalle.Location = new System.Drawing.Point(743, 199);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(92, 30);
            this.btnVerDetalle.TabIndex = 6;
            this.btnVerDetalle.Text = "Ver detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // FormCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 605);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCaja";
            this.Text = "FormCaja";
            this.Load += new System.EventHandler(this.FormCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridView dgvCuotas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Label lblVentasResult;
        private System.Windows.Forms.Label lblTotalMesResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalHoyResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalCuotasResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalMesCuotaResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalHoyCuotasResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVerDetalle;
    }
}