using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    internal class Cls_Empleado
    {
        // Atributos de la clase
        private static int cantidad = 10;
        private static byte indice = 0;
        private static int posicion = 0;

        private static string[] cedula = new string[cantidad];
        private static string[] nombre = new string[cantidad];
        private static string[] direccion = new string[cantidad];
        private static string[] telefono = new string[cantidad];
        private static float[] salario = new float[cantidad];

        // Metodos de la clase
        public static void inicializarArreglos()
        {
            cedula = Enumerable.Repeat(" ", cantidad).ToArray();
            nombre = Enumerable.Repeat(" ", cantidad).ToArray();
            direccion = Enumerable.Repeat(" ", cantidad).ToArray();
            telefono = Enumerable.Repeat(" ", cantidad).ToArray();
            salario = Enumerable.Repeat(0f, cantidad).ToArray();

            Console.Clear();
            Console.WriteLine("Sistema de Recursos Humanos: Modulo de Gestión de Empleados");
            Console.WriteLine(" ");
            Console.WriteLine("Arreglos inicializados con exito");
            Console.WriteLine(" ");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
        }

        public static void agregarEmpleado()
        {
            char respuesta;

            Console.Clear();
            Console.WriteLine("Sistema de Recursos Humanos: Modulo de Gestión de Empleados");
            Console.WriteLine(" ");
            Console.WriteLine("***AGREGAR EMPLEADO***");
            Console.WriteLine(" ");

            do
            {
                Console.Write("Ingrese la cedula del empleado: ");
                cedula[indice] = Console.ReadLine();
                Console.Write("Ingrese el nombre del empleado: ");
                nombre[indice] = Console.ReadLine();
                Console.Write("Ingrese la direccion del empleado: ");
                direccion[indice] = Console.ReadLine();
                Console.Write("Ingrese el telefono del empleado: ");
                telefono[indice] = Console.ReadLine();
                Console.Write("Ingrese el salario del empleado: ");
                float.TryParse(Console.ReadLine(), out salario[indice]);

                indice++;

                Console.WriteLine(" ");
                Console.WriteLine("Empleado agregado con exito");
                Console.WriteLine(" ");
                Console.WriteLine("Desea ingresar otro vehiculo? (s/n)");
                respuesta = Convert.ToChar(Console.ReadLine().ToLower());
                Console.ReadLine();

            } while (respuesta == 's');
        }   

        public static void consultarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("Sistema de Recursos Humanos: Modulo de Gestión de Empleados");
            Console.WriteLine(" ");
            Console.WriteLine("***CONSULTAR EMPLEADO***");
            Console.WriteLine(" ");

            Console.Write("Ingrese la cedula del empleado: ");
            string cedula = Console.ReadLine();

            posicion = Array.IndexOf(Cls_Empleado.cedula, cedula);

            if (posicion == -1)
            {
                Console.WriteLine(" ");
                Console.WriteLine("No se encontro el empleado");
                Console.WriteLine(" ");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Cedula: {Cls_Empleado.cedula[posicion]}");
                Console.WriteLine($"Nombre: {Cls_Empleado.nombre[posicion]}");
                Console.WriteLine($"Direccion: {Cls_Empleado.direccion[posicion]}");
                Console.WriteLine($"Telefono: {Cls_Empleado.telefono[posicion]}");
                Console.WriteLine($"Salario: {Cls_Empleado.salario[posicion]}");
                Console.WriteLine(" ");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadLine();
            }
        }
    }
}
