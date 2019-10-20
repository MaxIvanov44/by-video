using System;

namespace App_17
{
    struct User
    {
        public string name;
        public int age;

        public User(string n, int a)
        {
            name = n;
            age = a;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"name = {name}   age = {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[2];
            users[0] = new User("Bob", 20);
            users[1] = new User("Sam", 25);

            foreach (User user in users) user.DisplayInfo();

            User Max = new User("Maxim", 18);
            Max.age = 99;
            Max.DisplayInfo();

            Console.ReadKey();
        }
    }
}
