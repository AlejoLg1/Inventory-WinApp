using Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

                if(string.IsNullOrWhiteSpace(txtDescripcionCat.Text))
                {
                    MessageBox.Show("Debe ingresar una descripción para la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!txtDescripcionCat.Text.All(char.IsLetter))
                {
                    MessageBox.Show("Ingrese solo letras en la descripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (categoria.Id == 0 || !txtDescripcionCat.Text.Equals(categoria.Descripcion, StringComparison.OrdinalIgnoreCase))
                {
                    if (service.ExistsName(txtDescripcionCat.Text))
                    {
                        MessageBox.Show("Ya existe una categoría con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
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

        private void cargar()
        {
            CategoriaServices services = new CategoriaServices();

            try
            {
                lbPanelCategoria.Text = "Agregando Categoría";
                btnAceptarCategoria.Text = "Agregar";
                if (categoria != null) 
                {
                    lbPanelCategoria.Text = "Modificando Categoría";
                    btnAceptarCategoria.Text = "Modificar";
                    txtDescripcionCat.Text = categoria.Descripcion;
                }
            }
            catch (Exception ex)
            {

              throw ex;
                    
            }

        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
