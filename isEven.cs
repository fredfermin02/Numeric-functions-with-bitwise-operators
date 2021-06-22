using System;

namespace bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( isEven(4));
        }
        public static bool isEven(int a)
            {

            int comparador = 1;
            int compara = a & comparador;
            if (compara == 0)
                return true;
            else {
                return false;
            }

        }

    }
}
