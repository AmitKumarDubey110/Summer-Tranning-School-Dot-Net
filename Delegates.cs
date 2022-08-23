using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_Delegates_
{

    delegate void Procedure();

    class DelegateDemo
    {
        public static void Method1()
        {
            Console.WriteLine("Method1");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2");
        }

        public static void Method3()
        {
            Console.WriteLine("Method3");
        }
    
        static void Main()
        {
            Procedure Delobj = null;

            Delobj += new Procedure(DelegateDemo.Method1);

            Delobj += new Procedure(DelegateDemo.Method2);

            Delobj -= new Procedure(DelegateDemo.Method2);

            DelegateDemo demo = new DelegateDemo();
            Delobj += new Procedure(DelegateDemo.Method3);

            Delobj();

            Console.Read();
        }
    }
}
