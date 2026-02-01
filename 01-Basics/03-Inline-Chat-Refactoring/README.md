# Exercise 4: Inline Chat Refactoring — Quick Edits with Ctrl+I

**Difficulty:** Intermediate | **Time:** 30-35 minutes | **Copilot Features:** Inline Chat (`Ctrl+I`), Quick Fixes, Code Transformation, `/doc`, `/explain`

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Master inline chat (`Ctrl+I`) for quick code transformations
- ✅ Use inline chat for refactoring without losing code
- ✅ Transform code using natural language requests
- ✅ Add error handling with inline chat
- ✅ Improve readability with inline refactoring
- ✅ Work with async/await patterns and file I/O
- ✅ Apply error handling patterns

---

## 💡 What is Inline Chat (Ctrl+I)?

**Inline Chat** is different from regular Chat:

| Feature | Regular Chat | Inline Chat |
|---------|-------------|------------|
| Shortcut | `Ctrl+Shift+I` | `Ctrl+I` |
| Scope | Unlimited context | Current file/selection |
| Edit Type | Creates new code | Transforms existing code |
| Speed | Full conversation | Quick 1-2 line edits |
| Use Case | Complex questions | Quick refactors |

### **Inline Chat Workflow**
```
1. Position cursor in code or select code
2. Press Ctrl+I
3. Type your transformation request
4. Press Enter or Escape to accept/reject
5. Code changes inline
```

---

## 📋 Requirements

Build a file processor with methods for:
1. **Read CSV files** and parse data
2. **Write CSV files** with proper formatting
3. **Count file lines** efficiently
4. **Filter lines** based on predicates
5. **Convert CSV to JSON** format
6. **Handle errors** gracefully with try-catch
7. **Use async/await** for all I/O operations
8. **Improve code** with inline refactoring

---

## 🎯 Inline Chat Refactoring Patterns

### **Pattern 1: Add Error Handling**
```csharp
// Select method without error handling
public async Task<int> CountLinesAsync(string filePath)
{
    return (await File.ReadAllLinesAsync(filePath)).Length;
}

// Inline Chat (Ctrl+I): "Add try-catch error handling"
// Result: Method now has proper error handling
```

### **Pattern 2: Improve Readability**
```csharp
// Select complex LINQ
var result = data.Where(x => x.Status == "active").OrderBy(x => x.Date).Select(x => new { x.Id, x.Name });

// Inline Chat (Ctrl+I): "Break this into separate steps for readability"
// Result: More readable multi-line version
```

### **Pattern 3: Add Logging**
```csharp
// Select method without logging
public void ProcessFile(string path)
{
    // Process code...
}

// Inline Chat (Ctrl+I): "Add console logging for debugging"
// Result: Method now has logging statements
```

### **Pattern 4: Convert to Async**
```csharp
// Select synchronous method
public List<string> ReadLines(string filePath)
{
    return File.ReadAllLines(filePath).ToList();
}

// Inline Chat (Ctrl+I): "Convert this to async/await"
// Result: Becomes async Task method
```

### **Pattern 5: Add XML Documentation**
```csharp
public string ProcessData(string input) { ... }

// Inline Chat (Ctrl+I): "Add XML documentation comments"
// Result: XML docs added above method
```

---

## 📁 File Structure

```
03-Inline-Chat-Refactoring/
├── README.md (this file)
├── CHECKLIST.md
├── starter/
│   ├── FileProcessor.cs (basic implementations)
│   ├── Program.cs
│   └── FileProcessor.csproj
├── sample-data/
│   ├── data.csv (sample CSV file)
│   └── output/
│       └── (generated files)
└── solution/
    ├── FileProcessor.cs (refactored with error handling)
    ├── Program.cs
    └── FileProcessor.csproj
```

---

## 🚀 Getting Started

### **Step 1: Review Starter Code**
1. Open `FileProcessor.cs`
2. Review each method - they're functional but basic
3. Notice lack of error handling and logging

### **Step 2: Refactor with Inline Chat**
For each method:
1. Position cursor on method name
2. Press `Ctrl+I`
3. Type refactoring request:
   - "Add try-catch error handling for file operations"
   - "Improve readability with comments"
   - "Add validation for null/empty inputs"
4. Review suggestion
5. Press Tab to accept or Escape to reject

### **Step 3: Test Improvements**
1. Run the program
2. Test with valid and invalid files
3. Verify error handling works

### **Step 4: Documentation**
1. Select methods without XML docs
2. Press `Ctrl+I`
3. Type: "Add comprehensive XML documentation"
4. Accept suggestions

---

## 💻 Starter Code

### **starter/FileProcessor.cs**

```csharp
namespace InlineChatApp;

using System.Text.Json;

/// <summary>
/// Processes CSV and JSON files for data transformation and analysis.
/// </summary>
public class FileProcessor
{
    public async Task<List<Dictionary<string, string>>> ReadCsvFileAsync(string filePath)
    {
        var lines = await File.ReadAllLinesAsync(filePath);
        var headers = lines[0].Split(',');
        var data = new List<Dictionary<string, string>>();

        for (int i = 1; i < lines.Length; i++)
        {
            var values = lines[i].Split(',');
            var row = new Dictionary<string, string>();
            for (int j = 0; j < headers.Length; j++)
            {
                row[headers[j]] = values[j];
            }
            data.Add(row);
        }
        return data;
    }

    public async Task WriteCsvFileAsync(string filePath, List<Dictionary<string, string>> data)
    {
        if (data.Count == 0) return;

        var headers = data[0].Keys.ToArray();
        var lines = new List<string> { string.Join(",", headers) };

        foreach (var row in data)
        {
            var values = headers.Select(h => row[h]);
            lines.Add(string.Join(",", values));
        }

        await File.WriteAllLinesAsync(filePath, lines);
    }

    public async Task<int> CountLinesAsync(string filePath)
    {
        var lines = await File.ReadAllLinesAsync(filePath);
        return lines.Length;
    }

    public async Task<List<string>> FilterLinesAsync(string filePath, Func<string, bool> predicate)
    {
        var lines = await File.ReadAllLinesAsync(filePath);
        return lines.Where(predicate).ToList();
    }

    public async Task<string> ConvertCsvToJsonAsync(string csvFilePath)
    {
        var data = await ReadCsvFileAsync(csvFilePath);
        return JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
    }
}
```

### **starter/Program.cs**

```csharp
using InlineChatApp;

class Program
{
    static async Task Main()
    {
        var processor = new FileProcessor();

        try
        {
            string testFile = "test.csv";

            Console.WriteLine("=== File Processor Demo ===\n");

            // Create test data
            var testData = new List<Dictionary<string, string>>
            {
                new() { { "Name", "Alice" }, { "Age", "30" } },
                new() { { "Name", "Bob" }, { "Age", "25" } },
            };

            await processor.WriteCsvFileAsync(testFile, testData);
            Console.WriteLine($"✓ Created test CSV file");

            var count = await processor.CountLinesAsync(testFile);
            Console.WriteLine($"✓ File has {count} lines");

            var data = await processor.ReadCsvFileAsync(testFile);
            Console.WriteLine($"✓ Read {data.Count} records");

            var json = await processor.ConvertCsvToJsonAsync(testFile);
            Console.WriteLine($"✓ Converted to JSON:\n{json}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
```

---

## 🎯 Inline Chat Requests to Try

Here are specific refactoring requests to try with `Ctrl+I`:

1. **On ReadCsvFileAsync method:**
   ```
   Add comprehensive error handling for file not found, invalid CSV format, and null inputs
   ```

2. **On WriteCsvFileAsync method:**
   ```
   Add validation to check if directory exists and create it if needed
   ```

3. **On FilterLinesAsync method:**
   ```
   Add null check for filePath and predicate parameters
   ```

4. **On entire class:**
   ```
   Add logging statements to track file operations
   ```

5. **Select a complex method:**
   ```
   Add comments explaining the logic step-by-step
   ```

---

## 📋 Acceptance Criteria

- [ ] Used inline chat (`Ctrl+I`) at least 5 times
- [ ] Refactored methods with error handling
- [ ] Added input validation to all public methods
- [ ] Code handles file not found errors
- [ ] Code handles access denied errors
- [ ] Code handles invalid CSV format
- [ ] All async methods use proper await
- [ ] No blocking calls (.Result, .Wait())
- [ ] Code is more readable than starter
- [ ] Program runs without crashing

---

## 🧪 Test Scenarios

Create test files to verify error handling:

1. **Valid CSV file**: Should read successfully
2. **Missing file**: Should catch FileNotFoundException
3. **Empty file**: Should handle gracefully
4. **Invalid format**: Should catch format exceptions
5. **Permission denied**: Should catch UnauthorizedAccessException

---

## 💡 Inline Chat Tips

| Tip | Benefit |
|-----|---------|
| Be specific | "Add try-catch" vs "Add error handling for file operations" |
| One change at a time | Don't ask for multiple things in one request |
| Position cursor carefully | Place on method name, not in middle |
| Review before accepting | Look at the suggestion before pressing Tab |
| Use /explain if unsure | Ask Copilot to explain the changes |

---

## 🎓 Next Steps

Once you complete this exercise:
1. Review the [solution/FileProcessor.cs](solution/FileProcessor.cs)
2. Compare your refactored code with the solution
3. Notice how inline chat improved the code
4. **Basics section complete!** Ready for **02-Modes** section

---

## 📌 Key Takeaway

**Inline Chat is perfect for:**
- Quick refactors without writing long prompts
- Adding error handling to existing code
- Improving readability of complex logic
- Adding documentation
- Transforming code style (async, logging, etc.)

**NOT ideal for:**
- Complex algorithmic changes
- Major architectural decisions
- Generating entire new classes
