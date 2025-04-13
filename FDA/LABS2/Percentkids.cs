using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS2
{
    class Percentkids
    {
        static void Main(string[] args)
        {
            int c_ninos, c_ninas, total;
            double p_ninos, p_ninas;
            Console.WriteLine("Escribe la cantidad de niños:");
            c_ninos = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la cantidad de niñas:");
            c_ninas= int.Parse(Console.ReadLine());
            total = c_ninos + c_ninas;
            p_ninos = c_ninos * 100 / total;
            p_ninas= c_ninas * 100 / total;
            Console.WriteLine("El porcentaje de niños es: " + p_ninos + "% y el de niñas es: " + p_ninas + "%");
        }
    }
}
