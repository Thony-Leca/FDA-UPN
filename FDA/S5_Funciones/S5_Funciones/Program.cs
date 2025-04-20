using System;

namespace S5_Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            double montoPago;
            double montoBase;
            string tipocl;
            double ventatotal = 0;

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Ingresa el monto: ");
                montoBase = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el tipo de cliente: ");
                tipocl = Console.ReadLine();
                montoPago = total_Pago(montoBase, tipocl);
                ventatotal += montoPago;
            }
            Console.WriteLine("El total a pagar es: " + ventatotal);
        }
        public static void Saludar(string name)
        {
            Console.WriteLine("Bondo" + name);
        }
        public static void Multiplicar(int num1, int num2)
        {
            Console.WriteLine("X2: " + num1 * 2 + ", " + num2 * 2);
        }
        public static void OperacionMat(string tipo, int num1, int num2)
        {
            if (tipo == "multiplicar")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (tipo == "sumar")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (tipo == "restar")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (tipo == "dividir")
            {
                Console.WriteLine(num1 / num2);
            }
        }
        public static string FullName(string name, string lastname)
        {
            return name + lastname;
        }
        public static double total_Pago(double monto, string tipocl)
        {
            double pago = 0;
            double desc_monto = 0;
            double descadicional = 0;
            if (monto > 500)
            {
                desc_monto = monto * 0.10;
            }
            else if (monto > 300 && monto <= 500)
            {
                desc_monto = monto * 0.05;
            }
            else if (monto > 100 && monto <= 300)
            {
                desc_monto = monto * 0.02;
            }
            if (tipocl == "p")
            {
                descadicional = 50;
            }
            else if (tipocl == "r")
            {
                descadicional = 20;
            }
            pago = monto - desc_monto - descadicional;
            return pago;
        }
    }
}
