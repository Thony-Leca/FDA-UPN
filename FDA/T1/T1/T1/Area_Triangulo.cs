using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Area_Triangulo
    {
        static void Main(string[] args)
        {
            double base_t, altura_t, area_t = 0;
                Console.WriteLine("Ingresa la base del triángulo");
                base_t = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la altura del triángulo");
                altura_t = double.Parse(Console.ReadLine());
                if (base_t >0 && altura_t > 0)
                {
                    area_t = (base_t * altura_t) / 2;
                    Console.WriteLine("El área del triangulo es: " + area_t);
                }
                else
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Los números ingresados son negativos o no son mayores a 0.");
                }
            }
    }
}
