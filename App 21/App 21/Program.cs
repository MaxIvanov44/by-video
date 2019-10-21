using System;

namespace App_21
{
    class Program
    {
        static void Main(string[] args)
        {

            User max = new User { age = 99, name  ="MAX" };
            max.Info();

            User bob = new User("Bob") { age = 99};
            bob.Info();

            Console.ReadKey();
        }
      
    }
}
