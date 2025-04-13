using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3
{
    class N_Personas
    {
        static void Main(string[] args)
        {
            int npersonas;
            int edad, suma_edad;
            double promedio;
            suma_edad = 0;

            Console.WriteLine("Ingrese el número de personas");
            npersonas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= npersonas; i++)
            {
                Console.WriteLine("Ingrese la edad: " + i);
                edad = int.Parse(Console.ReadLine());
                suma_edad = suma_edad + edad;
            }
            promedio = suma_edad / npersonas;
            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}
