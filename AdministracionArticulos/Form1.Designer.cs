namespace AdministracionArticulos
{
    partial class Form1
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
            this.MSprincipal = new System.Windows.Forms.MenuStrip();
            this.MenuArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAgregarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuModificarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEliminarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAgregarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuModificarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEliminarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAgregarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuModificarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEliminarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.MSprincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSprincipal
            // 
            this.MSprincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MSprincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuArticulo,
            this.MenuMarca,
            this.MenuCategoria});
            this.MSprincipal.Location = new System.Drawing.Point(0, 0);
            this.MSprincipal.Name = "MSprincipal";
            this.MSprincipal.Size = new System.Drawing.Size(718, 28);
            this.MSprincipal.TabIndex = 0;
            this.MSprincipal.Text = "menuStrip1";
            // 
            // MenuArticulo
            // 
            this.MenuArticulo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAgregarArticulo,
            this.MenuModificarArticulo,
            this.MenuEliminarArticulo});
            this.MenuArticulo.Name = "MenuArticulo";
            this.MenuArticulo.Size = new System.Drawing.Size(75, 24);
            this.MenuArticulo.Text = "Articulo";
            // 
            // MenuAgregarArticulo
            // 
            this.MenuAgregarArticulo.Name = "MenuAgregarArticulo";
            this.MenuAgregarArticulo.Size = new System.Drawing.Size(224, 26);
            this.MenuAgregarArticulo.Text = "Agregar Articulo";
            // 
            // MenuModificarArticulo
            // 
            this.MenuModificarArticulo.Name = "MenuModificarArticulo";
            this.MenuModificarArticulo.Size = new System.Drawing.Size(224, 26);
            this.MenuModificarArticulo.Text = "Modificar Articulo";
            // 
            // MenuEliminarArticulo
            // 
            this.MenuEliminarArticulo.Name = "MenuEliminarArticulo";
            this.MenuEliminarArticulo.Size = new System.Drawing.Size(224, 26);
            this.MenuEliminarArticulo.Text = "Eliminar Articulo";
            // 
            // MenuMarca
            // 
            this.MenuMarca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAgregarMarca,
            this.MenuModificarMarca,
            this.MenuEliminarMarca});
            this.MenuMarca.Name = "MenuMarca";
            this.MenuMarca.Size = new System.Drawing.Size(64, 24);
            this.MenuMarca.Text = "Marca";
            // 
            // MenuAgregarMarca
            // 
            this.MenuAgregarMarca.Name = "MenuAgregarMarca";
            this.MenuAgregarMarca.Size = new System.Drawing.Size(224, 26);
            this.MenuAgregarMarca.Text = "Agregar Marca";
            // 
            // MenuModificarMarca
            // 
            this.MenuModificarMarca.Name = "MenuModificarMarca";
            this.MenuModificarMarca.Size = new System.Drawing.Size(224, 26);
            this.MenuModificarMarca.Text = "Modificar Marca";
            // 
            // MenuEliminarMarca
            // 
            this.MenuEliminarMarca.Name = "MenuEliminarMarca";
            this.MenuEliminarMarca.Size = new System.Drawing.Size(224, 26);
            this.MenuEliminarMarca.Text = "Eliminar Marca";
            // 
            // MenuCategoria
            // 
            this.MenuCategoria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAgregarCategoria,
            this.MenuModificarCategoria,
            this.MenuEliminarCategoria});
            this.MenuCategoria.Name = "MenuCategoria";
            this.MenuCategoria.Size = new System.Drawing.Size(88, 24);
            this.MenuCategoria.Text = "Categoria";
            // 
            // MenuAgregarCategoria
            // 
            this.MenuAgregarCategoria.Name = "MenuAgregarCategoria";
            this.MenuAgregarCategoria.Size = new System.Drawing.Size(225, 26);
            this.MenuAgregarCategoria.Text = "Agregar Categoria";
            // 
            // MenuModificarCategoria
            // 
            this.MenuModificarCategoria.Name = "MenuModificarCategoria";
            this.MenuModificarCategoria.Size = new System.Drawing.Size(225, 26);
            this.MenuModificarCategoria.Text = "Modificar Categoria";
            // 
            // MenuEliminarCategoria
            // 
            this.MenuEliminarCategoria.Name = "MenuEliminarCategoria";
            this.MenuEliminarCategoria.Size = new System.Drawing.Size(225, 26);
            this.MenuEliminarCategoria.Text = "Eliminar Categoria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.MSprincipal);
            this.MainMenuStrip = this.MSprincipal;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MSprincipal.ResumeLayout(false);
            this.MSprincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSprincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuArticulo;
        private System.Windows.Forms.ToolStripMenuItem MenuMarca;
        private System.Windows.Forms.ToolStripMenuItem MenuCategoria;
        private System.Windows.Forms.ToolStripMenuItem MenuAgregarArticulo;
        private System.Windows.Forms.ToolStripMenuItem MenuModificarArticulo;
        private System.Windows.Forms.ToolStripMenuItem MenuEliminarArticulo;
        private System.Windows.Forms.ToolStripMenuItem MenuAgregarMarca;
        private System.Windows.Forms.ToolStripMenuItem MenuModificarMarca;
        private System.Windows.Forms.ToolStripMenuItem MenuEliminarMarca;
        private System.Windows.Forms.ToolStripMenuItem MenuAgregarCategoria;
        private System.Windows.Forms.ToolStripMenuItem MenuModificarCategoria;
        private System.Windows.Forms.ToolStripMenuItem MenuEliminarCategoria;
    }
}

