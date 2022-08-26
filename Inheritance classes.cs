using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_Inheritance_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.Talk();
            d1.Sing();
            d1.Dance();
            Console.Read();
        }
    }

    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }

        public void Dance()
        {
            Console.WriteLine("Animal says Hello");
        }

        public void Talk()
        {
            Console.WriteLine("Animal talk");
        }

        public virtual void Sing()
        {
            Console.WriteLine("Animal song");
        }
    }

    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog constructor");
        }

        public new void Talk()
        {
            Console.WriteLine("Dog song");
        }
    }
}
