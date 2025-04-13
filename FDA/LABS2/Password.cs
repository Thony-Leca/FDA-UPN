using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS2
{
    class Password
    {
        static void Main(string[] args)
        {
            string pass;
            Console.WriteLine("Escribe la contraseña");
            pass = (Console.ReadLine());
            if (pass == "upn2025")
            {
                Console.WriteLine("Logueado");
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta");
            }
        }
    }
}
