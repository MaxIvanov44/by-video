using System;

namespace App_11_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition(new int[] { 1, 2, 3, 4 });
            Addition(2, 3, 4, 5);
            Addition();
            int z = 5;
            int d = 6;
            Console.WriteLine($"Initial value z = " + z);
            AdditionalVal(z, d);
            Console.WriteLine($"After AdditionalVal z = " + z);
            AdditionalRef(ref z, ref d);
            Console.WriteLine($"After AdditionalRef z = " + z);

            int perimetr;
            int area;
            GetData(10, 15, out area, out perimetr);
            Console.WriteLine(area);
            Console.WriteLine(perimetr);

            int id1 = Optional(s: 1, y: 2, z: 3, x: 4);
            int id2 = Optional(1, 2, 3);
            int id3 = Optional(1, 2);
            Console.ReadKey();
        }
        static void Addition(params int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            Console.WriteLine(result);
        }
        static void AdditionMas(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            Console.WriteLine(result);
        }
        static int Optional(int x, int y, int z = 5, int s = 7)
        {
            return x + y + z + s;
        }
        static void GetData(int width, int height, out int area, out int perimetr)
        {
            perimetr = (width + height) * 2;
            area = width * height;
        }
        static void AdditionalVal(int x, int y)
        {
            x = x + y;
            Console.WriteLine("x = " + x);
        }
        static void AdditionalRef(ref int x, ref int y)
        {
            x = x + y;
            Console.WriteLine("x = " + x);
        }
    }
}
