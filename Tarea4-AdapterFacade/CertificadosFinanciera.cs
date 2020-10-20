using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea4_AdapterFacade
{
    class CertificadosFinanciera
    {
        Random random;
        private string nombre;
        private string apellido;
        private int codigoCertificado;
        private double monto;
        private string duracion;
        private int valor;
        private int opcion;

        public void menu()
        {
            Console.Clear();
            Console.WriteLine("*----------Certificados Financieras----------*\n\n");
            Console.WriteLine("1. Apertura");
            Console.WriteLine("2. Consulta de interes");
            Console.WriteLine("3. Volver al Menu Principal");
            Console.WriteLine("*-----------------------------------------*");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    apertura();
                    break;
                case 2:
                    consultaIntereses();
                    break;
                case 3:
                    PrincipalContainer.menu();
                    break;
            }
        }

        public void apertura()
        {
            Console.Clear();
            Console.WriteLine("*----------Apertura----------*\n\n");
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Codigo de certificado: ");
            codigoCertificado = int.Parse(Console.ReadLine());
            Console.Write("Monto: ");
            monto = double.Parse(Console.ReadLine());
            Console.Write("Duracion: ");
            duracion = Console.ReadLine();
            Console.WriteLine("\n\nApertura registrada correctamente!...");
            Console.WriteLine("Presione una tecla para volver...");
            Console.ReadKey();
            menu();
        }
        public void consultaIntereses()
        {
            Console.Clear();
            Console.WriteLine("*----------Consulta de Interes----------*\n\n");
            Console.WriteLine($"Su valor arbitrario: {random.Next(Convert.ToInt32(monto))}");
            Console.WriteLine("\n\nConsulta realizada correctamente!...");
            Console.WriteLine("Presione una tecla para volver...");
            Console.ReadKey();
            menu();
        }
    }
}
