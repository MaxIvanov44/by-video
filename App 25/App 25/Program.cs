using System;

namespace App_25
{
    class Program
    {
        static void Main(string[] args)
        {

            int d = 8;
            d = 9;
            var t = 9;
            double r = MathLib.Pi;

            MathLib m = new MathLib();
            int u =  m.p;

            Console.ReadKey();
        }
    }
    class MathLib
    {
       public  const double Pi = 3.14;
        public readonly int p = 89;
        public MathLib()
        {
            p = 78;


        }
        public void Some()
        {
            p = 90;
        }
    }
}
