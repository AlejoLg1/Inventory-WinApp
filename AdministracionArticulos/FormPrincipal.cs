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
                //Agregar Marca
            }
            else
            {
                //Agregar Categoría
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
                //Modificar Marca
            }
            else
            {
                //Modificar Categoría
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
                //Eliminar Marca
            }
            else
            {
                //Eliminar Categoría
            }
            cargarGrids();
        }

        private void dgArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ArticuloServices articuloService = new ArticuloServices();
                Articulo articuloSeleccionado = (Articulo)dgArticulos.CurrentRow.DataBoundItem;
                listImagenes = articuloService.listarImagenes(articuloSeleccionado.Codigo);
                nudImagenesArticulos.Value = 0;
                nudImagenesArticulos.Maximum = listImagenes.Count;
                if (listImagenes.Count > 0)
                {
                    uploadImage(listImagenes[(int)nudImagenesArticulos.Value]);
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
                dgArticulos.Columns["Id"].Visible = false;
                dgArticulos.Columns["Imagen"].Visible = false;

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

    }
}
