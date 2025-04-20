using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5_Funciones
{
    class Pago_trabajador
    {
        static void Main(string[] args)
        {
            double sueldo_neto,
                   sueldo_bruto,
                   total_pagos = 0;
            int num_trabajadores;
            string tipoafp;
            Console.WriteLine("Ingresa el número de trabajadores: ");
            num_trabajadores= int.Parse(Console.ReadLine());
            for (int i = 1; i <= num_trabajadores; i++)
            {
                Console.WriteLine("Ingresa el sueldo del trabajador: ");
                sueldo_neto = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el tipo de afp del trabajador: ");
                tipoafp = Console.ReadLine();
                sueldo_bruto= Pago_Trabajador(sueldo_neto,tipoafp);
                total_pagos = total_pagos + sueldo_bruto; 
            }
            Console.WriteLine("El total de pagos fue de S/ " + total_pagos);
        }
        public static double Pago_Trabajador(double sueldo_neto, string tipo_afp)
        {
            double dscto_afp=0,
                   sueldo_bruto= 0;
            switch (tipo_afp)
            {
                case "integra":
                    dscto_afp = sueldo_neto * 0.13;
                    break;
                case "profuturo":
                    dscto_afp = sueldo_neto * 0.14;
                    break;
                case "prima":
                    dscto_afp = sueldo_neto * 0.12;
                    break;
                default:
                    break;
            }
            sueldo_bruto = sueldo_neto - dscto_afp;
            return sueldo_bruto;
        }
    }
}
