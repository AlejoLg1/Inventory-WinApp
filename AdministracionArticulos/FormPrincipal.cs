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
        private List<Categoria> listCategorias;
        private List<Marca> listMarca;
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
           
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
          
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void rdMarcas_CheckedChanged(object sender, EventArgs e)
        {
         
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

                listCategorias = categoriaService.listar();
                dgCategorias.DataSource = listCategorias;
                AjustarDgArticulosView(dgCategorias);

                listMarca = marcaService.listar();
                dgMarcas.DataSource = listMarca;
                AjustarDgArticulosView(dgMarcas);

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
