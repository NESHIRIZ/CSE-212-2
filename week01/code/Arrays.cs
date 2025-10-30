using System;
using System.Collections.Generic;
using System.Diagnostics;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // ---------------- PLAN ----------------
        // Step 1: Create a new array called 'multiples' with size 'length'.
        // Step 2: Use a loop to fill the array.
        // Step 3: Each element should equal number * (i + 1).
        // Step 4: Return the completed array.
        // ---------------------------------------

        // Step 1
        double[] multiples = new double[length];

        // Step 2
        for (int i = 0; i < length; i++)
        {
            // Step 3
            multiples[i] = number * (i + 1);
        }

        // Step 4
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} 
    /// and amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // ---------------- PLAN ----------------
        // Step 1: Find the number of elements in the list.
        // Step 2: Handle the case when no rotation is needed (amount = 0 or data empty).
        // Step 3: Get the last 'amount' elements (the rightmost part).
        // Step 4: Get the remaining elements at the start of the list.
        // Step 5: Clear the original list.
        // Step 6: Add the rightmost elements first, then the leftmost elements.
        // ---------------------------------------

        // Step 1
        int count = data.Count;

        // Step 2
        if (count == 0 || amount <= 0) return;

        amount = amount % count; // in case amount > count

        // Step 3
        List<int> rightPart = data.GetRange(count - amount, amount);

        // Step 4
        List<int> leftPart = data.GetRange(0, count - amount);

        // Step 5 and 6
        data.Clear();
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}

