using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            ref int nRef = ref Find(numbers, 4); //numbers[3]
            Console.WriteLine(numbers[3]);
            nRef = 45;
            Console.WriteLine(numbers[3]);

            Console.ReadKey();
        }
        static ref int Find(int[] numbers, int number)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i];
                }
            }
            throw new Exception("число не найдено");
        }
    }
}
