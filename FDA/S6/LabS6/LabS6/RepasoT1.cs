using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabS6
{
    class RepasoT1
    {
        static void Main(string[] args)
        {
            double resultado,n1,n2;
            string opc;
            Boolean is_valid = false;
            do
            {
                Console.WriteLine("Ingresa el tipo de operación a realizar:");
                Console.WriteLine("1 = suma, 2 = resta, 3 = multiplicación, 4 = división");
                opc = Console.ReadLine();
                if (int.Parse(opc) >= 1 && int.Parse(opc) <= 4)
                {
                    is_valid = true;
                }
                else
                {
                    Console.WriteLine("Ingresa un tipo de operación válido");
                }
            } while (is_valid == false);
            Console.WriteLine("Ingrese el número 1:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2:");
            n2 = double.Parse(Console.ReadLine());
            switch (opc)
            {
                case "1":
                    resultado = Sumar(n1, n2);
                    break;
                case "2":
                    resultado = Restar(n1, n2);
                    break;
                case "3":
                    resultado = Multiplicar(n1, n2);
                    break;
                case "4":
                    resultado = Dividir(n1, n2);
                    break;
                default:
                    break;
            }
        }
        public static double Sumar(double a, double b)
        {
           return a + b;
        }
        public static double Restar(double a, double b)
        {
            return a - b;
        }
        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }
        public static double Dividir(double a, double b)
        {
            return a / b;
        }
    }
}
