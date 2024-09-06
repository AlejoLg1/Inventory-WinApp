namespace AdministracionArticulos
{
    partial class formPrincipal
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
            this.lbArticulos = new System.Windows.Forms.Label();
            this.dgArticulos = new System.Windows.Forms.DataGridView();
            this.dgMarcas = new System.Windows.Forms.DataGridView();
            this.dgCategorias = new System.Windows.Forms.DataGridView();
            this.lbMarcas = new System.Windows.Forms.Label();
            this.lbCategorias = new System.Windows.Forms.Label();
            this.rdArticulos = new System.Windows.Forms.RadioButton();
            this.rdMarcas = new System.Windows.Forms.RadioButton();
            this.rdCategoria = new System.Windows.Forms.RadioButton();
            this.lbOpcionElemento = new System.Windows.Forms.Label();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lbArticulos
            // 
            this.lbArticulos.AutoEllipsis = true;
            this.lbArticulos.AutoSize = true;
            this.lbArticulos.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArticulos.Location = new System.Drawing.Point(268, 20);
            this.lbArticulos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbArticulos.Name = "lbArticulos";
            this.lbArticulos.Size = new System.Drawing.Size(115, 28);
            this.lbArticulos.TabIndex = 1;
            this.lbArticulos.Text = "Artículos";
            // 
            // dgArticulos
            // 
            this.dgArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgArticulos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArticulos.Location = new System.Drawing.Point(10, 65);
            this.dgArticulos.Name = "dgArticulos";
            this.dgArticulos.ReadOnly = true;
            this.dgArticulos.RowHeadersWidth = 51;
            this.dgArticulos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgArticulos.Size = new System.Drawing.Size(644, 144);
            this.dgArticulos.TabIndex = 2;
            // 
            // dgMarcas
            // 
            this.dgMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMarcas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMarcas.Location = new System.Drawing.Point(23, 379);
            this.dgMarcas.Name = "dgMarcas";
            this.dgMarcas.RowHeadersWidth = 51;
            this.dgMarcas.Size = new System.Drawing.Size(95, 141);
            this.dgMarcas.TabIndex = 3;
            // 
            // dgCategorias
            // 
            this.dgCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCategorias.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorias.Location = new System.Drawing.Point(466, 379);
            this.dgCategorias.Name = "dgCategorias";
            this.dgCategorias.RowHeadersWidth = 51;
            this.dgCategorias.Size = new System.Drawing.Size(189, 196);
            this.dgCategorias.TabIndex = 4;
            // 
            // lbMarcas
            // 
            this.lbMarcas.AutoSize = true;
            this.lbMarcas.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarcas.Location = new System.Drawing.Point(28, 340);
            this.lbMarcas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMarcas.Name = "lbMarcas";
            this.lbMarcas.Size = new System.Drawing.Size(94, 28);
            this.lbMarcas.TabIndex = 5;
            this.lbMarcas.Text = "Marcas";
            // 
            // lbCategorias
            // 
            this.lbCategorias.AutoSize = true;
            this.lbCategorias.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategorias.Location = new System.Drawing.Point(504, 340);
            this.lbCategorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategorias.Name = "lbCategorias";
            this.lbCategorias.Size = new System.Drawing.Size(138, 28);
            this.lbCategorias.TabIndex = 6;
            this.lbCategorias.Text = "Categorías";
            // 
            // rdArticulos
            // 
            this.rdArticulos.AutoSize = true;
            this.rdArticulos.Checked = true;
            this.rdArticulos.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdArticulos.Location = new System.Drawing.Point(171, 293);
            this.rdArticulos.Name = "rdArticulos";
            this.rdArticulos.Size = new System.Drawing.Size(89, 24);
            this.rdArticulos.TabIndex = 7;
            this.rdArticulos.TabStop = true;
            this.rdArticulos.Text = "Articulo";
            this.rdArticulos.UseVisualStyleBackColor = true;
            // 
            // rdMarcas
            // 
            this.rdMarcas.AutoSize = true;
            this.rdMarcas.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMarcas.Location = new System.Drawing.Point(310, 293);
            this.rdMarcas.Name = "rdMarcas";
            this.rdMarcas.Size = new System.Drawing.Size(74, 24);
            this.rdMarcas.TabIndex = 8;
            this.rdMarcas.Text = "Marca";
            this.rdMarcas.UseVisualStyleBackColor = true;
            this.rdMarcas.CheckedChanged += new System.EventHandler(this.rdMarcas_CheckedChanged);
            // 
            // rdCategoria
            // 
            this.rdCategoria.AutoSize = true;
            this.rdCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCategoria.Location = new System.Drawing.Point(430, 293);
            this.rdCategoria.Name = "rdCategoria";
            this.rdCategoria.Size = new System.Drawing.Size(106, 24);
            this.rdCategoria.TabIndex = 9;
            this.rdCategoria.Text = "Categoría";
            this.rdCategoria.UseVisualStyleBackColor = true;
            // 
            // lbOpcionElemento
            // 
            this.lbOpcionElemento.AutoSize = true;
            this.lbOpcionElemento.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpcionElemento.Location = new System.Drawing.Point(204, 241);
            this.lbOpcionElemento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOpcionElemento.Name = "lbOpcionElemento";
            this.lbOpcionElemento.Size = new System.Drawing.Size(266, 28);
            this.lbOpcionElemento.TabIndex = 10;
            this.lbOpcionElemento.Text = "Elemento a gestionar";
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(237, 359);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(221, 49);
            this.btAgregar.TabIndex = 11;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(237, 428);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(221, 49);
            this.btModificar.TabIndex = 12;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(237, 496);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(221, 49);
            this.btEliminar.TabIndex = 13;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(667, 587);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.lbOpcionElemento);
            this.Controls.Add(this.rdCategoria);
            this.Controls.Add(this.rdMarcas);
            this.Controls.Add(this.rdArticulos);
            this.Controls.Add(this.lbCategorias);
            this.Controls.Add(this.lbMarcas);
            this.Controls.Add(this.dgCategorias);
            this.Controls.Add(this.dgMarcas);
            this.Controls.Add(this.dgArticulos);
            this.Controls.Add(this.lbArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Control";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbArticulos;
        private System.Windows.Forms.DataGridView dgArticulos;
        private System.Windows.Forms.DataGridView dgMarcas;
        private System.Windows.Forms.DataGridView dgCategorias;
        private System.Windows.Forms.Label lbMarcas;
        private System.Windows.Forms.Label lbCategorias;
        private System.Windows.Forms.RadioButton rdArticulos;
        private System.Windows.Forms.RadioButton rdMarcas;
        private System.Windows.Forms.RadioButton rdCategoria;
        private System.Windows.Forms.Label lbOpcionElemento;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btEliminar;
    }
}

