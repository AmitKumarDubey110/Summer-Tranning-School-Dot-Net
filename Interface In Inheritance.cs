using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_Inherit_Interface_
{

    interface InterfaceEx
    {
        void xyz();
    }


    class Program : InterfaceEx
    {

        public void xyz()
        {
            System.Console.WriteLine("In sample: xyz");
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.xyz();
            Console.Read();
        }
    }
}
