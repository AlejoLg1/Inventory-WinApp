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
    }
}
