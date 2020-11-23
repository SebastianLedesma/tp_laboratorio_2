namespace Formularios
{
    partial class FormEscalera
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
            this.cmbTamanio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño:";
            // 
            // cmbTamanio
            // 
            this.cmbTamanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamanio.FormattingEnabled = true;
            this.cmbTamanio.Location = new System.Drawing.Point(51, 61);
            this.cmbTamanio.Name = "cmbTamanio";
            this.cmbTamanio.Size = new System.Drawing.Size(248, 21);
            this.cmbTamanio.TabIndex = 1;
            this.cmbTamanio.SelectedIndexChanged += new System.EventHandler(this.cmbTamanio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Material:";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(51, 131);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(248, 21);
            this.cmbMaterial.TabIndex = 3;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(65, 179);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(201, 179);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormEscalera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 232);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTamanio);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormEscalera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEscalera";
            this.Load += new System.EventHandler(this.FormEscalera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTamanio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}