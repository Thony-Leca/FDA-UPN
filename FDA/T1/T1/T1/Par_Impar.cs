using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Par_Impar
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese el número a validar: ");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                if (num % 2 ==0)
                {
                    Console.WriteLine("El número ingresado '" + num + "' es par");
                }
                else
                {
                    Console.WriteLine("El número ingresado '" + num + "' es impar");
                }
            }
            else
            {
                Console.WriteLine("El número ingresado no es válido");
            }
        }
    }
}
