using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea4_AdapterFacade
{
    class CertificadoM
    {
        Random random;
        private double monto;

        public void certificado()
        {
            Console.Clear();
            Console.WriteLine("*----------Consulta de Interes Movil----------*\n\n");
            Console.Write("Ingrese su monto: ");
            monto = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("*----------Consulta de Interes Movil----------*\n\n");
            Console.WriteLine($"Su valor arbitrario: {random.Next(Convert.ToInt32(monto))}");
            Console.WriteLine("\n\nPresione una tecla para volver...");
            Console.ReadKey();
        }
    }
}
