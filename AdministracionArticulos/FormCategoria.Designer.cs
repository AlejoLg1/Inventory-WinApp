namespace AdministracionArticulos
{
    partial class FormCategoria
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
            this.txtDescripcionCat = new System.Windows.Forms.TextBox();
            this.lblDescripcionCat = new System.Windows.Forms.Label();
            this.lblAgregarCat = new System.Windows.Forms.Label();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.btnAceptarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescripcionCat
            // 
            this.txtDescripcionCat.Location = new System.Drawing.Point(117, 155);
            this.txtDescripcionCat.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionCat.Name = "txtDescripcionCat";
            this.txtDescripcionCat.Size = new System.Drawing.Size(114, 20);
            this.txtDescripcionCat.TabIndex = 2;
            // 
            // lblDescripcionCat
            // 
            this.lblDescripcionCat.AutoSize = true;
            this.lblDescripcionCat.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCat.Location = new System.Drawing.Point(11, 153);
            this.lblDescripcionCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionCat.Name = "lblDescripcionCat";
            this.lblDescripcionCat.Size = new System.Drawing.Size(102, 20);
            this.lblDescripcionCat.TabIndex = 3;
            this.lblDescripcionCat.Text = "Descripción";
            // 
            // lblAgregarCat
            // 
            this.lblAgregarCat.AutoSize = true;
            this.lblAgregarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarCat.Location = new System.Drawing.Point(45, 66);
            this.lblAgregarCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgregarCat.Name = "lblAgregarCat";
            this.lblAgregarCat.Size = new System.Drawing.Size(186, 45);
            this.lblAgregarCat.TabIndex = 21;
            this.lblAgregarCat.Text = "Agregue la nueva categoria \r\npara poder registrar\r\narticulos de la misma\r\n";
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCategoria.Location = new System.Drawing.Point(152, 213);
            this.btnCancelarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(113, 37);
            this.btnCancelarCategoria.TabIndex = 23;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = true;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // btnAceptarCategoria
            // 
            this.btnAceptarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarCategoria.Location = new System.Drawing.Point(15, 213);
            this.btnAceptarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptarCategoria.Name = "btnAceptarCategoria";
            this.btnAceptarCategoria.Size = new System.Drawing.Size(113, 37);
            this.btnAceptarCategoria.TabIndex = 22;
            this.btnAceptarCategoria.Text = "Agregar";
            this.btnAceptarCategoria.UseVisualStyleBackColor = true;
            this.btnAceptarCategoria.Click += new System.EventHandler(this.btnAceptarCategoria_Click);
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 367);
            this.Controls.Add(this.btnCancelarCategoria);
            this.Controls.Add(this.btnAceptarCategoria);
            this.Controls.Add(this.lblAgregarCat);
            this.Controls.Add(this.txtDescripcionCat);
            this.Controls.Add(this.lblDescripcionCat);
            this.KeyPreview = true;
            this.Name = "FormCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategoria";
            this.Load += new System.EventHandler(this.FormCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescripcionCat;
        private System.Windows.Forms.Label lblDescripcionCat;
        private System.Windows.Forms.Label lblAgregarCat;
        private System.Windows.Forms.Button btnCancelarCategoria;
        private System.Windows.Forms.Button btnAceptarCategoria;
    }
}