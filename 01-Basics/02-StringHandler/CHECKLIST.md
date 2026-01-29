# Exercise 2: String Handler — Self-Assessment Checklist

---

## ✅ Feature Completeness

- [ ] ReverseString correctly reverses text
- [ ] ToTitleCase properly capitalizes each word
- [ ] CountVowels accurately counts vowels (case-insensitive)
- [ ] RemoveDuplicates removes consecutive duplicate characters
- [ ] IsPalindrome correctly identifies palindromes (case-insensitive)
- [ ] ValidateEmail validates basic email format
- [ ] All methods handle null input without crashing
- [ ] All methods handle empty string input gracefully
- [ ] Error messages are clear and helpful
- [ ] Interactive menu works end-to-end

---

## 💻 Code Quality

- [ ] Code compiles without errors
- [ ] Methods use clear, descriptive names (PascalCase)
- [ ] LINQ is used in CountVowels method
- [ ] No hardcoded values or magic numbers
- [ ] Code is DRY (no unnecessary repetition)
- [ ] Consistent indentation throughout
- [ ] Meaningful variable names (not x, y, temp)

---

## 🔍 .NET Best Practices

- [ ] Using `string?` (nullable reference types) for parameters
- [ ] Null checks present where needed
- [ ] Using `ArgumentException` or similar for invalid inputs
- [ ] Using `using System.Text.RegularExpressions` for Regex
- [ ] Methods return appropriate types (string, int, bool)
- [ ] No modification of input strings (functional approach)

---

## 📝 Documentation

- [ ] All public methods have XML documentation
- [ ] XML docs include parameter descriptions
- [ ] XML docs include return value descriptions
- [ ] Complex logic has inline comments

---

## 🧪 Testing

Manual Test Cases:
- [ ] Test: ReverseString("hello") = "olleh"
- [ ] Test: ToTitleCase("hello world") = "Hello World"
- [ ] Test: CountVowels("hello") = 2
- [ ] Test: RemoveDuplicates("aabbcc") = "abc"
- [ ] Test: IsPalindrome("racecar") = true
- [ ] Test: IsPalindrome("hello") = false
- [ ] Test: ValidateEmail("test@example.com") = true
- [ ] Test: ValidateEmail("invalid-email") = false
- [ ] Test: null input doesn't crash program
- [ ] Test: empty string handled correctly

---

## 🎯 Copilot Usage

- [ ] Used Copilot Chat to generate StringUtility class
- [ ] Used inline refactoring to improve at least one method
- [ ] Attempted `/fix` to debug any issues
- [ ] Verified all Copilot-generated code for correctness

---

## 📊 Summary

**Total Checks:** _____ / 43

- ✅ **30+/43:** Ready to move to Exercise 3
- ⚠️ **20-29/43:** Review and improve failing items
- ❌ **<20/43:** Complete more items before proceeding

---

## 💡 If You're Stuck

| Problem | Solution |
|---------|----------|
| Methods not handling null | Ask: `How do I validate null strings in C#?` |
| LINQ syntax unclear | Use: `/explain` on LINQ code to understand |
| Regex pattern not working | Ask: `Generate a regex pattern for email validation` |
| Program crashes on input | Use: `/fix` to debug the issue |

