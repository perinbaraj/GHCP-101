# Exercise 1: Calculator — Self-Assessment Checklist

Complete each item before submitting. Mark with [x] when done.

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
- [ ] No hardcoded values (magic numbers)
- [ ] Consistent indentation (4 spaces)
- [ ] No dead code or commented-out lines
- [ ] Methods are focused on single responsibility

---

## 🔍 .NET Best Practices

- [ ] Using `double` for numeric operations
- [ ] Null checking for invalid inputs
- [ ] Using `ArgumentException` for invalid divisor
- [ ] Using PascalCase for method names (Add, Subtract, etc.)
- [ ] Using meaningful method names that describe what they do
- [ ] No `System.Console.WriteLine()` used directly in business logic (kept in Program.cs)

---

## 📝 Documentation

- [ ] All public methods have XML documentation (`/// <summary>`)
- [ ] XML docs include parameter descriptions if applicable
- [ ] XML docs include return value descriptions
- [ ] README objectives completed

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

## 🎯 Copilot Usage

- [ ] Used Copilot Chat (`Ctrl+I`) to generate at least one method
- [ ] Used `/doc` slash command to generate documentation
- [ ] Verified Copilot-generated code for correctness before acceptance

---

## 📊 Summary

**Total Checks:** _____ / 40

- ✅ **30+/40:** Ready to move to Exercise 2
- ⚠️ **20-29/40:** Review failing items and ask Copilot for help
- ❌ **<20/40:** Complete more items before proceeding

---

## 💡 If You're Stuck

| Problem | Solution |
|---------|----------|
| Don't know how to parse user input | Ask Copilot: `How do I read and parse user input in C#?` |
| Method not working | Highlight it and ask: `/explain` to understand the logic |
| Need unit tests | Ask Copilot: `/tests` to generate test cases |
| Want to improve code | Use Inline Chat (`Ctrl+Shift+Space`): `Refactor this method to be more readable` |

