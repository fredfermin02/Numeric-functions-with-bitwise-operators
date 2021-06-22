using System;

namespace bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( isPositive(5));
        }
        public static bool isPositive(int a)
            {

            int comparador = 1+(a>>31)-(-a>>31);

            if (comparador == 2)
                return true;
            else {
                return false;
            }

        }

    }
}
