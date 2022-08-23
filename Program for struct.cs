using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_Struct_
{
     public struct Person
        {
            public string Name;
            public int Age;

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
    class Program
    {
        static void Main()
        {
            Person p1 = new Person("Anand",9);
            Console.WriteLine("p1 Name = {0} Age = {1}", p1.Name,p1.Age);

            Person p2 = p1;
            p2.Name = "Amit";
            p2.Age = 7;
            Console.WriteLine("p2 Name = {0} Age = {1}", p2.Name, p2.Age);

            Console.WriteLine("p1 Name = {0} Age = {1}", p1.Name, p1.Age);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
