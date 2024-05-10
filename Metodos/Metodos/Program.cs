using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumaNumer(10, 40));

        }

        static double sumaNumer(int a, int b) => a + b;
        static string sumaNumer(string a, int b) => a;

        private static int imprimir(int abc, int cde)
        {
            return abc + cde;
        }


    }
}