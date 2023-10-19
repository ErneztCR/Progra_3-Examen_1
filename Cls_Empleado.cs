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

            do
            {
                Console.Clear();
                Console.WriteLine("Sistema de Recursos Humanos: Modulo de Gestión de Empleados");
                Console.WriteLine(" ");
                Console.WriteLine("***AGREGAR EMPLEADO***");
                Console.WriteLine(" ");
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
                posicion++;

                Console.WriteLine(" ");
                Console.WriteLine("Empleado agregado con exito");
                Console.WriteLine(" ");
                Console.WriteLine("Desea ingresar otro empleado? (s/n)");
                respuesta = Convert.ToChar(Console.ReadLine().ToLower());

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
                Console.Clear();
                Console.WriteLine(" ");
                Console.WriteLine($"No se encontro el empleado con la Cedula: " + cedula);
                Console.WriteLine(" ");
                Console.WriteLine("Presione una tecla para volver...");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sistema de Recursos Humanos: Modulo de Gestión de Empleados");
                Console.WriteLine(" ");
                Console.WriteLine("***CONSULTAR EMPLEADO***");
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

        public static void modificarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("Sistema de Recursos Humanos: Modulo de Gestión de Empleados");
            Console.WriteLine(" ");
            Console.WriteLine("***MODIFICAR EMPLEADO***");
            Console.WriteLine(" ");

            Console.Write("Ingrese la cédula del empleado que desea modificar: ");
            string cedulaBuscada = Console.ReadLine();

            // Buscar la posición del empleado en el arreglo
            posicion = Array.IndexOf(cedula, cedulaBuscada);

            if (posicion == -1)
            {
                Console.Clear();
                Console.WriteLine(" ");
                Console.WriteLine($"No se encontro el empleado con la Cedula: " + cedula);
                Console.WriteLine(" ");
                Console.WriteLine("Presione una tecla para volver...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Cédula: {cedula[posicion]}");
                Console.WriteLine($"Nombre actual: {nombre[posicion]}");
                Console.WriteLine($"Dirección actual: {direccion[posicion]}");
                Console.WriteLine($"Teléfono actual: {telefono[posicion]}");
                Console.WriteLine($"Salario actual: {salario[posicion]}");
                Console.WriteLine(" ");

                // Solicitar nuevos datos al usuario
                Console.Write("Ingrese el nuevo nombre del empleado: ");
                nombre[posicion] = Console.ReadLine();
                Console.Write("Ingrese la nueva dirección del empleado: ");
                direccion[posicion] = Console.ReadLine();
                Console.Write("Ingrese el nuevo teléfono del empleado: ");
                telefono[posicion] = Console.ReadLine();
                Console.Write("Ingrese el nuevo salario del empleado: ");
                float.TryParse(Console.ReadLine(), out salario[posicion]);

                Console.WriteLine(" ");
                Console.WriteLine("Empleado modificado con éxito");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
        }

        public static void borrarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("Sistema de Recursos Humanos: Modulo de Gestión de Empleados");
            Console.WriteLine(" ");
            Console.WriteLine("***BORRAR EMPLEADO***");
            Console.WriteLine(" ");

            Console.Write("Ingrese la cédula del empleado que desea borrar: ");
            string cedulaBuscada = Console.ReadLine();

            // Buscar la posición del empleado en el arreglo
            posicion = Array.IndexOf(cedula, cedulaBuscada);

            if (posicion == -1)
            {
                Console.WriteLine(" ");
                Console.WriteLine("No se encontró el empleado");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Cédula: {cedula[posicion]}");
                Console.WriteLine($"Nombre: {nombre[posicion]}");
                Console.WriteLine($"Dirección: {direccion[posicion]}");
                Console.WriteLine($"Teléfono: {telefono[posicion]}");
                Console.WriteLine($"Salario: {salario[posicion]}");
                Console.WriteLine(" ");

                // Confirmar la eliminación del empleado
                Console.Write("¿Está seguro de que desea borrar este empleado? (s/n): ");
                char respuesta = Convert.ToChar(Console.ReadLine().ToLower());

                if (respuesta == 's')
                {
                    // Borrar el empleado (reiniciar los datos en esa posición)
                    cedula[posicion] = " ";
                    nombre[posicion] = " ";
                    direccion[posicion] = " ";
                    telefono[posicion] = " ";
                    salario[posicion] = 0f;
                    Console.WriteLine("Empleado borrado con éxito");
                }
                else
                {
                    Console.WriteLine("Borrado cancelado");
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
        }

        public static void reportes()
        {
            int opcion = 0;

            do 
            {
                Console.Clear();
                Console.WriteLine("Sistema de Recursos Humanos: Modulo de Gestión de Empleados");
                Console.WriteLine(" ");
                Console.WriteLine("***MENU REPORTES***");
                Console.WriteLine(" ");
                Console.WriteLine("1. Consultar Empleados");
                Console.WriteLine("2. Listar todos los empleados");
                Console.WriteLine("3. Calcular y mostrar el promedio de los salarios");
                Console.WriteLine("4. Calcular y mostrar el salario más alto y el más bajo de todos los empleados");
                Console.WriteLine("5. Volver al Menu Principal");
                Console.WriteLine(" ");
                Console.Write("Ingrese una opcion: ");

                int.TryParse(Console.ReadLine(), out opcion); // evalua si el valor ingresado es un numero

                switch (opcion)
                {
                    case 1:// Consultar Empleados
                        Cls_Empleado.consultarEmpleado();
                        break;
                    case 2:// Listar todos los empleados
                        Cls_Empleado.listarEmpleados();
                        break;
                    case 3:// Calcular y mostrar el promedio de los salarios
                        Cls_Empleado.promedioSalarios();
                        break;
                    case 4:// Calcular y mostrar el salario más alto y el más bajo de todos los empleados
                        Cls_Empleado.salarioMaximoMinimo();
                        break;
                    case 5:// Volver al menu principal
                        Console.Clear();
                        Cls_Menu.desplegarMenu();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Sistema de Recursos Humanos: Modulo de Gestión de Empleados");
                        Console.WriteLine(" ");
                        Console.WriteLine($"La opcion seleccionada no es valida");
                        Console.WriteLine(" ");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 5);

        }

        public static void listarEmpleados()
        {
            Console.Clear();
            Console.WriteLine("Sistema de Recursos Humanos: Modulo de Gestión de Empleados");
            Console.WriteLine(" ");
            Console.WriteLine("***LISTAR EMPLEADOS***");
            Console.WriteLine(" ");

            for (int i = 0; i < indice; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Cedula: {cedula[i]}");
                Console.WriteLine($"Nombre: {nombre[i]}");
                Console.WriteLine($"Direccion: {direccion[i]}");
                Console.WriteLine($"Telefono: {telefono[i]}");
                Console.WriteLine($"Salario: {salario[i]}");
                Console.WriteLine(" ");
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
        }

        public static void promedioSalarios()
        {
            Console.Clear();
            Console.WriteLine("Sistema de Recursos Humanos: Modulo de Gestión de Empleados");
            Console.WriteLine(" ");
            Console.WriteLine("***PROMEDIO DE SALARIOS***");
            Console.WriteLine(" ");

            float suma = 0f;

            for (int i = 0; i < indice; i++)
            {
                suma += salario[i];
            }

            float promedio = suma / indice;

            Console.WriteLine($"El promedio de los salarios es: {promedio}");
            Console.WriteLine(" ");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
        }

        public static void salarioMaximoMinimo()
        {
            Console.Clear();
            Console.WriteLine("Sistema de Recursos Humanos: Modulo de Gestión de Empleados");
            Console.WriteLine(" ");
            Console.WriteLine("***SALARIO MAXIMO Y MINIMO***");
            Console.WriteLine(" ");

            float maximo = salario[0];
            float minimo = salario[0];

            for (int i = 0; i < indice; i++)
            {
                if (salario[i] > maximo)
                {
                    maximo = salario[i];
                }

                if (salario[i] < minimo)
                {
                    minimo = salario[i];
                }
            }

            Console.WriteLine($"El salario máximo es: {maximo}");
            Console.WriteLine($"El salario mínimo es: {minimo}");
            Console.WriteLine(" ");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
        }
    }
}
