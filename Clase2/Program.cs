using System;

namespace Clase2
{
    class MyClass
    {
        static void Main(string[] args)
        {

            checked
            {                                       // Esto chequea que no pase por alto los errores de desbordamiento.

 //           int numero = int.MaxValue;

   //         int resultado=numero+numero;

     //       Console.WriteLine(resultado);
            }


            try 
            {
                System.IO.StreamReader archivo = null;
                string linea;
                int contador = 0;
                string path = @"C:\Users\Santi\Desktop\hola.txt";
                archivo = new System.IO.StreamReader(path);

                while ((linea=archivo.ReadLine())!= null)
                {
                    Console.WriteLine(linea);
                    contador++;
                


                }


            } catch (Exception ex)
            {



            }



        }
    }
}