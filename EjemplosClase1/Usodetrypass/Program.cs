using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Usodetrypass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Uso de tryparse";

            string dato;

            Console.WriteLine("Ingrese su edad: ");

            dato = Console.ReadLine();

            int numero;

            // numero = int.Parse(dato);

            while (int.TryParse(dato, out numero) == false)
            {
                Console.WriteLine("ERROR!!! Reintente el ingreso de edad: ");
                dato = Console.ReadLine();
            }
        }
    }
}
