using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_21
{
    class Solution
    {
        static void Main(string[] args)
        {
            int[] vInt = new int[] { 1, 2, 3 };
            string[] vString = new string[] { "Hello", "World" };

            printArray<int>(vInt);
            printArray<string>(vString);
        }

        private static void printArray<T>(T[] items)
        {
            foreach (var item in items)
                Console.WriteLine(item);
        }
    }
}
