# Exercise 9: Task Delegation with MCP — GitHub Copilot Agent as Project Manager

**Difficulty:** Advanced | **Time:** 50-60 minutes | **Copilot Features:** Agent Mode, Continue in Background, Cloud GitHub Copilot, MCP Integration

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Use GitHub Copilot Agent to delegate work to specialized sub-agents
- ✅ Integrate Model Context Protocol (MCP) servers for external tool access
- ✅ Work with agents in background while continuing other development
- ✅ Query GitHub data via MCP (repositories, issues, pull requests)
- ✅ Create an agent orchestration system with task delegation

---

## 📋 Scenario

You're building a **GitHub Repository Manager API** that helps teams:

1. **Requirements:**
   - Connect to GitHub repositories via API
   - List repositories, issues, PRs for a user/org
   - Analyze issue complexity (triaging)
   - Suggest issue assignments
   - Generate release notes from PRs
   - Track project health metrics

2. **Agent Architecture:**
   - **Main Agent (Project Manager):** Coordinates overall workflow
   - **GitHub MCP Agent:** Queries GitHub data (repos, issues, PRs)
   - **Analysis Agent:** Processes and analyzes data
   - **Report Agent:** Generates reports and summaries

3. **Your Task:**
   - Set up GitHub MCP server integration in .NET
   - Create agent delegation pattern
   - Implement "continue in background" workflow
   - Use cloud Copilot Chat for multi-turn interactions
   - Build agent-orchestrated task system

---

## 🤖 Key Concepts: Task Delegation & MCP

### **What is MCP (Model Context Protocol)?**

MCP allows agents to:
- Connect to external services (GitHub, databases, APIs)
- Query live data without manual API calls
- Perform tool-based actions autonomously
- Maintain context across multiple systems

### **GitHub MCP Server Integration**

The exercise includes access to GitHub data via MCP:
- List repositories for user/org
- Query issues with filters
- Get PR details and review status
- Track contributor statistics
- Analyze code patterns

### **Task Delegation Pattern**

```
User Request
    ↓
[Main Agent - Understands requirements]
    ↓
├─→ [GitHub MCP Agent - Fetches repo/issue data]
├─→ [Analysis Agent - Processes data]
└─→ [Report Agent - Generates output]
    ↓
Delegated responses combine → Final result
```

### **Continue in Background**

Work on one part while agents work on others:
```
You: "Implement feature X"  (Start task)
  ↓
Agent: Starts analyzing requirements (background)
  ↓
You: "While that's running, show me issue #15" (Continue working)
  ↓
Agent: Completes analysis while you're busy
  ↓
You: "Ok, I'm ready. Here's the agent result."
```

---

## 📝 Reference Prompt

Open GitHub Copilot Agent and try:

```
I'm building a GitHub Repository Manager API. I need to:

1. Set up MCP server integration to connect to GitHub
2. Create an Agent that queries GitHub data (repos, issues, PRs)
3. Build a task delegation system where main agent coordinates sub-agents:
   - GitHub MCP Agent: Fetch live data from GitHub
   - Analysis Agent: Process and categorize issues by complexity
   - Report Agent: Generate health summary

The system should support:
- Querying repos for a GitHub user/org
- Listing issues with smart filtering
- Analyzing issue complexity (labels, description length, open time)
- Generating monthly release notes from merged PRs
- Calculating project health score

Tech Stack:
- .NET 8 / C# 12
- ASP.NET Core
- MCP SDK for .NET
- GitHub API (via MCP)

Create:
1. Agent interface and implementations
2. MCP server configuration
3. Delegation pattern for sub-agents
4. Background task execution strategy
5. Cloud Copilot Chat integration points
```

---

## 💻 Starter Code Structure

```
starter/
├── GitHubManager.csproj
├── Program.cs (MCP setup TODO)
├── Agents/
│   ├── IAgent.cs (interface for all agents)
│   ├── MainAgent.cs (orchestrator TODO)
│   ├── GitHubMcpAgent.cs (queries GitHub via MCP)
│   ├── AnalysisAgent.cs (processes data TODO)
│   └── ReportAgent.cs (generates output TODO)
├── Services/
│   ├── McpServerManager.cs (MCP connection handler)
│   ├── GitHubQueryService.cs (queries via agent)
│   └── TaskDelegationService.cs (coordinates agents)
├── Models/
│   ├── RepositoryData.cs
│   ├── IssueData.cs
│   ├── PullRequestData.cs
│   └── ProjectHealthReport.cs
└── Controllers/
    └── GitHubController.cs (endpoints TODO)
```

---

## ⚙️ MCP Setup Guide

### **What MCP Tools Will Be Available**

Through the GitHub MCP server, agents can access:
```
mcp_io_github_git_list_repositories
  - List repos for user/org
  - Filter by language, stars, etc.

mcp_io_github_git_list_issues
  - Query issues with filters
  - Search by label, state, etc.

mcp_io_github_git_list_pull_requests
  - Get PRs with status
  - Filter by author, merged state

mcp_io_github_git_search_code
  - Find code patterns
  - Analyze codebase patterns
```

### **Agent Access Pattern**

Instead of direct API calls, agents request data:

```csharp
// Not this (direct API call):
var repos = await _githubClient.GetRepositories(org);

// But this (agent with MCP):
await _mainAgent.Delegate(
    agentType: AgentType.GitHubMcp,
    task: "List all repositories for GitHub org 'aspnet'",
    requiredTools: ["list_repositories", "get_repo_details"]
);
```

---

## ✅ Success Criteria (CHECKLIST.md)

See CHECKLIST.md for 60+ verification items covering:
- MCP server configuration
- Agent interfaces and implementations
- Task delegation pattern
- Background execution strategy
- GitHub data querying
- Error handling across agents
- Report generation
- Cloud Copilot integration

---

## 🎯 Key Takeaways

After this exercise, you'll understand:
- How agents delegate work to specialized sub-agents
- MCP integration in .NET applications
- Task coordination across multiple agents
- Background execution patterns
- Cloud Copilot Chat for interactive agent development

**Next:** Move to Exercise 10 (Specialized Agents) to configure domain-expert agents.

