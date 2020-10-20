using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Tarea4_AdapterFacade
{
    class CuentaAhorroM
    {
        private string nombre;
        private int codigoC;
        private double balance = 100000.45;

        public void consulta()
        {
            Console.Clear();
            Console.WriteLine("*----------Cuenta de Ahorro Movil----------*\n\n");
            Console.WriteLine("*-----Consulta-----*");
            Console.Write("Introduzca su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Introduza su numero de cuenta: ");
            codigoC = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("*----------Cuenta de Ahorro Movil----------*\n\n");
            Console.WriteLine($"Bienvenido {nombre}");
            Console.WriteLine($"Su balance es: {balance}\n\n\n");
            Console.WriteLine("Presione una tecla para volver...");
            Console.ReadKey();

        }
    }
}
