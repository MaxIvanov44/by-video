using System;

namespace App_18
{
    class Program
    {
        static void Main(string[] args)
        {
            static (string, int) GetValue((string,int) tuple, int x)
            {
                var result = (name: tuple.Item1, age: tuple.Item2 +x);
;
                return result;
            }
            var tuple = GetValue(("Max",18), 1);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);

            Console.ReadKey();
        }
    }
}
