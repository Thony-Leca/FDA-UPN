using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3
{
    class N_Estudiantes
    {
        static void Main(string[] args)
        {
            int nestudiantes, notas_femA, notas_femD, notas_mascA, notas_mascD;
            string sexo;
            double nota_f;
            notas_femA = 0;
            notas_femD = 0;
            notas_mascA = 0;
            notas_mascD = 0;

            Console.WriteLine("Ingrese el número de estudiantes");
            nestudiantes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nestudiantes; i++)
            {
                Console.WriteLine("Ingrese la Nota final del estudiante: " + i);
                nota_f = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el sexo del estudiante: (F o M)" + i);
                sexo = Console.ReadLine();
                if (nota_f >= 13)
                {
                    switch (sexo)
                    {
                        case "F":
                            notas_femA++;
                            break;
                        case "M":
                            notas_mascA++;
                            break;
                        default:
                            Console.WriteLine("Escribiste diferente a F o M");
                            break;
                    }
                }
                else
                {
                    {
                        switch (sexo)
                        {
                            case "F":
                                notas_femD++;
                                break;
                            case "M":
                                notas_mascD++;
                                break;
                            default:
                                Console.WriteLine("Escribiste diferente a F o M");
                                break;
                        }
                    }
                }
            }
            Console.WriteLine("Las alumnas aprobadas en total fueron: " + notas_femA + " y las desaprobadas fueron: " + notas_femD);
            Console.WriteLine("Los alumnos aprobadas en total fueron: " + notas_mascA + " y los desaprobados fueron: " + notas_mascD);
        }
    }
}
