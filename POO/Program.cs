using System;

namespace POO
{
    class Program
    {
        public static void Main(string[] args)
        {
            Saludo obj = new Saludo();
            obj.Saludar("Santiago");

            Area area = new Area();     // CREAMOS EL OBJ "area"

            //area.PI = 10;         No se permite cambiar si el valor es privado
            area.CambiarPI(0);     // Ahora podemos cambiarlo por que creamos un metodo para hacerlo
                                    // La ventaja es que podemos ponerle condicionales al metodo.

            Console.WriteLine(area.Calcular(10));

        
        }

    }


    class Saludo
    {
       // private string name;

        public void Saludar(string name)
        {
            Console.WriteLine($"Hola {name} un gusto en conocerte.");

        }
    }

    class Area
    {
        private double PI = Math.PI;

        public double Calcular(double x)
        {
            return PI * Math.Pow(x, 2);
        }

        public void CambiarPI(double valor)
        {
            if (valor > 0)
            {
                PI = valor;

            }else
            {
                Console.WriteLine("Que queres inventar papu?");
            }
        }

    }



}