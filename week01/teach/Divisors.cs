public static class Divisors
{
    /// <summary>
    /// Entry point for the Divisors class
    /// </summary>
    public static void Run()
    {
        List<int> list = FindDivisors(80);
        Console.WriteLine("<List>{" + string.Join(", ", list) + "}"); // <List>{1, 2, 4, 5, 8, 10, 16, 20, 40}
        List<int> list1 = FindDivisors(79);
        Console.WriteLine("<List>{" + string.Join(", ", list1) + "}"); // <List>{1}
    }

    /// <summary>
    /// Create a list of all divisors for a number including 1
    /// and excluding the number itself. Modulo will be used
    /// to test divisibility.
    /// </summary>
    /// <param name="number">The number to find the divisor</param>
    /// <returns>List of divisors</returns>
    private static List<int> FindDivisors(int number)
    {
        List<int> results = new();
        // This method finds all divisors of a given number, excluding the number itself.
        // It initializes an empty list to store the divisors.
        // The method iterates through all integers from 1 to number - 1,
        // checking if each integer divides evenly into the original number using the modulo operator.
        // If it does, that integer is added to the list of divisors.
        // Finally, the method returns the list of divisors found.

        // TODO problem 1

        for (int i = 1; i < number; ++i)
        {
            if (number % i == 0)
            {
                results.Add(i);
            }
        }
        // Return the list of divisors
        // The loop iterates from 1 to number - 1, checking each integer to see if it divides evenly into the original number.
        // If it does, that integer is added to the results list.
        return results;
    }

}