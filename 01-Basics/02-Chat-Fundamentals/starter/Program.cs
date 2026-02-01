using ChatFundamentalsApp;

class Program
{
    static void Main()
    {
        var utility = new ArrayUtility();

        Console.WriteLine("=== Array Utility Tests ===\n");

        int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6 };

        // Test FindMaximum
        Console.WriteLine($"FindMaximum({string.Join(", ", numbers)}): {utility.FindMaximum(numbers)}");

        // Test FindMinimum
        Console.WriteLine($"FindMinimum({string.Join(", ", numbers)}): {utility.FindMinimum(numbers)}");

        // Test CalculateAverage
        Console.WriteLine($"CalculateAverage({string.Join(", ", numbers)}): {utility.CalculateAverage(numbers):F2}");

        // Test FilterEvenNumbers
        int[] evens = utility.FilterEvenNumbers(numbers);
        Console.WriteLine($"FilterEvenNumbers({string.Join(", ", numbers)}): {string.Join(", ", evens)}");

        // Test SortDescending
        int[] sorted = utility.SortDescending(numbers);
        Console.WriteLine($"SortDescending({string.Join(", ", numbers)}): {string.Join(", ", sorted)}");

        // Test RemoveNulls
        int?[] withNulls = { 1, null, 2, null, 3 };
        int[] noNulls = utility.RemoveNulls(withNulls);
        Console.WriteLine($"RemoveNulls({string.Join(", ", withNulls.Select(x => x?.ToString() ?? "null"))}): {string.Join(", ", noNulls)}");

        // Test ChunkArray
        int[][] chunks = utility.ChunkArray(numbers, 3);
        Console.WriteLine($"ChunkArray({string.Join(", ", numbers)}, chunkSize=3):");
        foreach (var chunk in chunks)
        {
            Console.WriteLine($"  [{string.Join(", ", chunk)}]");
        }
    }
}
