using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS2
{
    class Aprobated
    {
        static void Main(string[] args)
        {
            double nota;
            Console.WriteLine("Escribe la nota");
            nota = double.Parse(Console.ReadLine());
            if (nota >= 13)
            {
                Console.WriteLine("APROBADO");
            }
            else
            {
                Console.WriteLine("DESAPROBADO");
            }
        }
    }
}
