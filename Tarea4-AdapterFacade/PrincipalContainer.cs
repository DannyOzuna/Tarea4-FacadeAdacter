using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Tarea4_AdapterFacade
{
    class PrincipalContainer
    {
        private static int opcion;
        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("*----------Sistema Bancario----------*\n\n");
            Console.WriteLine("1. Cuenta de Ahorro");
            Console.WriteLine("2. Prestamos");
            Console.WriteLine("3. Tarjetas de creditos");
            Console.WriteLine("4. Certificados Financieros");
            Console.WriteLine("5. App Movil");
            Console.WriteLine("6. Volver al Menu Principal");
            Console.WriteLine("*-----------------------------------------*");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    CuentasAhorros ahorros = new CuentasAhorros();
                    ahorros.menu();
                    break;
                case 2:
                    Prestamo prestamo = new Prestamo();
                    prestamo.menu();
                    break;
                case 3:
                    TarjetaCredito tarjeta = new TarjetaCredito();
                    tarjeta.menu();
                    break;
                case 4:
                    CertificadosFinanciera financiera = new CertificadosFinanciera();
                    financiera.menu();
                    break;
                case 5:
                    AppMovil movil = new AppMovil();
                    movil.menu();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
