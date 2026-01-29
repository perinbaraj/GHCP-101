namespace ArrayOperationsApp;

/// <summary>
/// A utility class for common array operations using LINQ.
/// </summary>
public class ArrayUtility
{
    /// <summary>
    /// Finds the maximum value in an array.
    /// </summary>
    /// <param name="array">The array to search.</param>
    /// <returns>The largest element.</returns>
    /// <exception cref="ArgumentException">Thrown when array is null or empty.</exception>
    public int FindMaximum(int[] array)
    {
        // TODO: Implement using Copilot
        // Use LINQ Max() method
        throw new NotImplementedException();
    }

    /// <summary>
    /// Finds the minimum value in an array.
    /// </summary>
    /// <param name="array">The array to search.</param>
    /// <returns>The smallest element.</returns>
    /// <exception cref="ArgumentException">Thrown when array is null or empty.</exception>
    public int FindMinimum(int[] array)
    {
        // TODO: Implement using Copilot
        // Use LINQ Min() method
        throw new NotImplementedException();
    }

    /// <summary>
    /// Calculates the average of all elements in an array.
    /// </summary>
    /// <param name="array">The array to analyze.</param>
    /// <returns>The average value.</returns>
    /// <exception cref="ArgumentException">Thrown when array is null or empty.</exception>
    public double CalculateAverage(int[] array)
    {
        // TODO: Implement using Copilot
        // Use LINQ Average() method
        throw new NotImplementedException();
    }

    /// <summary>
    /// Filters and returns only even numbers from the array.
    /// </summary>
    /// <param name="array">The array to filter.</param>
    /// <returns>An array containing only even numbers.</returns>
    /// <exception cref="ArgumentException">Thrown when array is null.</exception>
    public int[] FilterEvenNumbers(int[] array)
    {
        // TODO: Implement using Copilot and LINQ
        // Use Where() and ToArray()
        throw new NotImplementedException();
    }

    /// <summary>
    /// Sorts the array in descending order.
    /// </summary>
    /// <param name="array">The array to sort.</param>
    /// <returns>A new array sorted in descending order.</returns>
    /// <exception cref="ArgumentException">Thrown when array is null.</exception>
    public int[] SortDescending(int[] array)
    {
        // TODO: Implement using Copilot
        // Use OrderByDescending() and ToArray()
        throw new NotImplementedException();
    }

    /// <summary>
    /// Removes null values from an array of nullable integers.
    /// </summary>
    /// <param name="array">The array to process.</param>
    /// <returns>An array without null values.</returns>
    /// <exception cref="ArgumentException">Thrown when array is null.</exception>
    public int[] RemoveNulls(int?[] array)
    {
        // TODO: Implement using Copilot and LINQ
        // Use Where() to filter out nulls and ToArray()
        throw new NotImplementedException();
    }

    /// <summary>
    /// Splits an array into chunks of specified size.
    /// </summary>
    /// <param name="array">The array to chunk.</param>
    /// <param name="chunkSize">The size of each chunk.</param>
    /// <returns>A jagged array containing chunks.</returns>
    /// <exception cref="ArgumentException">Thrown when array is null or chunkSize is invalid.</exception>
    public int[][] ChunkArray(int[] array, int chunkSize)
    {
        // TODO: Implement using Copilot and LINQ
        // Use Chunk() method (C# 12) or Split()/Skip()/Take()
        throw new NotImplementedException();
    }
}
