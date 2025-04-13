using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS2
{
    class Age
    {
        static void Main(string[] args)
        {
            int edad,year_actual,year_birth;
            year_actual = 2025;
            Console.WriteLine("Escribe el año de tu nacimiento");
            year_birth =int.Parse(Console.ReadLine());
            edad = year_actual - year_birth;
            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
        }
    }
}
