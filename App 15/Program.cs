using System;

namespace App_15
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 0) return 1;
            else return n * Factorial(n - 1);
        }
        static int Fibonachi(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            else return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        static void Main(string[] args)
        {
            int y = Fibonachi(8);
            Console.WriteLine(y);
            Console.WriteLine(Fibonachi(4));
            Console.WriteLine(Fibonachi(6));


            int x = Factorial(5);
            Console.WriteLine(x);
            Console.WriteLine(Factorial(4));
            Console.WriteLine(Factorial(6));

            Console.ReadKey();
        }
       
    }
}
