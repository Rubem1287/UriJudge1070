using System;

namespace Uri1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = int.Parse(Console.ReadLine());

            if (x % 2 != 0)
            {
                Console.WriteLine();
                Console.WriteLine(x + 2);
                Console.WriteLine();
                Console.WriteLine(x + 4);
                Console.WriteLine();
                Console.WriteLine(x + 6);
                Console.WriteLine();
                Console.WriteLine(x + 8);
                Console.WriteLine();
                Console.WriteLine(x + 10);
                Console.WriteLine();
                Console.WriteLine(x + 12);

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(x + 1);
                Console.WriteLine();
                Console.WriteLine(x + 3);
                Console.WriteLine();
                Console.WriteLine(x + 5);
                Console.WriteLine();
                Console.WriteLine(x + 7);
                Console.WriteLine();
                Console.WriteLine(x + 9);
                Console.WriteLine();
                Console.WriteLine(x + 11);
            }
        }
    }
}
