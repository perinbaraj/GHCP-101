# Exercise 2: String Handler — Copilot Chat & Inline Refactoring

**Difficulty:** Beginner | **Time:** 20-25 minutes | **Copilot Features:** Chat, Inline Refactoring, `/fix`

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Use Copilot Chat for complex code logic suggestions
- ✅ Apply inline refactoring to improve code readability
- ✅ Learn string manipulation best practices in C#
- ✅ Use `/fix` slash command to debug code issues
- ✅ Understand LINQ for functional string processing

---

## 📋 Requirements

Build a string utility class that:
1. **Reverses a string** — "hello" → "olleh"
2. **Converts to Title Case** — "hello world" → "Hello World"
3. **Counts vowels** — "hello" → 2
4. **Removes duplicates** — "aabbcc" → "abc"
5. **Checks if palindrome** — "racecar" → true
6. **Validates email format** — Basic regex validation
7. **Handles null/empty inputs** gracefully with meaningful errors

---

## 🤖 Copilot Prompting (Reference)

### **Try This Prompt**
Open Chat (`Ctrl+I`) and ask:
```
Create a StringUtility class with methods to reverse strings, convert to title case,
count vowels, remove duplicates, check palindromes, and validate emails.
Handle null inputs gracefully.
```

**🎯 Tips:** 
- Use `/fix` if you get stuck on a method
- Try inline refactoring to improve code
- Ask Copilot to refactor using LINQ

👉 **For multiple prompting strategies and complete solutions, see [SOLUTION_GUIDE.md](../SOLUTION_GUIDE.md)**

---

## 💻 Starter Code

### **starter/StringUtility.cs**
```csharp
namespace StringHandlerApp;

/// <summary>
/// Provides utility methods for string manipulation and validation.
/// </summary>
public class StringUtility
{
    /// <summary>
    /// Reverses the input string.
    /// </summary>
    public string ReverseString(string? input)
    {
        // TODO: Implement using Copilot
        throw new NotImplementedException();
    }

    /// <summary>
    /// Converts a string to Title Case (each word capitalized).
    /// </summary>
    public string ToTitleCase(string? input)
    {
        // TODO: Implement using Copilot
        throw new NotImplementedException();
    }

    /// <summary>
    /// Counts the number of vowels in a string.
    /// </summary>
    public int CountVowels(string? input)
    {
        // TODO: Implement using Copilot (try LINQ)
        throw new NotImplementedException();
    }

    /// <summary>
    /// Removes consecutive duplicate characters.
    /// </summary>
    public string RemoveDuplicates(string? input)
    {
        // TODO: Implement using Copilot
        throw new NotImplementedException();
    }

    /// <summary>
    /// Checks if a string is a palindrome.
    /// </summary>
    public bool IsPalindrome(string? input)
    {
        // TODO: Implement using Copilot
        throw new NotImplementedException();
    }

    /// <summary>
    /// Validates an email address using basic regex pattern.
    /// </summary>
    public bool ValidateEmail(string? email)
    {
        // TODO: Implement using Copilot (use Regex)
        throw new NotImplementedException();
    }
}
```

### **starter/Program.cs**
```csharp
using StringHandlerApp;

// TODO: Create an interactive program that:
// 1. Displays a menu of string operations
// 2. Takes user input
// 3. Performs the selected operation using StringUtility
// 4. Displays the result
// 5. Handles errors gracefully
// 6. Allows looping until user exits

var utility = new StringUtility();
Console.WriteLine("Welcome to String Handler!");
```

---

## ✅ Verification

- [ ] All methods compile without errors
- [ ] Methods handle null/empty inputs without crashing
- [ ] All string operations produce correct output
- [ ] Code uses LINQ where appropriate
- [ ] Error messages are clear and helpful
- [ ] Program accepts user input and displays results

---

## 🎓 Key Takeaways

- **Copilot Chat** excels at generating complete classes with multiple related methods
- **Inline refactoring** helps improve code quality incrementally
- **LINQ** is powerful for functional-style string/collection operations
- **Nullable reference types** (`string?`) help catch null errors early
- **Regex** is useful for pattern matching (email validation)

---

## 📚 Next Steps

✅ Complete this exercise → Move to **03-ArrayOperations** (arrays with `/tests`)

