# Exercise 2: Comment-To-Code — Self-Assessment Checklist

---

## ✅ Comment-to-Code Usage

- [ ] Wrote descriptive comments before each method
- [ ] Comments included examples (input → output)
- [ ] Comments specified edge cases (null, empty)
- [ ] Comments were specific enough for Copilot to understand
- [ ] Generated code for at least 3 methods using comments
- [ ] Generated code for all 6 methods using comments
- [ ] Rejected at least 1 generated suggestion and refined the comment
- [ ] Accepted all remaining suggestions after review

---

## ✅ Feature Completeness

- [ ] ReverseString correctly reverses text
- [ ] ReverseString handles null input gracefully
- [ ] ReverseString handles empty string input
- [ ] ToTitleCase properly capitalizes each word
- [ ] CountVowels accurately counts vowels (case-insensitive)
- [ ] CountVowels handles null/empty input
- [ ] RemoveDuplicates removes consecutive duplicate characters correctly
- [ ] IsPalindrome correctly identifies palindromes (case-insensitive)
- [ ] IsPalindrome handles null/empty input
- [ ] ValidateEmail validates basic email format
- [ ] All methods handle null input without crashing
- [ ] All methods handle empty string input gracefully
- [ ] Error messages are clear and helpful
- [ ] Interactive menu/program works end-to-end

---

## 💻 Code Quality

- [ ] Code compiles without errors
- [ ] Methods use clear, descriptive names (PascalCase)
- [ ] LINQ is used effectively in methods
- [ ] No hardcoded values or magic numbers
- [ ] Code is DRY (no unnecessary repetition)
- [ ] Consistent indentation throughout
- [ ] Meaningful variable names

---

## 🔍 .NET Best Practices

- [ ] Using `string?` (nullable reference types) for parameters
- [ ] Null checks present where needed
- [ ] Using `ArgumentException` or similar for invalid inputs
- [ ] Using `using System.Text.RegularExpressions` for Regex
- [ ] Methods return appropriate types
- [ ] No modification of input strings (functional approach)
- [ ] Efficient string operations (not repeated concatenation)

---

## 📝 Documentation

- [ ] All public methods have XML documentation
- [ ] XML docs include parameter descriptions
- [ ] XML docs include return value descriptions
- [ ] XML docs include examples in remarks
- [ ] Complex logic has inline comments explaining the "why"
- [ ] Comments are professional and clear

---

## 🧪 Testing

Manual Test Cases:
- [ ] Test: ReverseString("hello") = "olleh"
- [ ] Test: ReverseString("") = ""
- [ ] Test: ReverseString(null) = ""
- [ ] Test: ToTitleCase("hello world") = "Hello World"
- [ ] Test: CountVowels("hello") = 2
- [ ] Test: CountVowels("AEIOU") = 5
- [ ] Test: RemoveDuplicates("aabbcc") = "abc"
- [ ] Test: RemoveDuplicates("hello") = "helo"
- [ ] Test: IsPalindrome("racecar") = true
- [ ] Test: IsPalindrome("hello") = false
- [ ] Test: ValidateEmail("test@example.com") = true
- [ ] Test: ValidateEmail("invalid-email") = false
- [ ] Test: null input doesn't crash program
- [ ] Test: empty string handled correctly

---

## 🎯 Comment Quality

- [ ] Comments describe the "what" (transformation to perform)
- [ ] Comments describe the "how" (algorithm or approach)
- [ ] Comments include examples (input → output)
- [ ] Comments mention edge cases
- [ ] Comments are concise but complete
- [ ] Comments were a driving factor in code generation

---

## 📊 Summary

**Total Checks:** _____ / 54

- ✅ **40+/54:** Ready to move to Exercise 3 — **Chat Fundamentals**
- ⚠️ **30-39/54:** Review and improve failing items
- ❌ **<30/54:** Complete more items before proceeding

---

## 💡 Reflection Questions

1. **Which comments were most effective?** (Examples? Edge cases? Both?)
2. **When did Copilot misunderstand?** (What could you have clarified?)
3. **Did comments improve the code review process?** (Easier to understand intent?)
4. **How does comment-to-code compare to autocomplete?** (Which feels more natural?)

---

## 🔄 Iteration Strategy

If a Copilot suggestion was incorrect:
1. **Analyze** what went wrong
2. **Refine** the comment to be more specific
3. **Try again** with updated comment
4. **Document** what worked in the final version

This iterative approach mirrors real development!
