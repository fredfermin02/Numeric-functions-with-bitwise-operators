using System;

namespace bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( isOdd(5));
        }
        public static bool isOdd(int a)
            {

            int comparador = 1;
            int compara = a & comparador;
            if (compara == 1)
                return true;
            else {
                return false;
            }

        }

    }
}
