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
                int opcion = int.Parse(input);

                if (!int.TryParse(input, out opcion) || opcion < 1 || opcion > 5 )
                {
                    Console.WriteLine("Ingrese una opcion valida");
                    continue;
                }

                // Ingresamos primer valor

                Console.WriteLine("Ingrese el primer numero");
                int num1;

                if (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Ingrese un numero valido");
                    continue;
                }

                // Ingresamos segundo valor

                Console.WriteLine("Ingrese el segundo numero");
                int num2;

                if (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Ingrese un numero valido");
                    continue;
                }

                // Operaciones

                switch( opcion )
                {
                    case 1:
                        {
                            Console.WriteLine("El resultado es " + (num1 + num2));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("El resultado es " + (num1 - num2));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("El resultado es " + (num1 * num2));
                            break;
                        }
                    case 4:
                        {
                            if (num2 == 0)
                            { 
                                Console.WriteLine("No se puede dividir entre 0");
                                continue;
                            }
                            else
                            {
                            Console.WriteLine("El resultado es " + (num1 / num2));
                            break;
                            }
                        }
                    case 5:
                        {
                            Console.WriteLine("El resultado es " + (num1 % num2));
                            break;
                        }
                }

                // Preguntamos si desea realizar otra operacion
                Console.WriteLine("¿Desea realizar otra operacion?(S/N)");
                string reiniciarInput = Console.ReadLine().Trim().ToUpper();

                reiniciar = reiniciarInput == "S";


            }










        }
    }
}