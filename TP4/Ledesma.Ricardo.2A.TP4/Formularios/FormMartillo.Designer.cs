namespace Formularios
{
    partial class FormMartillo
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
            this.cmbTipoMartillo = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoDeMango = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de martillo:";
            // 
            // cmbTipoMartillo
            // 
            this.cmbTipoMartillo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMartillo.FormattingEnabled = true;
            this.cmbTipoMartillo.Location = new System.Drawing.Point(50, 62);
            this.cmbTipoMartillo.Name = "cmbTipoMartillo";
            this.cmbTipoMartillo.Size = new System.Drawing.Size(233, 21);
            this.cmbTipoMartillo.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(53, 174);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(208, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de mango:";
            // 
            // cmbTipoDeMango
            // 
            this.cmbTipoDeMango.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeMango.FormattingEnabled = true;
            this.cmbTipoDeMango.Location = new System.Drawing.Point(53, 125);
            this.cmbTipoDeMango.Name = "cmbTipoDeMango";
            this.cmbTipoDeMango.Size = new System.Drawing.Size(230, 21);
            this.cmbTipoDeMango.TabIndex = 5;
            // 
            // FormMartillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 229);
            this.Controls.Add(this.cmbTipoDeMango);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbTipoMartillo);
            this.Controls.Add(this.label1);
            this.Name = "FormMartillo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMartillo";
            this.Load += new System.EventHandler(this.FormMartillo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoMartillo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoDeMango;
    }
}