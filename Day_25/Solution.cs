using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static string PrintIsPrime(int n)
    {
        if (n == 2)
            return "Prime";
        else if (n % 2 == 0 || n == 1)
            return "Not prime";
        else
        {
            for (int divisor = 2; divisor < Math.Sqrt(n); divisor++)
            {
                if (n % divisor == 0)
                    return "Not prime";
            }
            return "Prime";
        }
    }

    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(PrintIsPrime(Convert.ToInt32(Console.ReadLine())));
        }

        Console.ReadKey();
    }
}
