# Repository Structure & Learning Guide

## 📚 How This Repository is Organized

This GitHub Copilot training curriculum is designed for absolute beginners with a unique two-level approach:

### **Level 1: Exercise READMEs (Lightweight)**
- Clear learning objectives
- What you need to build (requirements)
- ONE example prompt to get started
- Link to detailed solutions

### **Level 2: SOLUTION_GUIDE.md (Comprehensive)**
- Multiple prompting strategies (3-4 approaches)
- Complete working code solutions
- Detailed explanations
- Key insights and best practices
- Common mistakes and how to avoid them

---

## 🎯 Learning Path (Everyone Does All Exercises in Order)

```
01-Basics (4 exercises)
    ↓
02-Modes (3 exercises)
    ↓
03-Agents (2 exercises)
    ↓
04-App-Challenge (Pick 1 of 3 templates)
```

---

## 📂 Complete Directory Structure

```
GHCP-101/
├── README.md                              # Main entry point & linear progression
│
├── 01-Basics/
│   ├── SOLUTION_GUIDE.md                 # Comprehensive solutions for all 4 exercises
│   ├── 01-Calculator/
│   │   ├── README.md                     # Exercise description (1 prompt)
│   │   ├── CHECKLIST.md                  # Self-assessment checklist
│   │   ├── starter/
│   │   │   ├── Calculator.cs             # Partial code with TODO
│   │   │   ├── Program.cs                # Main program (incomplete)
│   │   │   └── Calculator.csproj
│   │   └── solution/                     # Reference implementation
│   │       ├── Calculator.cs
│   │       ├── Program.cs
│   │       └── Calculator.csproj
│   │
│   ├── 02-StringHandler/
│   │   ├── README.md
│   │   ├── CHECKLIST.md
│   │   ├── starter/
│   │   │   ├── StringUtility.cs
│   │   │   ├── Program.cs
│   │   │   └── StringUtility.csproj
│   │   └── solution/
│   │       ├── StringUtility.cs
│   │       ├── Program.cs
│   │       └── StringUtility.csproj
│   │
│   ├── 03-ArrayOperations/
│   │   ├── README.md
│   │   ├── CHECKLIST.md
│   │   ├── starter/
│   │   │   ├── ArrayUtility.cs
│   │   │   ├── Program.cs
│   │   │   └── ArrayUtility.csproj
│   │   └── solution/
│   │       ├── ArrayUtility.cs
│   │       ├── ArrayUtility.Tests.cs
│   │       ├── Program.cs
│   │       └── ArrayUtility.csproj
│   │
│   └── 04-FileProcessor/
│       ├── README.md
│       ├── CHECKLIST.md
│       ├── starter/
│       │   ├── FileProcessor.cs
│       │   ├── Program.cs
│       │   └── FileProcessor.csproj
│       └── solution/
│           ├── FileProcessor.cs
│           ├── Program.cs
│           └── FileProcessor.csproj
│
├── 02-Modes/
│   ├── SOLUTION_GUIDE.md                 # Comprehensive solutions for all 3 exercises
│   ├── 01-AskMode/
│   │   ├── README.md                     # Exercise description (1 prompt)
│   │   ├── CHECKLIST.md
│   │   ├── starter/
│   │   │   ├── Models/
│   │   │   ├── Repositories/
│   │   │   ├── Controllers/
│   │   │   └── Program.cs
│   │   └── solution/
│   │
│   ├── 02-EditMode/
│   │   ├── README.md
│   │   ├── CHECKLIST.md
│   │   ├── starter/
│   │   └── solution/
│   │
│   └── 03-PlanMode/
│       ├── README.md
│       ├── CHECKLIST.md
│       ├── starter/
│       └── solution/
│
├── 03-Agents/
│   ├── SOLUTION_GUIDE.md                 # Comprehensive solutions for both exercises
│   ├── 01-CLITool/
│   │   ├── README.md                     # Exercise description (1 prompt)
│   │   ├── CHECKLIST.md
│   │   ├── starter/
│   │   └── solution/
│   │
│   └── 02-Microservice/
│       ├── README.md
│       ├── CHECKLIST.md
│       ├── starter/
│       └── solution/
│
├── 04-App-Challenge/
│   ├── 01-TodoAPI/
│   │   ├── README.md                     # Project brief & requirements
│   │   ├── starter/                      # Scaffolding only
│   │   └── reference/                    # Complete example
│   │
│   ├── 02-WeatherService/
│   │   ├── README.md
│   │   ├── starter/
│   │   └── reference/
│   │
│   └── 03-NoteAPI/
│       ├── README.md
│       ├── starter/
│       └── reference/
│
├── .github/
│   └── pull_request_template.md          # PR submission template
│
└── docs/
    ├── exercise-guidelines.md             # How each exercise type works
    ├── copilot-prompting-tips.md          # Advanced prompting techniques
    ├── dotnet-best-practices.md           # SOLID, patterns, testing
    └── setup-guide.md                     # Environment setup (optional)
```

---

## 🚀 How to Use This Repository

### **For Beginners (New to Copilot)**

1. **Start Here**: [README.md](README.md)
   - Overview of what you'll learn
   - "Start Your Journey" link to Exercise 1

2. **Per Exercise**:
   - Open exercise folder (e.g., `01-Basics/01-Calculator`)
   - Read `README.md` - understand requirements + see 1 example prompt
   - Open `/starter` folder - see partial code with TODO comments
   - Use Copilot Chat (`Ctrl+I`) to implement
   - Verify with `/tests` or manual testing
   - Check `CHECKLIST.md` before moving to next exercise

3. **When Stuck**:
   - Check the section's `SOLUTION_GUIDE.md` (e.g., `01-Basics/SOLUTION_GUIDE.md`)
   - See alternative prompting strategies
   - Review complete reference solution
   - Understand the "why" behind the pattern

4. **Complete All 4 Sections**:
   - Section 1: Basics (4 exercises)
   - Section 2: Modes (3 exercises)
   - Section 3: Agents (2 exercises)
   - Section 4: Pick 1 App Challenge

5. **Submit a PR**:
   - For App Challenge, push code to a branch
   - Create PR following template in `.github/pull_request_template.md`
   - Get feedback from mentors

---

## 📖 What Each Section Teaches

### **01-Basics** (3-4 hours)
**What You Learn**: Copilot fundamentals

- **01-Calculator**: Autocomplete, method generation, `/doc` command
- **02-StringHandler**: Chat for complex logic, LINQ basics
- **03-ArrayOperations**: Unit testing with `/tests`, test-driven thinking
- **04-FileProcessor**: Async/await, `/explain` command, error handling

**Copilot Features Covered**:
- Autocomplete (`→` tab)
- Chat (`Ctrl+I`)
- Slash commands: `/doc`, `/tests`, `/explain`, `/fix`
- Context: `@workspace`, `#selection`

---

### **02-Modes** (2-3 hours)
**What You Learn**: Advanced Copilot Chat modes

- **01-AskMode**: Research, debugging, pattern analysis
- **02-EditMode**: Bulk refactoring, multi-file transformations
- **03-PlanMode**: Architecture design, project planning

**Skills Covered**:
- Code analysis and debugging
- Refactoring patterns
- Architectural planning
- Design decision making

---

### **03-Agents** (2-3 hours)
**What You Learn**: Autonomous workflows & distributed systems

- **01-CLITool**: Agent architecture, command patterns, orchestration
- **02-Microservice**: Microservice design, inter-service communication, MCP

**Patterns Covered**:
- Pipeline pattern
- Handler/command pattern
- Service-oriented architecture
- Event-driven communication

---

### **04-App-Challenge** (3-6 hours)
**What You Learn**: Build a complete application from scratch

- **TodoAPI**: CRUD operations, database integration, testing
- **WeatherService**: External API integration, async operations
- **NoteAPI**: Complex data models, search functionality

---

## 🎓 Reading Guide for Each Exercise

### **Exercise README Structure**
```markdown
# Exercise Title — Copilot Feature

Difficulty | Time | Features

## 🎯 Learning Objectives
[3-4 bullet points]

## 📋 Requirements
[What to build, example usage]

## 🤖 Copilot Prompting (Reference)
[ONE simple prompt example]
👉 For more strategies, see SOLUTION_GUIDE.md

## 📁 File Structure
[Starter vs solution]

## 🚀 Getting Started
[Step-by-step: read starter → use Copilot → verify]
```

### **SOLUTION_GUIDE Structure**
```markdown
# Solution Guide: [Section Name]

## Exercise 1: [Title]

### 🤖 Prompting Strategies
- Approach 1: [Simple version]
- Approach 2: [All-in-one version]
- Approach 3: [Interactive version]

### ✅ Reference Solution
[Complete working code with comments]

### 💡 Key Insights
[3-5 important takeaways]

### ⚠️ Common Mistakes
[Table of mistakes and fixes]

### 🎓 Summary
[What you learned]
```

---

## ✅ Checklist Pattern

Each exercise has `CHECKLIST.md` with self-assessment items:

```markdown
## Code Quality
- [ ] Code compiles without errors
- [ ] No warnings in build output
- [ ] Follows C# naming conventions (PascalCase)
- [ ] Includes XML documentation (///)

## Functionality
- [ ] All methods implemented
- [ ] Edge cases handled
- [ ] Input validation present
- [ ] Error messages clear

## Testing
- [ ] Unit tests pass
- [ ] Manual testing done
- [ ] Edge cases tested
- [ ] Error scenarios tested

## Learning
- [ ] Understand the pattern used
- [ ] Can explain the code to others
- [ ] Tried alternative approaches
```

---

## 🔗 Navigation Quick Links

**From any exercise README:**
- `[SOLUTION_GUIDE.md](../SOLUTION_GUIDE.md)` → Detailed solutions
- `[README.md](../README.md)` → Main curriculum overview
- `[01-Basics/](../01-Basics/)` → First section

**From solution code:**
- Look for comments explaining "why"
- See docstrings explaining "what"
- Check associated checklist for "verify"

---

## 💡 Tips for Using This Curriculum

### **As a Learner**
1. Don't look at solutions immediately - try first!
2. Try multiple prompt variations (see SOLUTION_GUIDE)
3. Understand the "why", not just the "how"
4. Attempt advanced modifications after basic version works
5. Share your learnings with peers

### **As a Mentor**
1. Point struggling learners to SOLUTION_GUIDE
2. Ask "What would you ask Copilot?" instead of giving answers
3. Discuss multiple approaches shown in solution guide
4. Encourage reading the explanation sections
5. Code review their submissions against checklist

---

## 📊 Expected Time

- **Total Curriculum**: 10-16 hours
- **01-Basics**: 3-4 hours (4 exercises)
- **02-Modes**: 2-3 hours (3 exercises)
- **03-Agents**: 2-3 hours (2 exercises)
- **04-App-Challenge**: 3-6 hours (pick 1)

---

## 🎯 Success Criteria

You've completed the curriculum when you:

- ✅ Completed all 12 exercises (01-Basics through 03-Agents)
- ✅ Understood Copilot features: Chat, slash commands, modes
- ✅ Can describe patterns: Repository, Service, Agent, Microservice
- ✅ Understand SOLID principles and why they matter
- ✅ Completed 1 App Challenge and submitted PR
- ✅ Can teach someone else how to use Copilot effectively

---

## 📚 Additional Resources

In `/docs`:
- `exercise-guidelines.md` - How each exercise type works
- `copilot-prompting-tips.md` - Advanced techniques
- `dotnet-best-practices.md` - SOLID, patterns, testing
- `setup-guide.md` - Environment setup (optional)

---

## 🚀 Next Steps After This Curriculum

- Contribute to open source using Copilot
- Build your own projects with Copilot assistance
- Learn advanced Copilot features (custom instructions, etc.)
- Mentor others on this curriculum
- Explore enterprise patterns (DDD, event sourcing, etc.)

---

## 📞 Support

- **Stuck on an exercise?** → Check SOLUTION_GUIDE.md
- **Copilot not generating good code?** → Try alternative prompts from SOLUTION_GUIDE
- **Don't understand a pattern?** → Read explanation section in SOLUTION_GUIDE
- **Want to discuss?** → Post in discussion forum or ask mentor

---

Made with ❤️ for developers new to GitHub Copilot.

Happy coding! 🚀
