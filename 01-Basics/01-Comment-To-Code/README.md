# Exercise 2: Comment-To-Code — Generate Code from Comments

**Difficulty:** Beginner | **Time:** 20-25 minutes | **Copilot Features:** Comment-to-Code, Chat, Code Generation

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Understand how to write effective comments for code generation
- ✅ Use Copilot to generate code from descriptive comments
- ✅ Learn the comment-driven development approach
- ✅ Practice iterative refinement with Copilot
- ✅ Review and validate Copilot-generated code
- ✅ Understand LINQ and string manipulation patterns

---

## 💡 What is Comment-to-Code?

**Comment-to-Code** is a development approach where you:
1. Write clear, descriptive comments explaining what you want
2. Position cursor after the comment
3. Copilot generates code matching your description
4. Review and refine as needed

### **Example Workflow**

```csharp
// Reverse the input string
// Result: "hello" becomes "olleh"
public string ReverseString(string input)
{
    // Type comment above, position here
    // Copilot suggests: return new string(input.Reverse().ToArray());
}
```

---

## 📋 Requirements

Build a string utility class where you:
1. **Write descriptive comments** for each method
2. **Let Copilot generate implementations** from comments
3. **Implement string operations:**
   - Reverse a string
   - Convert to Title Case
   - Count vowels (with specificity: which vowels?)
   - Remove duplicates (consecutive or all?)
   - Check if palindrome
   - Validate email format
4. **Handle edge cases:** null, empty strings
5. **Document each method** with XML comments

---

## 🎯 Writing Effective Comments for Code Generation

### **✅ GOOD Comments (Specific, Actionable)**
```csharp
// Reverse the input string by converting to char array, reversing, and joining back
public string ReverseString(string input)
{
    // Copilot generates good code
}

// Count vowels (a, e, i, o, u) case-insensitively
public int CountVowels(string input)
{
    // Clear specification helps Copilot
}
```

### **❌ VAGUE Comments (Ambiguous)**
```csharp
// Do something with the string
public string ReverseString(string input)
{
    // Too vague - Copilot guesses
}

// Count vowels
public int CountVowels(string input)
{
    // Doesn't specify case-sensitivity or which vowels
}
```

### **💎 EXCELLENT Comments (Describe Input/Output)**
```csharp
// Given a string, return it reversed
// Example: "hello" → "olleh"
// Edge cases: empty string returns empty, null returns empty string
public string ReverseString(string? input)
{
    // Copilot has all context needed
}
```

---

## 📁 File Structure

```
01-Comment-To-Code/
├── README.md (this file)
├── CHECKLIST.md
├── starter/
│   ├── StringUtility.cs (method signatures with comments)
│   ├── Program.cs (partial)
│   └── StringUtility.csproj
└── solution/
    ├── StringUtility.cs (reference implementation)
    ├── Program.cs (reference)
    └── StringUtility.csproj
```

---

## 🚀 Getting Started

1. **Open `starter/StringUtility.cs`** in VS Code
2. **Read the method signatures** and comments
3. **For first method**, position cursor after the comment block
4. **Let Copilot suggest code** (wait 1-2 seconds)
5. **Review the suggestion** carefully
6. **Accept (Tab) or modify** as needed
7. **Repeat for each method**
8. **Test all implementations** manually
9. **Complete the checklist**

---

## 💻 Starter Code

### **starter/StringUtility.cs**

```csharp
namespace CommentToCodeApp;

/// <summary>
/// Provides utility methods for string manipulation and validation.
/// All methods are implemented using comment-to-code approach.
/// </summary>
public class StringUtility
{
    /// <summary>
    /// Reverses the input string.
    /// Example: "hello" → "olleh"
    /// </summary>
    // Reverse the input string using char array or LINQ
    // Edge case: null or empty returns empty
    public string ReverseString(string? input)
    {
        // TODO: Let Copilot generate from comment above
        throw new NotImplementedException();
    }

    /// <summary>
    /// Converts a string to Title Case (each word capitalized).
    /// Example: "hello world" → "Hello World"
    /// </summary>
    // Convert each word to have first letter uppercase, rest lowercase
    // Example: "hello world" becomes "Hello World"
    public string ToTitleCase(string? input)
    {
        // TODO: Let Copilot generate from comment above
        throw new NotImplementedException();
    }

    /// <summary>
    /// Counts the number of vowels (a, e, i, o, u) in a string (case-insensitive).
    /// </summary>
    // Count vowels (a, e, i, o, u) case-insensitively
    // Use LINQ to filter and count
    // Example: "hello" has 2 vowels
    public int CountVowels(string? input)
    {
        // TODO: Let Copilot generate from comment above
        throw new NotImplementedException();
    }

    /// <summary>
    /// Removes consecutive duplicate characters.
    /// Example: "aabbcc" → "abc"
    /// </summary>
    // Remove consecutive duplicate characters, keep one
    // Example: "aabbcc" → "abc", "hello" → "helo" 
    public string RemoveDuplicates(string? input)
    {
        // TODO: Let Copilot generate from comment above
        throw new NotImplementedException();
    }

    /// <summary>
    /// Checks if a string is a palindrome (reads same forwards and backwards).
    /// </summary>
    // Check if the string is a palindrome
    // Case-insensitive, ignore spaces for checking
    // Example: "racecar" is a palindrome, "hello" is not
    public bool IsPalindrome(string? input)
    {
        // TODO: Let Copilot generate from comment above
        throw new NotImplementedException();
    }

    /// <summary>
    /// Validates basic email format using regex.
    /// </summary>
    // Validate basic email format: must contain @ and have text before and after
    // Use Regex for validation
    // Example: "test@example.com" is valid, "invalid-email" is not
    public bool ValidateEmail(string? input)
    {
        // TODO: Let Copilot generate from comment above
        throw new NotImplementedException();
    }
}
```

---

## 🎯 Comment-to-Code Patterns to Practice

### **Pattern 1: Transformation Logic**
```csharp
// Convert input string to uppercase using LINQ
public string ToUpperCase(string? input)
{
    // Copilot generates: return new string(input?.Select(char.ToUpper).ToArray() ?? Array.Empty<char>());
}
```

### **Pattern 2: Filtering with Conditions**
```csharp
// Filter to keep only alphabetic characters
public string RemoveNumbers(string? input)
{
    // Copilot generates: return new string(input?.Where(char.IsLetter).ToArray() ?? Array.Empty<char>());
}
```

### **Pattern 3: Aggregation/Counting**
```csharp
// Count consonants (all letters except a, e, i, o, u)
public int CountConsonants(string? input)
{
    // Copilot generates: return input?.Where(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c)).Count() ?? 0;
}
```

### **Pattern 4: Validation**
```csharp
// Check if string contains only digits
public bool IsNumeric(string? input)
{
    // Copilot generates: return !string.IsNullOrEmpty(input) && input.All(char.IsDigit);
}
```

---

## 📋 Acceptance Criteria

- [ ] All methods generated using comment-to-code approach
- [ ] Comments were clear and specific
- [ ] Code compiles without errors
- [ ] All string operations work correctly
- [ ] Edge cases (null, empty) handled properly
- [ ] LINQ used where appropriate
- [ ] Code reviewed for correctness before accepting

---

## 🧪 Testing Examples

Try these test cases in `Program.cs`:

```csharp
var util = new StringUtility();

// Test ReverseString
Console.WriteLine(util.ReverseString("hello"));        // olleh
Console.WriteLine(util.ReverseString(""));             // (empty)
Console.WriteLine(util.ReverseString(null));           // (empty)

// Test ToTitleCase
Console.WriteLine(util.ToTitleCase("hello world"));    // Hello World

// Test CountVowels
Console.WriteLine(util.CountVowels("hello"));          // 2
Console.WriteLine(util.CountVowels("AEIOU"));          // 5

// Test RemoveDuplicates
Console.WriteLine(util.RemoveDuplicates("aabbcc"));    // abc
Console.WriteLine(util.RemoveDuplicates("hello"));     // helo

// Test IsPalindrome
Console.WriteLine(util.IsPalindrome("racecar"));       // true
Console.WriteLine(util.IsPalindrome("hello"));         // false

// Test ValidateEmail
Console.WriteLine(util.ValidateEmail("test@example.com"));   // true
Console.WriteLine(util.ValidateEmail("invalid-email"));      // false
```

---

## 💡 Tips for Success

1. **Start with clear comments** — The better your comment, the better Copilot's code
2. **Include examples** — Showing input/output helps Copilot understand intent
3. **Be specific about edge cases** — Mention null, empty, special cases
4. **Review before accepting** — Don't blindly trust suggestions
5. **Iterate if needed** — If code is wrong, refine the comment and try again

---

## 🎓 Next Steps

Once you complete this exercise:
1. Review the [solution/StringUtility.cs](solution/StringUtility.cs)
2. Compare your comments with the solution
3. Notice how different comment styles produce different code
4. Move to Exercise 3: **Chat Fundamentals** for advanced prompting
