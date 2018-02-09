using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int factorial(int n)
    {
        // Complete this function
        int total = 1;

        if (n > 1)
        {
            total *= n * (n - 1);
            total = n * factorial(n - 1);
        }

        return total;

    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int result = factorial(n);
        Console.WriteLine(result);
    }
}