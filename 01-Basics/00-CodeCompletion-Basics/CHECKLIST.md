# Exercise 1: Code Completion Basics — Self-Assessment Checklist

---

## ✅ Autocomplete Usage

- [ ] Used Copilot autocomplete to complete at least 1 method body
- [ ] Used Copilot autocomplete to complete at least 2 method bodies
- [ ] Used Copilot autocomplete to complete all method bodies
- [ ] Pressed Tab to accept suggestions (not arrow keys)
- [ ] Rejected at least 1 incorrect suggestion with Escape
- [ ] Used Ctrl+Space at least once to manually trigger autocomplete
- [ ] Accepted a multi-line suggestion successfully

---

## ✅ Feature Completeness

- [ ] Program accepts two numbers from user input
- [ ] Program accepts operation choice (+, -, *, /)
- [ ] Addition works correctly
- [ ] Subtraction works correctly
- [ ] Multiplication works correctly
- [ ] Division works correctly
- [ ] Division by zero displays error message instead of crashing
- [ ] Invalid operation input is handled gracefully
- [ ] Non-numeric input is handled gracefully
- [ ] Result is displayed to user

---

## 💻 Code Quality

- [ ] Code compiles without errors or warnings
- [ ] Variable names follow C# PascalCase convention (for public) / camelCase (for private)
- [ ] Methods are organized logically
- [ ] Consistent indentation (4 spaces)
- [ ] No dead code or commented-out lines
- [ ] Methods are focused on single responsibility

---

## 🔍 .NET Best Practices

- [ ] Using `double` for numeric operations
- [ ] Null checking for invalid inputs
- [ ] Using `ArgumentException` for invalid divisor
- [ ] Using PascalCase for method names (Add, Subtract, etc.)
- [ ] Using meaningful method names
- [ ] No `Console.WriteLine()` in business logic (kept in Program.cs)

---

## 📝 Documentation

- [ ] All public methods have XML documentation (`/// <summary>`)
- [ ] README objectives completed
- [ ] Autocomplete patterns understood

---

## 🧪 Testing

Manual Test Cases Completed:
- [ ] Test: 5 + 3 = 8
- [ ] Test: 10 - 4 = 6
- [ ] Test: 7 * 6 = 42
- [ ] Test: 20 / 5 = 4
- [ ] Test: 10 / 0 → Error message shown
- [ ] Test: "abc" as input → Error handled
- [ ] Test: Operation "%" → Error handled

---

## 📊 Summary

**Total Checks:** _____ / 38

- ✅ **28+/38:** Ready to move to Exercise 2 — **Comment-To-Code**
- ⚠️ **20-27/38:** Review failing items and try using more autocomplete
- ❌ **<20/38:** Complete more items before proceeding

---

## 💡 Autocomplete Tips & Tricks

| Tip | Benefit |
|-----|---------|
| Wait 1-2 seconds after typing | Gives Copilot time to generate suggestion |
| More context = better suggestion | Write clear signatures before accepting |
| Review before Tab | Don't blindly accept all suggestions |
| Use Escape liberally | It's okay to reject and type manually |
| Try Ctrl+Space if stuck | Forces autocomplete popup |

