using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea4_AdapterFacade
{
    class Prestamo
    {
        private string nombre;
        private string apellido;
        private int codigoPrestamo;
        private double monto;
        private double tasa = 0.19;
        private double deposito;
        private int opcion;

        public void menu()
        {
            Console.Clear();
            Console.WriteLine("*----------Prestamos----------*\n\n");
            Console.WriteLine("1. Solicitud");
            Console.WriteLine("2. Pago de prestamos");
            Console.WriteLine("3. Volver al Menu Principal");
            Console.WriteLine("*-----------------------------------------*");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    solicitud();
                    break;
                case 2:
                    pago();
                    break;
                case 3:
                    PrincipalContainer.menu();
                    break;
            }
        }

        public void solicitud()
        {
            Console.Clear();
            Console.WriteLine("*----------Solicitud----------*\n\n");
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Codigo de Prestamo: ");
            codigoPrestamo = int.Parse(Console.ReadLine());
            Console.Write("Moto de Prestamo: ");
            monto = double.Parse(Console.ReadLine());
            Console.WriteLine($"Taza Actual de Prestamo: {tasa*100}%");
            Console.WriteLine($"Monto de pago mensual: RD${monto * tasa}");
            Console.WriteLine("\n\nSolicitud registrada correctamente!...");
            Console.WriteLine("Presione una tecla para volver...");
            Console.ReadKey();
            menu();
        }
        public void pago()
        {
            int code;
            do
            {
                Console.Clear();
                Console.WriteLine("*----------Pago de Prestamo----------*\n\n");
                Console.Write("Introduzca el codigo de prestamos: ");
                code = int.Parse(Console.ReadLine());
            } while (code != codigoPrestamo);
            Console.Clear();
            Console.WriteLine("*----------Pago de Prestamo----------*\n\n");
            Console.Write("Introduzca el monto: ");
            monto -= double.Parse(Console.ReadLine());
            Console.WriteLine($"\nPago realizado sastifactoriamente!...");
            Console.WriteLine($"\nSolo debe RD${monto}");
            Console.WriteLine("\n\nPresione una tecla para volver...");
            Console.ReadKey();
            menu();
        }
    }
}
