using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Utils;

namespace Services
{
    public class ArticuloServices
    {
        private DataBaseAccess DB = new DataBaseAccess();

        public List<Articulo> listar()
        {
            List<Articulo> list = new List<Articulo>();
            try
            {
                DB.setQuery("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id AS MarcaId, M.Descripcion AS MarcaDescripcion, C.Id AS CategoriaId, C.Descripcion AS CategoriaDescripcion, A.Precio FROM ARTICULOS AS A LEFT JOIN CATEGORIAS AS C ON C.Id = A.IdCategoria LEFT JOIN MARCAS AS M ON M.Id = A.IdMarca");
                DB.excecuteQuery();

                while (DB.Reader.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)DB.Reader["Id"];
                    articulo.Codigo = (string)DB.Reader["Codigo"];
                    articulo.Nombre = (string)DB.Reader["Nombre"];
                    articulo.Descripcion = (string)DB.Reader["Descripcion"];

                    AsignarMarcaYCategoria(articulo, DB.Reader);

                    articulo.Precio = (decimal)DB.Reader["Precio"];

                    list.Add(articulo);
                }

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DB.CloseConnection();
            }
        }

        public List<string> listarImagenes(string codArticulo)
        {
            List<string> list = new List<string>();

            try
            {
                DB.setQuery("SELECT I.ImagenUrl as Imagen FROM IMAGENES AS I LEFT JOIN ARTICULOS AS A on A.Id = I.IdArticulo WHERE A.Codigo = @CodArticulo");
                DB.setParameter("@CodArticulo", codArticulo);
                DB.excecuteQuery();

                while (DB.Reader.Read())
                {
                    list.Add(DB.Reader["Imagen"].ToString());
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DB.CloseConnection();
            }

        }

        private void AsignarMarcaYCategoria(Articulo articulo, SqlDataReader reader)
        {
            articulo.Marca = new Marca();
            if (!reader.IsDBNull(reader.GetOrdinal("MarcaId")))
            {
                articulo.Marca.Id = (int)reader["MarcaId"];
                articulo.Marca.Descripcion = (string)reader["MarcaDescripcion"];
            }
            else
            {
                articulo.Marca.Id = 0;
                articulo.Marca.Descripcion = string.Empty;
            }


            articulo.Categoria = new Categoria();
            if (!reader.IsDBNull(reader.GetOrdinal("CategoriaId")))
            {
                articulo.Categoria.Id = (int)reader["CategoriaId"];
                articulo.Categoria.Descripcion = (string)reader["CategoriaDescripcion"];
            }
            else
            {
                articulo.Categoria.Id = 0;
                articulo.Categoria.Descripcion = string.Empty;
            }
        }

        public void add(Articulo newArticulo) 
        {
            try
            {
                DB.setQuery("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");

                DB.setParameter("@Codigo", newArticulo.Codigo);
                DB.setParameter("@Nombre", newArticulo.Nombre);
                DB.setParameter("@Descripcion", newArticulo.Descripcion);
                DB.setParameter("@IdMarca", newArticulo.Marca.Id);
                DB.setParameter("@IdCategoria", newArticulo.Categoria.Id);
                DB.setParameter("@Precio", newArticulo.Precio);

                DB.excecuteAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DB.CloseConnection();
            }
        }

        public void modify(Articulo articulo)
        {
            try
            {
                DB.setQuery("Update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @precio Where Id = @Id");

                DB.setParameter("@Codigo", articulo.Codigo);
                DB.setParameter("@Nombre", articulo.Nombre);
                DB.setParameter("@Descripcion", articulo.Descripcion);
                DB.setParameter("@IdMarca", articulo.Marca.Id);
                DB.setParameter("@IdCategoria", articulo.Categoria.Id);
                DB.setParameter("@Precio", articulo.Precio);
                DB.setParameter("@Id", articulo.Id);

                DB.excecuteAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(int Id)
        {
            try
            {
                DB.setQuery("Delete from ARTICULOS where Id = @Id");
                DB.setParameter("@Id", Id);
                DB.excecuteAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool repeatedCode(string codArticulo)
        {
            try
            {
                bool response = false;
                DB.setQuery("Select Codigo from ARTICULOS where Codigo = @codArticulo");
                DB.setParameter("@codArticulo", codArticulo);
                DB.excecuteQuery();

                if (DB.Reader.Read())
                {
                    response = true;
                }

                return response;
            }
            catch (Exception ex)
            {
                return true;
            }
        }
    }
}
