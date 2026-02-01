# 01-Basics: GitHub Copilot Fundamentals

**Level:** Beginner | **Duration:** 2-3 hours total | **Prerequisite:** VS Code with GitHub Copilot installed

---

## 🎯 Section Overview

This section teaches the **fundamental features** of GitHub Copilot through 4 progressive exercises. You'll learn how to work efficiently with Copilot in real-world scenarios.

### **Learning Path**

```
00-CodeCompletion-Basics
    ↓
01-Comment-To-Code
    ↓
02-Chat-Fundamentals
    ↓
03-Inline-Chat-Refactoring
```

---

## 📚 Exercises

### **Exercise 1: Code Completion Basics** ⚡
**Time:** 15-20 minutes | **Copilot Features:** Autocomplete, Tab completion, Multi-line suggestions

Learn how Copilot's autocomplete works and how to use Tab to accept suggestions efficiently.

**Key Skills:**
- Using autocomplete ghost text
- Accepting/rejecting suggestions with Tab/Escape
- Recognizing when suggestions are helpful
- Using `Ctrl+Space` to trigger autocomplete manually

**Topics Covered:**
- Basic autocomplete workflow
- Multi-line suggestions
- Naming conventions (PascalCase)
- When to accept vs. reject

📂 Folder: [00-CodeCompletion-Basics](00-CodeCompletion-Basics)

---

### **Exercise 2: Comment-To-Code** 💬
**Time:** 20-25 minutes | **Copilot Features:** Comment-driven code generation, Chat, Code validation

Learn to write effective comments that help Copilot generate better code.

**Key Skills:**
- Writing specific, actionable comments
- Including examples in comments
- Mentioning edge cases in comments
- Iterating on comments when code generation fails

**Topics Covered:**
- Comment-driven development
- LINQ operations
- String manipulation patterns
- Edge case handling

📂 Folder: [01-Comment-To-Code](01-Comment-To-Code)

---

### **Exercise 3: Chat Fundamentals** 💭
**Time:** 25-30 minutes | **Copilot Features:** Chat (`Ctrl+I`), @-commands, #-commands, Slash commands, Testing

Master Copilot Chat and learn how to use context commands for better results.

**Key Skills:**
- Using `@workspace`, `@vscode`, `@terminal` for context
- Using `#file`, `#selection` to scope code
- Using `/doc`, `/tests`, `/explain`, `/fix` slash commands
- Writing clear prompts for chat

**Topics Covered:**
- Chat context commands (@)
- Code selection commands (#)
- Action commands (/)
- Unit testing with `/tests`
- Code explanation with `/explain`

📂 Folder: [02-Chat-Fundamentals](02-Chat-Fundamentals)

---

### **Exercise 4: Inline Chat Refactoring** ⚙️
**Time:** 30-35 minutes | **Copilot Features:** Inline chat (`Ctrl+I`), Quick refactoring, Error handling

Learn to use inline chat for quick code transformations and improvements.

**Key Skills:**
- Using `Ctrl+I` for inline chat
- Quick refactoring requests
- Adding error handling with inline chat
- Improving code readability
- Adding documentation with inline chat

**Topics Covered:**
- Inline chat workflow
- Error handling patterns
- Input validation
- Async/await patterns
- File I/O operations

📂 Folder: [03-Inline-Chat-Refactoring](03-Inline-Chat-Refactoring)

---

## 🗺️ Feature Coverage by Exercise

| Feature | Ex 1 | Ex 2 | Ex 3 | Ex 4 |
|---------|------|------|------|------|
| **Autocomplete** | ✅ | | | |
| **Tab Completion** | ✅ | | | |
| **Comments** | | ✅ | | |
| **Chat** | | ✅ | ✅ | ✅ |
| **@workspace** | | | ✅ | |
| **@vscode** | | | ✅ | |
| **#file** | | | ✅ | |
| **#selection** | | | ✅ | ✅ |
| **/doc** | | ✅ | ✅ | ✅ |
| **/tests** | | | ✅ | |
| **/explain** | | | ✅ | ✅ |
| **/fix** | | | ✅ | ✅ |
| **Inline Chat** | | | | ✅ |
| **Code Completion** | ✅ | | | |

---

## 💻 Technology Stack

- **Language:** C# (net8.0)
- **Testing Framework:** xUnit (Exercise 3)
- **File Operations:** System.IO, System.Text.Json (Exercise 4)
- **LINQ:** Functional programming patterns (Exercises 2, 3)

---

## 🚀 Getting Started

### **Prerequisites**
- ✅ VS Code installed
- ✅ GitHub Copilot extension installed and active
- ✅ .NET SDK 8.0 or later
- ✅ C# extension for VS Code

### **Quick Start**
1. Start with **Exercise 1** ([00-CodeCompletion-Basics](00-CodeCompletion-Basics))
2. Open the README in each exercise folder
3. Follow the step-by-step instructions
4. Check your work against the solution folder
5. Complete the self-assessment checklist
6. Move to the next exercise

---

## 📋 Exercise Structure

Each exercise folder contains:

```
Exercise-Name/
├── README.md           # Full instructions and learning objectives
├── CHECKLIST.md        # Self-assessment checklist
├── starter/
│   ├── *.cs           # Partial implementation to complete
│   ├── *.csproj       # Project file
│   └── Program.cs     # Main entry point
└── solution/
    ├── *.cs           # Reference implementation
    ├── *.csproj       # Project file
    └── Program.cs     # Reference main
```

---

## 🎯 Learning Objectives (Overall)

By completing this section, you will:

✅ Understand Copilot autocomplete behavior and best practices
✅ Write effective comments for code generation
✅ Use Copilot Chat with context and selection commands
✅ Master slash commands (/doc, /tests, /explain, /fix)
✅ Perform quick refactoring with inline chat
✅ Recognize when to use each Copilot feature
✅ Build real C# applications with Copilot assistance
✅ Apply error handling and validation patterns
✅ Write clean, maintainable code with Copilot

---

## 💡 Pro Tips

### **Autocomplete**
- Wait 1-2 seconds for suggestion to appear
- More context = better suggestions
- Review before accepting with Tab

### **Comments**
- Be specific about input/output
- Include examples: `"hello" → "olleh"`
- Mention edge cases: "null returns empty"

### **Chat**
- Use `@workspace` for project context
- Use `#file` to reference entire classes
- Use `#selection` for specific methods
- One question at a time

### **Inline Chat**
- Position cursor on method name
- Press `Ctrl+I` for quick edits
- Be specific: "Add error handling" vs "Fix"
- Review before accepting

---

## 📊 Time Estimates

| Exercise | Time | Difficulty |
|----------|------|-----------|
| 00-CodeCompletion-Basics | 15-20 min | Beginner |
| 01-Comment-To-Code | 20-25 min | Beginner |
| 02-Chat-Fundamentals | 25-30 min | Beginner-Intermediate |
| 03-Inline-Chat-Refactoring | 30-35 min | Intermediate |
| **Total Section** | **1.5-2.5 hours** | |

---

## ✅ Section Completion Criteria

You're ready to move to **02-Modes** when:

- ✅ All 4 exercises completed
- ✅ All checklists at ≥70% completion
- ✅ Programs run without errors
- ✅ You understand when to use each Copilot feature
- ✅ You can explain the difference between:
  - Autocomplete vs. Chat
  - Chat vs. Inline Chat
  - Comment-to-code vs. Chat

---

## 🎓 Next Steps

After completing this section:

**→ Move to [02-Modes](../02-Modes/) to learn:**
- Ask Mode: Detailed Q&A for complex problems
- Edit Mode: Production code strategies
- Plan Mode: Architectural planning

---

## 📚 Additional Resources

- [GitHub Copilot Documentation](https://docs.github.com/copilot)
- [Copilot Best Practices](../docs/copilot-prompting-tips.md)
- [.NET Best Practices](../docs/dotnet-best-practices.md)
- [Exercise Guidelines](../docs/exercise-guidelines.md)

---

## ❓ Frequently Asked Questions

**Q: I don't see Copilot suggestions appearing**
A: Check that Copilot is active (status bar icon), wait 1-2 seconds, or press `Ctrl+Space` to trigger.

**Q: Can I skip exercises?**
A: Not recommended - each exercise builds on previous learning. Start with Exercise 1.

**Q: What if Copilot's suggestion is wrong?**
A: Press `Escape` to reject, then either type manually or refine your prompt and try again.

**Q: Do I need to match the solution exactly?**
A: No - your implementation can differ as long as it works correctly and follows best practices.

**Q: Which Copilot feature should I use for X?**
A: See the feature coverage table above, or check the tips section for each feature.

---

## 🤝 Need Help?

- Review the README in each exercise
- Check the CHECKLIST for specific guidance
- Look at the solution folder for reference
- Use `/explain` in Copilot Chat to understand code
- Ask in course discussions or forums

---

## 📝 Notes

- Exercises use C# net8.0 for consistency
- All code follows C# naming conventions (PascalCase public, camelCase private)
- Focus on learning Copilot features first, C# skills second
- Don't memorize code - understand the patterns

---

**Ready to start? Open [00-CodeCompletion-Basics/README.md](00-CodeCompletion-Basics/README.md)** 🚀
