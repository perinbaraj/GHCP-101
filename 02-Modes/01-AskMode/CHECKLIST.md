# Exercise 5: Ask Mode — Self-Assessment Checklist

---

## ✅ Issues Identified & Fixed

Using Ask Mode, identify and document these issues:

- [ ] Issue 1: Identified (document what it is)
- [ ] Issue 1: Fixed (show the solution)
- [ ] Issue 2: Identified
- [ ] Issue 2: Fixed
- [ ] Issue 3: Identified
- [ ] Issue 3: Fixed
- [ ] Issue 4: Identified
- [ ] Issue 4: Fixed
- [ ] Issue 5: Identified
- [ ] Issue 5: Fixed

---

## 🏗️ Architecture Improvements

- [ ] Created IUserRepository interface
- [ ] Refactored UserRepository to implement interface
- [ ] Replaced loops with LINQ methods
- [ ] Added proper exception handling
- [ ] Configured dependency injection in Program.cs
- [ ] Updated UserController to use injected IUserRepository
- [ ] Removed direct instantiation of UserRepository

---

## 🧪 Testing & Validation

- [ ] GetUserById returns correct user
- [ ] GetUserById throws KeyNotFoundException for invalid ID
- [ ] FilterByAge returns correct age range
- [ ] GetAllUsers returns all users without exposing internal list
- [ ] UpdateUser updates correctly
- [ ] DeleteUser removes user successfully
- [ ] Controller tests use mocked repository
- [ ] Unit tests pass (70%+ coverage)

---

## 💻 Code Quality

- [ ] Code compiles without errors
- [ ] LINQ used instead of manual loops
- [ ] Null safety properly implemented
- [ ] Consistent naming conventions
- [ ] Proper logging/error messages
- [ ] No magic numbers or hardcoded values

---

## 🤖 Copilot Research

- [ ] Asked Copilot to analyze code issues
- [ ] Asked about Repository Pattern best practices
- [ ] Asked about Service Pattern vs Repository Pattern
- [ ] Asked about dependency injection benefits
- [ ] Asked about interface-based design
- [ ] Reviewed Copilot's recommendations

---

## 📝 Documentation

- [ ] Interface methods documented with XML comments
- [ ] Exception types documented
- [ ] Controller methods have response type attributes
- [ ] Complex logic has inline comments

---

## 📊 Summary

**Total Checks:** _____ / 43

- ✅ **32+/43:** Ready to move to Exercise 6 (Edit Mode)
- ⚠️ **22-31/43:** Review and improve failing items
- ❌ **<22/43:** Ask Copilot more research questions

---

## 💡 Key Learnings

**Patterns Learned:**
- [ ] Repository Pattern understood
- [ ] Service Pattern understood
- [ ] Dependency Injection understood
- [ ] Interface-based design understood

**Debugging Skills:**
- [ ] Can identify architectural anti-patterns
- [ ] Can ask effective research questions to Copilot
- [ ] Can refactor based on best practices

