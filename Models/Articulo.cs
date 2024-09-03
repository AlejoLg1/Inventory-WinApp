using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Articulo
    {
        public int Id { get; set; }

        [DisplayName("Código")]
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        [DisplayName("Marca")]
        public int IdMarca { get; set; }

        [DisplayName("Categoria")]
        public int IdCategoria { get; set; }

        public string Imagen { get; set; }

        public decimal Precio { get; set; }
    }
}
