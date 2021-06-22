using System;

namespace bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( isNegative(-5));
        }
        public static bool isNegative(int a)
            {

            int comparador = 1+(a>>31)-(-a>>31);

            if (comparador == 0)
                return true;
            else {
                return false;
            }

        }

    }
}
