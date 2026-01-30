# Exercise 10: Specialized Domain Agents — Configuring Expert Agents

**Difficulty:** Advanced | **Time:** 45-60 minutes | **Copilot Features:** Agent Specialization, Role-Based Logic, Tool Assignment

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Configure specialized agents with domain expertise
- ✅ Design role-based agent personas (Frontend, Backend, DevOps, QA)
- ✅ Route tasks to agents based on expertise
- [ ] Implement tool-specific capabilities per agent
- ✅ Handle agent specialization conflicts (disagreements)
- ✅ Create agent competency scoring system
- ✅ Build agent capability registry

---

## 📋 Scenario

You're building a **Development Team AI Assistant** that orchestrates specialized agents:

### **Specialized Agents to Create:**

1. **Frontend Specialist Agent**
   - Expertise: UI/UX, React, CSS, Accessibility
   - Tools: Browser testing, design validation, a11y checking
   - Responsibilities: Code reviews for frontend, suggest UX improvements

2. **Backend Specialist Agent**
   - Expertise: APIs, databases, security, performance
   - Tools: Database schema analysis, API design, security scanning
   - Responsibilities: Architecture reviews, query optimization

3. **DevOps Specialist Agent**
   - Expertise: Deployment, infrastructure, monitoring, scaling
   - Tools: Docker, Kubernetes, CI/CD, logging
   - Responsibilities: Pipeline configuration, infrastructure setup

4. **QA Specialist Agent**
   - Expertise: Testing strategies, test automation, edge cases
   - Tools: Test generation, coverage analysis, failure analysis
   - Responsibilities: Test planning, bug triage, quality metrics

### **Your Task:**

Build a system where:
- User submits a task/code for review
- Main agent routes to appropriate specialist
- Specialist analyzes using domain knowledge
- Handles cases where multiple agents should review
- Conflicts resolved via consensus or escalation

---

## 🤖 Key Concepts: Agent Specialization

### **Agent Roles & Expertise**

```
User Task
    ↓
[Task Router/Main Agent]
    ├─ Is this a frontend issue? → Frontend Agent
    ├─ Is this a database issue? → Backend Agent
    ├─ Is this infrastructure? → DevOps Agent
    └─ Is this a test issue? → QA Agent
```

### **Competency Scoring**

Each agent has:
- **Core Competency:** Primary domain (90-100%)
- **Secondary Competency:** Related domains (60-80%)
- **Low Competency:** Unfamiliar domains (20-40%)

```csharp
// Example: Frontend agent reviewing backend API
// Primary: Frontend components (95%)
// Secondary: API integration (65%)
// Low: Database schema (25%)
```

### **Multi-Agent Review**

Some tasks need multiple perspectives:

```
Code Review Request
    ↓
├─→ Frontend Agent: "UI looks good, accessibility OK"
├─→ Backend Agent: "API endpoint design needs work"
└─→ QA Agent: "Test coverage low, edge cases missing"
    ↓
Consolidated feedback with agent agreement/disagreement
```

### **Conflict Resolution**

When agents disagree:
```
Frontend: "Use CSS-in-JS"
Backend: "Use plain CSS for performance"
    ↓
[Conflict Resolution Engine]
    ↓
Decision: "Use CSS modules (compromise)"
```

---

## 📝 Reference Prompt

Open GitHub Copilot Agent and try:

```
I'm building a Development Team AI Assistant with specialized agents.
I need 4 expert agents with distinct personalities and expertise:

1. Frontend Specialist
   - Keywords: React, Vue, CSS, Accessibility, UX
   - Reviews: Component structure, styling, user experience
   - Tools: Browser automation, a11y testing, design validation

2. Backend Specialist
   - Keywords: APIs, databases, security, performance
   - Reviews: Code architecture, database design, security
   - Tools: Query analysis, API design, threat modeling

3. DevOps Specialist
   - Keywords: Docker, Kubernetes, CI/CD, monitoring
   - Reviews: Infrastructure, deployment, scalability
   - Tools: Container analysis, pipeline validation, health checks

4. QA Specialist
   - Keywords: Testing, edge cases, coverage, quality
   - Reviews: Test strategy, bug triage, quality metrics
   - Tools: Test generation, coverage analysis, failure diagnosis

Create:
1. Agent specialization profiles (competencies, tools)
2. Task router that identifies which agent should review
3. Competency scoring system
4. Multi-agent consensus when multiple agents should review
5. Conflict resolution logic
6. Agent capability registry

Include competency levels (0-100) for each agent across domains.
```

---

## 💻 Starter Code Structure

```
starter/
├── TeamAssistant.csproj
├── Program.cs (agent registration TODO)
├── Agents/
│   ├── ISpecializedAgent.cs (extends IAgent)
│   ├── FrontendSpecialist.cs (implementation TODO)
│   ├── BackendSpecialist.cs (implementation TODO)
│   ├── DevOpsSpecialist.cs (implementation TODO)
│   ├── QASpecialist.cs (implementation TODO)
│   └── SpecializedAgentBase.cs (shared logic)
├── Services/
│   ├── AgentSpecializationRegistry.cs (agent capabilities)
│   ├── TaskRouter.cs (route to right agent)
│   ├── CompetencyScorer.cs (score matching)
│   ├── ConflictResolver.cs (handle disagreement)
│   └── MultiAgentConsensus.cs (aggregate reviews)
├── Models/
│   ├── AgentProfile.cs (expertise, tools)
│   ├── TaskRequest.cs (what to review)
│   ├── SpecialistReview.cs (agent output)
│   ├── ConflictData.cs (disagreement tracking)
│   └── TeamDecision.cs (final consensus)
└── Controllers/
    └── ReviewController.cs (submit for review)
```

---

## 🎯 Agent Specialization Pattern

### **AgentProfile Definition**

```csharp
// Example: Frontend Specialist Profile
new AgentProfile
{
    Name = "Frontend Specialist",
    PrimaryDomain = "Frontend",
    Competencies = new()
    {
        { "React/Vue", 95 },
        { "CSS/Styling", 92 },
        { "Accessibility", 88 },
        { "Performance", 75 },
        { "APIs", 65 },
        { "Databases", 30 }
    },
    Tools = new[] { "BrowserTest", "A11yChecker", "DesignValidator" },
    Persona = "Thinks UI-first, loves elegant components",
    ReviewFocus = new[] { "Code structure", "UX", "Accessibility" }
}
```

### **Task Routing Example**

```csharp
// User submits: "Review this React component and database query"
var task = new TaskRequest
{
    Title = "Code Review Request",
    Topics = new[] { "React component", "SQL query" },
    Code = codeSample
};

// Router determines:
// Frontend Agent: 95% match (React component)
// Backend Agent: 85% match (SQL query)
// DevOps Agent: 10% match
// QA Agent: 40% match

// Decision: Route to BOTH Frontend and Backend agents
```

---

## ✅ Success Criteria (CHECKLIST.md)

See CHECKLIST.md for 65+ verification items covering:
- Agent specialization profiles
- Competency scoring system
- Task routing logic
- Multi-agent consensus
- Conflict resolution
- Agent registration
- API endpoints
- Error handling

---

## 🎯 Key Takeaways

After this exercise, you'll understand:
- How to configure agents with specific expertise
- Building competency scoring systems
- Task routing based on agent capabilities
- Multi-agent consensus and decision-making
- Conflict resolution in collaborative systems
- Real-world team dynamics in AI assistants

**Congratulations!** You've completed all 3 advanced agent exercises.

---

## 🏆 Next Steps

1. **Review** all agent exercises and compare approaches
2. **Integrate** lessons into personal projects
3. **Experiment** with agent role-playing for different domains
4. **Deploy** a team assistant in your organization
5. **Iterate** on agent personas based on real usage

