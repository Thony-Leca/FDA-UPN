using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabS4
{
    class Sueldo_vendedor
    {
        static void Main(string[] args)
        {
            double sueldo_t, sueldo_b, monto_ventas;
            sueldo_b = 930;
            Console.WriteLine("Escribe el monto de tus ventas");
            monto_ventas= double.Parse(Console.ReadLine());
            sueldo_t = sueldo_b + (monto_ventas * 0.10);
            Console.WriteLine("Tu sueldo a cobrar es: " + sueldo_t);
        }
    }
}
