using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_Read_and_write_
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            do
            {
                line = Console.ReadLine();

                if (line != null)
                    Console.WriteLine("This is the text entered by you:     " + line);
            }
            while (line != null);
        }
    }
}
