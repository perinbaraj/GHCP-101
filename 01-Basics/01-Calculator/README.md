# Exercise 1: Simple Calculator — Copilot Autocomplete & Code Generation

**Difficulty:** Beginner | **Time:** 15-20 minutes | **Copilot Features:** Autocomplete, Chat, `/doc`

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Use Copilot autocomplete to generate method implementations
- ✅ Apply `/doc` slash command to generate XML documentation
- ✅ Learn basic C# naming conventions (PascalCase for methods)
- ✅ Understand async/await patterns in console applications

---

## 📋 Requirements

Build a console calculator that:
1. **Accepts two numbers** from user input
2. **Supports basic operations:** Addition, Subtraction, Multiplication, Division
3. **Handles edge cases:** Division by zero, invalid input
4. **Uses async/await** for any I/O operations
5. **Includes XML documentation** for all public methods

### **Example Usage**
```
Enter first number: 10
Enter operation (+, -, *, /): +
Enter second number: 5
Result: 15
```

---

## 🤖 Copilot Prompting (Reference)

### **Try This Prompt**
Open Chat (`Ctrl+I`) and describe what you want to build:
```
Create a C# Calculator class with Add, Subtract, Multiply, Divide methods.
Handle division by zero. Then create a Program.cs that uses it.
```

**🎯 Tip:** After you implement, use `/doc` to generate documentation and `/explain` to understand your code better.

👉 **For detailed prompting approaches and complete solutions, see [SOLUTION_GUIDE.md](../SOLUTION_GUIDE.md)**

---

## 📁 File Structure

```
01-Calculator/
├── README.md (this file)
├── CHECKLIST.md
├── starter/
│   ├── Calculator.cs (partial, your job to complete)
│   ├── Program.cs (partial, your job to complete)
│   └── Calculator.csproj
└── solution/
    ├── Calculator.cs (reference)
    ├── Program.cs (reference)
    └── Calculator.csproj
```

---

## 🚀 Getting Started

1. **Open starter folder** in VS Code
2. **Review Calculator.cs** — See the method signatures
3. **Use Copilot Chat** to generate method bodies
4. **Review Program.cs** — See the program structure
5. **Implement the main logic** with Copilot's help
6. **Test manually** with sample inputs
7. **Generate XML docs** using `/doc` command
8. **Verify checklist** before finishing

---

## 💻 Starter Code

### **starter/Calculator.cs**
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
    public double Add(double a, double b)
    {
        // TODO: Implement using Copilot
        throw new NotImplementedException();
    }

    /// <summary>
    /// Subtracts the second number from the first.
    /// </summary>
    public double Subtract(double a, double b)
    {
        // TODO: Implement using Copilot
        throw new NotImplementedException();
    }

    /// <summary>
    /// Multiplies two numbers together.
    /// </summary>
    public double Multiply(double a, double b)
    {
        // TODO: Implement using Copilot
        throw new NotImplementedException();
    }

    /// <summary>
    /// Divides the first number by the second.
    /// Throws ArgumentException if divisor is zero.
    /// </summary>
    public double Divide(double a, double b)
    {
        // TODO: Implement with division by zero handling
        throw new NotImplementedException();
    }
}
```

### **starter/Program.cs**
```csharp
using CalculatorApp;

// TODO: Implement main program using Copilot
// 1. Get two numbers from user input
// 2. Get operation choice (+, -, *, /)
// 3. Perform calculation using Calculator class
// 4. Display result
// 5. Handle errors gracefully
```

### **starter/Calculator.csproj**
```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

</Project>
```

---

## ✅ Verification

Before moving to the next exercise, verify:
- Your code compiles without errors
- Calculator methods return correct results
- Division by zero is handled
- Input validation prevents crashes
- XML documentation is present on all public methods
- Program successfully runs end-to-end

---

## 🎓 Key Takeaways

- **Autocomplete** fills in common patterns when you start typing
- **Chat (`Ctrl+I`)** is great for generating entire functions
- **Slash commands** like `/doc` save time on documentation
- **Null safety** and **error handling** are essential in C#
- **Async/await** is the modern way to handle I/O in .NET

---

## 📚 Next Steps

✅ Complete this exercise → Move to **02-StringHandler** (string manipulation with Chat refactoring)

