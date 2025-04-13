using System;

namespace FDA_PCS2{
    class Precio_venta{
        static void Main(string[] args){
            double m_ganancia;
            double p_costo;
            double p_venta;
            m_ganancia = 1.30;
            Console.WriteLine("Calcula tu precio de venta");
            Console.WriteLine("Ingresa el costo del producto:");
            p_costo = Double.Parse(Console.ReadLine());
            p_venta = p_costo * m_ganancia;
            Console.WriteLine("El precio de venta de tu producto es: S/" + p_venta);
        }
    }
}
