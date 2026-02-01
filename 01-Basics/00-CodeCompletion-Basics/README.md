# Exercise 1: Code Completion Basics — Autocomplete & Tab Completion

**Difficulty:** Beginner | **Time:** 15-20 minutes | **Copilot Features:** Autocomplete, Tab Completion, Multi-line Suggestions

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Understand how GitHub Copilot autocomplete works
- ✅ Practice using Tab to accept code suggestions
- ✅ Learn to trigger autocomplete at the right moments
- ✅ Recognize when Copilot provides accurate vs. incorrect suggestions
- ✅ Use multi-line suggestions for faster coding
- ✅ Apply basic C# naming conventions

---

## 📋 Requirements

Build a simple calculator class where you:
1. **Let Copilot autocomplete** method signatures
2. **Accept suggestions** using Tab key
3. **Review before accepting** multi-line suggestions
4. **Implement basic operations:** Addition, Subtraction, Multiplication, Division
5. **Handle edge cases:** Division by zero
6. **Use PascalCase** naming convention (let Copilot enforce this)

### **Example Autocomplete Workflow**
```
Type: public double Add(
[Copilot autocompletes: double a, double b)]
Accept with Tab
Type: {
[Copilot suggests: return a + b;]
Accept with Tab
```

---

## 🤖 How Copilot Autocomplete Works

### **Triggering Autocomplete**
- **Automatic**: Copilot suggests after typing method names, variable declarations
- **Manual**: Press `Ctrl+Space` to trigger autocomplete popup
- **Disable**: Press `Escape` to dismiss suggestions

### **Accepting Suggestions**
- **Tab**: Accept the entire suggestion
- **Ctrl+Right Arrow**: Accept word-by-word
- **Arrow Keys**: Cycle through multiple suggestions
- **Escape**: Reject and dismiss

### **Key Tips**
- ✅ More context = better suggestions (write clear method signatures first)
- ✅ Let Copilot complete entire method bodies in one go
- ✅ If suggestion is wrong, press Escape and type manually
- ✅ Watch the suggestion ghost text — it's free!

---

## 📁 File Structure

```
01-CodeCompletion-Basics/
├── README.md (this file)
├── CHECKLIST.md
├── starter/
│   ├── Calculator.cs (partial - use autocomplete to complete)
│   ├── Program.cs (partial - use autocomplete to complete)
│   └── Calculator.csproj
└── solution/
    ├── Calculator.cs (reference)
    ├── Program.cs (reference)
    └── Calculator.csproj
```

---

## 🚀 Getting Started

1. **Open `starter/Calculator.cs`** in VS Code
2. **Read the method signatures** already provided
3. **Position cursor** at the end of the first method signature
4. **Type `{`** and wait for Copilot suggestion
5. **Press Tab** to accept the autocomplete suggestion
6. **Repeat** for each method
7. **Review all code** before testing
8. **Test manually** with sample inputs
9. **Complete the checklist** below

---

## 💻 Starter Code

### **starter/Calculator.cs**
```csharp
namespace CodeCompletionApp;

/// <summary>
/// A simple calculator demonstrating Copilot autocomplete.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Adds two numbers together.
    /// </summary>
    public double Add(double a, double b)
    {
        // TODO: Let Copilot autocomplete - type { and press Tab
    }

    /// <summary>
    /// Subtracts b from a.
    /// </summary>
    public double Subtract(double a, double b)
    {
        // TODO: Let Copilot autocomplete
    }

    /// <summary>
    /// Multiplies two numbers.
    /// </summary>
    public double Multiply(double a, double b)
    {
        // TODO: Let Copilot autocomplete
    }

    /// <summary>
    /// Divides a by b with zero check.
    /// </summary>
    public double Divide(double a, double b)
    {
        // TODO: Let Copilot autocomplete - but verify division by zero handling!
        if (b == 0)
        {
            throw new ArgumentException("Cannot divide by zero");
        }
    }
}
```

### **starter/Program.cs**
```csharp
using CodeCompletionApp;

class Program
{
    static void Main()
    {
        // TODO: Let Copilot autocomplete the rest
        var calculator = new Calculator();
        
        // Example usage - let Copilot suggest
        Console.WriteLine("Enter first number: ");
    }
}
```

---

## 🎯 Copilot Autocomplete Patterns to Practice

### **Pattern 1: Method Body Autocomplete**
```csharp
public string Greet(string name)
{
    // Type: return
    // Copilot suggests: return $"Hello, {name}!";
    // Accept with Tab
}
```

### **Pattern 2: Variable Declaration Autocomplete**
```csharp
var result = calculator.Add(10, 5);
// Copilot suggests: Console.WriteLine(result);
```

### **Pattern 3: Loop/Conditional Autocomplete**
```csharp
for (int i = 0; i < 10; i++)
{
    // Copilot suggests: Console.WriteLine(i);
}
```

### **Pattern 4: Multi-line Suggestions**
- Type a few lines of code
- Copilot suggests completing the entire block
- Review before accepting

---

## 📋 Acceptance Criteria

- [ ] All methods compile without errors
- [ ] Autocomplete was used for at least 80% of method implementations
- [ ] Division by zero is handled correctly
- [ ] Program runs without crashing
- [ ] Results are mathematically correct
- [ ] Code follows C# naming conventions
- [ ] All suggestions were reviewed before accepting

---

## 💡 If Copilot Autocomplete Doesn't Trigger

| Situation | Solution |
|-----------|----------|
| No suggestion appearing | Wait 1-2 seconds, or press `Ctrl+Space` to trigger |
| Suggestion is wrong | Press `Escape` and type manually |
| Multiple suggestions shown | Use arrow keys to browse alternatives |
| Autocomplete disabled | Check VS Code settings: `GitHub Copilot: Autocomplete` enabled? |

---

## 📊 Self-Assessment

**Total autocomplete interactions:** _____
**Accepted suggestions:** _____ / Total (ratio: ____%)
**Rejected/manually typed:** _____

- ✅ **80%+**: Great! You're mastering autocomplete
- ⚠️ **50-79%**: Good start, but try accepting more suggestions
- ❌ **<50%**: You might be too conservative - let Copilot help more!

---

## 🎓 Next Steps

Once you complete this exercise:
1. Review the [solution/Calculator.cs](solution/Calculator.cs) for reference
2. Compare your autocomplete journey with the solution
3. Notice patterns in what Copilot suggests well
4. Move to Exercise 2: **Comment-To-Code** for the next Copilot feature
