using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class array_bodega
    {
        static void Main(string[] args)
        {
            int n_productos = 0;
            Console.WriteLine("Cuantos productos ingresarás?");
            n_productos = int.Parse(Console.ReadLine());
            string[] name_p = new string[n_productos];
            double[] price_p = new double[n_productos];

            cargaProductos(ref name_p, ref price_p);
            listarProductosOrden(name_p, price_p);
        }
        static void cargaProductos(ref string[] name_p,ref double[] price_p)
        {
            for (int i = 0; i < name_p.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del producto " + (i + 1));
                name_p[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del producto " + (i + 1));
                price_p[i] = double.Parse(Console.ReadLine());
            }
        }
        static void listarProductosOrden(string[] name_p, double[] price_p)
        {
            for (int i = 0; i < name_p.Length; i++)
            {
                for (int j = i + 1; j < name_p.Length; j++)
                {
                    double aux_price;
                    string aux_name;
                    if (price_p[i] > price_p[j])
                    {
                        aux_price = price_p[i];
                        aux_name = name_p[i];
                        price_p[i] = price_p[j];
                        name_p[i] = name_p[j];
                        price_p[j] = aux_price;
                        name_p[j] = aux_name;
                    }
                }

                Console.WriteLine(name_p[i] + " | " + price_p[i]);
            }
        }
    }
}
