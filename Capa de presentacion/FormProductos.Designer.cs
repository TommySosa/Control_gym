namespace Control_Gym.Capa_de_presentacion
{
    partial class FormProductos
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
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.lblCodProveedor = new System.Windows.Forms.Label();
            this.lblCodTipoProducto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbCodTipoProducto = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodProveedor = new System.Windows.Forms.TextBox();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.btnBuscarCod = new System.Windows.Forms.Button();
            this.txtTipoP = new System.Windows.Forms.TextBox();
            this.dtpFechaVenc = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Location = new System.Drawing.Point(16, 41);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(74, 13);
            this.lblCodProducto.TabIndex = 0;
            this.lblCodProducto.Text = "Cod producto:";
            // 
            // lblCodProveedor
            // 
            this.lblCodProveedor.AutoSize = true;
            this.lblCodProveedor.Location = new System.Drawing.Point(16, 69);
            this.lblCodProveedor.Name = "lblCodProveedor";
            this.lblCodProveedor.Size = new System.Drawing.Size(80, 13);
            this.lblCodProveedor.TabIndex = 1;
            this.lblCodProveedor.Text = "Cod proveedor:";
            // 
            // lblCodTipoProducto
            // 
            this.lblCodTipoProducto.AutoSize = true;
            this.lblCodTipoProducto.Location = new System.Drawing.Point(16, 102);
            this.lblCodTipoProducto.Name = "lblCodTipoProducto";
            this.lblCodTipoProducto.Size = new System.Drawing.Size(109, 13);
            this.lblCodTipoProducto.TabIndex = 2;
            this.lblCodTipoProducto.Text = "Cod tipo de producto:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 137);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre: ";
            // 
            // cmbCodTipoProducto
            // 
            this.cmbCodTipoProducto.FormattingEnabled = true;
            this.cmbCodTipoProducto.Location = new System.Drawing.Point(556, 209);
            this.cmbCodTipoProducto.Name = "cmbCodTipoProducto";
            this.cmbCodTipoProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbCodTipoProducto.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(174, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtCodProveedor
            // 
            this.txtCodProveedor.Location = new System.Drawing.Point(174, 62);
            this.txtCodProveedor.Name = "txtCodProveedor";
            this.txtCodProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtCodProveedor.TabIndex = 10;
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(174, 36);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(100, 20);
            this.txtCodProducto.TabIndex = 11;
            this.txtCodProducto.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaVenc);
            this.groupBox1.Controls.Add(this.txtTipoP);
            this.groupBox1.Controls.Add(this.txtCod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.lblStock);
            this.groupBox1.Controls.Add(this.lblFechaVencimiento);
            this.groupBox1.Controls.Add(this.txtGanancia);
            this.groupBox1.Controls.Add(this.txtCosto);
            this.groupBox1.Controls.Add(this.txtPrecioVenta);
            this.groupBox1.Controls.Add(this.lblGanancia);
            this.groupBox1.Controls.Add(this.lblCosto);
            this.groupBox1.Controls.Add(this.lblPrecioVenta);
            this.groupBox1.Controls.Add(this.lblCodProducto);
            this.groupBox1.Controls.Add(this.txtCodProducto);
            this.groupBox1.Controls.Add(this.lblCodProveedor);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCodProveedor);
            this.groupBox1.Controls.Add(this.lblCodTipoProducto);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(56, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 346);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(174, 7);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Producto solicitante: ";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(174, 285);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 23;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(16, 292);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 22;
            this.lblStock.Text = "Stock:";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(16, 261);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(115, 13);
            this.lblFechaVencimiento.TabIndex = 20;
            this.lblFechaVencimiento.Text = "Fecha de vencimiento:";
            // 
            // txtGanancia
            // 
            this.txtGanancia.Location = new System.Drawing.Point(174, 225);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(100, 20);
            this.txtGanancia.TabIndex = 19;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(174, 195);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 18;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(174, 164);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 17;
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Location = new System.Drawing.Point(16, 232);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(56, 13);
            this.lblGanancia.TabIndex = 16;
            this.lblGanancia.Text = "Ganancia:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(16, 198);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(37, 13);
            this.lblCosto.TabIndex = 15;
            this.lblCosto.Text = "Costo:";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(16, 171);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(85, 13);
            this.lblPrecioVenta.TabIndex = 14;
            this.lblPrecioVenta.Text = "Precio de venta:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(20, 37);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 15;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(247, 37);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Borrar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(133, 37);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMostrar);
            this.groupBox2.Controls.Add(this.btnCrear);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Location = new System.Drawing.Point(536, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 104);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(363, 36);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 18;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(67, 393);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(933, 150);
            this.dgvProductos.TabIndex = 19;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(82, 367);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(110, 20);
            this.txtCodigoProducto.TabIndex = 20;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(79, 351);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(103, 13);
            this.lblCodigoProducto.TabIndex = 21;
            this.lblCodigoProducto.Text = "Codigo de producto:";
            // 
            // btnBuscarCod
            // 
            this.btnBuscarCod.Location = new System.Drawing.Point(218, 364);
            this.btnBuscarCod.Name = "btnBuscarCod";
            this.btnBuscarCod.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCod.TabIndex = 22;
            this.btnBuscarCod.Text = "Buscar";
            this.btnBuscarCod.UseVisualStyleBackColor = true;
            // 
            // txtTipoP
            // 
            this.txtTipoP.Location = new System.Drawing.Point(174, 99);
            this.txtTipoP.Name = "txtTipoP";
            this.txtTipoP.Size = new System.Drawing.Size(100, 20);
            this.txtTipoP.TabIndex = 26;
            // 
            // dtpFechaVenc
            // 
            this.dtpFechaVenc.Location = new System.Drawing.Point(174, 253);
            this.dtpFechaVenc.Name = "dtpFechaVenc";
            this.dtpFechaVenc.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVenc.TabIndex = 27;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 541);
            this.Controls.Add(this.btnBuscarCod);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCodTipoProducto);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.Label lblCodProveedor;
        private System.Windows.Forms.Label lblCodTipoProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbCodTipoProducto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodProveedor;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Button btnBuscarCod;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoP;
        private System.Windows.Forms.DateTimePicker dtpFechaVenc;
    }
}