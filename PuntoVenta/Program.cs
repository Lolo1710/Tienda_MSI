using PuntoVenta.Servicios;
using System;
using System.Collections.Generic;

namespace PuntoVenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res;
            do
            {
                Menu menu = new Menu();
                menu.Inicio();

                Console.WriteLine("\nDeseas continuar?");
                Console.WriteLine("\n1. Si\n2. No");
                res = int.Parse(Console.ReadLine());
            } while (res != 2);
        }
    }
}
