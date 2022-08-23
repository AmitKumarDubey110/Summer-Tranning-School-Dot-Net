using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_class_and_object_
{
    class Outputclass
    {
        string myString;

        public Outputclass(string inputString)
        {
            myString = inputString;
        }

        public void printString()
        {
            Console.WriteLine("{0}",myString);
        }

        ~Outputclass()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Outputclass outc1 = new Outputclass("This is printed by output class.");
            outc1.printString();
            Console.Read();
        }
    }
}
