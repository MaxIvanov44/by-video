using Accounts;
using System;

namespace App_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "TOM";
            person.Display();

            User user = new User();
            Console.ReadKey();
        }
    }
    class Person
    {
        public int age;
        internal string name;
        public void Display()
        {
            Console.WriteLine(name);
        }
    }

    class Manager : User
    {

        public void DisplayManager()
        {
            Console.WriteLine(name);
        }
    }
}
