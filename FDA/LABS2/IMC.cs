using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS2
{
    class IMC
    {
        static void Main(string[] args)
        {
            double altura;
            double imc;
            double peso; 
            Console.WriteLine("Escribe tu peso en kg");
            peso = Double.Parse(Console.ReadLine());
            Console.WriteLine("Escribe tu altura en m");
            altura = Double.Parse(Console.ReadLine());
            imc = peso / (Math.Pow(altura, 2));
            Console.WriteLine(imc);
        }
    }
}
