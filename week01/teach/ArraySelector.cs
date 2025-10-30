
using System;
using System.Collections.Generic;

public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };

        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}");
        // Expected output: <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        // Create a list to store the results
        List<int> result = new List<int>();

        // Track where we are in each array
        int index1 = 0;
        int index2 = 0;

        // Loop through the selector array
        foreach (var s in select)
        {
            if (s == 1)
            {
                result.Add(list1[index1]);
                index1++;
            }
            else if (s == 2)
            {
                result.Add(list2[index2]);
                index2++;
            }
        }

        // Return the result as an array
        return result.ToArray();
    }
}
