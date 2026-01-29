# Exercise 3: Array Operations — Self-Assessment Checklist

---

## ✅ Feature Completeness

- [ ] FindMaximum returns correct maximum value
- [ ] FindMinimum returns correct minimum value
- [ ] CalculateAverage returns correct average
- [ ] FilterEvenNumbers returns only even numbers
- [ ] SortDescending returns array sorted in descending order
- [ ] RemoveNulls removes null values correctly
- [ ] ChunkArray splits array into correct chunks
- [ ] All methods handle empty arrays without crashing
- [ ] All methods handle single element arrays
- [ ] All methods handle negative numbers correctly

---

## 💻 Code Quality

- [ ] Code compiles without errors
- [ ] Methods use LINQ for cleaner implementations
- [ ] No hardcoded values or magic numbers
- [ ] Variable names are descriptive
- [ ] Methods are concise and focused
- [ ] No dead code or commented-out lines
- [ ] Consistent formatting and indentation

---

## 🧪 Unit Tests

- [ ] Unit tests generated using `/tests` command
- [ ] Tests cover normal operation cases
- [ ] Tests cover empty array edge case
- [ ] Tests cover single element edge case
- [ ] Tests cover negative numbers
- [ ] Tests cover null values (where applicable)
- [ ] All unit tests pass successfully
- [ ] Test class properly organized with xUnit

---

## 📝 Documentation

- [ ] All public methods have XML documentation
- [ ] XML docs include parameter descriptions
- [ ] XML docs include return value descriptions
- [ ] Test class has brief description comment
- [ ] Complex logic has inline comments

---

## 🔍 .NET Best Practices

- [ ] Using `int[]` or `int?[]` appropriately
- [ ] Null/empty array validation with `ArgumentException`
- [ ] Using LINQ methods (Max, Min, Where, OrderByDescending)
- [ ] Methods return correct types (int, double, int[], int[][])
- [ ] No modification of input arrays (functional approach)

---

## 🎯 Copilot Usage

- [ ] Used Copilot Chat to generate ArrayUtility class
- [ ] Used `/tests` to generate unit tests
- [ ] Reviewed and understood generated test cases
- [ ] All Copilot-generated code verified for correctness

---

## 📊 Summary

**Total Checks:** _____ / 40

- ✅ **30+/40:** Ready to move to Exercise 4
- ⚠️ **20-29/40:** Review and improve failing items
- ❌ **<20/40:** Complete more items before proceeding

---

## 💡 If You're Stuck

| Problem | Solution |
|---------|----------|
| Don't know LINQ syntax | Ask: `Show me LINQ methods to find max/min in an array` |
| Tests not compiling | Ask: `/fix` to debug test code |
| Need more test cases | Ask: `Generate edge case tests for array with null values` |
| Not sure about xUnit | Use: `/explain` on generated test code |

