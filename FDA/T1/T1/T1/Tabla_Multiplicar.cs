using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Tabla_Multiplicar
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese el número a generar su tabla de multiplicar: ");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                for (int i = 1; i <=12; i++)
                {
                    Console.WriteLine(num + " x " + i + " = " + num * i);
                }
            }
            else
            {
                Console.WriteLine("El número ingresado no es válido");
            }
        }
    }
}
