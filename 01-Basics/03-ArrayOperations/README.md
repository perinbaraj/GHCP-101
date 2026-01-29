# Exercise 3: Array Operations — Unit Tests with `/tests`

**Difficulty:** Beginner-Intermediate | **Time:** 25-30 minutes | **Copilot Features:** `/tests`, Chat, Autocomplete

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Use `/tests` slash command to generate unit tests
- ✅ Learn collection manipulation with LINQ
- ✅ Write testable code that's easy to verify
- ✅ Understand xUnit testing framework basics
- ✅ Apply single responsibility principle to methods

---

## 📋 Requirements

Build an array utility class with methods for:
1. **Find Maximum** — Find the largest element
2. **Find Minimum** — Find the smallest element
3. **Calculate Average** — Compute mean of elements
4. **Filter Even Numbers** — Return only even elements
5. **Sort Descending** — Sort array in descending order
6. **Remove Nulls** — Filter out null values
7. **Chunk Array** — Split into groups of n elements
8. All methods must handle edge cases (empty arrays, single elements)

---

## 🤖 Copilot Prompting (Reference)

### **Try This Prompt**
Open Chat (`Ctrl+I`) and ask:
```
Create an ArrayUtility class with methods to find max/min, calculate average,
filter even numbers, sort descending, remove nulls, and chunk arrays.
Use LINQ. Then generate unit tests using /tests.
```

**🎯 Tips:**
- After implementing, select your class and use `/tests` for test generation
- Ask Copilot to add edge case tests
- Verify all tests pass before moving on

👉 **For detailed solutions and test examples, see [SOLUTION_GUIDE.md](../SOLUTION_GUIDE.md)**

---

## 💻 Starter Code

### **starter/ArrayUtility.cs**
```csharp
namespace ArrayOperationsApp;

/// <summary>
/// Provides utility methods for array manipulation and analysis.
/// </summary>
public class ArrayUtility
{
    public int FindMaximum(int[] array) { throw new NotImplementedException(); }
    public int FindMinimum(int[] array) { throw new NotImplementedException(); }
    public double CalculateAverage(int[] array) { throw new NotImplementedException(); }
    public int[] FilterEvenNumbers(int[] array) { throw new NotImplementedException(); }
    public int[] SortDescending(int[] array) { throw new NotImplementedException(); }
    public int[] RemoveNulls(int?[] array) { throw new NotImplementedException(); }
    public int[][] ChunkArray(int[] array, int chunkSize) { throw new NotImplementedException(); }
}
```

### **starter/ArrayUtility.Tests.cs**
```csharp
using Xunit;
using ArrayOperationsApp;

namespace ArrayOperationsApp.Tests;

public class ArrayUtilityTests
{
    // TODO: Use Copilot's /tests command to generate comprehensive tests
    // Tests should cover:
    // - Normal cases
    // - Empty arrays
    // - Single element arrays
    // - Null values
    // - Negative numbers
}
```

---

## ✅ Verification

- [ ] All methods compile
- [ ] All generated tests pass
- [ ] Edge cases are handled (empty, single element, nulls)
- [ ] LINQ is used for cleaner code
- [ ] Test coverage is comprehensive

---

## 🎓 Key Takeaways

- **`/tests` slash command** automatically generates test cases and edge cases
- **xUnit** is a popular modern .NET testing framework
- **LINQ methods** like `.Max()`, `.Min()`, `.Where()`, `.OrderByDescending()` simplify array operations
- **Testable code** is code that's decoupled and has single responsibility
- **Edge case testing** catches bugs before production

---

## 📚 Next Steps

✅ Complete this exercise → Move to **04-FileProcessor** (file I/O with `/explain`)

