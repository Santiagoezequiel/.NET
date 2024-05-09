using System;

namespace Intentos
{
    class Program
    {
        static void Main(string[] args)
        {

            int reinicio = 1;


            do
            {
                
            int miNumero = 101;
            Random rnd = new Random();
            int aleatorio = rnd.Next(1, 101);
            int intentos = 0;

                Console.WriteLine("Adivina el numero del 1 al 100  !");

                    while (aleatorio != miNumero)
                    {
                       try
                       { 
                            intentos++;
                            miNumero=int.Parse(Console.ReadLine());
                            if (miNumero > aleatorio) Console.WriteLine("El numero es mas chico!");
                            if (miNumero < aleatorio) Console.WriteLine("El numero es mas grande!");

                       }
                       catch (Exception e) when (e.GetType()!=typeof(TimeoutException))
                       { 
                            Console.WriteLine("SOLO PUEDES INGRESAR NUMEROS ENTEROS!");
                            intentos--;

                       }
                    }

                Console.WriteLine($"Felicidades! El numero es {aleatorio}, te tomó {intentos} intentos!");
                Console.WriteLine("");


                Console.WriteLine("Deseas volver a jugar? (S/N)");
                string respuesta = Console.ReadLine().Trim().ToUpper();

                        if (respuesta == "S" || respuesta == "SI")
                        {
                            reinicio = 0;   
                        }
                        else
                        {
                            Console.WriteLine("Cerrando juego...");
                            reinicio = 1;
                        }
            }
            while (reinicio == 0) ;


        }
    }
}