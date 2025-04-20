using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabS4
{
    class doble_carrera
    {
        static void Main(string[] args)
        {
            string carrera_n1, carrera_n2;
            Console.WriteLine("Escribe tu primera carrera");
            carrera_n1 = Console.ReadLine();
            Console.WriteLine("Escribe tu segunda carrera");
            carrera_n2 = Console.ReadLine();
            if (carrera_n1 == "Empresarial" || carrera_n1 == "Sistemas" && carrera_n1 == "Empresarial" || carrera_n2 == "Sistemas")
            {
                Console.WriteLine("Doble carrera");
            }
            else
            {
                Console.WriteLine("No registra");
            }
        }
    }
}
