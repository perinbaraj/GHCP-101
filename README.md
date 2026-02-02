# GitHub Copilot Hands-On Fundamentals with .NET

A comprehensive, progressive training program to master GitHub Copilot for .NET/C# development. Learn from basic code generation to autonomous agentic workflows in 4 sections with 12+ hands-on exercises and a real-world 60-minute app challenge.

**Status:** ✅ Complete | **Total Exercises:** 12 | **App Challenges:** 4

---

## 🚀 Getting Started

### **Section 1: Basics**
Build foundational Copilot skills with console apps.

1. [**01-Calculator**](01-Basics/01-Calculator/README.md) — Autocomplete & Chat basics
2. [**02-StringHandler**](01-Basics/02-StringHandler/README.md) — String manipulation & refactoring
3. [**03-ArrayOperations**](01-Basics/03-ArrayOperations/README.md) — LINQ & `/tests` command
4. [**04-FileProcessor**](01-Basics/04-FileProcessor/README.md) — Async/await & `/explain`

### **Section 2: Modes**
Learn advanced Copilot features for real-world workflows.

1. [**01-AskMode**](02-Modes/01-AskMode/README.md) — Research & debugging patterns
2. [**02-EditMode**](02-Modes/02-EditMode/README.md) — Bulk refactoring transformations
3. [**03-PlanMode**](02-Modes/03-PlanMode/README.md) — Architectural planning

### **Section 3: Agents**
Master GitHub Copilot Agent Mode with task delegation and specialization.

1. [**01-AgentMode-Fundamentals**](03-Agents/01-AgentMode-Fundamentals/README.md) — Agent Mode basics & autonomous reasoning
2. [**02-TaskDelegation-WithMCP**](03-Agents/02-TaskDelegation-WithMCP/README.md) — Delegating to agents via MCP integration
3. [**03-SpecializedAgents**](03-Agents/03-SpecializedAgents/README.md) — Configuring domain-expert agents

### **Section 4: App Challenges**
Build real-world applications using any tech stack.

**Interconnected Weather App (3 parts: Frontend → Backend → Database)**
1. [**01-WeatherApp-Frontend**](04-App-Challenge/01-WeatherApp-Frontend/README.md) — React/Vue/Angular weather visualization
2. [**02-WeatherApp-Backend**](04-App-Challenge/02-WeatherApp-Backend/README.md) — REST APIs with caching & business logic
3. [**03-WeatherApp-Database**](04-App-Challenge/03-WeatherApp-Database/README.md) — Data persistence & historical analytics
**Independent Full-Stack Project**
4. [**04-MovieBookingSystem**](04-App-Challenge/04-MovieBookingSystem/README.md)— Complete booking system with payments


---

## 📖 How Each Exercise Works

1. **Read the README** in the exercise folder (objectives & Copilot prompts)
2. **Review starter code** in `starter/` folder
3. **Implement** using Copilot Chat & slash commands
4. **Verify** against CHECKLIST.md
5. **Compare** with `solution/` folder for reference
6. **Move to next** exercise

---

## 📋 Training Structure

### **Section 1: Copilot Basics**
Learn foundational Copilot features: autocomplete, Chat, and slash commands.

- **01-Calculator** — Simple arithmetic operations with autocomplete and `/doc` slash command
- **02-StringHandler** — String manipulation using Chat for refactoring suggestions
- **03-ArrayOperations** — Array/list operations with `/tests` for unit test generation
- **04-FileProcessor** — File I/O with `/explain` for understanding complex patterns

**Key Skills:** Code generation, Chat interaction, slash commands, inline refactoring

---

### **Section 2: Copilot Modes**
Explore Ask, Edit, and Plan modes for real-world workflows.

- **01-AskMode** — Research existing API patterns, debug logic issues
- **02-EditMode** — Bulk refactor legacy code, apply transformations across files
- **03-PlanMode** — Break down complex features into structured tasks and roadmaps

**Key Skills:** Multi-step reasoning, code transformation, architectural planning

---

### **Section 3: GitHub Copilot Agents**
Master Agent Mode with hands-on exercises: autonomous reasoning, task delegation, and specialized agents.

- **01-AgentMode-Fundamentals** — Build a Finance Dashboard API using Agent Mode to break down complex requirements
- **02-TaskDelegation-WithMCP** — Use agents to delegate work across microservices via GitHub MCP integration
- **03-SpecializedAgents** — Create custom domain-expert agents (.md files) for different roles

**Key Skills:** Agent Mode autonomy, task delegation, MCP integration, specialized routing, custom personas

---

### **Section 4: Real-World App Challenges** (Tech-Agnostic)
Apply everything learned by building production-quality applications.

**Path 1: Weather App (Interconnected - Full Stack)**
- **01-WeatherApp-Frontend** — Frontend UI (React, Vue, Angular, or any framework)
- **02-WeatherApp-Backend** — Backend APIs (Node, Python, C#, Java, or any framework)
- **03-WeatherApp-Database** — Data persistence (PostgreSQL, MongoDB, or any database)

**Path 2: Movie Booking System (Independent - Full Stack)**
- **04-MovieBookingSystem** — Complete system with dynamic pricing, payments, seat management

**Deliverable:** Working app(s) with tests, documentation, and professional code quality

---

## 🚀 Quick Start

1. **Clone & Navigate**
   ```bash
   git clone https://github.com/perinbaraj/GHCP-101.git
   cd GHCP-101
   ```

2. **Start with the Basics**
   - Complete all exercises in sequence: Basics → Modes → Agents → App Challenge

3. **Follow Exercise Format**
   - Read the exercise **README.md** for objectives
   - Use starter code in `starter/` folder
   - Complete the implementation using Copilot
   - Verify against **CHECKLIST.md**
   - Compare with `solution/` folder for reference

---

## 📖 How to Use GitHub Copilot for Each Exercise

### **Copilot Chat** (`Ctrl+I` in IDE)
- Ask questions about code patterns
- Request explanations of complex logic
- Get refactoring suggestions

### **Slash Commands**
- `/explain` — Understand existing code
- `/doc` — Generate documentation and XML comments
- `/tests` — Create unit test cases
- `/fix` — Debug and fix errors
- `/new` — Generate new code snippets

### **Inline Chat** (`Ctrl+Shift+Space`)
- Highlight code → press shortcut → ask Copilot to transform
- Great for quick refactoring and style improvements

### **@workspace Context**
- Reference files across the project with `@workspace`
- Helps Copilot understand project-wide patterns and conventions

### **#selection Context**
- Use `#selection` to reference highlighted code in Chat
- Faster than manually copying code

---

## ✅ Exercise Format & Self-Checklists

Each exercise includes:

1. **README.md** — Learning objectives, requirements, and Copilot prompting tips
2. **starter/** — Boilerplate code to get started
3. **CHECKLIST.md** — Self-assessment criteria (features + code quality)
4. **solution/** — Reference implementation (don't peek until you try!)

### **Checklist Categories**

- ✅ **Feature Completeness** — Does it do what's required?
- ✅ **Code Quality** — SOLID principles, async/await, DI, null safety
- ✅ **Testing** — Unit tests, integration tests, test coverage
- ✅ **.NET Best Practices** — Naming conventions, documentation, architecture

---

## 🏆 60-Minute App Challenge

### **How It Works**
1. **Form Teams** (2-3 people)
2. **Pick a Template** (Todo, Weather, or Notes app)
3. **Use Copilot for:** Planning, code generation, refactoring, testing, documentation
4. **Build & Submit** a pull request with working app

### **PR Requirements** (Mandatory)
- [ ] All features implemented and working
- [ ] Unit tests with 70%+ coverage
- [ ] Async/await patterns used correctly
- [ ] Dependency injection configured
- [ ] XML documentation for public methods
- [ ] PR description generated by Copilot Chat
- [ ] Clean commit history with meaningful messages

### **Submission**
- Submit a PR to the `challenge-submissions` branch
- Include Copilot-generated summary of changes
- Reference any issues or design docs

---

## 🔧 .NET Requirements

- **.NET Version:** .NET 8 LTS (or .NET 6+)
- **Testing Framework:** xUnit + Moq
- **IDE:** Visual Studio Code with [GitHub Copilot extension](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot)
- **C# Version:** C# 12+ (nullable reference types enabled)

### **Setup**
```bash
# Verify .NET installation
dotnet --version

# Create a new console app (if needed)
dotnet new console -n MyApp

# Run tests
dotnet test

# Build
dotnet build
```

---

## 📚 Additional Resources

- [Microsoft .NET Learning Paths](https://learn.microsoft.com/en-us/dotnet/)
- [GitHub Copilot Best Practices](https://docs.github.com/en/copilot/using-github-copilot/prompt-engineering-for-github-copilot)
- [ASP.NET Core Documentation](https://learn.microsoft.com/en-us/aspnet/core/)
- [SOLID Principles in C#](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals)

---

## � What's Included

### **12 Progressive Exercises**

**Section 1: Basics** - Learn Copilot fundamentals
| Exercise | Focus | Skills |
|----------|-------|--------|
| 01-Calculator | Autocomplete & Chat | Code generation, Chat basics |
| 02-StringHandler | String manipulation | Refactoring, LINQ |
| 03-ArrayOperations | Arrays & LINQ | `/tests` slash command, testing |
| 04-FileProcessor | Async/File I/O | `/explain`, async/await |

**Section 2: Modes** - Advanced Copilot workflows
| Exercise | Focus | Skills |
|----------|-------|--------|
| 01-AskMode | Ask Mode - research | Pattern analysis, debugging |
| 02-EditMode | Edit Mode - refactoring | Bulk transformations, consistency |
| 03-PlanMode | Plan Mode - design | Architecture, task breakdown |

**Section 3: Agents** - Agent Mode & Task Delegation
| Exercise | Focus | Skills |
|----------|-------|--------|
| 01-AgentMode-Fundamentals | Agent autonomy, Finance Dashboard | Complex task breakdown, Agent Mode |
| 02-TaskDelegation-WithMCP | Delegation, GitHub MCP, Microservices | MCP integration, task orchestration |
| 03-SpecializedAgents | Custom domain-expert agents | Agent personas, specialization |

**Section 4: App Challenges** - Build real apps
| Challenge | Focus | Difficulty |
|-----------|------|-------|------------|
| 01-WeatherApp-Frontend | UI/HTTP integration, responsive design | Medium |
| 02-WeatherApp-Backend | REST APIs, business logic, caching | Medium |
| 03-WeatherApp-Database | Data persistence, analytics, optimization | Medium |
| 04-MovieBookingSystem | Full-stack, complex business logic, payments | Hard |

### **Complete Documentation**
- ✅ Every exercise has README.md with objectives & Copilot prompts
- ✅ Every exercise has CHECKLIST.md for self-assessment (40-70 items)
- ✅ **3 SOLUTION_GUIDE.md files** — Comprehensive solutions with multiple prompting strategies (3,200+ lines total)
  - [01-Basics/SOLUTION_GUIDE.md](01-Basics/SOLUTION_GUIDE.md) — Calculator, StringHandler, ArrayOperations, FileProcessor
  - [02-Modes/SOLUTION_GUIDE.md](02-Modes/SOLUTION_GUIDE.md) — AskMode, EditMode, PlanMode
  - [03-Agents/SOLUTION_GUIDE.md](03-Agents/SOLUTION_GUIDE.md) — AgentMode-Fundamentals, TaskDelegation-WithMCP, SpecializedAgents
- ✅ `docs/exercise-guidelines.md` — How to use each exercise
- ✅ `docs/copilot-prompting-tips.md` — Advanced prompting techniques
- ✅ `docs/dotnet-best-practices.md` — .NET/C# standards & SOLID principles
- ✅ `.github/pull_request_template.md` — Professional submission format

### **Code Scaffolding**
- ✅ Starter code for each exercise (with TODO comments)
- ✅ Reference solutions (complete implementations)
- ✅ .csproj files ready to use

---

## 📁 Repository Structure

```
GHCP-101/
├── README.md (this file - all key info here)
│
├── 01-Basics/ (4 exercises)
│   ├── SOLUTION_GUIDE.md ⭐ (comprehensive solutions for all Basics exercises)
│   ├── 01-Calculator/
│   │   ├── README.md (objectives & Copilot prompts)
│   │   ├── CHECKLIST.md (self-assessment)
│   │   ├── starter/ (code to complete)
│   │   └── solution/ (reference)
│   ├── 02-StringHandler/
│   ├── 03-ArrayOperations/
│   └── 04-FileProcessor/
│
├── 02-Modes/ (3 exercises)
│   ├── SOLUTION_GUIDE.md ⭐ (comprehensive solutions for all Modes exercises)
│   ├── 01-AskMode/
│   ├── 02-EditMode/
│   └── 03-PlanMode/
│
├── 03-Agents/ (3 exercises)
│   ├── SOLUTION_GUIDE.md ⭐ (comprehensive solutions for all Agents exercises)
│   ├── 01-AgentMode-Fundamentals/
│   ├── 02-TaskDelegation-WithMCP/
│   └── 03-SpecializedAgents/
│
├── 04-App-Challenge/ (4 interconnected + independent projects)
│   ├── README.md (overview and learning paths)
│   ├── 01-WeatherApp-Frontend/
│   ├── 02-WeatherApp-Backend/
│   ├── 03-WeatherApp-Database/
│   └── 04-MovieBookingSystem/
│
├── .github/
│   └── pull_request_template.md (for challenge submissions)
│
└── docs/
    ├── exercise-guidelines.md (how to use exercises)
    ├── copilot-prompting-tips.md (prompting strategies)
    └── dotnet-best-practices.md (.NET standards & patterns)
```

---

## 🎓 Learning Outcomes

After completing this training, you will:

**Master GitHub Copilot**
- ✅ Use Chat effectively for code generation (`Ctrl+I`)
- ✅ Apply slash commands appropriately (`/explain`, `/doc`, `/tests`, `/fix`)
- ✅ Leverage Ask/Edit/Plan modes for complex tasks
- ✅ Use context enhancement (`@workspace`, `#selection`)

**Write Production .NET Code**
- ✅ Follow SOLID principles
- ✅ Implement async/await correctly
- ✅ Use dependency injection effectively
- ✅ Write comprehensive tests (70%+ coverage)
- ✅ Create professional documentation

**Build Real Applications**
- ✅ Design RESTful APIs
- ✅ Implement search & filtering
- ✅ Apply caching strategies
- ✅ Handle errors professionally

**Think Architecturally**
- ✅ Design systems with Copilot
- ✅ Understand microservices
- ✅ Orchestrate complex workflows
- ✅ Apply architectural patterns

---

---

## ✅ Exercise Format (Same for All)

Each exercise folder contains:

1. **README.md**
   - Learning objectives (3-5 items)
   - Detailed requirements
   - Specific Copilot prompting tips (3-4 tailored prompts)
   - Key concepts to learn
   - Time estimate

2. **CHECKLIST.md**
   - Feature completeness (10+ items)
   - Code quality criteria (8+ items)
   - .NET best practices (8+ items)
   - Documentation requirements (5+ items)
   - Testing criteria (8+ items)
   - Total: 40-70 items to verify completion

3. **starter/**
   - Partial code with TODO comments
   - Project file (.csproj)
   - Structure to follow

4. **solution/**
   - Complete reference implementation
   - Professional quality code
   - For comparison after attempting

### **How to Complete an Exercise**

1. **Read README.md** — Understand objectives & requirements
2. **Review starter code** — See what structure you're working with
3. **Ask Copilot** — Use suggested prompts from README
4. **Implement** — Generate code, test as you go
5. **Check CHECKLIST.md** — Verify 80%+ complete
6. **Compare with solution/** — Learn from reference implementation
7. **Explore SOLUTION_GUIDE.md** — See multiple prompting strategies & best practices (section-level)
8. **Move to next** — When checklist mostly complete

---

## 🤖 Copilot Features Used

| Feature | Hotkey | Use Case | Exercise |
|---------|--------|----------|----------|
| Chat | `Ctrl+I` | Ask questions, generate code | All |
| Inline Chat | `Ctrl+Shift+Space` | Refactor highlighted code | All |
| /explain | In Chat | Understand complex code | FileProcessor, others |
| /doc | In Chat | Generate XML documentation | Calculator, others |
| /tests | In Chat | Generate unit tests | ArrayOperations, others |
| /fix | In Chat | Debug errors | Debug-focused exercises |
| @workspace | In Chat | Reference project context | Later exercises |
| #selection | In Chat | Reference highlighted code | All |

---

## 💡 Key Features

✅ **Linear Progression** — Everyone does all 12 exercises in order  
✅ **No Skipping** — Each exercise builds on the previous  
✅ **Hands-On** — 12 complete exercises, 3 real-world apps  
✅ **Copilot-Centric** — Every exercise leverages Copilot effectively  
✅ **.NET-Specific** — Modern C# patterns & best practices  
✅ **Well-Documented** — Clear guides for every step  
✅ **Self-Assessed** — Comprehensive checklists for each exercise  
✅ **Professional** — Enterprise-grade code quality standards  

---

## 🚀 Start Your Journey

**Begin here:** Go to [01-Basics/01-Calculator](01-Basics/01-Calculator/) and read the README.md

Then follow this exact sequence:
1. ✅ All 4 Basics exercises
2. ✅ All 3 Modes exercises
3. ✅ All 3 Agents exercises
4. ✅ Pick your app challenge path (Weather App 1-3 OR Movie Booking System)

**Total Exercises:** 12 + 4 app challenges

---

## 📖 Step-by-Step for Each Exercise

```bash
cd 01-Basics/01-Calculator  # or any exercise folder

# Then:
1. Read README.md - understand objectives & Copilot prompts
2. Review starter/ code - see what you're building
3. Open Copilot Chat (Ctrl+I) - use suggested prompts
4. Implement your solution - write code, test
5. Check CHECKLIST.md - verify 80%+ complete
6. Compare with solution/ - learn best practices
7. Check ../SOLUTION_GUIDE.md - see multiple approaches & insights
8. Move to next exercise
```

---

## 📖 Support & Documentation

**Need help?** Check these docs:

| Question | Where |
|----------|-------|
| How do I use this exercise? | Exercise README.md |
| How do I see multiple solution approaches? | Section SOLUTION_GUIDE.md (01-Basics/, 02-Modes/, 03-Agents/) |
| How do I prompt Copilot? | `docs/copilot-prompting-tips.md` |
| What's the .NET convention? | `docs/dotnet-best-practices.md` |
| How do I complete the exercise? | `docs/exercise-guidelines.md` |
| How do I submit my app? | `.github/pull_request_template.md` |

---

## 📚 Additional Resources

- [Microsoft .NET Documentation](https://learn.microsoft.com/en-us/dotnet/)
- [GitHub Copilot Best Practices](https://docs.github.com/en/copilot/using-github-copilot/prompt-engineering-for-github-copilot)
- [ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/)
- [C# Fundamentals](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals)
- [SOLID Principles](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/architectural-principles)

---

## 💡 Tips for Success

1. **Start with 01-Calculator** — Don't jump around
2. **Read each README carefully** — They have specific Copilot prompts
3. **Use Copilot Chat actively** — Not just for code generation
4. **Verify with checklists** — Don't move on until 80%+ complete
5. **Compare with solutions** — Understand best practices
6. **Explore SOLUTION_GUIDE.md** — Each section has comprehensive guides with multiple prompting strategies
7. **Test your code** — Always verify before moving on
8. **Ask questions** — If stuck, ask Copilot in Chat

---

## 📞 Support & Feedback

- **Stuck on an exercise?** Check the section's SOLUTION_GUIDE.md (e.g., `01-Basics/SOLUTION_GUIDE.md`) for multiple approaches
- **Need prompting help?** Each exercise README has Copilot prompting tips
- **Want to suggest improvements?** Create an issue with tag `enhancement`
- **Found a bug?** Create an issue with tag `bug`

---

**Happy Coding with Copilot! 🚀**

