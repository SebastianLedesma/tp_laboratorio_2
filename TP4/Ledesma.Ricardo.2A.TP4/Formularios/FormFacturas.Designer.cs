namespace Formularios
{
    partial class FormFacturas
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
            this.dtgView = new System.Windows.Forms.DataGridView();
            this.btnEliminarFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgView
            // 
            this.dtgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgView.Location = new System.Drawing.Point(12, 12);
            this.dtgView.Name = "dtgView";
            this.dtgView.Size = new System.Drawing.Size(619, 299);
            this.dtgView.TabIndex = 0;
            // 
            // btnEliminarFactura
            // 
            this.btnEliminarFactura.Location = new System.Drawing.Point(253, 329);
            this.btnEliminarFactura.Name = "btnEliminarFactura";
            this.btnEliminarFactura.Size = new System.Drawing.Size(115, 33);
            this.btnEliminarFactura.TabIndex = 1;
            this.btnEliminarFactura.Text = "Eliminar Factura";
            this.btnEliminarFactura.UseVisualStyleBackColor = true;
            this.btnEliminarFactura.Click += new System.EventHandler(this.btnEliminarFactura_Click);
            // 
            // FormFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 374);
            this.Controls.Add(this.btnEliminarFactura);
            this.Controls.Add(this.dtgView);
            this.MaximizeBox = false;
            this.Name = "FormFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFacturas";
            this.Load += new System.EventHandler(this.FormFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgView;
        private System.Windows.Forms.Button btnEliminarFactura;
    }
}