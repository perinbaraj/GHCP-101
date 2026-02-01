# Exercise 3: Chat Fundamentals — @, #, and Slash Commands

**Difficulty:** Beginner-Intermediate | **Time:** 25-30 minutes | **Copilot Features:** Chat (`Ctrl+I`), @workspace, @vscode, #file, #selection, Slash Commands (`/doc`, `/tests`, `/explain`, `/fix`)

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Understand Copilot Chat window and its capabilities
- ✅ Use @-commands to reference context (@workspace, @vscode, @terminal)
- ✅ Use #-commands to select code scope (#file, #selection)
- ✅ Master slash commands (/doc, /tests, /explain, /fix)
- ✅ Write effective prompts that reference code
- ✅ Generate tests using `/tests` command
- ✅ Understand unit testing with xUnit

---

## 💡 Copilot Chat Context Commands

### **@-Commands (What context to include)**

| Command | Purpose | Example |
|---------|---------|---------|
| `@workspace` | Reference entire project structure | `@workspace how should I organize this utility?` |
| `@vscode` | Reference VS Code settings/features | `@vscode how do I configure debug settings?` |
| `@terminal` | Reference terminal history/output | `@terminal why did the build fail?` |
| (No prefix) | Reference current file | `Create error handling for this method` |

### **#-Commands (Which code to reference)**

| Command | Purpose | Example |
|---------|---------|---------|
| `#file` | Include entire current file | `#file make this more efficient` |
| `#selection` | Include selected code only | Select method, then `#selection add logging` |
| `#terminalSelection` | Reference terminal output | `#terminalSelection fix this error` |

### **Slash Commands (Specific actions)**

| Command | Purpose | When to use |
|---------|---------|------------|
| `/doc` | Generate XML documentation | After writing a method |
| `/tests` | Generate unit tests | After writing a class |
| `/explain` | Explain selected code | When code is unclear |
| `/fix` | Fix errors in code | When code has errors |

---

## 📋 Requirements

Build an array utility class where you:
1. **Use Copilot Chat** to design the class architecture
2. **Use `@workspace`** to understand project structure
3. **Use `#file`** to reference entire implementations
4. **Use `#selection`** to refactor specific methods
5. **Use `/tests`** to generate comprehensive tests
6. **Use `/explain`** to understand complex LINQ
7. **Use `/fix`** to debug test failures
8. **Implement collection operations:**
   - Find Maximum, Minimum
   - Calculate Average
   - Filter Even Numbers
   - Sort Descending
   - Remove Nulls
   - Chunk Array
9. **Write xUnit tests** for all methods
10. **Verify all tests pass**

---

## 🎯 Chat Workflow Examples

### **Example 1: Using @workspace**
```
Question: @workspace Can you show me the structure of this solution?
Copilot: [Shows project structure, dependencies, organization]

Question: How should ArrayUtility integrate with the existing code?
Copilot: [Considers context from @workspace to provide architectural advice]
```

### **Example 2: Using #file with /tests**
```
Question: #file /tests Generate comprehensive xUnit tests for this class
Copilot: [Analyzes entire file, generates unit tests]
```

### **Example 3: Using #selection with /explain**
```
1. Select a complex LINQ statement in your code
2. Open Chat (Ctrl+I)
3. Type: #selection /explain what does this LINQ do?
Copilot: [Explains the selected code in detail]
```

### **Example 4: Using /fix**
```
1. Test fails with an error
2. Copy error message
3. Select the failing test code
4. Open Chat: #selection /fix this test failure: [paste error]
Copilot: [Suggests fix]
```

---

## 📁 File Structure

```
02-Chat-Fundamentals/
├── README.md (this file)
├── CHECKLIST.md
├── starter/
│   ├── ArrayUtility.cs (method signatures)
│   ├── ArrayUtility.Tests.cs (empty test class)
│   ├── Program.cs
│   └── ArrayUtility.csproj
└── solution/
    ├── ArrayUtility.cs (reference)
    ├── ArrayUtility.Tests.cs (reference tests)
    ├── Program.cs
    └── ArrayUtility.csproj
```

---

## 🚀 Getting Started

### **Step 1: Understand the Project Structure**
1. Open Chat (`Ctrl+I`)
2. Type: `@workspace what's in this project?`
3. Review the output to understand the structure

### **Step 2: Generate Implementations**
1. Open `ArrayUtility.cs`
2. Open Chat (`Ctrl+I`)
3. Type: `#file Implement all the methods in this class`
4. Review suggestions and accept/modify

### **Step 3: Generate Tests**
1. Open Chat and select the method to test
2. Type: `#selection /tests Generate comprehensive tests`
3. Review and refine tests

### **Step 4: Fix Issues**
1. Run tests - if any fail
2. Open Chat
3. Type: `#selection /fix why is this test failing?`
4. Apply suggestions

### **Step 5: Document Code**
1. Select a complex method
2. Open Chat
3. Type: `#selection /explain this LINQ logic`
4. Understand the code better

---

## 💻 Starter Code

### **starter/ArrayUtility.cs**

```csharp
namespace ChatFundamentalsApp;

/// <summary>
/// Provides utility methods for array manipulation and analysis.
/// </summary>
public class ArrayUtility
{
    /// <summary>
    /// Finds the maximum value in an array.
    /// </summary>
    public int FindMaximum(int[] array)
    {
        // TODO: Use Chat to implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Finds the minimum value in an array.
    /// </summary>
    public int FindMinimum(int[] array)
    {
        // TODO: Use Chat to implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Calculates the average of array elements.
    /// </summary>
    public double CalculateAverage(int[] array)
    {
        // TODO: Use Chat to implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Filters and returns only even numbers.
    /// </summary>
    public int[] FilterEvenNumbers(int[] array)
    {
        // TODO: Use Chat to implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Sorts the array in descending order.
    /// </summary>
    public int[] SortDescending(int[] array)
    {
        // TODO: Use Chat to implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Removes null values from nullable integer array.
    /// </summary>
    public int[] RemoveNulls(int?[] array)
    {
        // TODO: Use Chat to implement
        throw new NotImplementedException();
    }

    /// <summary>
    /// Splits array into chunks of specified size.
    /// </summary>
    public int[][] ChunkArray(int[] array, int chunkSize)
    {
        // TODO: Use Chat to implement
        throw new NotImplementedException();
    }
}
```

### **starter/ArrayUtility.Tests.cs**

```csharp
using Xunit;
using ChatFundamentalsApp;

namespace ChatFundamentalsApp.Tests;

public class ArrayUtilityTests
{
    // TODO: Use /tests command to generate comprehensive tests
    // In Chat, select the ArrayUtility class and type: /tests
}
```

---

## 🎯 Key Chat Prompting Tips

1. **Be Specific**: `Generate LINQ-based implementations for array operations` vs `Write some code`
2. **Provide Context**: Use `@workspace` and `#file` to give Copilot more information
3. **Use Slash Commands**: `/tests`, `/explain`, `/fix` are powerful shortcuts
4. **One Task at a Time**: Ask for one operation per chat message
5. **Review Output**: Always review generated code before accepting
6. **Iterate**: If output isn't perfect, refine your prompt and try again

---

## 🧪 Testing Strategy

When using `/tests`:
- Copilot generates tests for normal cases
- You should add edge cases manually:
  - Empty arrays
  - Single element arrays
  - Arrays with negative numbers
  - Null values (where applicable)

---

## 📋 Acceptance Criteria

- [ ] Used `@workspace` at least once
- [ ] Used `#file` to reference code
- [ ] Used `#selection` to refactor
- [ ] Used `/tests` to generate tests
- [ ] Used `/explain` to understand code
- [ ] Used `/fix` to resolve issues (if needed)
- [ ] All methods implemented
- [ ] All tests pass
- [ ] Edge cases covered

---

## 💡 Chat Tips

| Scenario | What to Do |
|----------|-----------|
| Need to understand context | Start with `@workspace [question]` |
| Referencing specific code | Use `#file` or select and use `#selection` |
| Getting tests | Use `/tests` after selecting your class |
| Code is confusing | Select code and use `/explain` |
| Tests fail | Copy error and use `#selection /fix` |

---

## 🎓 Next Steps

Once you complete this exercise:
1. Review the [solution/ArrayUtility.Tests.cs](solution/ArrayUtility.Tests.cs)
2. Compare your tests with the solution
3. Notice how `/tests` generated different tests
4. Move to Exercise 4: **Inline Chat Refactoring** for quick edits
