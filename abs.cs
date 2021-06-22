using System;

namespace bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( abs(-5));
        }
        public static int abs(int a)
            {

            int comparador = 15|a;

            if (comparador <= 0)
                return -a;
            else {
                return a;
            }

        }

    }
}
