using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea4_AdapterFacade
{
    class AppMovil
    {
        //Variables de referencia
        PrestamoM prestamoM;
        CuentaAhorroM ahorroM;
        CertificadoM certificadoM;
        private int opcion;

        public void menu()
        {
            Console.Clear();
            Console.WriteLine("*----------App Movil----------*\n\n");
            Console.WriteLine("1. Prestamo");
            Console.WriteLine("2. Cuenta de Ahorro");
            Console.WriteLine("3. Certificados Finacieros");
            Console.WriteLine("4. Volver al Menu Principal");
            Console.WriteLine("*-----------------------------------------*");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    operacionCuentra();
                    menu();
                    break;
                case 2:
                    operacionPrestamo();
                    menu();
                    break;
                case 3:
                    operacionCertificado();
                    menu();
                    break;
                case 4:
                    PrincipalContainer.menu();
                    break;
            }
        }

        public void operacionPrestamo()
        {
            prestamoM = new PrestamoM();
            prestamoM.pago();
        }
        public void operacionCuentra()
        {
            ahorroM = new CuentaAhorroM();
            ahorroM.consulta();
        }
        public void operacionCertificado()
        {
            certificadoM = new CertificadoM();
            certificadoM.certificado();
        }
    }
}
