using System;

namespace POO
{
    class Program
    {
        public static void Main(string[] args)
        {
            Saludo obj = new Saludo();
           // obj.Saludar("Santiago");

            Area area = new Area();
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

    }



}