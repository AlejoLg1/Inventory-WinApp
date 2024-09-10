using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Models;
using Utils;

namespace Services
{
    public class CategoriaServices
    {
        private DataBaseAccess dato = new DataBaseAccess();
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();

            try
            {
                dato.setQuery("SELECT Id, Descripcion from CATEGORIAS");
                dato.excecuteQuery();
                while (dato.Reader.Read())
                {
                    Categoria auxiliar = new Categoria();
                    auxiliar.Id = dato.Reader.GetInt32(0);
                    auxiliar.Descripcion = (string)dato.Reader["Descripcion"];

                    lista.Add(auxiliar);
                }


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dato.CloseConnection();
            }
        }

        public void add(Categoria NewCategoria)
        {
            try
            {
                dato.setQuery("INSERT into CATEGORIAS (Descripcion) values(@Descripcion)");
                dato.setParameter("@Descripcion", NewCategoria.Descripcion);

                dato.excecuteAction();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dato.CloseConnection();
            }
        }

        public void modify(Categoria categoria)
        {
            try
            {
                dato.setQuery("UPDATE CATEGORIAS set Descripcion = @Descripcion where id = @Id");
                dato.setParameter("@Descripcion", categoria.Descripcion);
                dato.setParameter("@Id", categoria.Id);

                dato.excecuteAction();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dato.CloseConnection();
            }
        }

        public void delete(int Id)
        {
            try
            {
              dato.setQuery("DELETE from CATEGORIAS where id = @Id");
              dato.setParameter("@Id",Id);

              dato.excecuteAction();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dato.CloseConnection();
            }
        }
    }
}
