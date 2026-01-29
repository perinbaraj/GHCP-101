# Exercise 8: CLI Tool Agent — Autonomous Multi-Step Execution

**Difficulty:** Advanced | **Time:** 50-60 minutes | **Copilot Features:** Agent Mode, Multi-step Reasoning, Autonomous Execution

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Understand autonomous agent workflows
- ✅ Design multi-step CLI applications
- ✅ Use Copilot to break down complex workflows
- ✅ Implement command patterns and handlers
- ✅ Create extensible plugin architecture

---

## 📋 Scenario

Build a **File Conversion Agent** — a CLI tool that autonomously:

1. **Accepts user input** — What conversion to perform?
2. **Validates input** — Is the source file valid?
3. **Decides strategy** — Which converter to use?
4. **Executes conversion** — Transform the file
5. **Validates output** — Did conversion succeed?
6. **Reports results** — Success, errors, stats

The tool should support:
- CSV ↔ JSON conversion
- JSON ↔ XML conversion
- CSV → PDF report generation
- Batch processing multiple files

---

## 🤖 Copilot Agent Mode (Reference)

### **Try This Prompt**
Open Chat and ask:
```
Design a file conversion agent that accepts user input and autonomously:
1. Validates file format
2. Chooses the right converter
3. Performs conversion
4. Validates output
5. Reports results

Show me the architecture, key classes, and error handling approach.
```

**🎯 Tips:**
- Ask for command pattern implementation
- Request handler chain design
- Get validation pipeline examples

👉 **For complete agent architecture and implementation, see [SOLUTION_GUIDE.md](../SOLUTION_GUIDE.md)**

---

## 💻 Starter Code Structure

### **starter/Models/ConversionRequest.cs**
```csharp
namespace FileConversionAgent.Models;

/// <summary>
/// Represents a file conversion request.
/// </summary>
public class ConversionRequest
{
    public string SourceFilePath { get; set; }
    public string DestinationFilePath { get; set; }
    public string SourceFormat { get; set; }
    public string TargetFormat { get; set; }
    public Dictionary<string, object> Options { get; set; } = new();
}
```

### **starter/Abstractions/IConverter.cs**
```csharp
namespace FileConversionAgent.Abstractions;

using FileConversionAgent.Models;

/// <summary>
/// Defines the interface for file converters.
/// </summary>
public interface IConverter
{
    Task<bool> CanConvertAsync(ConversionRequest request);
    Task ConvertAsync(ConversionRequest request);
    string GetSupportedFormats();
}
```

### **starter/Agents/ConversionAgent.cs**
```csharp
namespace FileConversionAgent.Agents;

using FileConversionAgent.Models;
using FileConversionAgent.Abstractions;

/// <summary>
/// Autonomous agent that orchestrates file conversions.
/// </summary>
public class ConversionAgent
{
    private readonly List<IConverter> _converters;

    public ConversionAgent(List<IConverter> converters)
    {
        _converters = converters;
    }

    /// <summary>
    /// Executes the conversion workflow autonomously.
    /// </summary>
    public async Task<ConversionResult> ExecuteConversionAsync(ConversionRequest request)
    {
        try
        {
            // Step 1: Validate request
            ValidateRequest(request);

            // Step 2: Find appropriate converter
            var converter = await FindConverterAsync(request);

            // Step 3: Execute conversion
            await converter.ConvertAsync(request);

            // Step 4: Validate output
            ValidateOutput(request);

            return new ConversionResult { Success = true };
        }
        catch (Exception ex)
        {
            return new ConversionResult { Success = false, Error = ex.Message };
        }
    }

    // TODO: Implement ValidateRequest
    // TODO: Implement FindConverterAsync
    // TODO: Implement ValidateOutput
}
```

### **starter/Program.cs**
```csharp
using FileConversionAgent;
using FileConversionAgent.Converters;
using FileConversionAgent.Agents;

// TODO: Setup DI container
// TODO: Create menu-driven interface
// TODO: Accept conversion requests from user
// TODO: Execute agent with error handling
```

---

## 📋 Tasks

### **Task 1: Design the Agent Architecture**
1. Ask Copilot Prompt 1 above
2. Document the design with interfaces and classes
3. Create a sequence diagram showing the workflow

### **Task 2: Implement Core Interfaces**
1. Ask Prompt 2 for implementation strategy
2. Implement `IConverter` interface
3. Create base converter class
4. Implement at least 2 specific converters (CSV→JSON, JSON→XML)

### **Task 3: Build the Agent Orchestrator**
1. Implement `ConversionAgent` class
2. Implement validation pipeline
3. Implement converter selection logic
4. Add error handling and recovery

### **Task 4: Create CLI Interface**
1. Build menu-driven interface in Program.cs
2. Accept conversion requests from user
3. Execute agent workflows
4. Display results or errors

### **Task 5: Test the Agent**
1. Ask Prompt 4 for testing strategy
2. Write unit tests for each converter
3. Write integration tests for agent orchestration
4. Test error scenarios and recovery

---

## 🎓 Key Concepts

- **Agent Pattern** — Autonomous execution of complex workflows
- **Chain of Responsibility** — Converters handle specific transformations
- **Validation Pipeline** — Multi-stage input/output validation
- **Extensibility** — Easy to add new converters
- **Error Recovery** — Graceful handling of failures

---

## ✅ Verification

- [ ] Agent architecture is clear and extensible
- [ ] At least 2 converters implemented
- [ ] Validation pipeline working
- [ ] Error handling and recovery implemented
- [ ] CLI interface functional
- [ ] Unit tests passing
- [ ] Integration tests passing
- [ ] Can perform end-to-end conversions

---

## 💡 What is an Agent?

An **agent** is software that:
- ✅ Takes high-level goals/requests
- ✅ Breaks them into steps autonomously
- ✅ Executes steps in sequence
- ✅ Handles errors and adjusts
- ✅ Reports results

Unlike traditional imperative code, agents are **intelligent and autonomous**.

---

## 📚 Next Steps

✅ Complete this exercise → Move to **02-Microservice** (distributed agent architecture)

