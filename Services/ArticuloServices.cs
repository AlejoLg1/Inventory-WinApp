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
                DB.setQuery("SELECT A.Codigo, A.Nombre, A.Descripcion, M.Id AS MarcaId, M.Descripcion AS MarcaDescripcion, C.Id AS CategoriaId, C.Descripcion AS CategoriaDescripcion, A.Precio FROM ARTICULOS AS A LEFT JOIN CATEGORIAS AS C ON C.Id = A.IdCategoria LEFT JOIN MARCAS AS M ON M.Id = A.IdMarca");
                DB.excecuteQuery();

                while (DB.Reader.Read())
                {
                    Articulo articulo = new Articulo();
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
    }
}
