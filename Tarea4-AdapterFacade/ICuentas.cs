using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea4_AdapterFacade
{
    interface ICuentas
    {
        void apertura();
        double deposito();
        double retiro();
        double consulta();
    }
}
