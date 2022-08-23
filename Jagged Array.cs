using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_jagged_array_
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[5];

            string[,] names = new string[5,4];

            byte[][] scores = new byte[5][];

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = new byte[i + 3];
            }

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
            }
            Console.Read();
        }
    }
}
