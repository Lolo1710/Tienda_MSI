using PuntoVenta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta.Servicios
{
    public class Promociones
    {
        public void Promos(int precio)
        {
            Console.WriteLine("\nCuantos articulos vas a llevar?");
            int res = int.Parse(Console.ReadLine());
            int total = precio * res;
            if(total >= 5000 & total <= 7999.99)
            {
                Console.WriteLine("\nFelicidades, tu compra aplica para un descuento del 10%");
                double nuevoTotal = total * 0.90;
                Console.WriteLine($"El monto a pagar es de: ${nuevoTotal}");
            }
            else if (total >= 8000 & total <= 9999.99)
            {
                Console.WriteLine($"\nEl total de tu compra es de: ${total}");
                Console.WriteLine("Por lo tanto tu compra aplica para nuestra promocion 3 meses sin intereses");
                Console.WriteLine("\nDeseas que tu pago sea al contado o prefieres a 3 meses sin intereses?");
                Console.WriteLine("\n1. Contado \n2. 3 meses sin intereses");
                Console.WriteLine("Elije una opcion:");
                int eleccion =  int.Parse(Console.ReadLine());
                if (eleccion == 2)
                {
                    DateTime date = DateTime.Now;
                    DateTime date2 = date.AddDays(31);
                    DateTime date3 = date2.AddDays(30);
                    float Total3msi = total / 3;                    
                    Console.WriteLine($"\nEl monto a pagar hoy {date} es de: ${Total3msi}");
                    Console.WriteLine($"\nTu siguiente pago sera {date2} por el monto de: ${Total3msi}");
                    Console.WriteLine($"\nTu ultimo pago sera {date3} por el monto de ${Total3msi}");
                }
                else
                {
                    Console.WriteLine($"\nEl monto a pagar es de: ${total}");
                }
            }
            else if(total >= 10000)
            {
                Console.WriteLine($"\nEl total de tu compra es de: ${total}");
                Console.WriteLine("Por lo tanto tu compra aplica para nuestra promocion 3, 6 y 12 meses sin intereses");
                Console.WriteLine("\nDeseas que tu pago sea al contado o prefieres a meses sin intereses?");
                Console.WriteLine("\n1. Contado \n2. Meses sin intereses");
                Console.WriteLine("Elije una opcion:");
                int eleccion = int.Parse(Console.ReadLine());
                if (eleccion == 2)
                {
                    Console.WriteLine("\nA cuantos meses deseas diferir tu compra?");
                    Console.WriteLine("\n1. 3 Meses\n2. 6 Meses \n3. 12 Meses");
                    int eleccionMSI = int.Parse(Console.ReadLine());
                    switch(eleccionMSI)
                    {
                        case 1:
                            float Total3msi = total / 3; 
                            Console.WriteLine($"\nEl monto a pagar mensualmente es de: ${Total3msi}");
                            break;
                        case 2:
                            float Total6msi = total / 6;
                            Console.WriteLine($"\nEl monto a pagar mensualmente es de: ${Total6msi}");
                            break;
                        case 3:
                            float Total12msi = total / 12;
                            Console.WriteLine($"\nEl monto a pagar mensualmente es de: ${Total12msi}");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"\nEl monto a pagar es de: ${total}");
                }
            }
            else
            {
                Console.WriteLine($"\nEl total a pagar es de: ${total}");
            }
        }
    }
}
