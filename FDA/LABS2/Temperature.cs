using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS2
{
    class Temperature
    {
        static void Main(string[] args)
        {
            double temperature;
            Console.WriteLine("Escribe la temperatura");
            temperature = double.Parse(Console.ReadLine());
            if(temperature>=37) { 
                Console.WriteLine("La temperatura es alta");
            }
        }
    }
}
