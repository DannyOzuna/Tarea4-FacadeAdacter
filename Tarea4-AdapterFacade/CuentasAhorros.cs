using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea4_AdapterFacade
{
    class CuentasAhorros
    {
        ICuentas cuentas;
        private int opcion;

        public void menu()
        {
            Console.Clear();
            Console.WriteLine("*----------Cuentas de Ahorro----------*\n\n");
            Console.WriteLine("1. Ahorro Normal");
            Console.WriteLine("2. Super Ahorro");
            Console.WriteLine("3. Volver al Menu Principal");
            Console.WriteLine("*-----------------------------------------*");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    cuentas = new AhorroNormal();
                    break;
                case 2:
                    cuentas = new Adaptador();
                    break;
                case 3:
                    PrincipalContainer.menu();
                    break;
            }
                
            menuCliente();
        }
        public void menuCliente()
        {
            Console.Clear();
            Console.WriteLine("*----------Cuentas de Ahorro----------*\n\n");
            Console.WriteLine("1. Apertura");
            Console.WriteLine("2. Deposito");
            Console.WriteLine("3. Retiro");
            Console.WriteLine("4. Consulta");
            Console.WriteLine("5. Volver al menu");
            Console.WriteLine("*-----------------------------------------*");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    cuentas.apertura();
                    menuCliente();
                    break;
                case 2:
                    Console.Clear();
                    cuentas.deposito();
                    Console.ReadKey();
                    menuCliente();
                    break;
                case 3:
                    Console.Clear();
                    cuentas.retiro();
                    Console.ReadKey();
                    menuCliente();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("*----------Consulta----------*\n\n");
                    Console.WriteLine($"Monto Actual: {cuentas.consulta()}");
                    Console.WriteLine("Presione una tecla para volver!....");
                    Console.ReadKey();
                    menuCliente();
                    break;
                case 5:
                    menu();
                    break;
            }
        }
    }
}
