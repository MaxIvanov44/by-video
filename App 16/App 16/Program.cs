using System;

namespace App_16
{
    class Program
    {
        enum Days 
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum Operation
        {
            Add, 
            Substract,
            Multiply,
            Divide
        }
        static void ApplyOperation (double x, double y, Operation op)
        {
            double result=0;
            switch (op) 
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Substract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }
            Console.WriteLine(result);

        }
        static void Main(string[] args)
        {
            ApplyOperation(10, 15, Operation.Add);
            ApplyOperation(10, 15, Operation.Multiply);
            Days day;
            day = Days.Friday;
            Console.Write(day);
            Console.WriteLine("    " + (int)day);
            Console.ReadKey();
        }
    }
}
