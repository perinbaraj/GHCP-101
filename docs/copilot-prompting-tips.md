# GitHub Copilot Prompting Tips & Techniques

---

## 🎯 Prompting Framework

Great prompts follow this structure:

```
[CONTEXT] I'm building [what]
[REQUIREMENTS] It needs to:
- [Feature 1]
- [Feature 2]
- [Feature 3]
[CONSTRAINTS] with these constraints:
- [Constraint 1]
- [Constraint 2]
[OUTPUT] Please provide [what format - code, design, explanation]
```

---

## 📝 Effective Prompting Examples

### **Example 1: Generate a Service Class**
```
I'm building a user management system in ASP.NET Core.
Create a UserService class that:
- Implements CRUD operations (Create, Read, Update, Delete)
- Uses async/await for all I/O operations
- Has dependency injection through constructor
- Includes null validation for inputs
- Throws ArgumentException for invalid data
- Has comprehensive XML documentation

Use modern C# features and follow SOLID principles.
```

### **Example 2: Implement Search Functionality**
```
I need to implement search in my Note-Taking API.
The search should:
- Search across note titles and content
- Be case-insensitive
- Support multiple search terms (AND logic)
- Use LINQ for efficiency
- Handle null inputs gracefully
- Return results sorted by relevance

Generate the SearchNotes method with:
- Clear parameter names
- Null checks
- Proper return type
- Performance considerations
```

### **Example 3: Debug Code Issues**
```
I have a problem with this code:
[paste your code]

The issue is: [describe what's wrong or what error you get]

Please:
1. Identify the root cause
2. Explain why it's wrong
3. Provide a corrected version
4. Explain the fix
```

### **Example 4: Refactor for Maintainability**
```
I want to improve this code for readability and maintainability:
[paste code]

Refactor it to:
- Use LINQ instead of loops where appropriate
- Extract complex conditions into named variables
- Add meaningful comments
- Improve variable names
- Apply DRY principle

Show the refactored version with explanations.
```

---

## 🚀 Slash Commands

### **`/explain` — Understand Code**
Use when you need to understand complex code.

```
Select complex code and ask:
/explain

What this does:
- Explains the logic step-by-step
- Identifies patterns used
- Notes potential issues
```

### **`/doc` — Generate Documentation**
Use to add XML documentation.

```
Select a class or method and ask:
/doc

What this does:
- Adds <summary>, <param>, <returns> tags
- Includes exception documentation
- Preserves your code, adds comments
```

### **`/tests` — Generate Unit Tests**
Use to create comprehensive test cases.

```
Select your class/method and ask:
/tests

What this does:
- Generates xUnit test class
- Tests happy path and edge cases
- Uses Moq for dependencies
- Includes null input tests
```

### **`/fix` — Debug Issues**
Use when you have compilation errors or logic bugs.

```
Highlight problematic code and ask:
/fix

What this does:
- Identifies the issue
- Provides corrected code
- Explains the fix
```

### **`/new` — Generate New Code**
Use to create new files or functions.

```
In Chat, ask:
/new Generate a [specific thing]

Examples:
/new Generate a repository pattern implementation
/new Generate a configuration file for logging
```

---

## 🎨 Context Enhancement

### **Using `@workspace`**
Include workspace context in your prompt:

```
I'm working on @workspace
I need to [task]
The project uses [tech stack]
Please generate [what]
```

This helps Copilot understand:
- Your project structure
- Existing patterns
- Naming conventions
- Technology stack

### **Using `#selection`**
Reference specific code:

```
I have this code:
#selection

Can you refactor it to use LINQ instead of loops?
```

---

## 💡 Advanced Prompting Techniques

### **1. Chain of Thought**
Break complex tasks into steps:

```
Help me design a microservice architecture.
Step 1: Define service boundaries
Step 2: Identify API contracts
Step 3: Plan data persistence
Step 4: Consider communication patterns
Step 5: Design error handling

For each step, explain the decision and trade-offs.
```

### **2. Show Examples**
Provide examples of expected behavior:

```
I need a validation method.
Examples of what should pass:
- Email: "user@example.com"
- Email: "firstname.lastname@company.co.uk"

Examples of what should fail:
- Email: "invalid-email"
- Email: "@example.com"
- Email: "user@"

Generate a validation regex with explanation.
```

### **3. Ask for Multiple Approaches**
Get different perspectives:

```
I need to implement caching in my API.
Show me three different approaches:
1. [Approach 1 description]
2. [Approach 2 description]
3. [Approach 3 description]

For each, explain:
- Pros and cons
- Performance implications
- Complexity level
- Recommended use cases
```

### **4. Clarify Constraints**
Help Copilot understand limitations:

```
Generate a report generator that:
- Must run in under 5 seconds
- Can't use external APIs
- Must fit in 50MB memory
- Should be maintainable by junior developers
- Must support these formats: [CSV, JSON, XML]

Explain your architectural choices given these constraints.
```

### **5. Request Defensive Programming**
Ask for robust code:

```
Generate a file processor that:
- Handles all common exceptions
- Validates input thoroughly
- Provides clear error messages
- Logs all operations
- Includes retry logic for transient failures
- Can be easily extended for new file types

Include error handling code, not just the happy path.
```

---

## ✅ Prompting Do's & Don'ts

### **DO:**
- ✅ Be specific and detailed
- ✅ Include context about your project
- ✅ Specify technology stack (.NET 8, C#, xUnit)
- ✅ Mention constraints (performance, memory, time)
- ✅ Ask for explanations, not just code
- ✅ Verify generated code works
- ✅ Ask follow-up questions
- ✅ Use examples to clarify expectations

### **DON'T:**
- ❌ Be vague ("make it better")
- ❌ Ask for code without context
- ❌ Accept code without review
- ❌ Assume Copilot knows your requirements
- ❌ Use complex words when simpler ones work
- ❌ Ignore error messages from Copilot's code
- ❌ Rush through generated code
- ❌ Forget to test before committing

---

## 🔍 Common Prompting Mistakes

### **Mistake 1: Too Vague**
❌ "Generate a class for users"
✅ "Generate a C# UserService class with async CRUD methods, dependency injection, validation, and error handling"

### **Mistake 2: Missing Context**
❌ "How do I cache data?"
✅ "I'm building an ASP.NET Core API. How should I implement caching for frequently-accessed product data with 1-hour expiration?"

### **Mistake 3: Too General**
❌ "Generate a project structure"
✅ "Generate a .NET 8 console application structure for a file conversion tool with services, models, and tests"

### **Mistake 4: Unclear Requirements**
❌ "Make this faster"
✅ "Optimize this database query to execute in under 500ms for 1M records"

### **Mistake 5: No Acceptance Criteria**
❌ "Generate tests"
✅ "Generate xUnit tests covering happy path, null inputs, and error scenarios with 80%+ coverage"

---

## 🎓 Iterative Prompting

Refine Copilot's output through conversation:

```
First prompt: "Generate a user authentication service"
Response: [Code generated]

Follow-up: "Add rate limiting for failed login attempts"
Response: [Updated code]

Follow-up: "Explain the security considerations"
Response: [Explanation]

Follow-up: "How would you handle JWT token refresh?"
Response: [More details]
```

---

## 📊 Prompting by Task Type

### **For Code Generation**
```
Generate [what] in [language] that:
- Does [requirement 1]
- Does [requirement 2]
- Uses [pattern/library]
- Handles [edge case]
- Includes [documentation level]
```

### **For Architecture**
```
Design a [system] with:
- [Requirement 1] 
- [Requirement 2]
- [Constraint 1]

Include:
- Architecture diagram
- Component descriptions
- Communication patterns
- Scalability notes
```

### **For Debugging**
```
I have this error:
[error message]

In this code:
[code snippet]

The expected behavior is:
[what should happen]

What's wrong and how do I fix it?
```

### **For Refactoring**
```
Refactor this code:
[code]

Goals:
- Improve [readability/performance/testability]
- Apply [pattern/principle]
- Use [technology/approach]

Explain the improvements.
```

### **For Testing**
```
/tests

Generate comprehensive unit tests for this code that cover:
- Happy path scenarios
- Null/empty input handling
- Error conditions
- Edge cases: [specific cases]

Use xUnit and Moq, with descriptive test names.
```

---

## 🎯 Tips for Different Exercise Types

### **For Basics Exercises**
- Ask Copilot to generate entire classes
- Use `/doc` for XML documentation
- Use `/tests` to generate test cases
- Review generated code carefully

### **For Modes Exercises**
- Use "Ask Mode" by asking research questions first
- Use "Edit Mode" to refactor across files
- Use "Plan Mode" to structure complex tasks

### **For Agents Exercises**
- Ask for multi-step workflow design
- Request autonomous decision-making logic
- Ask for error recovery strategies

### **For App Challenge**
- Ask for complete project plan first
- Generate components incrementally
- Test after each component
- Ask for performance optimization tips

---

## 💬 Real-World Prompting Examples

### **Example 1: API Design**
```
I'm building a REST API for managing tasks.
Design the API with:
- GET /tasks (list, with pagination)
- GET /tasks/{id}
- POST /tasks
- PUT /tasks/{id}
- DELETE /tasks/{id}
- GET /tasks/search

For each endpoint, provide:
- Request/response examples
- Possible status codes
- Validation rules
```

### **Example 2: Performance Issue**
```
This method is slow for large datasets:
[code]

It processes 1M records in 30 seconds.
Target is under 5 seconds.

Analyze the performance issue and suggest:
1. Root cause
2. Optimization strategies
3. Optimized code
4. Expected performance improvement
```

### **Example 3: Testing Coverage**
```
/tests

Generate comprehensive tests for this service.
The tests should:
- Achieve 85%+ code coverage
- Test all CRUD operations
- Test validation logic
- Mock external dependencies
- Test error scenarios
- Use Moq for dependencies
```

---

## 🏆 Pro Tips

1. **Ask for Explanations** — Always ask "Why did you choose this approach?"
2. **Request Multiple Options** — "Show me three ways to implement this"
3. **Include Constraints** — Performance, memory, or time limits
4. **Be Iterative** — Refine requests based on responses
5. **Verify Code** — Always review and test before accepting
6. **Learn the Patterns** — Ask Copilot to explain design patterns
7. **Build Context** — Reference previous code with `@workspace`

---

**Remember:** Copilot is most effective when you're specific, provide context, and ask clarifying questions. Treat it as a conversation, not one-off requests!

