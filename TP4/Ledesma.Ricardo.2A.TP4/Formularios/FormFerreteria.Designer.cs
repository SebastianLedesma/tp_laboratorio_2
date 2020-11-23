namespace Formularios
{
    partial class FormFerreteria
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdCarrito = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSockCinta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStockEscalera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStockMartillo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockTaladro = new System.Windows.Forms.TextBox();
            this.btnPedirMercaderia = new System.Windows.Forms.Button();
            this.btnDetenerStockeo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMedioDePago = new System.Windows.Forms.ComboBox();
            this.btnVentasGeneradas = new System.Windows.Forms.Button();
            this.richtxtDetalle = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de productos:";
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Items.AddRange(new object[] {
            "Cinta",
            "Escalera",
            "Martillo",
            "Taladro"});
            this.cmbProductos.Location = new System.Drawing.Point(55, 69);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(267, 21);
            this.cmbProductos.TabIndex = 1;
            this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.cmbProductos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detalle del carrito:";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(55, 288);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(106, 44);
            this.btnVender.TabIndex = 4;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Location = new System.Drawing.Point(216, 288);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(106, 44);
            this.btnCancelarVenta.TabIndex = 5;
            this.btnCancelarVenta.Text = "Cancelar venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Productos del carrito:";
            // 
            // txtProdCarrito
            // 
            this.txtProdCarrito.Location = new System.Drawing.Point(456, 316);
            this.txtProdCarrito.Name = "txtProdCarrito";
            this.txtProdCarrito.ReadOnly = true;
            this.txtProdCarrito.Size = new System.Drawing.Size(50, 20);
            this.txtProdCarrito.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSockCinta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtStockEscalera);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtStockMartillo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStockTaladro);
            this.groupBox1.Location = new System.Drawing.Point(12, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 50);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock disponible";
            // 
            // txtSockCinta
            // 
            this.txtSockCinta.Location = new System.Drawing.Point(442, 16);
            this.txtSockCinta.Name = "txtSockCinta";
            this.txtSockCinta.ReadOnly = true;
            this.txtSockCinta.Size = new System.Drawing.Size(60, 20);
            this.txtSockCinta.TabIndex = 12;
            this.txtSockCinta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cinta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Escalera:";
            // 
            // txtStockEscalera
            // 
            this.txtStockEscalera.Location = new System.Drawing.Point(63, 19);
            this.txtStockEscalera.Name = "txtStockEscalera";
            this.txtStockEscalera.ReadOnly = true;
            this.txtStockEscalera.Size = new System.Drawing.Size(60, 20);
            this.txtStockEscalera.TabIndex = 10;
            this.txtStockEscalera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Martillo:";
            // 
            // txtStockMartillo
            // 
            this.txtStockMartillo.Location = new System.Drawing.Point(187, 19);
            this.txtStockMartillo.Name = "txtStockMartillo";
            this.txtStockMartillo.ReadOnly = true;
            this.txtStockMartillo.Size = new System.Drawing.Size(60, 20);
            this.txtStockMartillo.TabIndex = 2;
            this.txtStockMartillo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Taladro:";
            // 
            // txtStockTaladro
            // 
            this.txtStockTaladro.Location = new System.Drawing.Point(316, 19);
            this.txtStockTaladro.Name = "txtStockTaladro";
            this.txtStockTaladro.ReadOnly = true;
            this.txtStockTaladro.Size = new System.Drawing.Size(60, 20);
            this.txtStockTaladro.TabIndex = 0;
            this.txtStockTaladro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPedirMercaderia
            // 
            this.btnPedirMercaderia.Location = new System.Drawing.Point(552, 334);
            this.btnPedirMercaderia.Name = "btnPedirMercaderia";
            this.btnPedirMercaderia.Size = new System.Drawing.Size(109, 35);
            this.btnPedirMercaderia.TabIndex = 9;
            this.btnPedirMercaderia.Text = "Pedir mercaderia";
            this.btnPedirMercaderia.UseVisualStyleBackColor = true;
            this.btnPedirMercaderia.Click += new System.EventHandler(this.btnPedirMercaderia_Click);
            // 
            // btnDetenerStockeo
            // 
            this.btnDetenerStockeo.Enabled = false;
            this.btnDetenerStockeo.Location = new System.Drawing.Point(683, 334);
            this.btnDetenerStockeo.Name = "btnDetenerStockeo";
            this.btnDetenerStockeo.Size = new System.Drawing.Size(109, 35);
            this.btnDetenerStockeo.TabIndex = 10;
            this.btnDetenerStockeo.Text = "Detener Stockeo";
            this.btnDetenerStockeo.UseVisualStyleBackColor = true;
            this.btnDetenerStockeo.Click += new System.EventHandler(this.btnDetenerStockeo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Medio de pago:";
            // 
            // cmbMedioDePago
            // 
            this.cmbMedioDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioDePago.FormattingEnabled = true;
            this.cmbMedioDePago.Location = new System.Drawing.Point(55, 243);
            this.cmbMedioDePago.Name = "cmbMedioDePago";
            this.cmbMedioDePago.Size = new System.Drawing.Size(267, 21);
            this.cmbMedioDePago.TabIndex = 12;
            // 
            // btnVentasGeneradas
            // 
            this.btnVentasGeneradas.Location = new System.Drawing.Point(552, 392);
            this.btnVentasGeneradas.Name = "btnVentasGeneradas";
            this.btnVentasGeneradas.Size = new System.Drawing.Size(240, 39);
            this.btnVentasGeneradas.TabIndex = 13;
            this.btnVentasGeneradas.Text = "Mostrar ventas realizadas";
            this.btnVentasGeneradas.UseVisualStyleBackColor = true;
            this.btnVentasGeneradas.Click += new System.EventHandler(this.btnVentasGeneradas_Click);
            // 
            // richtxtDetalle
            // 
            this.richtxtDetalle.Location = new System.Drawing.Point(346, 69);
            this.richtxtDetalle.Name = "richtxtDetalle";
            this.richtxtDetalle.ReadOnly = true;
            this.richtxtDetalle.Size = new System.Drawing.Size(458, 241);
            this.richtxtDetalle.TabIndex = 14;
            this.richtxtDetalle.Text = "";
            // 
            // FormFerreteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 445);
            this.Controls.Add(this.richtxtDetalle);
            this.Controls.Add(this.btnVentasGeneradas);
            this.Controls.Add(this.cmbMedioDePago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDetenerStockeo);
            this.Controls.Add(this.btnPedirMercaderia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtProdCarrito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormFerreteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFerreteria";
            this.Load += new System.EventHandler(this.FormFerreteria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProdCarrito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSockCinta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStockEscalera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStockMartillo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockTaladro;
        private System.Windows.Forms.Button btnPedirMercaderia;
        private System.Windows.Forms.Button btnDetenerStockeo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMedioDePago;
        private System.Windows.Forms.Button btnVentasGeneradas;
        private System.Windows.Forms.RichTextBox richtxtDetalle;
    }
}

