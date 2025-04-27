using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Combustible
    {
        static void Main(string[] args)
        {
            int cantidad = 0,
                tipo_comb,
                tipo_pago,
                promocional;
            double monto_neto,
                   total_pago,
                   monto_recargo,
                   monto_promocional = 0,
                   monto_billete,
                   monto_devolver;
            while (true)
            {
                Console.WriteLine("Ingresa la cantidad de galones:");
                cantidad = int.Parse(Console.ReadLine());
                if (cantidad > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ingresa un valor válido.Intenta nuevamente.");
                    Console.WriteLine("---------------");
                }
            }
            while (true)
            {
                Console.WriteLine("Ingresa el tipo de combustible: 1 si es Premium o 2 si es Regular:");
                tipo_comb = int.Parse(Console.ReadLine());
                if (tipo_comb == 1 || tipo_comb == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ingresa una opción válida. Intenta nuevamente.");
                    Console.WriteLine("---------------");
                }
            }
            monto_neto = CalculaMontoGalones(cantidad, tipo_comb);
            while (true)
            {
                Console.WriteLine("Ingresa el tipo de pago: 1 si es Tarjeta o 2 si es Efectivo:");
                tipo_pago = int.Parse(Console.ReadLine());
                if (tipo_pago == 1 || tipo_pago == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ingresa una opción válida. Intenta nuevamente.");
                    Console.WriteLine("---------------");
                }
            }
            while (true)
            {
                Console.WriteLine("El cliente tiene descuento promocional? 1 es si o 2 es no:");
                promocional = int.Parse(Console.ReadLine());
                if (promocional == 1 || promocional == 2)
                {
                    switch (promocional)
                    {
                        case 1:
                            monto_promocional = DescuentoPromocional(tipo_pago, monto_neto);
                        break;
                        case 2:
                            break;
                        default:
                            break;
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Ingresa una opción válida. Intenta nuevamente.");
                    Console.WriteLine("---------------");
                }
            }
            total_pago = monto_neto - monto_promocional;
            monto_recargo = RecargoAdicional(tipo_pago, total_pago);
            total_pago = total_pago + monto_recargo;
            Console.WriteLine("El total de pago es de: S/" + total_pago);

            if(tipo_pago == 2)
            {
                Console.WriteLine("Ingrese el monto del billete recibido por el cliente: ");
                monto_billete = double.Parse(Console.ReadLine());
                if(monto_billete > total_pago)
                {
                    monto_devolver = monto_billete - total_pago;
                    Console.WriteLine("El vuelto es de S/ " + monto_devolver);
                }
                else
                {
                    monto_devolver = 0;
                }
            }
            Console.WriteLine("El monto de los galones es de S/ " + monto_neto + " con un recargo de S/ " + monto_recargo + ", con un descuento de S/ " + monto_promocional + ". El total a pagar es de S/ " + total_pago);
        }

        public static int CalculaMontoGalones(int cantidad, int tipo_comb) {
            int precio_comb = 0;
            switch (tipo_comb)
            {
                case 1:
                    precio_comb = 25;
                    break;
                case 2:
                    precio_comb = 18;
                    break;
                default:
                    break;
            }
            return cantidad * precio_comb;
        }
        public static double RecargoAdicional(int tipo_pago, double monto_neto)
        {
            double recargo = 0;
            switch (tipo_pago)
            {
                case 1:
                    recargo = 0.05;
                    break;
                case 2:
                    recargo = 0;
                    break;
                default:
                    break;
            }
            return monto_neto * recargo;
        }
        public static double DescuentoPromocional(int tipo_pago, double monto_neto)
        {
            double promocional = 0;
            switch (tipo_pago)
            {
                case 1:
                    promocional = 0.1;
                    break;
                case 2:
                    promocional = 0.12;
                    break;
                default:
                    break;
            }
            return monto_neto * promocional;
        }
    }
}

