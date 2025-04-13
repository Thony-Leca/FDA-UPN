using System;

namespace S3
{
    class Contar_Goles
    {
        static void Main(string[] args)
        {
            int goles = 0;
            int edad = 0;
            string nombre;
            int pj = 0;
            Console.WriteLine("Ingresa la cantidad de goles:");
            goles = int.Parse(Console.ReadLine());
            if (goles >= 15 && goles <=20){
                Console.WriteLine("Goleador");
                Console.WriteLine("Ingresa su edad:");
                edad = int.Parse(Console.ReadLine());
                if (edad > 30){
                    Console.WriteLine("Próximo al retiro");
                }else{
                    Console.WriteLine("Ingresa su nombre:");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Sigue asi goleador " + nombre);
                }
            }
            else if (goles >= 10 && goles <=14){
                Console.WriteLine("Buena racha");
                Console.WriteLine("Ingresa sus partidos jugados:");
                pj = int.Parse(Console.ReadLine());
                if (pj <5 || goles >12) {
                    Console.WriteLine("Continua con esa racha");
                }
            }
            else if (goles >= 5 && goles <= 9){
                Console.WriteLine("Goleador Promedio");
            }
        }
    }
}
