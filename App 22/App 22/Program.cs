﻿using System;

namespace App_22
{
    class Program
    {
        static void Main(string[] args)
        {
            State state1 = new State();
            State state2 = new State();

            state2.country = new Country();
            state2.country.x = 8;

            state1 = state2;

            state2.country.x = 5;

            Console.WriteLine(state1.country.x);
            Console.WriteLine(state2.country.x);


            Console.ReadKey();
        }
    }
    struct State
    {
        public int x;
        public int y;
        public Country country;
    }
    class Country
    {
        public int x;
        public int y;
    }
}
