using System;

namespace Tarea4_AdapterFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            TarjetaCredito tarjeta = new TarjetaCredito();
            Console.WriteLine("*-------------------------------------------*");
            Console.WriteLine("      Bienvenidos al Sistema Bancario        ");
            Console.WriteLine("*-------------------------------------------*");
            Console.WriteLine("\n\n\n\nPresione una tecla.....");
            Console.ReadKey();
            tarjeta.menu();
        }
    }
}
