namespace Formularios
{
    partial class FormHerramientas
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDistribuidor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origen:";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(45, 67);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(228, 21);
            this.cmbOrigen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Distribuidor:";
            // 
            // cmbDistribuidor
            // 
            this.cmbDistribuidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistribuidor.FormattingEnabled = true;
            this.cmbDistribuidor.Location = new System.Drawing.Point(45, 133);
            this.cmbDistribuidor.Name = "cmbDistribuidor";
            this.cmbDistribuidor.Size = new System.Drawing.Size(228, 21);
            this.cmbDistribuidor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(45, 208);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(228, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(35, 308);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(226, 308);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 372);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDistribuidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.label1);
            this.Name = "FormHerramientas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHerramientas";
            this.Load += new System.EventHandler(this.FormHerramientas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.ComboBox cmbOrigen;
        protected System.Windows.Forms.ComboBox cmbDistribuidor;
        protected System.Windows.Forms.TextBox txtPrecio;
    }
}