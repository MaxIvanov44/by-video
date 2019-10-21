using System;

namespace Accounts
{
    public class User
    {
        protected internal int age;
        protected internal string name;
        public void Display()
        {
            Console.WriteLine(name);
        }
        private class UserAccount
        {
            private string password;
        }
    }
    class Employee : User
    {
        public void DisplayEmployee()
        {
            Console.WriteLine(name);
        }
    }
}
