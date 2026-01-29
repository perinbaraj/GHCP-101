# Exercise 4: File Processor — Self-Assessment Checklist

---

## ✅ Feature Completeness

- [ ] Reads CSV file and parses header row correctly
- [ ] Returns data as list of dictionaries
- [ ] Writes CSV file with proper formatting
- [ ] Counts file lines accurately
- [ ] FilterLinesAsync works with custom predicates
- [ ] CSV to JSON conversion produces valid JSON
- [ ] File not found errors are caught and reported
- [ ] File access errors are handled gracefully
- [ ] Program completes without crashing
- [ ] Results are displayed to user

---

## 💻 Code Quality

- [ ] Code compiles without errors
- [ ] All methods use async/await correctly
- [ ] No blocking calls (`.Result`, `.Wait()`)
- [ ] LINQ used for filtering and transformation
- [ ] Variable names are clear and descriptive
- [ ] No hardcoded file paths (parameterized)
- [ ] Consistent formatting and indentation

---

## 🔍 .NET Best Practices

- [ ] Using `async/await` throughout
- [ ] Using `Task<T>` return types for async methods
- [ ] Using `System.IO.File` or `StreamReader` for I/O
- [ ] Using `System.Text.Json` for JSON serialization
- [ ] Proper exception handling with try-catch
- [ ] Null checks on file paths and data

---

## 📝 Documentation

- [ ] All public methods have XML documentation
- [ ] XML docs explain async nature of methods
- [ ] Complex logic has inline comments
- [ ] Error handling is documented

---

## 🧪 Testing

Manual Test Cases:
- [ ] Read valid CSV file successfully
- [ ] Write CSV file creates readable output
- [ ] Count lines returns correct number
- [ ] Filter lines returns only matching lines
- [ ] CSV to JSON conversion produces valid JSON
- [ ] FileNotFoundException handled gracefully
- [ ] UnauthorizedAccessException handled
- [ ] Invalid file format doesn't crash
- [ ] Large file processing completes in reasonable time

---

## ⏱️ Performance

- [ ] File operations don't freeze the UI
- [ ] Async methods complete without blocking
- [ ] Large files handled efficiently (no memory overload)

---

## 🎯 Copilot Usage

- [ ] Used Copilot Chat to generate FileProcessor class
- [ ] Used `/explain` to understand async/await patterns
- [ ] Reviewed and understood error handling code
- [ ] All Copilot-generated code verified for correctness

---

## 📊 Summary

**Total Checks:** _____ / 42

- ✅ **30+/42:** Basics section complete! Move to Section 2 - **Modes**
- ⚠️ **20-29/42:** Review and improve failing items
- ❌ **<20/42:** Complete more items before proceeding

---

## 💡 If You're Stuck

| Problem | Solution |
|---------|----------|
| Don't understand async/await | Use: `/explain` on an async method |
| File not being read | Ask: `How do I read a CSV file in C# with proper error handling?` |
| JSON serialization failing | Ask: `Generate code to serialize C# objects to JSON` |
| Performance issues | Ask: `How do I efficiently read and process large files?` |

