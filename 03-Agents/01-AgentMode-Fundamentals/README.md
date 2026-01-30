# Exercise 8: GitHub Copilot Agent Mode Fundamentals

**Difficulty:** Advanced | **Time:** 45-60 minutes | **Copilot Features:** Agent Mode, Multi-Step Reasoning, Autonomous Code Generation

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Understand GitHub Copilot Agent Mode capabilities and limitations
- ✅ Learn when to use Agent Mode vs Chat Mode vs Edit Mode
- ✅ Use agents to break down complex tasks autonomously
- ✅ Work with agents in background while continuing development
- ✅ Verify and guide agent-generated solutions

---

## 📋 Scenario

You're building a **Personal Finance Dashboard API** that needs:

1. **Core Features:**
   - Track income and expenses
   - Categorize transactions
   - Generate monthly reports
   - Calculate budget summaries
   - Support for multiple currencies

2. **Your Task:**
   Use GitHub Copilot Agent Mode to autonomously design and partially implement:
   - Data models (Transaction, Category, Budget)
   - API endpoints structure
   - Database schema (planning)
   - Business logic for calculations
   - Error handling strategy

3. **Agent Workflow:**
   - Describe the full requirement to Agent
   - Let agent suggest architecture & initial implementation
   - Review and refine agent suggestions
   - Complete remaining implementation manually

---

## 🤖 How GitHub Copilot Agent Mode Works

### **Agent Mode vs Chat Mode**

| Aspect | Chat Mode | Agent Mode |
|--------|-----------|-----------|
| **Interaction** | You ask, Copilot answers | Copilot takes autonomous steps |
| **Scope** | Single prompt, single response | Multi-step task completion |
| **Control** | You drive each step | Agent suggests path, you guide |
| **Best For** | Questions, quick help | Complex multi-part tasks |
| **Effort** | Requires manual iteration | Less back-and-forth |

### **When to Use Agent Mode**
✅ Breaking down large features  
✅ Generating project structure  
✅ Building boilerplate code  
✅ Planning architecture  
✅ Creating test suites  

### **When to Avoid Agent Mode**
❌ Simple single-step tasks  
❌ Highly specialized domain logic  
❌ Security-sensitive code  
❌ When you need precise control  

---

## 📝 Reference Prompt

Open GitHub Copilot Agent and paste this:

```
I'm building a Personal Finance Dashboard API with these requirements:

Features:
- Track income and expenses with categories
- Support multiple currencies
- Generate monthly budget reports
- Calculate spending trends
- Store transactions in database

Tech Stack:
- .NET 8 / C# 12
- ASP.NET Core for API
- Entity Framework Core for database
- xUnit for testing

Task:
Please autonomously:
1. Design the core data models (Transaction, Category, Budget, User)
2. Plan the API endpoint structure (CRUD for transactions and budgets)
3. Suggest the database schema
4. Outline the business logic layer
5. Plan error handling and validation

For each part, provide:
- Code structure/skeleton
- Key classes and methods
- Database relationships
- Validation rules
```

---

## 💻 Starter Code Structure

The `starter/` folder contains:

```
starter/
├── FinanceDashboard.csproj
├── Program.cs (minimal setup)
├── Models/
│   ├── User.cs (TODO: design with agent help)
│   ├── Transaction.cs (TODO: design with agent help)
│   ├── Category.cs (TODO: design with agent help)
│   └── Budget.cs (TODO: design with agent help)
├── Controllers/
│   └── TransactionsController.cs (TODO: endpoints to create)
├── Services/
│   └── FinanceService.cs (TODO: business logic skeleton)
└── Data/
    └── FinanceContext.cs (TODO: DbContext setup)
```

---

## ✅ Success Criteria (CHECKLIST.md)

See CHECKLIST.md for 50+ verification items covering:
- Data model completeness
- API endpoint design
- Database schema correctness
- Service layer abstraction
- Error handling strategy
- Code organization
- Agent collaboration effectiveness

---

## 🎯 Key Takeaways

After this exercise, you'll understand:
- How Agent Mode simplifies complex task breakdown
- When to let agents work autonomously vs manual control
- How to verify and refine agent-generated code
- Best practices for human-agent collaboration

**Next:** Move to Exercise 9 (Task Delegation with MCP) to learn delegating work to specialized agents.

