# Exercise 4: File Processor — Understanding Code with `/explain`

**Difficulty:** Intermediate | **Time:** 30-35 minutes | **Copilot Features:** `/explain`, Chat, Refactoring

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Use `/explain` slash command to understand complex code
- ✅ Work with file I/O in .NET
- ✅ Understand async/await patterns with file operations
- ✅ Apply error handling for file operations
- ✅ Learn data processing patterns

---

## 📋 Requirements

Build a file processor that:
1. **Read CSV file** — Parse comma-separated values
2. **Write JSON file** — Convert data to JSON format
3. **Count file lines** — Read and count lines efficiently
4. **Filter and transform** — Process lines based on criteria
5. **Handle errors** — File not found, invalid format, access issues
6. **Use async/await** — Non-blocking file operations
7. **Work with streams** — Memory-efficient large file handling

---

## 🤖 Copilot Prompting (Reference)

### **Try This Prompt**
Open Chat (`Ctrl+I`) and ask:
```
Create an async FileProcessor class with methods to read/write CSV files,
count file lines, filter lines with a predicate, and convert CSV to JSON.
Handle file not found and other common errors. Use async/await throughout.
```

**🎯 Tips:**
- Use `/explain` on complex async methods to understand the flow
- Ask Copilot to add error handling
- Test with real CSV files

👉 **For multiple solutions and error handling examples, see [SOLUTION_GUIDE.md](../SOLUTION_GUIDE.md)**

---

## 💻 Starter Code

### **starter/FileProcessor.cs**
```csharp
namespace FileProcessorApp;

using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
/// Processes CSV and JSON files for data transformation and analysis.
/// </summary>
public class FileProcessor
{
    /// <summary>
    /// Reads a CSV file and returns data as list of dictionaries.
    /// </summary>
    public async Task<List<Dictionary<string, string>>> ReadCsvFileAsync(string filePath)
    {
        // TODO: Implement using Copilot
        throw new NotImplementedException();
    }

    /// <summary>
    /// Writes data to a CSV file.
    /// </summary>
    public async Task WriteCsvFileAsync(string filePath, List<Dictionary<string, string>> data)
    {
        // TODO: Implement using Copilot
        throw new NotImplementedException();
    }

    /// <summary>
    /// Counts the number of lines in a file efficiently.
    /// </summary>
    public async Task<int> CountLinesAsync(string filePath)
    {
        // TODO: Implement using Copilot
        throw new NotImplementedException();
    }

    /// <summary>
    /// Filters lines based on a predicate function.
    /// </summary>
    public async Task<List<string>> FilterLinesAsync(string filePath, Func<string, bool> predicate)
    {
        // TODO: Implement using Copilot
        throw new NotImplementedException();
    }

    /// <summary>
    /// Converts a CSV file to JSON format.
    /// </summary>
    public async Task ConvertCsvToJsonAsync(string csvPath, string jsonPath)
    {
        // TODO: Implement using Copilot
        throw new NotImplementedException();
    }
}
```

### **starter/Program.cs**
```csharp
using FileProcessorApp;

// TODO: Create an interactive program that:
// 1. Accepts file paths from user
// 2. Performs file operations (read, write, convert)
// 3. Displays results
// 4. Handles file errors gracefully
// 5. Uses async/await throughout

Console.WriteLine("Welcome to File Processor!");
```

---

## 📂 Sample Test Data

### **starter/data/sample.csv**
```csv
Name,Age,Email,City
John Doe,30,john@example.com,New York
Jane Smith,28,jane@example.com,Los Angeles
Bob Johnson,35,bob@example.com,Chicago
```

---

## ✅ Verification

- [ ] Program reads CSV files correctly
- [ ] Program writes CSV files without errors
- [ ] JSON conversion produces valid JSON
- [ ] Async methods use proper await syntax
- [ ] File not found errors are handled
- [ ] Program runs efficiently with large files
- [ ] All operations complete as expected

---

## 🎓 Key Takeaways

- **`/explain` slash command** helps understand complex patterns like async/await
- **Async/await** prevents blocking on I/O operations
- **File streams** are memory-efficient for large files
- **Error handling** is critical for file operations (permissions, encoding, format)
- **Data transformation** (CSV to JSON) is a common real-world task

---

## 📚 Next Steps

✅ Complete Exercise 4 → All Basics exercises complete! 

🎉 **Congratulations!** You've mastered Copilot Basics. Next: Section 2 - **Copilot Modes**

