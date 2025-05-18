using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class array_mascotas
    {
        static void Main(string[] args)
        {
            int n_mascotas=0;
            string name_mascota;
            Console.WriteLine("Cuantos nombres de mascotas ingresarás?");
            n_mascotas = int.Parse(Console.ReadLine());
            string[] array_mascotas = new string[n_mascotas];
            for (int i = 0; i < array_mascotas.Length; i++)
            {
                Console.WriteLine("Cúal es el nombre de la mascota " + (i+1));
                name_mascota = Console.ReadLine();
                array_mascotas[i] = name_mascota;
            }
            for (int i = 0; i < array_mascotas.Length; i++)
            {
                Console.WriteLine("El nombre colocado a la mascota " + (i+1) + " es: " + array_mascotas[i].ToUpper());
            }

        }
    }
}
