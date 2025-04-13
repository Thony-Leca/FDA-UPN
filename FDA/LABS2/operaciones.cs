using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS2
{
    class operaciones
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double division;
            double multiplicacion;
            double resta;
            double suma;
            Console.WriteLine("Escribe el 1er numero");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el 2do numero");
            b = Double.Parse(Console.ReadLine());
            suma = a + b;
            resta = a - b;
            multiplicacion = a * b;
            division = a / b;
            Console.WriteLine("La suma de los numeros es " + suma);
            Console.WriteLine("La resta de los numeros es " + resta);
            Console.WriteLine("La multiplicacion de los numeros es " + multiplicacion);
            Console.WriteLine("La division de los numeros es " + division);
        }
    }
}
