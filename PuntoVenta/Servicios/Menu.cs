using System;
using PuntoVenta.Servicios;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using PuntoVenta.Entities;

namespace PuntoVenta.Servicios
{
    public class Menu
    {
        public void Inicio()
        {
            List<Articulos> lista = new List<Articulos>();
            Mis_Articulos articulo = new Mis_Articulos();
            Promociones promocion = new Promociones();

            lista = articulo.Agregar();
            articulo.Imprimir(lista);

            Console.WriteLine("\nSelecciona el ID del producto a comprar");
            int opcion = int.Parse(Console.ReadLine());

            if( opcion >= 1 & opcion <= 5 ) 
            {
                int corregirOpcion = opcion - 1;
                int precio = articulo.ComprobarArticulo(corregirOpcion);
                promocion.Promos(precio);

            }
            else
            {
                Console.WriteLine("\nEl producto con ese ID no existe, por favor ingresa un ID de producto del 1 al 5");
            }
        }
    }
}
