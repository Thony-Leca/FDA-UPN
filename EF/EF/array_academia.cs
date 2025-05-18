using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class array_academia
    {
        static void Main(string[] args)
        {
            int n_alumnos = 0;
            Console.WriteLine("Cuantos estudiantes ingresarás?");
            n_alumnos = int.Parse(Console.ReadLine());
            string[] codigo = new string[n_alumnos];
            string[] apellido_pat = new string[n_alumnos];
            string[] apellido_mat = new string[n_alumnos];
            string[] nombre = new string[n_alumnos];
            double[] nota_f = new double[n_alumnos];

            cargaAlumnos(ref codigo, ref apellido_pat, ref apellido_mat, ref nombre, ref nota_f);

            int option;
            do
            {
                Console.WriteLine("---- MENU ----");
                Console.WriteLine("1 - Listar Alumnos");
                Console.WriteLine("2 - buscar alumnos por nombre");
                Console.WriteLine("3 - buscar alumnos por código");
                Console.WriteLine("4 - Salir");
                Console.WriteLine("Seleccione una operación");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {

                    case 1:
                        listarAlumnos(codigo, apellido_pat, apellido_mat, nombre, nota_f);
                        break;
                    case 2:
                        buscarAlumnosNombre(codigo, apellido_pat, apellido_mat, nombre, nota_f);
                        break;
                    case 3:
                        buscarAlumnosCodigo(codigo, apellido_pat, apellido_mat, nombre, nota_f);
                        break;
                    case 4:
                        //SALIR
                        Console.WriteLine("Salir");
                        break;
                    default:
                        Console.WriteLine("Digite una opción válida");
                        break;
                }
            } while (option != 4);

        }
        static void cargaAlumnos(ref string[] codigo, ref string[] apellido_pat, ref string[] apellido_mat, ref string[] nombre, ref double[] nota_f)
        {
            for (int i = 0; i < codigo.Length; i++)
            {
                Console.WriteLine("Ingrese el código del estudiante " + (i + 1));
                codigo[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido paterno del estudiante " + (i + 1));
                apellido_pat[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido materno del producto " + (i + 1));
                apellido_mat[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del estudiante " + (i + 1));
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la nota final del estudiante " + (i + 1));
                nota_f[i] = double.Parse(Console.ReadLine());
            }
        }
        static void listarAlumnos(string[] codigo, string[] apellido_pat, string[] apellido_mat, string[] nombre, double[] nota_f)
        {
            for (int i = 0; i < codigo.Length; i++)
            {
                Console.WriteLine(codigo[i] + " | " + apellido_pat[i] + " | " + apellido_mat[i] + " | " + nombre[i] + " | " + nota_f[i]);
            }
        }
        static void buscarAlumnosNombre(string[] codigo, string[] apellido_pat, string[] apellido_mat, string[] nombre, double[] nota_f)
        {

            Console.WriteLine("Ingrese el nombre del estudiante a buscar:");
            string busqueda = Console.ReadLine();
            bool encontrado = false;
            for (int i = 0; i < nombre.Length; i++)
            {

                if (nombre[i].ToLower() == busqueda.ToLower())
                {
                    encontrado = true;
                    Console.WriteLine(codigo[i] + " | " + apellido_pat[i] + " | " + apellido_mat[i] + " | " + nombre[i] + " | " + nota_f[i]);
                    break;
                }
                if (!encontrado)
                {
                    Console.WriteLine("No se encontró un estudiante con ese nombre");
                }
            }
        }
        static void buscarAlumnosCodigo(string[] codigo, string[] apellido_pat, string[] apellido_mat, string[] nombre, double[] nota_f)
        {

            Console.WriteLine("Ingrese el código del estudiante a buscar:");
            string busqueda = Console.ReadLine();
            int indicebusqueda = Array.IndexOf(codigo, busqueda);
            string resultado;
            if (indicebusqueda == -1)
            {
                Console.WriteLine("No se encontro un estudiante con ese código");
            }
            else
            {
                if (nota_f[indicebusqueda] >= 13)
                {
                    resultado = "aprobado";
                }
                else
                {
                    resultado = "desaprobado";
                }
                    Console.WriteLine("El alumno con los datos " + apellido_pat[indicebusqueda] + " | " + apellido_mat[indicebusqueda] + " | " + nombre[indicebusqueda] + " está " + resultado);
            }
        }
    }
}
