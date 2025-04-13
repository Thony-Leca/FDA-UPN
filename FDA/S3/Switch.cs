using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3
{
    class Switch
    {
        static void Main(string[] args)
        {
            int a = 1;
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Primero, segundo o tercero");
                    break;
                case 4:
                    Console.WriteLine("Cuarto");
                    break;
                case 5:
                    Console.WriteLine("Quinto");
                    break;
                default:
                    Console.WriteLine("Nada de lo contrario");
                    break;
            }
        }
    }
}
