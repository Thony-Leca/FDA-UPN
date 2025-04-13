using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3
{
    class Bucle_For
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("La tabla del " + n +" es:");
            for (int i = 0; i <=12; i++)
            {
                Console.WriteLine(i+ "x"+n + " = " + i*n);
            }
        }
    }
}
