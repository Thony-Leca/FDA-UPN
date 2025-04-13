using System;

namespace FDA_PCS2{
    class sueldo_trabajador{
        static void Main(string[] args)
        {
            double d_afp;
            double s_bruto;
            double s_neto;
            Console.WriteLine("Calcula tu sueldo");
            Console.WriteLine("Ingresa tu sueldo bruto(sin descuentos):");
            s_bruto = Double.Parse(Console.ReadLine());
            if (s_bruto > 3000)
            {
                d_afp = 0.13;
            }
            else
            {
                d_afp = 0.11;
            }
            s_neto = s_bruto - (s_bruto * d_afp);
            Console.WriteLine("Tu sueldo a recibir es: S/ " + s_neto + " en donde estas aportado a tu AFP el monto de S/ " + (s_bruto - s_neto));
        }
    }
}
