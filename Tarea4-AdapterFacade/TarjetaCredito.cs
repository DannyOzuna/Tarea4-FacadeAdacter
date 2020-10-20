using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea4_AdapterFacade
{
    class TarjetaCredito
    {
        private string nombre;
        private string apellido;
        private int codigoTarjeta;
        private double montoLimite;
        private double valor;
        private int opcion;

        public void menu()
        {
            Console.Clear();
            Console.WriteLine("*----------Tarjetas de Creditos----------*\n\n");
            Console.WriteLine("1. Expedicion");
            Console.WriteLine("2. Consumos");
            Console.WriteLine("3. Pago");
            Console.WriteLine("4. Volver al menu principal");
            Console.WriteLine("*-----------------------------------------*");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    expedicion();
                    break;
                case 2:
                    consumo();
                    break;
                case 3:
                    pago();
                    break;
                case 4:
                    PrincipalContainer.menu();
                    break;
            }
        }

        public void expedicion()
        {
            Console.Clear();
            Console.WriteLine("*----------Expedicion----------*\n\n");
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Codigo de la Tarjeta: ");
            codigoTarjeta = int.Parse(Console.ReadLine());
            Console.Write("Monto limite de la tarjeta: ");
            montoLimite = double.Parse(Console.ReadLine());
            Console.WriteLine("\n\nExpedicion Exitosa!...");
            Console.WriteLine("Presione una tecla para volver...");
            Console.ReadKey();
            menu();
        }
        public void consumo()
        {
            Console.Clear();
            Console.WriteLine("*----------Consumo----------*\n\n");
            Console.Write("Ingrese el monto a consumir: ");
            valor = double.Parse(Console.ReadLine());
            if (valor > montoLimite)
            {
                Console.WriteLine("No tiene suficiente salgo");
                Console.WriteLine("Presione una tecla para volver a intentar!...");
                Console.ReadKey();
                consumo();
            }
            else
            {
                montoLimite -= valor;
                Console.WriteLine("\nConsumo Exitoso!...");
                Console.WriteLine($"\n\nSu Consumo es: {valor}");
                Console.WriteLine($"Saldo disponible: {montoLimite}");
                Console.WriteLine("\n\nPresione una tecla para volver...");
                Console.ReadKey();
                menu();
            }
        }
        public void pago()
        {
            double recibido = 0;
            Console.Clear();
            Console.WriteLine("*----------Pago----------*\n");
            Console.WriteLine($"Debe: {valor}\n\n");
            Console.Write("Ingrese el monto a Pagar: ");
            recibido = double.Parse(Console.ReadLine());
            valor -= recibido;
            montoLimite += recibido;
            Console.WriteLine("\nPago Exitoso!...");
            Console.WriteLine($"\n\nSu Pago es: {recibido}");
            Console.WriteLine($"Su Debe es: {valor}");
            Console.WriteLine($"Saldo disponible: {montoLimite}");
            Console.WriteLine("\n\nPresione una tecla para volver...");
            Console.ReadKey();
            menu();
        }

    }
}
