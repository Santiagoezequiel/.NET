using System;

namespace Constructores
{
    class Program
    {
        public static void Main(string[] args) 
        { 
            Coche coche1 = new Coche();

            Coche coche2 = new Coche();

            Console.WriteLine(coche2.info());
        }
        
    }

    class Coche
    {

        public Coche()
        {
            ruedas = 4;
            largo = 3.5;
            aire = false;
            tapizado = "Cuero";

        }




        private int ruedas;
        private double largo;
        private bool aire;
        private string tapizado;


        public string info()
        {

            return $"Informacion del coche:\n" +
                $"Ruedas: {ruedas}\n" +
                $"Largo: {largo}\n" +
                $"Tapizado: {tapizado}\n" +
                $"Aire: {(aire ? "Si, tiene" : "No, no tiene") }";



        }

    }
}