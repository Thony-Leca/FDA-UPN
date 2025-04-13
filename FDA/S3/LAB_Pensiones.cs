using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3
{
    class LAB_Pensiones
    {
        static void Main(string[] args)
        {
            int cat_A = 550;
            int cat_B = 500;
            int cat_C = 460;
            int cat_D = 400;
            int cat_asignada = 0;
            String cat_name = null;
            double prom_ponde = 0;
            double descuento = 0;
            double pension = 0;

            Console.WriteLine("Ingresa tu categoría:");
            cat_name= Console.ReadLine();
            if (cat_name == "A")
            {
                cat_asignada = cat_A;
            }
            else if (cat_name == "B")
            {
                cat_asignada = cat_B;
            }
            else if (cat_name == "C")
            {
                cat_asignada = cat_C;
            }
            else if (cat_name == "D")
            {
                cat_asignada = cat_D;
            }

            Console.WriteLine("Ingresa tu promedio ponderado del ciclo anterior:");
            prom_ponde = int.Parse(Console.ReadLine());
            if(prom_ponde <14)
            {
                descuento = 0;
            }
            else if(prom_ponde < 16)
            {
                descuento = 0.1;
            }
            else if(prom_ponde < 18)
            {
                descuento = 0.12;
            }
            else
            {
                descuento = 0.15;
            }
            pension = cat_asignada - (cat_asignada * descuento);
            Console.WriteLine("Perteneces a la categoría " +cat_name+ " con un descuento del " + descuento*100 + "% " + 
                ", tus pensiones a pagar serán de: S/" + pension);
        }
    }
}
