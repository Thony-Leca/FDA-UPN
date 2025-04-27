using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Autenticacion
    {
        static void Main(string[] args)
        {
            string user = "admin",
                   user_ingresado = "",
                   pass_ingresado = "",
                   pass = "123";
                   int steps = 1;

            do
            {
                Console.WriteLine("Ingresa el usuario: ");
                user_ingresado = Console.ReadLine();
                Console.WriteLine("Ingresa la contraseña: ");
                pass_ingresado = Console.ReadLine();
                if ( user_ingresado == user && pass_ingresado == pass )
                {
                    Console.WriteLine("Has iniciado sesión correctamente");
                    break;
                }
                else if (steps == 3)
                {
                    Console.WriteLine("Usuario bloqueado");
                    break;
                }
                else
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Las credenciales son incorrectas. Ingresa nuevamente");
                    steps++;
                }
            } while (steps <= 3);
        }
      }
}
