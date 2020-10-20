using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea4_AdapterFacade
{
    class SuperAhorro
    {
        public double monto;
        public double retiros;
        public bool uso;
        public SuperAhorro()
        {
            uso = false;
            monto = 0;
        }
        public double validarRetiro()
        {
            Console.Write("Ingrese su retiro: ");
            retiros = double.Parse(Console.ReadLine());
            if (retiros <= (monto * 0.4))
            {
                monto -= retiros;
                uso = true;
                Console.WriteLine("\n\nRetiro Exitoso!");
                Console.WriteLine("Presione una tecla para volver...");
                return monto;
            }
            else
                uso = false;
            return monto;
        }
    }
}


