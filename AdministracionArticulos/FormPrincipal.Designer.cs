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
            this.pbPcArticulos = new System.Windows.Forms.PictureBox();
            this.nudImagenesArticulos = new System.Windows.Forms.NumericUpDown();
            this.txtFiltroArticulo = new System.Windows.Forms.TextBox();
            this.lblFiltroArticulo = new System.Windows.Forms.Label();
            this.btnFiltroArticulo = new System.Windows.Forms.Button();
            this.btnResetearDgv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPcArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImagenesArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbArticulos
            // 
            this.lbArticulos.AutoEllipsis = true;
            this.lbArticulos.AutoSize = true;
            this.lbArticulos.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArticulos.Location = new System.Drawing.Point(8, 25);
            this.lbArticulos.Name = "lbArticulos";
            this.lbArticulos.Size = new System.Drawing.Size(149, 35);
            this.lbArticulos.TabIndex = 1;
            this.lbArticulos.Text = "Artículos";
            // 
            // dgArticulos
            // 
            this.dgArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgArticulos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArticulos.Location = new System.Drawing.Point(14, 87);
            this.dgArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgArticulos.Name = "dgArticulos";
            this.dgArticulos.ReadOnly = true;
            this.dgArticulos.RowHeadersWidth = 51;
            this.dgArticulos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgArticulos.Size = new System.Drawing.Size(859, 177);
            this.dgArticulos.TabIndex = 2;
            this.dgArticulos.SelectionChanged += new System.EventHandler(this.dgArticulos_SelectionChanged);
            // 
            // dgMarcas
            // 
            this.dgMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMarcas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMarcas.Location = new System.Drawing.Point(18, 332);
            this.dgMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.dgMarcas.Name = "dgMarcas";
            this.dgMarcas.ReadOnly = true;
            this.dgMarcas.RowHeadersWidth = 51;
            this.dgMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMarcas.Size = new System.Drawing.Size(257, 239);
            this.dgMarcas.TabIndex = 3;
            // 
            // dgCategorias
            // 
            this.dgCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCategorias.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorias.Location = new System.Drawing.Point(615, 332);
            this.dgCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.dgCategorias.Name = "dgCategorias";
            this.dgCategorias.ReadOnly = true;
            this.dgCategorias.RowHeadersWidth = 51;
            this.dgCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCategorias.Size = new System.Drawing.Size(257, 241);
            this.dgCategorias.TabIndex = 4;
            // 
            // lbMarcas
            // 
            this.lbMarcas.AutoSize = true;
            this.lbMarcas.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarcas.Location = new System.Drawing.Point(82, 280);
            this.lbMarcas.Name = "lbMarcas";
            this.lbMarcas.Size = new System.Drawing.Size(121, 35);
            this.lbMarcas.TabIndex = 5;
            this.lbMarcas.Text = "Marcas";
            // 
            // lbCategorias
            // 
            this.lbCategorias.AutoSize = true;
            this.lbCategorias.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategorias.Location = new System.Drawing.Point(665, 280);
            this.lbCategorias.Name = "lbCategorias";
            this.lbCategorias.Size = new System.Drawing.Size(177, 35);
            this.lbCategorias.TabIndex = 6;
            this.lbCategorias.Text = "Categorías";
            // 
            // rdArticulos
            // 
            this.rdArticulos.AutoSize = true;
            this.rdArticulos.Checked = true;
            this.rdArticulos.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdArticulos.Location = new System.Drawing.Point(199, 708);
            this.rdArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.rdArticulos.Name = "rdArticulos";
            this.rdArticulos.Size = new System.Drawing.Size(111, 30);
            this.rdArticulos.TabIndex = 7;
            this.rdArticulos.TabStop = true;
            this.rdArticulos.Text = "Articulo";
            this.rdArticulos.UseVisualStyleBackColor = true;
            // 
            // rdMarcas
            // 
            this.rdMarcas.AutoSize = true;
            this.rdMarcas.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMarcas.Location = new System.Drawing.Point(383, 708);
            this.rdMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.rdMarcas.Name = "rdMarcas";
            this.rdMarcas.Size = new System.Drawing.Size(93, 30);
            this.rdMarcas.TabIndex = 8;
            this.rdMarcas.Text = "Marca";
            this.rdMarcas.UseVisualStyleBackColor = true;
            // 
            // rdCategoria
            // 
            this.rdCategoria.AutoSize = true;
            this.rdCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCategoria.Location = new System.Drawing.Point(543, 708);
            this.rdCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.rdCategoria.Name = "rdCategoria";
            this.rdCategoria.Size = new System.Drawing.Size(130, 30);
            this.rdCategoria.TabIndex = 9;
            this.rdCategoria.Text = "Categoría";
            this.rdCategoria.UseVisualStyleBackColor = true;
            // 
            // lbOpcionElemento
            // 
            this.lbOpcionElemento.AutoSize = true;
            this.lbOpcionElemento.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpcionElemento.Location = new System.Drawing.Point(277, 650);
            this.lbOpcionElemento.Name = "lbOpcionElemento";
            this.lbOpcionElemento.Size = new System.Drawing.Size(339, 35);
            this.lbOpcionElemento.TabIndex = 10;
            this.lbOpcionElemento.Text = "Elemento a gestionar";
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(247, 759);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(395, 60);
            this.btAgregar.TabIndex = 11;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(247, 844);
            this.btModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(395, 60);
            this.btModificar.TabIndex = 12;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(247, 927);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(395, 60);
            this.btEliminar.TabIndex = 13;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // pbPcArticulos
            // 
            this.pbPcArticulos.Location = new System.Drawing.Point(309, 332);
            this.pbPcArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPcArticulos.Name = "pbPcArticulos";
            this.pbPcArticulos.Size = new System.Drawing.Size(272, 241);
            this.pbPcArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPcArticulos.TabIndex = 14;
            this.pbPcArticulos.TabStop = false;
            // 
            // nudImagenesArticulos
            // 
            this.nudImagenesArticulos.Location = new System.Drawing.Point(383, 578);
            this.nudImagenesArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudImagenesArticulos.Name = "nudImagenesArticulos";
            this.nudImagenesArticulos.ReadOnly = true;
            this.nudImagenesArticulos.Size = new System.Drawing.Size(120, 22);
            this.nudImagenesArticulos.TabIndex = 15;
            this.nudImagenesArticulos.ValueChanged += new System.EventHandler(this.nudImagenesArticulos_ValueChanged);
            // 
            // txtFiltroArticulo
            // 
            this.txtFiltroArticulo.Location = new System.Drawing.Point(353, 33);
            this.txtFiltroArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroArticulo.Name = "txtFiltroArticulo";
            this.txtFiltroArticulo.Size = new System.Drawing.Size(180, 22);
            this.txtFiltroArticulo.TabIndex = 16;
            // 
            // lblFiltroArticulo
            // 
            this.lblFiltroArticulo.AutoSize = true;
            this.lblFiltroArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroArticulo.Location = new System.Drawing.Point(267, 37);
            this.lblFiltroArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroArticulo.Name = "lblFiltroArticulo";
            this.lblFiltroArticulo.Size = new System.Drawing.Size(78, 20);
            this.lblFiltroArticulo.TabIndex = 17;
            this.lblFiltroArticulo.Text = "Nombre :";
            // 
            // btnFiltroArticulo
            // 
            this.btnFiltroArticulo.Location = new System.Drawing.Point(543, 33);
            this.btnFiltroArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltroArticulo.Name = "btnFiltroArticulo";
            this.btnFiltroArticulo.Size = new System.Drawing.Size(100, 25);
            this.btnFiltroArticulo.TabIndex = 18;
            this.btnFiltroArticulo.Text = "Buscar";
            this.btnFiltroArticulo.UseVisualStyleBackColor = true;
            this.btnFiltroArticulo.Click += new System.EventHandler(this.btnFiltroArticulo_Click);
            // 
            // btnResetearDgv
            // 
            this.btnResetearDgv.Location = new System.Drawing.Point(651, 33);
            this.btnResetearDgv.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetearDgv.Name = "btnResetearDgv";
            this.btnResetearDgv.Size = new System.Drawing.Size(100, 26);
            this.btnResetearDgv.TabIndex = 19;
            this.btnResetearDgv.Text = "Resetear";
            this.btnResetearDgv.UseVisualStyleBackColor = true;
            this.btnResetearDgv.Click += new System.EventHandler(this.btnResetearDgv_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(889, 999);
            this.Controls.Add(this.btnResetearDgv);
            this.Controls.Add(this.btnFiltroArticulo);
            this.Controls.Add(this.lblFiltroArticulo);
            this.Controls.Add(this.txtFiltroArticulo);
            this.Controls.Add(this.nudImagenesArticulos);
            this.Controls.Add(this.pbPcArticulos);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Control";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPcArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImagenesArticulos)).EndInit();
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
        private System.Windows.Forms.PictureBox pbPcArticulos;
        private System.Windows.Forms.NumericUpDown nudImagenesArticulos;
        private System.Windows.Forms.TextBox txtFiltroArticulo;
        private System.Windows.Forms.Label lblFiltroArticulo;
        private System.Windows.Forms.Button btnFiltroArticulo;
        private System.Windows.Forms.Button btnResetearDgv;
    }
}

