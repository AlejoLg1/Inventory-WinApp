using Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionArticulos
{
    public partial class FormCategoria : Form
    {
        private Categoria categoria = null;
        public FormCategoria()
        {
            InitializeComponent();
        }

        public FormCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }

        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaServices service = new CategoriaServices();

            try
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                }

                categoria.Descripcion = txtDescripcionCat.Text;
                

                if (categoria.Id != 0)
                {
                    service.modify(categoria);
                    MessageBox.Show("Categoria modificada exitosamente");
                }
                else
                {
                    service.add(categoria);
                    MessageBox.Show("Categoria agregada exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
