﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_21
{
  
       public  class User
        {
            public string name;
            public int age;
            public User()
            {

            }
            public User(string name)
            {
                this.name = name;
            }
            public User(string n, int a) : this()
            {
                age = a;
            }

            public void Info()
            {
                Console.WriteLine(name + "  " + age);
            }
        }
    
}
