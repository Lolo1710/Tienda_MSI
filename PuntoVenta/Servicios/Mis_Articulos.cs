using PuntoVenta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta.Servicios
{
    public class Mis_Articulos
    {
        public List<Articulos> Agregar()
        {
            try
            {

                List<Articulos> lista = new List<Articulos>();

                Articulos articulo1 = new Articulos()
                {
                    ID_Articulo = 1,
                    Nombre_Articulo = "Pc Gamer",
                    Descripcion = "Para jugar",
                    Precio = 2500
                };

                lista.Add(articulo1);

                Articulos articulo2 = new Articulos()
                {
                    ID_Articulo = 2,
                    Nombre_Articulo = "Pc Escritorio",
                    Descripcion = "Para Escuela",
                    Precio = 3000
                };

                lista.Add(articulo2);

                Articulos articulo3 = new Articulos()
                {
                    ID_Articulo = 3,
                    Nombre_Articulo = "Audifonos",
                    Descripcion = "Para relajarte",
                    Precio = 1500
                };

                lista.Add(articulo3);

                Articulos articulo4 = new Articulos()
                {
                    ID_Articulo = 4,
                    Nombre_Articulo = "Xbox",
                    Descripcion = "Para jugar en linea",
                    Precio = 4500
                };

                lista.Add(articulo4);

                Articulos articulo5 = new Articulos()
                {
                    ID_Articulo = 5,
                    Nombre_Articulo = "Mouse",
                    Descripcion = "Optimizar tu PC",
                    Precio = 1000
                };

                lista.Add(articulo5);

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("\nSucedio un error " + ex.Message);
            }
        }

        public void Imprimir(List<Articulos> art)
        {
            try
            {
                Console.Write($"ID:     ");
                Console.Write($"Nombre:     ");
                Console.Write($"Descripcion:     ");
                Console.Write($"Precio:     ");
                foreach (Articulos articulo in art)
                {
                    Console.WriteLine("");
                    Console.Write($"{articulo.ID_Articulo}     ");
                    Console.Write($"{articulo.Nombre_Articulo}     ");
                    Console.Write($"{articulo.Descripcion}     ");
                    Console.Write($"{articulo.Precio}     ");
                    Console.WriteLine("");
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedio un error " + ex.Message);
            }
        }

        public int ComprobarArticulo(int opcion)
        {
            try
            {
                List<Articulos> lista = new List<Articulos>();
                Mis_Articulos articulo = new Mis_Articulos();
                lista = articulo.Agregar();

                Console.WriteLine("\nLos detalles del articulo seleccionado son:");
                Console.WriteLine($"ID: {lista[opcion].ID_Articulo}");
                Console.WriteLine($"Producto: {lista[opcion].Nombre_Articulo}");
                Console.WriteLine($"Precio: {lista[opcion].Precio}");

                return lista[opcion].Precio;
            }
            catch (Exception ex)
            {
                throw new Exception("\nSucedio un error " + ex.Message);
            }
        }
    }
}
