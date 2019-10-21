using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_23
{
    class Program
    {
        static void Main(string[] args)
        {
            //User user1 = new User { name = "tom", age = 30 };
            //ChangeUser(ref user1);
            //Console.WriteLine(user1.name +  "   " + user1.age);

            Person person1 = new Person  { name = "tom", age = 30 };
            ChangePerson(ref person1);
            Console.WriteLine(person1.name + "   " + person1.age);
            Console.ReadKey();
        }
        static void ChangePerson(ref  Person person)
        {
            person.name = "bob";
            person.age = 33;
            person = new Person { name = "Bill", age = 50 };
        }
        static void ChangeUser( ref User user)
        {
            user.name = "bob";
            user.age = 33;
        }
    }
    struct User
    {
        public int age;
        public string name;

    }
    class Person
    {
        public int age;
        public string name;

    }
}
