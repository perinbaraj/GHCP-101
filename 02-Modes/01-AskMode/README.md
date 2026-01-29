# Exercise 5: Ask Mode — Research & Debugging with Copilot

**Difficulty:** Intermediate | **Time:** 30-40 minutes | **Copilot Features:** Chat Research, Debugging, Pattern Analysis

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Use Copilot Chat for research and pattern discovery
- ✅ Debug complex issues with Copilot's help
- ✅ Understand common API design patterns
- ✅ Learn repository and service patterns
- ✅ Apply dependency injection in ASP.NET Core

---

## 📋 Task

You're given **legacy code with bugs and design issues**. Your job is to:

1. **Analyze the code** — Ask Copilot what patterns it uses
2. **Identify issues** — Use Ask mode to find logic errors
3. **Research solutions** — Ask about best practices
4. **Fix bugs** — Implement Copilot's suggestions
5. **Refactor for clarity** — Apply recommended patterns

---

## 🤖 Copilot Ask Mode (Reference)

### **Try This Prompt**
Paste the buggy UserRepository code into Chat and ask:
```
Analyze this code. What design patterns are missing? 
What issues do you see? How should I refactor it?
```

**🎯 Tip:** Ask follow-up questions like "Should I use dependency injection?" or "What's the repository pattern?"

👉 **For complete solutions and refactoring details, see [SOLUTION_GUIDE.md](../SOLUTION_GUIDE.md)**

---

## 💻 Starter Code (Intentionally Buggy)

### **starter/Models/User.cs**
```csharp
namespace AskModeApp.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public DateTime CreatedDate { get; set; }
}
```

### **starter/Repositories/UserRepository.cs** (Contains Issues)
```csharp
namespace AskModeApp.Repositories;

using AskModeApp.Models;

public class UserRepository
{
    private static List<User> _users = new();

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public User GetUserById(int id)
    {
        foreach (var user in _users)
        {
            if (user.Id == id)
                return user;
        }
        return null; // Issue: Could throw instead
    }

    public List<User> GetAllUsers()
    {
        return _users; // Issue: Exposes internal collection
    }

    public List<User> FilterByAge(int minAge, int maxAge)
    {
        var result = new List<User>();
        foreach (var user in _users)
        {
            if (user.Age >= minAge && user.Age <= maxAge)
                result.Add(user);
        }
        return result;
    }

    public void UpdateUser(int id, User updatedUser)
    {
        var user = GetUserById(id);
        if (user != null)
        {
            user.Name = updatedUser.Name;
            user.Age = updatedUser.Age;
            user.Email = updatedUser.Email;
        }
        // Issue: No indication if update succeeded
    }

    public bool DeleteUser(int id)
    {
        var user = GetUserById(id);
        if (user != null)
        {
            _users.Remove(user);
            return true;
        }
        return false;
    }
}
```

### **starter/Controllers/UserController.cs** (Incomplete)
```csharp
using AskModeApp.Models;
using AskModeApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AskModeApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly UserRepository _repository = new(); // Issue: Direct instantiation

    [HttpGet("{id}")]
    public IActionResult GetUser(int id)
    {
        // TODO: Ask Copilot how to structure this properly
        return Ok();
    }

    [HttpPost]
    public IActionResult CreateUser(User user)
    {
        // TODO: Ask Copilot about validation and return codes
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateUser(int id, User user)
    {
        // TODO: Ask Copilot about best practices
        return Ok();
    }
}
```

---

## 📋 Tasks to Complete

### **Step 1: Analyze Issues** (Using Ask Mode)
1. Open the code in your editor
2. Select UserRepository class
3. Open Chat and paste: `Analyze this code. What are the design issues?`
4. Document 3-5 issues Copilot identifies
5. Ask: `How would you fix these issues?`

### **Step 2: Research Patterns** (Using Ask Mode)
Ask Copilot:
```
What's the difference between Repository and Service patterns?
When should I use IRepository interface vs concrete class?
How does dependency injection improve testability?
```

### **Step 3: Fix the Code**
1. Create IUserRepository interface
2. Refactor UserRepository to use LINQ
3. Add proper null handling and return codes
4. Implement dependency injection in Controller

### **Step 4: Test Improvements**
1. Create unit tests using xUnit
2. Mock IUserRepository for testing Controller
3. Verify all CRUD operations work

---

## 🎓 Expected Improvements

**Before:**
- Direct instantiation of repository in controller
- Null returns instead of exceptions
- Loops instead of LINQ
- No interface abstraction
- No dependency injection

**After:**
- IUserRepository interface injected via DI container
- Proper exception handling (throws `KeyNotFoundException`)
- LINQ for filtering and querying
- Testable Controller with mocked repository
- Clean separation of concerns

---

## ✅ Verification

- [ ] Can identify 3+ issues in the buggy code
- [ ] Can explain what each issue causes
- [ ] Implemented IUserRepository interface
- [ ] Refactored to use LINQ
- [ ] Dependency injection configured in Program.cs
- [ ] Unit tests pass
- [ ] Controller tests use mocked repository
- [ ] All CRUD operations work correctly

---

## 💡 Key Concepts to Learn

- **Repository Pattern** — Abstracts data access layer
- **Service Pattern** — Adds business logic between controller and repository
- **Dependency Injection** — Loose coupling via constructor injection
- **Interface-based design** — Enables testing and flexibility
- **LINQ** — Modern alternative to loops

---

## 📚 Next Steps

✅ Complete this exercise → Move to **02-EditMode** (bulk refactoring)

