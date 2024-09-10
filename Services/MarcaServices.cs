using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Services
{
    public class MarcaServices
    {
        private DataBaseAccess dato = new DataBaseAccess();
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();

            try
            {
                dato.setQuery("SELECT Id, Descripcion from MARCAS");
                dato.excecuteQuery();
                while (dato.Reader.Read())
                {
                    Marca auxiliar = new Marca();
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
          private void add(Marca newMarca)
          {
              try
              {
                  dato.setQuery("INSERT into MARCAS (Descripcion) values(@Descripcion)");
                  dato.setParameter("@Descricion", newMarca.Descripcion);

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

          private void modify(Marca marca)
          {
              try
              {
                  dato.setQuery("UPDATE MARCAS Descripcion = @Descripcion where id = @Id");
                  dato.setParameter("@Descripcion", marca.Descripcion);

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

