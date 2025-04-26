using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDA_PracticadeCampoS4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadAlumnos, cantidadAprobados = 0, cantidadDesaprobados = 0;
            double n1, n2, n3, n4, promedio, porcentajeAprobados, porcentajeDesaprobados;

            Console.Write("Ingresa la cantidad de alumnos a calificar: ");
            cantidadAlumnos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantidadAlumnos; i++)
            {
                Console.Write($"Ingresa la nota de la práctica calificada del estudiante {i}: ");
                n1 = double.Parse(Console.ReadLine());

                Console.Write($"Ingresa la nota actitudinal del estudiante {i}: ");
                n2 = double.Parse(Console.ReadLine());

                Console.Write($"Ingresa la nota de los trabajos del estudiante {i}: ");
                n3 = double.Parse(Console.ReadLine());

                Console.Write($"Ingresa la nota del examen del estudiante {i}: ");
                n4 = double.Parse(Console.ReadLine());

                promedio = n1 * 0.15 + n2 * 0.10 + n3 * 0.25 + n4 * 0.5;

                if (promedio >= 12)
                    cantidadAprobados++;
                else
                    cantidadDesaprobados++;
            }

            porcentajeAprobados = (cantidadAprobados / cantidadAlumnos) * 100;
            porcentajeDesaprobados = (cantidadDesaprobados /cantidadAlumnos) * 100;

            Console.WriteLine($"Según lo ingresado, la cantidad de alumnos aprobados es: {cantidadAprobados} y la cantidad de alumnos desaprobados es: {cantidadDesaprobados}. teniendo como porcentajes un  {porcentajeAprobados}% y {porcentajeDesaprobados}% respectivamente");
        }
    }
}
