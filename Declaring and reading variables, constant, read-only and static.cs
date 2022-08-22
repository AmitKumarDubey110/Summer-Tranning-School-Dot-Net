using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2_Demo_
{
    public class Myclass1
    {
        public const double PIX = 2.1415;
    }

    public class Myclass
    {
        public readonly double PI;

            public Myclass()
            {
              PI = 3.14159;
            }
    }

    public class car
    {
        public static int NumberofWheels = 4;
    }

    class Program : Myclass1
    {
        static void Main()
        {
            int i = car.NumberofWheels;
            Console.WriteLine(i);

            Myclass mc = new Myclass();
            Console.WriteLine(mc.PI);
            Console.WriteLine(PIX);
            Console.Read();

        }
    }
}
