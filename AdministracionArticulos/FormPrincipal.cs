using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Services;

namespace AdministracionArticulos
{
    public partial class formPrincipal : Form
    {
        private List<Articulo> listArticulos;
        private bool Marca; 

        public formPrincipal()
        {
            InitializeComponent();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            cargarGrids();
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

        private void cargarGrids()
        {
            ArticuloServices articuloService = new ArticuloServices();
            CategoriaServices categoriaService = new CategoriaServices();
            MarcaServices marcaService = new MarcaServices();

            try
            {
                listArticulos = articuloService.listar();
                dgArticulos.DataSource = listArticulos;
                dgArticulos.Columns["Id"].Visible = false;
                dgArticulos.Columns["Imagen"].Visible = false;
                AjustarDgArticulosView(dgArticulos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AjustarDgArticulosView(DataGridView dataGridView)
        {
            int recordCount = dataGridView.Rows.Count;
            int maxVisibleRows = 6;
            int rowHeight = dataGridView.RowTemplate.Height;
            int headerHeight = dataGridView.ColumnHeadersHeight;


            int totalHeight = (recordCount > maxVisibleRows ? maxVisibleRows : recordCount) * rowHeight + headerHeight + 2;

            dataGridView.Height = totalHeight;

            if (recordCount > maxVisibleRows)
            {
                dataGridView.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                dataGridView.ScrollBars = ScrollBars.None;
            }
        }

    }
}
