using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3
{
    class N_Pares
    {
        static void Main(string[] args)
        {
            int ni,nf;
            Console.WriteLine("Ingresa el valor inicial:");
            ni=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor final:");
            nf = int.Parse(Console.ReadLine());
            if (nf > ni)
            {
                for (int i = ni; i <= nf; i++)
                {
                    Console.WriteLine(i * 2);
                }
            }
        }
    }
}
