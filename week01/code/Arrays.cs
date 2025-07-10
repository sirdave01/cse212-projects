using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // first of all, we need to create an array of doubles with the specified length.

        double[] multiples = new double[length];

        // then we need to fill the array with multiples of the given number.

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // finally, we return the filled array.

        return multiples;

        // Note: The above code is a simple implementation. You can optimize it further if needed.
        // However, for the sake of this exercise, this implementation is sufficient.
        // If you want to handle edge cases like negative numbers or zero, you can add additional checks.
        // For now, we assume that the input will always be valid as per the problem statement.
        // TODO Problem 1 End
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // first of all, we need to check if the amount is greater than the size of the list.

        if (data == null || data.Count == 0 || amount <= 0 || amount > data.Count)
        {
            throw new ArgumentException("Invalid amount or empty list.");
        }
        // then we need to calculate the effective rotation amount, which is the amount modulo the size of the list.

        int effectiveAmount = amount % data.Count;

        // if the effective amount is zero, we don't need to do anything.

        if (effectiveAmount == 0)
        {
            return;
        }

        // next, we need to split the list into two parts: the last 'effectiveAmount' elements and the rest.

        List<int> lastPart = data.GetRange(data.Count - effectiveAmount, effectiveAmount);
        List<int> firstPart = data.GetRange(0, data.Count - effectiveAmount);

        // then we need to clear the original list and add the last part followed by the first part.

        data.Clear();
        data.AddRange(lastPart);
        data.AddRange(firstPart);

        // finally, we have rotated the list to the right by the specified amount.

        // Note: The above code assumes that the input list is not null and has at least one element.
        // If you want to handle edge cases like null or empty lists, you can add additional checks.
        // For now, we assume that the input will always be valid as per the problem statement.
        // TODO Problem 2 End
    }
}
