using System.Text.Json;

namespace FileProcessorApp;

/// <summary>
/// A utility class for processing files (CSV, JSON, text files).
/// Uses async/await for non-blocking I/O operations.
/// </summary>
public class FileProcessor
{
    /// <summary>
    /// Reads a CSV file and returns data as a list of dictionaries.
    /// </summary>
    /// <param name="filePath">Path to the CSV file.</param>
    /// <returns>A list where each entry is a dictionary of column names to values.</returns>
    /// <exception cref="FileNotFoundException">Thrown when file doesn't exist.</exception>
    /// <exception cref="ArgumentException">Thrown when file path is null or empty.</exception>
    public async Task<List<Dictionary<string, string>>> ReadCsvFileAsync(string filePath)
    {
        // TODO: Implement using Copilot
        // 1. Validate file path
        // 2. Check if file exists
        // 3. Read all lines asynchronously
        // 4. Parse CSV (first line = headers)
        // 5. Return list of dictionaries
        throw new NotImplementedException();
    }

    /// <summary>
    /// Writes data to a CSV file.
    /// </summary>
    /// <param name="filePath">Path where to save the CSV file.</param>
    /// <param name="data">List of dictionaries to write.</param>
    /// <exception cref="ArgumentException">Thrown when parameters are invalid.</exception>
    public async Task WriteCsvFileAsync(string filePath, List<Dictionary<string, string>> data)
    {
        // TODO: Implement using Copilot
        // 1. Validate inputs
        // 2. Get all unique keys from all dictionaries
        // 3. Write headers
        // 4. Write data rows
        // 5. Save file asynchronously
        throw new NotImplementedException();
    }

    /// <summary>
    /// Counts the total number of lines in a file.
    /// </summary>
    /// <param name="filePath">Path to the file.</param>
    /// <returns>The line count.</returns>
    /// <exception cref="FileNotFoundException">Thrown when file doesn't exist.</exception>
    public async Task<int> CountLinesAsync(string filePath)
    {
        // TODO: Implement using Copilot
        // 1. Validate file path
        // 2. Check if file exists
        // 3. Use File.ReadLinesAsync() or StreamReader
        // 4. Count lines efficiently
        throw new NotImplementedException();
    }

    /// <summary>
    /// Filters file lines based on a predicate condition.
    /// </summary>
    /// <param name="filePath">Path to the file.</param>
    /// <param name="predicate">Function to determine which lines to keep.</param>
    /// <returns>A list of lines matching the predicate.</returns>
    /// <exception cref="FileNotFoundException">Thrown when file doesn't exist.</exception>
    public async Task<List<string>> FilterLinesAsync(string filePath, Func<string, bool> predicate)
    {
        // TODO: Implement using Copilot
        // 1. Validate inputs
        // 2. Check if file exists
        // 3. Read all lines asynchronously
        // 4. Filter using predicate
        // 5. Return matching lines
        throw new NotImplementedException();
    }

    /// <summary>
    /// Converts a CSV file to JSON format.
    /// </summary>
    /// <param name="csvPath">Path to input CSV file.</param>
    /// <param name="jsonPath">Path where to save JSON file.</param>
    /// <exception cref="FileNotFoundException">Thrown when CSV file doesn't exist.</exception>
    public async Task ConvertCsvToJsonAsync(string csvPath, string jsonPath)
    {
        // TODO: Implement using Copilot
        // 1. Use ReadCsvFileAsync to read CSV
        // 2. Convert list to JSON using JsonSerializer
        // 3. Write JSON file asynchronously
        // 4. Handle any serialization options (pretty-print, etc)
        throw new NotImplementedException();
    }
}
