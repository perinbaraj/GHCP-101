# Exercise Guidelines & Best Practices

---

## 📋 Exercise Structure

Each exercise follows a consistent format:

```
exercise-name/
├── README.md          # Learning objectives, requirements, prompting tips
├── CHECKLIST.md       # Self-assessment criteria
├── starter/           # Boilerplate code to complete
│   ├── *.cs files
│   └── *.csproj
└── solution/          # Reference implementation (for comparison)
    ├── *.cs files
    └── *.csproj
```

---

## 🚀 How to Use Each Exercise

### **Step 1: Read the README**
- Understand learning objectives
- Review requirements
- Read Copilot prompting tips

### **Step 2: Review Starter Code**
- Open `starter/` folder
- Read the scaffolded code
- Note TODO comments showing what to implement

### **Step 3: Implement with Copilot**
- Use suggested Copilot prompts from README
- Generate code incrementally
- Test after each feature

### **Step 4: Check the Checklist**
- Use CHECKLIST.md to verify completion
- Mark items as you complete them
- Don't proceed until most items are checked

### **Step 5: Compare with Solution**
- Open `solution/` folder (only after attempting)
- Compare your implementation
- Note differences and improvements
- Ask Copilot to explain solution code

### **Step 6: Move to Next Exercise**
- Only proceed if checklist mostly complete
- Exercises build on each other

---

## 🤖 Best Practices for Copilot Usage

### **1. Be Specific in Prompts**
❌ **Bad:** "Generate a class"
✅ **Good:** "Generate a C# service class for user management with async CRUD methods, dependency injection, and null validation"

### **2. Include Context**
❌ **Bad:** "Make this better"
✅ **Good:** "Refactor this method to use LINQ instead of loops and add async/await for I/O operations"

### **3. Ask for Testing**
❌ **Bad:** (Just generate code)
✅ **Good:** Ask for `/tests` slash command to generate unit tests alongside code

### **4. Request Documentation**
❌ **Bad:** (Code without comments)
✅ **Good:** Use `/doc` slash command to add XML documentation

### **5. Verify Quality**
- Always review generated code before accepting
- Check for null safety, async/await, error handling
- Verify code compiles and passes tests

### **6. Ask for Explanations**
- Use `/explain` on complex code
- Ask "Why did you use this pattern?"
- Understand the reasoning behind suggestions

---

## 📚 Copilot Features Cheat Sheet

| Feature | Hotkey | Use Case |
|---------|--------|----------|
| Chat | `Ctrl+I` | Ask questions, get explanations, generate code |
| Inline Chat | `Ctrl+Shift+Space` | Highlight code and ask Copilot to refactor |
| `/explain` | In Chat | Understand what code does |
| `/doc` | In Chat | Generate XML documentation |
| `/tests` | In Chat | Generate unit test cases |
| `/fix` | In Chat | Debug and fix issues |
| `/new` | In Chat | Generate new code snippets |
| `@workspace` | In Chat | Reference entire workspace context |
| `#selection` | In Chat | Reference highlighted code |

---

## ✅ Code Quality Checklist (For All Exercises)

Before marking an exercise complete:

- [ ] **Compiles:** No errors or warnings
- [ ] **Tests Pass:** All unit tests passing
- [ ] **Functionality:** All features working as specified
- [ ] **Async/Await:** Async used for I/O operations
- [ ] **Error Handling:** Try-catch or proper validation
- [ ] **Null Safety:** Nullable reference types enabled, checks in place
- [ ] **Documentation:** XML comments on public members
- [ ] **Naming:** PascalCase for classes/methods, camelCase for variables
- [ ] **SOLID:** Single responsibility, no tight coupling
- [ ] **DRY:** No unnecessary code duplication

---

## 🧪 Testing Best Practices

### **Unit Tests**
- Test one method/behavior per test
- Use descriptive test names: `Test_MethodName_WithCondition_ExpectedResult`
- Mock dependencies using Moq
- Test both success and failure paths

### **Test Coverage**
- Aim for 70%+ coverage of critical logic
- 100% coverage of business logic
- Don't just test happy paths—test edge cases

### **Test Examples**
```csharp
[Fact]
public async Task CreateUser_WithValidData_ReturnsCreatedUser()
{
    // Arrange
    var request = new CreateUserRequest { Name = "John" };
    
    // Act
    var result = await _service.CreateUserAsync(request);
    
    // Assert
    Assert.NotNull(result);
    Assert.Equal("John", result.Name);
}

[Fact]
public async Task CreateUser_WithNullData_ThrowsArgumentException()
{
    // Act & Assert
    await Assert.ThrowsAsync<ArgumentException>(
        () => _service.CreateUserAsync(null)
    );
}
```

---

## 📝 Documentation Standards

### **XML Comments**
```csharp
/// <summary>
/// Creates a new user in the system.
/// </summary>
/// <param name="request">The user creation request with required fields.</param>
/// <returns>The newly created user with assigned ID.</returns>
/// <exception cref="ArgumentException">Thrown when request is null.</exception>
/// <exception cref="InvalidOperationException">Thrown when email already exists.</exception>
public async Task<UserResponse> CreateUserAsync(CreateUserRequest request)
{
    // Implementation
}
```

### **README Template**
```markdown
# Exercise X: [Title]

## Learning Objectives
- ✅ Objective 1
- ✅ Objective 2

## Requirements
- Requirement 1
- Requirement 2

## Copilot Prompts
[Suggested prompts for Chat]

## Success Criteria
- [ ] Criteria 1
- [ ] Criteria 2
```

---

## 🔄 Git Best Practices

### **Commit Messages**
✅ **Good:**
```
feat: Add user authentication service
fix: Handle null reference in ProductService
test: Add unit tests for OrderValidator
docs: Update API documentation
refactor: Extract duplicate validation logic
```

❌ **Bad:**
```
updates
fix bug
work in progress
asdf
```

### **Commit Frequency**
- One feature per commit
- One fix per commit
- Commit at logical checkpoints
- Avoid huge commits with multiple unrelated changes

---

## ⚠️ Common Mistakes to Avoid

1. **Using `.Result` or `.Wait()`** — Causes deadlocks. Use `await` instead.
2. **Hardcoded values** — Use configuration, constants, or parameters.
3. **Ignoring null checks** — Always validate input.
4. **Mixing async and sync** — Use async/await consistently.
5. **Poor variable names** — Use descriptive names (not `x`, `y`, `temp`).
6. **No error handling** — Always catch and handle exceptions.
7. **Testing only happy paths** — Test edge cases and errors too.
8. **Tight coupling** — Use interfaces and dependency injection.

---

## 🆘 Getting Unstuck

**If you're stuck:**
1. Check the exercise README for prompting tips
2. Ask Copilot: "How do I [specific problem] in C#?"
3. Use `/explain` on similar working code
4. Review the solution folder for reference
5. Ask a peer or mentor

**If Copilot gives wrong suggestions:**
1. Ask it to explain the code
2. Point out the issue: "This doesn't handle null values"
3. Ask for a revised version
4. Test before accepting

---

## 🎓 Learning Path

**Recommended Order:**
1. Complete all **Basics** exercises (console apps)
2. Complete **Modes** exercises (Ask, Edit, Plan)
3. Complete **Agents** exercises (CLI, Microservice)
4. Choose one **App Challenge** and complete it
5. (Optional) Complete other App Challenge templates

**Alternative for Experienced Developers:**
- Skip Basics, start with Modes
- Jump directly to App Challenge if time-constrained

---

## 💡 Pro Tips

1. **Use @workspace** in Chat to help Copilot understand your project structure
2. **Commit frequently** so you can revert if needed
3. **Read error messages carefully** — they often tell you exactly what's wrong
4. **Ask Copilot to explain** before accepting generated code
5. **Use meaningful branch names** like `feature/user-authentication`
6. **Test locally** before committing
7. **Comment complex logic** even if you understand it now

---

## 📞 Support Resources

- **Stuck on .NET syntax?** → Ask Copilot `/explain`
- **Need unit test ideas?** → Ask Copilot `/tests`
- **Debugging?** → Use `/fix` and provide error message
- **Want documentation?** → Use `/doc` on your class
- **Need architectural advice?** → Ask in Chat with `@workspace` context

---

**Happy Learning! 🚀**

Remember: Copilot is your coding partner. Use it to accelerate your learning while maintaining code quality and understanding.

