using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea4_AdapterFacade
{
    class AhorroNormal : ICuentas
    {
        private string nombre;
        private string apellido;
        private int numeroCuenta;
        private double monto;
        public void apertura()
        {
            Console.WriteLine("*----------Apertura de Cuenta----------*");
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Numero de Cuenta: ");
            numeroCuenta = int.Parse(Console.ReadLine());
            Console.Write("Monto de Apertura: ");
            monto = double.Parse(Console.ReadLine());
            Console.WriteLine("\n\nLa cuenta se registrado correctamente!...");
            Console.WriteLine("Presione una tecla para volver!....");
            Console.ReadKey();
        }

        public double consulta()
        {
            return monto;
        }

        public double deposito()
        {
            Console.Write("Ingrese su deposito: ");
            monto += double.Parse(Console.ReadLine());
            return monto;
        }

        public double retiro()
        {
            Console.WriteLine($"Monto Actual: {monto}\n\n");
            if (monto <= 0)
            {
                Console.WriteLine("Tiene Saldo Disponible\n\n");
                Console.WriteLine("Presione una tecla para volver!....");
                Console.ReadKey();
                return 0;

            }
            else
            {
                
                Console.Write("Ingrese su retiro: ");
                double retiros = double.Parse(Console.ReadLine());
                if (monto < retiros)
                {
                    Console.WriteLine("\n\nEl retiro es mas alto que el monto disponible");
                    Console.WriteLine("Presione una tecla para volver a intentar!....");
                    Console.ReadKey();
                    Console.Clear();
                    retiro();                    
                }
                else
                {
                    monto -= retiros;
                    Console.WriteLine("\n\nRetiro Exitoso!");
                    Console.WriteLine("Presione una tecla para volver!...");
                }
                
                return monto;
            }
        }
    }
}
