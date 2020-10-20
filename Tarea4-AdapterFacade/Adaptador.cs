using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea4_AdapterFacade
{
    class Adaptador: ICuentas
    {
        SuperAhorro superAhorro = new SuperAhorro();
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
            Console.WriteLine("\n\nDeposito Exitoso!");
            Console.WriteLine("Presione una tecla para volver...");
            return monto;
        }

        public double retiro()
        {
            superAhorro.monto = monto;
            superAhorro.validarRetiro();
            if (superAhorro.uso == true)
            {
                monto = superAhorro.monto;
            }
            else
            {
                Console.WriteLine("\n\nSe realizara el retiro de manera normal");
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                double retiros = superAhorro.retiros;
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
                    Console.WriteLine("\n\nRetiro normal Exitoso!");
                    Console.WriteLine("Presione una tecla para volver!...");
                }
            }
            return monto;
        }
    }
}
