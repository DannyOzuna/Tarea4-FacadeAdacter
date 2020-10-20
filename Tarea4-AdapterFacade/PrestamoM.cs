using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea4_AdapterFacade
{
    class PrestamoM
    {
        private double monto = 10000;
        public void pago()
        {
            Console.Clear();
            Console.WriteLine("*----------Pago de Prestamo Movil----------*\n\n");
            Console.Write("Introduzca el monto: ");
            monto -= double.Parse(Console.ReadLine());
            Console.WriteLine($"\nPago realizado sastifactoriamente!...");
            Console.WriteLine($"\nSolo debe RD${monto}");
            Console.WriteLine("\n\nPresione una tecla para volver...");
            Console.ReadKey();
        }
    }
}
