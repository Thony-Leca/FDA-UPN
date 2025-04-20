using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabS4
{
    class movilidad
    {
        static void Main(string[] args)
        {
            int cant_movilidades;
            string tipo_comb;
            double gasto_gnv=0,
                   gasto_glp=0,
                   gasto_petroleo = 0,
                   gasto_gasolina = 0,
                   gasto_comb =0,
                   total_comb = 0;

            Console.WriteLine("Cuantas movilidades ingresarás?");
            cant_movilidades = int.Parse(Console.ReadLine());
            for (int i = 1; i <= cant_movilidades; i++)
            {
                Console.WriteLine("Cúal es el tipo de combustible?");
                tipo_comb = Console.ReadLine().ToLower();
                Console.WriteLine("Cúanto gastó?");
                gasto_comb = double.Parse(Console.ReadLine());
                if (tipo_comb == "gnv")
                {
                    gasto_gnv = gasto_gnv + gasto_comb;
                }
                else if (tipo_comb == "glp")
                {
                    gasto_glp = gasto_glp + gasto_comb;
                }
                else if (tipo_comb == "petroleo")
                {
                    gasto_petroleo = gasto_petroleo + gasto_comb;
                }
                else if (tipo_comb == "gasolina")
                {
                    gasto_gasolina = gasto_gasolina + gasto_comb;
                }
                total_comb = total_comb + gasto_comb;
            }

            Console.WriteLine("El total de combustible gastado para las " + cant_movilidades + " unidades fue de S/ " + total_comb);
            Console.WriteLine("El gasto de GNV es S/ " + gasto_gnv);
            Console.WriteLine("El gasto de GLP es S/ " + gasto_glp);
            Console.WriteLine("El gasto de gasolina es S/ " + gasto_gasolina);
            Console.WriteLine("El gasto de petroleo es S/ " + gasto_petroleo);
        }
    }
}
