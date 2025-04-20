using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabS4
{
    class compra_producto
    {
        static void Main(string[] args)
        {
            int cantidad_producto=0;
            double monto_total =0,
                   monto_t_producto, 
                   monto_producto, 
                   igv;
            string continua = "";
            igv = 0.18;

            do
            {
                Console.WriteLine("Ingrese el precio del producto");
                monto_producto= double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad del producto");
                cantidad_producto = int.Parse(Console.ReadLine());
                monto_t_producto = (monto_producto + (igv * monto_producto)) * cantidad_producto;
                Console.WriteLine("Registras más productos? Presiona S");
                continua = Console.ReadLine().ToLower();
                monto_total = monto_total + monto_t_producto;
            } while(continua == "s");

            Console.WriteLine("El monto total de productos es" + monto_total);
        }
    }
}
