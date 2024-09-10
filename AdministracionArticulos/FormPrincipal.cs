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
        private List<string> listImagenes;
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

        /*---------------- EVENTS ----------------*/

        private void btAgregar_Click(object sender, EventArgs e)
        {
           if (rdArticulos.Checked)
            {
                FormArticulo articulo = new FormArticulo();
                articulo.ShowDialog();
            }
           else if (rdMarcas.Checked)
            {
                FormMarca marca = new FormMarca();
                marca.ShowDialog();
            }
            else
            {
                //Agregar Categoría
                FormCategoria categoria = new FormCategoria();
                categoria.ShowDialog();
            }
            cargarGrids();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (rdArticulos.Checked)
            {
                Articulo selectedArt;
                selectedArt = (Articulo)dgArticulos.CurrentRow.DataBoundItem;
                FormArticulo articulo = new FormArticulo(selectedArt);
                articulo.ShowDialog();
            }
            else if (rdMarcas.Checked)
            {
                Marca selectedMarca;
                selectedMarca = (Marca)dgMarcas.CurrentRow.DataBoundItem;
                FormMarca marca = new FormMarca(selectedMarca);
                marca.ShowDialog();
            }
            else
            {
                Categoria selectedCat;
                selectedCat = (Categoria)dgCategorias.CurrentRow.DataBoundItem;
                FormCategoria categoria = new FormCategoria(selectedCat);
                categoria.ShowDialog();
            }
            cargarGrids();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (rdArticulos.Checked)
            {
                deleteArticulo();
            }
            else if (rdMarcas.Checked)
            {
                deleteMarca();
            }
            else
            {
                deleteCategoria();
            }
            cargarGrids();
        }

        private void dgArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ArticuloServices articuloService = new ArticuloServices();
                if (dgArticulos.CurrentRow != null)
                {
                  Articulo articuloSeleccionado = (Articulo)dgArticulos.CurrentRow.DataBoundItem;
                  listImagenes = articuloService.listarImagenes(articuloSeleccionado.Codigo);
                }
                nudImagenesArticulos.Value = 0;
                
                if (listImagenes.Count > 0)
                {
                    nudImagenesArticulos.Maximum = listImagenes.Count;
                    uploadImage(listImagenes[(int)nudImagenesArticulos.Value]);
                }
                else
                {
                    nudImagenesArticulos.Maximum = 0;
                    uploadImage("DefaultImage");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void nudImagenesArticulos_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ArticuloServices articuloService = new ArticuloServices();
                Articulo articuloSeleccionado = (Articulo)dgArticulos.CurrentRow.DataBoundItem;
                listImagenes = articuloService.listarImagenes(articuloSeleccionado.Codigo);
                if (listImagenes.Count > 0)
                {
                    nudImagenesArticulos.Maximum = listImagenes.Count - 1;
                    uploadImage(listImagenes[(int)nudImagenesArticulos.Value]);
                }
                else
                {
                    uploadImage("DefaultImage");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /*---------------- FUNCTIONS ----------------*/

        private void cargarGrids()
        {
            ArticuloServices articuloService = new ArticuloServices();
            CategoriaServices categoriaService = new CategoriaServices();
            MarcaServices marcaService = new MarcaServices();

            try
            {
                listArticulos = articuloService.listar();
                if (listArticulos.Count > 0)
                {
                listImagenes = articuloService.listarImagenes(listArticulos[0].Codigo);
                }

                dgArticulos.DataSource = listArticulos;
                hideColumns();

                if (listImagenes.Count > 0)
                {
                    uploadImage(listImagenes[0]);
                }
                else
                {
                    uploadImage("DefaultImage");
                }

                AjustarDgView(dgArticulos, 6);

                listCategorias = categoriaService.listar();
                dgCategorias.DataSource = listCategorias;
                AjustarDgView(dgCategorias, 6);

                listMarca = marcaService.listar();
                dgMarcas.DataSource = listMarca;
                AjustarDgView(dgMarcas, 6);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void hideColumns()
        {
            dgArticulos.Columns["Id"].Visible = false;
            dgArticulos.Columns["Imagen"].Visible = false;
        }

        private void AjustarDgView(DataGridView dataGridView, int maxVisibleRows)
        {
            int recordCount = dataGridView.Rows.Count;
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

        private void uploadImage(string image)
        {
            try
            {
                pbPcArticulos.Load(image);
            }
            catch (Exception ex)
            {
                pbPcArticulos.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
        }

        public void deleteArticulo()
        {
            ArticuloServices service = new ArticuloServices();
            Articulo selectedArt;

            try
            {
                selectedArt = (Articulo)dgArticulos.CurrentRow.DataBoundItem;
                DialogResult response = MessageBox.Show($"¿Éstá seguro de eliminar el Artículo '{selectedArt.Nombre}' con código '{selectedArt.Codigo}'?", "Eliminar Artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (response == DialogResult.Yes)
                {
                    service.delete(selectedArt.Id);
                    cargarGrids();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteCategoria()
        {
            CategoriaServices service = new CategoriaServices();
            Categoria selectedCat;

            try
            {
                selectedCat = (Categoria)dgCategorias.CurrentRow.DataBoundItem;
                DialogResult response = MessageBox.Show($"¿Éstá seguro de eliminar la categoria '{selectedCat.Descripcion}' con Id '{selectedCat.Id}'?", "Eliminar Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (response == DialogResult.Yes)
                {
                    service.delete(selectedCat.Id);
                    cargarGrids();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteMarca()
        {
            MarcaServices service = new MarcaServices();
            Marca selectedMarca;

            try
            {
                selectedMarca = (Marca)dgMarcas.CurrentRow.DataBoundItem;
                DialogResult response = MessageBox.Show($"¿Éstá seguro de eliminar la marca '{selectedMarca.Descripcion}' con Id '{selectedMarca.Id}'?", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (response == DialogResult.Yes)
                {
                    service.delete(selectedMarca.Id);
                    cargarGrids();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnFiltroArticulo_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltroArticulo.Text;

            listaFiltrada = listArticulos.FindAll(art => art.Nombre.ToLower().Contains(filtro.ToLower()) || art.Categoria.ToString().ToLower().Contains(filtro.ToLower()) || art.Marca.ToString().ToLower().Contains(filtro.ToLower()));

            dgArticulos.DataSource = null;
            dgArticulos.DataSource = listaFiltrada;
            hideColumns();
        }

        private void btnResetearDgv_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            listaFiltrada = listArticulos;

            dgArticulos.DataSource = null;
            dgArticulos.DataSource = listaFiltrada;
            hideColumns();
        }
    }
}
