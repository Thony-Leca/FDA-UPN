using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabS6
{
    class CarWash
    {
        static void Main(string[] args)
        {
            double serv_auto = 25,
                   serv_camioneta = 35,
                   serv_moto = 15,
                   precio_v = 0,
                   monto_total = 0,
                   serv_encerado = 0;
            string tipo_v, 
                   encerado = null;
            int cantidad_v = 0;
            Boolean is_valid_tipov = false,
                    is_valid_serv_encerado  = false;

            Console.WriteLine("Ingresa la cantidad de vehículos a lavar:");
            cantidad_v= int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantidad_v; i++)
            {
                do
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Ingresa el tipo de vehículo N° " + i + " a consultar:");
                    Console.WriteLine("A = auto, C = camioneta, M = moto");
                    tipo_v = Console.ReadLine().ToUpper();
                    if (tipo_v == "A" || tipo_v == "C" || tipo_v == "M")
                    {
                        is_valid_tipov = true;
                        do
                        {
                            Console.WriteLine("Requiere el servicio de encerado? Escribe S = si o N = no");
                            encerado = Console.ReadLine();
                            if (encerado.ToUpper() == "S" || encerado.ToUpper() == "N")
                            {
                                is_valid_serv_encerado = true;
                                if (encerado.ToUpper() == "S")
                                {
                                    serv_encerado = 15;
                                }
                                else
                                {
                                    serv_encerado = 0;
                                }
                            }
                            else
                            {
                                is_valid_serv_encerado = false;
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("Ingresa una respuesta válida");
                            }
                        } while (is_valid_serv_encerado == false);
                        
                    }
                    else
                    {
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Ingresa un tipo de vehículo válido");
                    }
                } while (is_valid_tipov == false);
                switch (tipo_v)
                {
                    case "A":
                        precio_v = serv_auto + serv_encerado;
                        break;
                    case "C":
                        precio_v = serv_camioneta + serv_encerado;
                        break;
                    case "M":
                        precio_v = serv_moto + serv_encerado;
                        break;
                    default:
                        break;
                }
                monto_total = monto_total + precio_v;
            }
            Console.WriteLine("El monto total de los lavados es: S/ " + monto_total);
        }
    }
}
