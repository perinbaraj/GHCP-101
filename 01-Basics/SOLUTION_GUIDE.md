# Solution Guide: 01-Basics Exercises

This guide shows reference solutions, multiple prompting strategies, and explanations for all exercises in the Basics section.

---

## Exercise 1: Simple Calculator

### 📝 Overview
Build a calculator that accepts two numbers and performs basic arithmetic operations (Add, Subtract, Multiply, Divide) with proper error handling.

---

### 🤖 Prompting Strategies

#### **Approach 1: Method-by-Method (Beginner-Friendly)**
Best for understanding each method independently:
```
Create a C# Calculator class with an Add method:
- Parameters: double a, double b
- Returns: double (sum of a and b)
- Include input validation

Then create Subtract, Multiply, Divide using the same pattern.
Divide should throw ArgumentException if b is zero.
```

#### **Approach 2: All-in-One (More Efficient)**
Best for generating complete functionality quickly:
```
Create a Calculator class with Add, Subtract, Multiply, Divide methods.
All take two doubles and return a double.
Divide should check for zero divisor and throw ArgumentException.
Use modern C# with nullable reference types.
```

#### **Approach 3: Interactive Build (Chat)**
Best for learning through conversation:
```
User: "Create a Calculator class"
Copilot: [generates basic skeleton]
User: "Add validation for null inputs"
Copilot: [refines code]
User: "Make Divide handle division by zero"
Copilot: [adds error handling]
```

---

### ✅ Reference Solution

#### **Calculator.cs**
```csharp
namespace CalculatorApp;

/// <summary>
/// A simple calculator class that performs basic arithmetic operations.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Adds two numbers together.
    /// </summary>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <returns>The sum of a and b.</returns>
    public double Add(double a, double b)
    {
        return a + b;
    }

    /// <summary>
    /// Subtracts the second number from the first.
    /// </summary>
    /// <param name="a">The minuend.</param>
    /// <param name="b">The subtrahend.</param>
    /// <returns>The difference of a and b.</returns>
    public double Subtract(double a, double b)
    {
        return a - b;
    }

    /// <summary>
    /// Multiplies two numbers together.
    /// </summary>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <returns>The product of a and b.</returns>
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    /// <summary>
    /// Divides the first number by the second.
    /// </summary>
    /// <param name="a">The dividend.</param>
    /// <param name="b">The divisor.</param>
    /// <returns>The quotient of a divided by b.</returns>
    /// <exception cref="ArgumentException">Thrown when b is zero.</exception>
    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new ArgumentException("Divisor cannot be zero.", nameof(b));
        return a / b;
    }
}
```

#### **Program.cs**
```csharp
using CalculatorApp;

var calculator = new Calculator();

Console.WriteLine("=== Simple Calculator ===\n");

while (true)
{
    try
    {
        Console.Write("Enter first number: ");
        if (!double.TryParse(Console.ReadLine(), out var firstNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.\n");
            continue;
        }

        Console.Write("Enter operation (+, -, *, /): ");
        var operation = Console.ReadLine();

        Console.Write("Enter second number: ");
        if (!double.TryParse(Console.ReadLine(), out var secondNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.\n");
            continue;
        }

        var result = operation switch
        {
            "+" => calculator.Add(firstNumber, secondNumber),
            "-" => calculator.Subtract(firstNumber, secondNumber),
            "*" => calculator.Multiply(firstNumber, secondNumber),
            "/" => calculator.Divide(firstNumber, secondNumber),
            _ => throw new ArgumentException("Invalid operation.")
        };

        Console.WriteLine($"\nResult: {firstNumber} {operation} {secondNumber} = {result}\n");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Error: {ex.Message}\n");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unexpected error: {ex.Message}\n");
    }
}
```

---

### 💡 Key Insights

1. **Division by Zero**: Essential to check and throw meaningful exceptions
2. **Input Validation**: Use `double.TryParse()` to safely parse user input
3. **Switch Expressions**: Modern C# syntax for clean operation selection
4. **Try-Catch**: Graceful error handling prevents app crashes
5. **XML Documentation**: Use `///` comments for IDE intellisense

---

### ⚠️ Common Mistakes to Avoid

| Mistake | Problem | Fix |
|---------|---------|-----|
| `double result = a / b;` without check | App crashes when b = 0 | Add `if (b == 0) throw ArgumentException` |
| `int firstNumber = int.Parse(input)` | Crashes on invalid input | Use `double.TryParse(input, out var num)` |
| Missing XML docs | No intellisense for users | Add `/// <summary>` comments |
| Ignoring floating point precision | `0.1 + 0.2 != 0.3` | Be aware for financial apps |
| Not catching exceptions | App terminates on error | Wrap in try-catch blocks |

---

---

## Exercise 2: String Handler

### 📝 Overview
Build a string utility class with 6 methods: Reverse, ToTitleCase, CountVowels, RemoveDuplicates, IsPalindrome, and ValidateEmail. All must handle null/empty inputs gracefully.

---

### 🤖 Prompting Strategies

#### **Approach 1: Complete Class Generation**
```
Create a StringUtility class in C# with these methods:
- ReverseString(string input): string
- ToTitleCase(string input): string  
- CountVowels(string input): int
- RemoveDuplicates(string input): string
- IsPalindrome(string input): bool
- ValidateEmail(string email): bool

All should handle null/empty inputs by throwing ArgumentNullException.
Use modern C# (nullable reference types).
```

#### **Approach 2: Method-by-Method with LINQ**
```
Create a StringUtility class. First, implement ReverseString using LINQ:

public string ReverseString(string input)
{
    if (string.IsNullOrWhiteSpace(input))
        throw new ArgumentNullException(nameof(input));
    
    // Implement using LINQ
}
```

#### **Approach 3: Ask for Refactoring**
```
[Generate basic StringUtility with loops]

User: "Refactor CountVowels to use LINQ instead of a loop"
Copilot: [refactors to LINQ version]

User: "Make RemoveDuplicates more concise using LINQ"
Copilot: [improves code]
```

---

### ✅ Reference Solution

#### **StringUtility.cs**
```csharp
using System.Text.RegularExpressions;

namespace StringHandlerApp;

/// <summary>
/// Provides utility methods for string manipulation and validation.
/// </summary>
public class StringUtility
{
    /// <summary>
    /// Reverses a string.
    /// </summary>
    /// <param name="input">The string to reverse.</param>
    /// <returns>The reversed string.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input is null.</exception>
    public string ReverseString(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentNullException(nameof(input), "Input cannot be null or empty.");
        
        return new string(input.Reverse().ToArray());
    }

    /// <summary>
    /// Converts a string to Title Case (each word capitalized).
    /// </summary>
    /// <param name="input">The string to convert.</param>
    /// <returns>The title-cased string.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input is null.</exception>
    public string ToTitleCase(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentNullException(nameof(input), "Input cannot be null or empty.");
        
        var words = input.Split(' ');
        return string.Join(" ", words.Select(w => 
            char.ToUpper(w[0]) + w.Substring(1).ToLower()));
    }

    /// <summary>
    /// Counts the number of vowels in a string.
    /// </summary>
    /// <param name="input">The string to analyze.</param>
    /// <returns>The count of vowels.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input is null.</exception>
    public int CountVowels(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentNullException(nameof(input), "Input cannot be null or empty.");
        
        var vowels = "aeiouAEIOU";
        return input.Count(c => vowels.Contains(c));
    }

    /// <summary>
    /// Removes consecutive duplicate characters from a string.
    /// </summary>
    /// <param name="input">The string to process.</param>
    /// <returns>The string with consecutive duplicates removed.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input is null.</exception>
    public string RemoveDuplicates(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentNullException(nameof(input), "Input cannot be null or empty.");
        
        var result = new System.Text.StringBuilder();
        char? lastChar = null;
        
        foreach (var ch in input)
        {
            if (ch != lastChar)
            {
                result.Append(ch);
                lastChar = ch;
            }
        }
        
        return result.ToString();
    }

    /// <summary>
    /// Checks if a string is a palindrome (case-insensitive).
    /// </summary>
    /// <param name="input">The string to check.</param>
    /// <returns>True if palindrome, false otherwise.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input is null.</exception>
    public bool IsPalindrome(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentNullException(nameof(input), "Input cannot be null or empty.");
        
        var cleaned = new string(input.Where(char.IsLetter).ToArray()).ToLower();
        return cleaned == new string(cleaned.Reverse().ToArray());
    }

    /// <summary>
    /// Validates if a string is a valid email format.
    /// </summary>
    /// <param name="email">The email to validate.</param>
    /// <returns>True if valid email format, false otherwise.</returns>
    /// <exception cref="ArgumentNullException">Thrown when email is null.</exception>
    public bool ValidateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentNullException(nameof(email), "Email cannot be null or empty.");
        
        var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, pattern);
    }
}
```

---

### 💡 Key Insights

1. **LINQ Methods**: `.Reverse()`, `.Count()`, `.Where()` simplify string operations
2. **String.IsNullOrWhiteSpace()**: Checks for null, empty, and whitespace-only strings
3. **StringBuilder**: More efficient for building strings in loops
4. **Regex Basics**: `@"^[^@\s]+@[^@\s]+\.[^@\s]+$"` is a simple email pattern
5. **LINQ on Strings**: Strings are `IEnumerable<char>`, so LINQ methods work

---

### ⚠️ Common Mistakes to Avoid

| Mistake | Problem | Fix |
|---------|---------|-----|
| `new string(input.Reverse())` | Wrong type, need `.ToArray()` | Use `new string(input.Reverse().ToArray())` |
| Not handling null inputs | Crashes with NullReferenceException | Check `string.IsNullOrWhiteSpace()` first |
| Email regex too complex | Overly complicated, hard to maintain | Use simple pattern: `^[^@]+@[^@]+\.[^@]+$` |
| Case-sensitive palindrome check | "Racecar" fails | Convert to lowercase before checking |
| Using `string.Replace("a", "")` | Can't remove multiple duplicate chars | Use loop with StringBuilder or LINQ |

---

---

## Exercise 3: Array Operations

### 📝 Overview
Build an array utility class with 7 LINQ-based methods for finding max/min, calculating averages, filtering, sorting, chunking, and removing nulls.

---

### 🤖 Prompting Strategies

#### **Approach 1: LINQ-Focused Generation**
```
Create an ArrayUtility class with these LINQ-based methods:
- FindMaximum(int[] array): int - use .Max()
- FindMinimum(int[] array): int - use .Min()
- CalculateAverage(int[] array): double - use .Average()
- FilterEvenNumbers(int[] array): int[] - use .Where()
- SortDescending(int[] array): int[] - use .OrderByDescending()
- RemoveNulls(int?[] array): int[] - use .Where() and .ToArray()
- ChunkArray(int[] array, int chunkSize): int[][] - split into groups

Include validation for empty arrays.
```

#### **Approach 2: Build with Tests**
```
Create an ArrayUtility class.
Then select it and use /tests to generate unit tests.
This will help you verify each method works correctly.
```

#### **Approach 3: Interactive LINQ Learning**
```
User: "Create FindMaximum method using LINQ"
Copilot: [generates using .Max()]
User: "Show me how to filter even numbers"
Copilot: [generates using .Where(x => x % 2 == 0)]
User: "How do I chunk an array into groups?"
Copilot: [generates chunking logic]
```

---

### ✅ Reference Solution

#### **ArrayUtility.cs**
```csharp
namespace ArrayOperationsApp;

/// <summary>
/// Provides utility methods for array manipulation and analysis using LINQ.
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
        if (array == null || array.Length == 0)
            throw new ArgumentException("Array cannot be null or empty.", nameof(array));
        
        return array.Max();
    }

    /// <summary>
    /// Finds the minimum value in an array.
    /// </summary>
    /// <param name="array">The array to search.</param>
    /// <returns>The smallest element.</returns>
    /// <exception cref="ArgumentException">Thrown when array is null or empty.</exception>
    public int FindMinimum(int[] array)
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Array cannot be null or empty.", nameof(array));
        
        return array.Min();
    }

    /// <summary>
    /// Calculates the average of all elements in an array.
    /// </summary>
    /// <param name="array">The array to analyze.</param>
    /// <returns>The average value.</returns>
    /// <exception cref="ArgumentException">Thrown when array is null or empty.</exception>
    public double CalculateAverage(int[] array)
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Array cannot be null or empty.", nameof(array));
        
        return array.Average();
    }

    /// <summary>
    /// Filters and returns only even numbers from the array.
    /// </summary>
    /// <param name="array">The array to filter.</param>
    /// <returns>An array containing only even numbers.</returns>
    /// <exception cref="ArgumentException">Thrown when array is null.</exception>
    public int[] FilterEvenNumbers(int[] array)
    {
        if (array == null)
            throw new ArgumentException("Array cannot be null.", nameof(array));
        
        return array.Where(x => x % 2 == 0).ToArray();
    }

    /// <summary>
    /// Sorts the array in descending order.
    /// </summary>
    /// <param name="array">The array to sort.</param>
    /// <returns>A new array sorted in descending order.</returns>
    /// <exception cref="ArgumentException">Thrown when array is null.</exception>
    public int[] SortDescending(int[] array)
    {
        if (array == null)
            throw new ArgumentException("Array cannot be null.", nameof(array));
        
        return array.OrderByDescending(x => x).ToArray();
    }

    /// <summary>
    /// Removes null values from an array of nullable integers.
    /// </summary>
    /// <param name="array">The array to process.</param>
    /// <returns>An array without null values.</returns>
    /// <exception cref="ArgumentException">Thrown when array is null.</exception>
    public int[] RemoveNulls(int?[] array)
    {
        if (array == null)
            throw new ArgumentException("Array cannot be null.", nameof(array));
        
        return array.Where(x => x.HasValue).Select(x => x!.Value).ToArray();
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
        if (array == null)
            throw new ArgumentException("Array cannot be null.", nameof(array));
        
        if (chunkSize <= 0)
            throw new ArgumentException("Chunk size must be positive.", nameof(chunkSize));
        
        return array
            .Select((value, index) => new { value, index })
            .GroupBy(x => x.index / chunkSize)
            .Select(g => g.Select(x => x.value).ToArray())
            .ToArray();
    }
}
```

---

### 💡 Key Insights

1. **LINQ Method Chaining**: `.Where().Select().ToArray()` creates readable pipelines
2. **Nullable Handling**: `.HasValue` and `.Value` for `int?` values
3. **GroupBy Logic**: `index / chunkSize` groups items efficiently
4. **Null Checking**: Always validate array isn't null before using LINQ
5. **Operator Overloading**: `%` for modulo (even check), `/` for integer division

---

### ⚠️ Common Mistakes to Avoid

| Mistake | Problem | Fix |
|---------|---------|-----|
| `array.Max()` on empty array | Throws exception | Check `array.Length > 0` first |
| `.Where(x => x % 2)` | Returns bool, not filtered | Use `.Where(x => x % 2 == 0)` |
| `int value = nullable;` | Compiler error | Use `nullable.Value` or `nullable ?? 0` |
| Not calling `.ToArray()` | Returns IEnumerable, not array | Always end with `.ToArray()` for `int[]` |
| `.Chunk()` (old .NET) | Not available in .NET 7 | Use GroupBy logic instead |

---

---

## Exercise 4: File Processor

### 📝 Overview
Build an async file processor that reads/writes CSV files, counts lines, filters lines, and converts CSV to JSON. Must handle file errors gracefully.

---

### 🤖 Prompting Strategies

#### **Approach 1: Complete Async Implementation**
```
Create an async FileProcessor class with these methods:
- ReadCsvFileAsync(string filePath): Task<List<Dictionary<string, string>>>
- WriteCsvFileAsync(string filePath, List<Dictionary<string, string>> data): Task
- CountLinesAsync(string filePath): Task<int>
- FilterLinesAsync(string filePath, Func<string, bool> predicate): Task<List<string>>
- ConvertCsvToJsonAsync(string csvPath, string jsonPath): Task

Use async/await. Include error handling for FileNotFoundException
and UnauthorizedAccessException. Use System.IO and System.Text.Json.
```

#### **Approach 2: Interactive Error Handling**
```
User: "Create ReadCsvFileAsync"
Copilot: [generates basic version]
User: "Add error handling for file not found"
Copilot: [adds try-catch]
User: "What about permissions issues?"
Copilot: [adds UnauthorizedAccessException handling]
```

#### **Approach 3: Learn-by-Explaining**
```
[Generate FileProcessor]
User: "Select ReadCsvFileAsync and use /explain"
Copilot: [explains async/await flow, error handling]
User: "How does Task work here?"
Copilot: [explains Task basics]
```

---

### ✅ Reference Solution

#### **FileProcessor.cs**
```csharp
using System.Text.Json;

namespace FileProcessorApp;

/// <summary>
/// Processes CSV and JSON files for data transformation and analysis.
/// All operations are async for non-blocking I/O.
/// </summary>
public class FileProcessor
{
    /// <summary>
    /// Reads a CSV file and returns data as a list of dictionaries.
    /// </summary>
    /// <param name="filePath">Path to the CSV file.</param>
    /// <returns>A list where each item is a row with column names as keys.</returns>
    /// <exception cref="FileNotFoundException">Thrown when file doesn't exist.</exception>
    /// <exception cref="UnauthorizedAccessException">Thrown when no permission to read.</exception>
    public async Task<List<Dictionary<string, string>>> ReadCsvFileAsync(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"File not found: {filePath}");

            var lines = await File.ReadAllLinesAsync(filePath);
            
            if (lines.Length == 0)
                return new List<Dictionary<string, string>>();

            var headers = lines[0].Split(',');
            var result = new List<Dictionary<string, string>>();

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');
                var row = new Dictionary<string, string>();

                for (int j = 0; j < headers.Length && j < values.Length; j++)
                {
                    row[headers[j].Trim()] = values[j].Trim();
                }

                result.Add(row);
            }

            return result;
        }
        catch (UnauthorizedAccessException)
        {
            throw new UnauthorizedAccessException($"Permission denied for file: {filePath}");
        }
    }

    /// <summary>
    /// Writes data to a CSV file.
    /// </summary>
    /// <param name="filePath">Path where to save the CSV file.</param>
    /// <param name="data">List of dictionaries to write.</param>
    /// <exception cref="ArgumentException">Thrown when parameters are invalid.</exception>
    public async Task WriteCsvFileAsync(string filePath, List<Dictionary<string, string>> data)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be empty.", nameof(filePath));

            if (data == null || data.Count == 0)
                throw new ArgumentException("Data cannot be null or empty.", nameof(data));

            var headers = data.First().Keys.ToList();
            var lines = new List<string> { string.Join(",", headers) };

            foreach (var row in data)
            {
                var values = headers.Select(h => row.ContainsKey(h) ? row[h] : "");
                lines.Add(string.Join(",", values));
            }

            await File.WriteAllLinesAsync(filePath, lines);
        }
        catch (UnauthorizedAccessException)
        {
            throw new UnauthorizedAccessException($"Permission denied for file: {filePath}");
        }
    }

    /// <summary>
    /// Counts the total number of lines in a file efficiently.
    /// </summary>
    /// <param name="filePath">Path to the file.</param>
    /// <returns>The line count.</returns>
    /// <exception cref="FileNotFoundException">Thrown when file doesn't exist.</exception>
    public async Task<int> CountLinesAsync(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"File not found: {filePath}");

            var lines = await File.ReadAllLinesAsync(filePath);
            return lines.Length;
        }
        catch (UnauthorizedAccessException)
        {
            throw new UnauthorizedAccessException($"Permission denied for file: {filePath}");
        }
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
        try
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"File not found: {filePath}");

            var allLines = await File.ReadAllLinesAsync(filePath);
            return allLines.Where(predicate).ToList();
        }
        catch (UnauthorizedAccessException)
        {
            throw new UnauthorizedAccessException($"Permission denied for file: {filePath}");
        }
    }

    /// <summary>
    /// Converts a CSV file to JSON format.
    /// </summary>
    /// <param name="csvPath">Path to input CSV file.</param>
    /// <param name="jsonPath">Path where to save JSON file.</param>
    /// <exception cref="FileNotFoundException">Thrown when CSV file doesn't exist.</exception>
    public async Task ConvertCsvToJsonAsync(string csvPath, string jsonPath)
    {
        try
        {
            var data = await ReadCsvFileAsync(csvPath);
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(jsonPath, json);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to convert CSV to JSON: {ex.Message}", ex);
        }
    }
}
```

#### **Program.cs**
```csharp
using FileProcessorApp;

var processor = new FileProcessor();

Console.WriteLine("=== File Processor ===\n");

try
{
    // Example: Create sample CSV
    var sampleData = new List<Dictionary<string, string>>
    {
        new() { { "Name", "Alice Johnson" }, { "Age", "28" }, { "Email", "alice@example.com" } },
        new() { { "Name", "Bob Smith" }, { "Age", "35" }, { "Email", "bob@example.com" } },
        new() { { "Name", "Charlie Brown" }, { "Age", "42" }, { "Email", "charlie@example.com" } }
    };

    // Write CSV
    Console.WriteLine("Writing sample data to users.csv...");
    await processor.WriteCsvFileAsync("users.csv", sampleData);
    Console.WriteLine("✓ CSV file created\n");

    // Count lines
    var lineCount = await processor.CountLinesAsync("users.csv");
    Console.WriteLine($"File has {lineCount} lines\n");

    // Read CSV
    Console.WriteLine("Reading CSV file...");
    var data = await processor.ReadCsvFileAsync("users.csv");
    Console.WriteLine($"✓ Read {data.Count} records\n");

    // Filter lines
    Console.WriteLine("Filtering lines with 'Alice'...");
    var filtered = await processor.FilterLinesAsync("users.csv", line => line.Contains("Alice"));
    foreach (var line in filtered)
    {
        Console.WriteLine($"  {line}");
    }
    Console.WriteLine();

    // Convert to JSON
    Console.WriteLine("Converting to JSON...");
    await processor.ConvertCsvToJsonAsync("users.csv", "users.json");
    Console.WriteLine("✓ JSON file created\n");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}
```

---

### 💡 Key Insights

1. **Async/Await Pattern**: `await File.ReadAllLinesAsync()` doesn't block UI
2. **Task Pattern**: Methods return `Task<T>` for async operations
3. **Dictionary for CSV Rows**: Maps column headers to values flexibly
4. **JsonSerializer**: Serializes to indented JSON for readability
5. **Error Handling**: Catch specific exceptions (FileNotFoundException, UnauthorizedAccessException)

---

### ⚠️ Common Mistakes to Avoid

| Mistake | Problem | Fix |
|---------|---------|-----|
| `File.ReadAllLines()` instead of `await` version | Blocks thread | Use `await File.ReadAllLinesAsync()` |
| Missing `await` keyword | Returns Task instead of result | Always use `await` with async methods |
| Not checking `File.Exists()` | Direct error message is unclear | Check first and throw custom error |
| CSV parsing without trimming | Whitespace included in data | Use `.Trim()` on headers and values |
| Not handling `UnauthorizedAccessException` | App crashes on permission denied | Add try-catch for this specific exception |
| JsonSerializer with defaults | Outputs minified JSON | Use `WriteIndented = true` for readability |

---

## 🎓 Summary: Key Concepts Across All Exercises

### **Copilot Features Used**
- ✅ **Chat (`Ctrl+I`)**: Generate entire classes and methods
- ✅ **Autocomplete**: Fills in common patterns
- ✅ **`/doc`**: Auto-generates XML documentation  
- ✅ **`/explain`**: Explains complex code (async, LINQ, etc.)
- ✅ **`/fix`**: Fixes compilation errors
- ✅ **`/tests`**: Generates unit tests
- ✅ **Inline Refactoring**: Improve existing code

### **C# Features Learned**
- **Nullable Reference Types** (`string?`): Catch null bugs early
- **LINQ**: `.Where()`, `.Select()`, `.OrderBy()` for functional code
- **Async/Await**: Non-blocking I/O with `Task<T>`
- **Switch Expressions**: Clean conditional logic
- **Exception Handling**: Specific exceptions for different errors
- **Dictionary**: Flexible key-value storage
- **StringBuilder**: Efficient string building in loops

### **Software Engineering Principles**
- **SOLID**: Single Responsibility (each method does one thing)
- **Error Handling**: Catch and rethrow with context
- **Input Validation**: Check parameters before use
- **Documentation**: XML comments for IDE intellisense
- **Testing**: Unit tests verify behavior
- **Code Reuse**: DRY principle with helper methods

---

## 📚 Next Section

✅ Completed: **01-Basics**

🚀 Next: **02-Modes** (Ask, Edit, Plan modes of Copilot Chat)
