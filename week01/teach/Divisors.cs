using System;
using System.Collections.Generic;

public static class Divisors
{
    public static void Run()
    {
        // Test with two numbers
        var divisors12 = FindDivisors(12);
        Console.WriteLine("<list>{" + string.Join(", ", divisors12) + "}");

        var divisors17 = FindDivisors(17);
        Console.WriteLine("<list>{" + string.Join(", ", divisors17) + "}");
    }

    public static List<int> FindDivisors(int number)
    {
        List<int> divisors = new List<int>();

        // Add all divisors except the number itself
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                divisors.Add(i);
            }
        }

        return divisors;
    }
}

