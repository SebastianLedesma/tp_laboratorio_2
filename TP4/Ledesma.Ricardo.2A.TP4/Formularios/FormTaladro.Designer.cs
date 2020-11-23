namespace Formularios
{
    partial class FormTaladro
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
            this.cmbEsRecargable = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTiempoTrabajo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso en gramos:";
            // 
            // cmbEsRecargable
            // 
            this.cmbEsRecargable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEsRecargable.FormattingEnabled = true;
            this.cmbEsRecargable.Location = new System.Drawing.Point(48, 66);
            this.cmbEsRecargable.Name = "cmbEsRecargable";
            this.cmbEsRecargable.Size = new System.Drawing.Size(202, 21);
            this.cmbEsRecargable.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(48, 173);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(175, 173);
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
            this.label2.Location = new System.Drawing.Point(45, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiempo de trabajo:";
            // 
            // cmbTiempoTrabajo
            // 
            this.cmbTiempoTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiempoTrabajo.FormattingEnabled = true;
            this.cmbTiempoTrabajo.Location = new System.Drawing.Point(48, 124);
            this.cmbTiempoTrabajo.Name = "cmbTiempoTrabajo";
            this.cmbTiempoTrabajo.Size = new System.Drawing.Size(202, 21);
            this.cmbTiempoTrabajo.TabIndex = 5;
            // 
            // FormTaladro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 240);
            this.Controls.Add(this.cmbTiempoTrabajo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbEsRecargable);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormTaladro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTaladro";
            this.Load += new System.EventHandler(this.FormTaladro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEsRecargable;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTiempoTrabajo;
    }
}