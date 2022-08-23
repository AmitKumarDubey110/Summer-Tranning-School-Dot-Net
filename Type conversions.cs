using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_Type_Conversion_
{
    class Program
    {
        static void Main(string[] args)
        {
          //example of implicit
            int x = 10000;

            int y = 20000;

            long total;

            total = x + y;

            Console.WriteLine("Value of implicit is:"+total);

            //example of Explicit
            int xx = 65;

            char value;

            value = (char)xx;

            Console.WriteLine("Value of Explicit is:" + value);

            Console.ReadLine();
        }
    }
}
