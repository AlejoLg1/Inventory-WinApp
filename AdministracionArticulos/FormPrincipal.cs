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
    public partial class formPrincipal : Form
    {
        private bool Marca; 

        public formPrincipal()
        {
            InitializeComponent();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            Marca = false; 
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (Marca)
            {
                FormAgregarMarca agregarMarca = new FormAgregarMarca();
                agregarMarca.ShowDialog();
            }
            else
            {
                FormAgregarArticulo agregarArticulo = new FormAgregarArticulo();
                agregarArticulo.ShowDialog();
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (Marca)
            {
                FormModificarMarca modificarMarca = new FormModificarMarca();
                modificarMarca.ShowDialog();
            }
            else
            {
                FormModificarArticulo modificarArticulo = new FormModificarArticulo();
                modificarArticulo.ShowDialog();
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (Marca)
            {
                FormEliminarMarca eliminarMarca = new FormEliminarMarca();
                eliminarMarca.ShowDialog();
            }
            else
            {
                FormEliminarArticulo eliminarArticulo = new FormEliminarArticulo();
                eliminarArticulo.ShowDialog();
            }
        }

        private void rdMarcas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMarcas.Checked)
            {
                Marca = true; 
            }
            else
            {
                Marca = false; 
            }
        }
    }
}
