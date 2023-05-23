using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta.Entities
{
    public class Articulos
    {
        public int ID_Articulo { get; set; }
        public string Nombre_Articulo { get; set;}
        public string Descripcion { get; set;}
        public int Precio { get; set;}
    }
}
