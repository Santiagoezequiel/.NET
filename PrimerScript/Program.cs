using System;

namespace PrimerScript
{
    class Program
    {

        static void Main(string[] args)
        {
            bool reiniciar = true;

            while (reiniciar)
            {
                Console.WriteLine("Ingrese la operacion que desea realizar");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Resto");

                // Preguntamos las opciones
                string input = Console.ReadLine();
                int opcion;

                if (!int.TryParse(input, out opcion) || opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Opción inválida. Por favor, ingrese un número del 1 al 5.");
                    continue; // Reiniciar el bucle
                }

                Console.WriteLine("Ingrese primer numero"); // Pregunta primer numero
                int num1;

                if (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Número inválido. Por favor, ingrese un número entero válido.");
                    continue; // Reiniciar el bucle
                }

                Console.WriteLine("Ingrese segundo numero");
                int num2;

                if (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Número inválido. Por favor, ingrese un número entero válido.");
                    continue; // Reiniciar el bucle
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("El resultado es " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("El resultado es " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("El resultado es " + (num1 * num2));
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("No se puede dividir por cero.");
                        }
                        else
                        {
                            Console.WriteLine("El resultado es " + (num1 / num2));
                        }
                        break;
                    case 5:
                        Console.WriteLine("El resultado es " + (num1 % num2));
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                // Preguntar si desea reiniciar
                Console.WriteLine("¿Desea realizar otra operación? (S/N)");
                string reiniciarInput = Console.ReadLine().Trim().ToUpper();
                reiniciar = reiniciarInput == "S";
            }
        }
    }
}
