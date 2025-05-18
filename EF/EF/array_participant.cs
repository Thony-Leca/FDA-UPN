using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class array_participant
    {
        static void Main(string[] args)
        {
            int n_participants = 0;
            String reemplazo;
            Console.WriteLine("Cuantos nombres de participantes ingresarás?");
            n_participants = int.Parse(Console.ReadLine());
            string[] array_participants = new string[n_participants];
            for (int i = 0; i < array_participants.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del participante " + (i + 1));
                array_participants[i] = Console.ReadLine();
            }

            for (int i = 0; i < array_participants.Length; i++)
            {
                if (array_participants[i].Contains("o"))
                {
                    reemplazo= array_participants[i].Replace("o", "e");
                }
                else if (array_participants[i].Contains("O"))
                {
                    reemplazo = array_participants[i].Replace("O", "E");
                }
                else
                {
                    reemplazo = array_participants[i];
                }
                Console.WriteLine("El nombre del participante " + (i + 1) + " es: " + reemplazo);
            }
        }
    }
}
