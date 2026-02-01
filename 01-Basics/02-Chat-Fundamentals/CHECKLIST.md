# Exercise 3: Chat Fundamentals — Self-Assessment Checklist

---

## ✅ Copilot Chat Feature Usage

- [ ] Used `@workspace` to understand project structure
- [ ] Used `@vscode` to reference VS Code features (if applicable)
- [ ] Used `#file` to reference entire ArrayUtility class
- [ ] Used `#selection` to refactor at least one method
- [ ] Used `#terminalSelection` if tests failed (if applicable)
- [ ] Used `/doc` to generate documentation
- [ ] Used `/tests` to generate unit tests
- [ ] Used `/explain` to understand complex LINQ
- [ ] Used `/fix` to debug failing tests (if needed)
- [ ] Wrote clear, specific prompts (not vague questions)

---

## ✅ Feature Completeness

- [ ] FindMaximum returns correct maximum value
- [ ] FindMaximum handles single element
- [ ] FindMaximum handles negative numbers
- [ ] FindMinimum returns correct minimum value
- [ ] FindMinimum handles single element
- [ ] CalculateAverage returns correct average as double
- [ ] CalculateAverage handles single element
- [ ] FilterEvenNumbers returns only even numbers
- [ ] FilterEvenNumbers returns empty array if no evens
- [ ] SortDescending returns array sorted descending
- [ ] RemoveNulls filters out null values
- [ ] RemoveNulls preserves non-null values
- [ ] ChunkArray splits array correctly into chunks
- [ ] ChunkArray handles remainder chunk correctly

---

## 💻 Code Quality

- [ ] Code compiles without errors
- [ ] All methods use LINQ for clean implementations
- [ ] No hardcoded values or magic numbers
- [ ] Variable names are descriptive
- [ ] Methods are concise and focused
- [ ] Consistent formatting and indentation
- [ ] Edge cases handled (empty arrays, null values)
- [ ] No dead code or commented-out lines

---

## 🧪 Unit Tests

- [ ] Tests generated using `/tests` command
- [ ] Tests compile and run successfully
- [ ] Tests cover normal operation cases
- [ ] Tests cover empty array edge case
- [ ] Tests cover single element edge case
- [ ] Tests cover negative numbers
- [ ] Tests cover null values (where applicable)
- [ ] All unit tests pass successfully
- [ ] Test class properly organized with xUnit
- [ ] Test method names are descriptive
- [ ] Tests use `Assert` statements correctly

---

## 📝 Documentation

- [ ] All public methods have XML documentation
- [ ] XML docs include parameter descriptions
- [ ] XML docs include return value descriptions
- [ ] XML docs include examples (if complex)
- [ ] Test class has brief description comment
- [ ] Complex LINQ logic has inline comments
- [ ] Slash command output reviewed and kept if useful

---

## 🔍 .NET Best Practices

- [ ] Using `int[]` or `int?[]` appropriately
- [ ] Null/empty array validation with `ArgumentException`
- [ ] Using LINQ methods (Max, Min, Where, OrderByDescending, etc.)
- [ ] Methods return correct types (int, double, int[], int[][])
- [ ] No modification of input arrays (functional approach)
- [ ] Efficient algorithms - no unnecessary iterations

---

## 🎯 Chat Usage Quality

- [ ] Prompts were specific and clear
- [ ] Used @ and # commands strategically
- [ ] Slash commands were used appropriately
- [ ] Reviewed Copilot suggestions before accepting
- [ ] Iterated on prompts when results weren't perfect
- [ ] Used `/explain` to verify understanding
- [ ] Used `/fix` to resolve issues

---

## 📊 Summary

**Total Checks:** _____ / 60

- ✅ **45+/60:** Ready to move to Exercise 4 — **Inline Chat Refactoring**
- ⚠️ **33-44/60:** Review and improve failing items
- ❌ **<33/60:** Complete more items before proceeding

---

## 💡 Reflection Questions

1. **Which @ or # commands were most useful?** Why?
2. **How did `/tests` compare to writing tests manually?**
3. **Did `/explain` help you understand the LINQ?**
4. **How would you improve your chat prompts next time?**
5. **Which feature (autocomplete vs comment-to-code vs chat) feels most productive?**

---

## 🔄 Chat Command Reference

Save this for future exercises:

**Context Commands (@)**
- `@workspace` → full project context
- `@vscode` → editor/extension settings
- `@terminal` → terminal history

**Code Selection (#)**
- `#file` → entire current file
- `#selection` → highlighted code
- `#terminalSelection` → terminal output

**Action Commands (/)**
- `/doc` → generate documentation
- `/tests` → generate unit tests
- `/explain` → explain code
- `/fix` → debug code
