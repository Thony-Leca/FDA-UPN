using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3
{
    class While
    {
        static void Main(string[] args)
        {
            String Sexo = "M";
            while (Sexo == "M")
            {
                Console.WriteLine(Sexo);
                Console.WriteLine("Escribe el sexo:");
                Sexo= Console.ReadLine();
            }
        }
    }
}
