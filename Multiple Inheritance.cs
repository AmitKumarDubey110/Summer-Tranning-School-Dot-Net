using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_Multi_Inheritance_
{

    interface Interface1
    {
        void Show();
    }

    interface Interface2
    {
        void Display();
    }


    class Program : Interface1, Interface2 
    {

        public void Show()
        {
            System.Console.WriteLine("It is: Show method of Inherface1");
        }

        public void Display()
        {
            System.Console.WriteLine("It is: Display method of Inheritance2");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.Show();
            obj.Display();

            Console.Read();
        }
    }
}
