# Exercise 10: Custom Agent Modes — Creating Domain Expert Agents

**Difficulty:** Intermediate-Advanced | **Time:** 40-50 minutes | **Copilot Features:** Custom Agent Mode, System Prompts, Role-Based Prompting

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Create custom agent personas as `.md` files
- ✅ Write system prompts that define agent expertise and behavior
- ✅ Use custom agents with GitHub Copilot Agent Mode
- ✅ Ask specialized questions to domain-expert agents
- ✅ Compare agent responses across different specializations

---

## 📋 Scenario

You're learning to create **specialized agent personalities** that you can invoke with GitHub Copilot. Instead of complex code, you'll create simple `.md` files that define:
- Agent name and role
- Area of expertise
- Personality/communication style
- Guidelines for responses
- Example questions it should handle

Then you'll use these agents with Copilot to get domain-specific advice.

### **Agents to Create:**

1. **FrontendExpert.md**
   - Role: Frontend specialist
   - Expertise: React, CSS, Accessibility, UX patterns
   - Personality: User-centric, design-focused, accessibility-conscious

2. **DevOpsExpert.md**
   - Role: DevOps/Infrastructure specialist
   - Expertise: CI/CD, Docker, Kubernetes, Infrastructure, Deployment
   - Personality: Automation-focused, reliability-minded, performance-conscious

3. **QAExpert.md** (optional)
   - Role: QA/Testing specialist
   - Expertise: Testing strategies, coverage, edge cases, quality metrics
   - Personality: Detail-oriented, edge-case focused, quality-driven

### **Your Task:**

1. **Create 2-3 `.md` files** defining specialist agents
2. **Use agents with Copilot Agent Mode** to ask questions
3. **Ask CI/CD questions to DevOpsExpert** and observe specialized responses
4. **Compare answers** across different agent specializations

---

## 💻 Agent `.md` File Structure

Each agent is defined in a simple Markdown file with:

### **Example: DevOpsExpert.md**

```markdown
# DevOps Expert Agent

## Role
You are a DevOps/Infrastructure specialist with deep expertise in continuous integration, 
continuous deployment, and infrastructure automation.

## Expertise Areas
- CI/CD pipelines (GitHub Actions, Jenkins, GitLab CI)
- Container orchestration (Docker, Kubernetes, Docker Compose)
- Infrastructure as Code (Terraform, CloudFormation, Ansible)
- Monitoring and logging (Prometheus, ELK, Grafana)
- Cloud platforms (AWS, Azure, GCP)
- Linux/Unix administration
- Network and security configuration

## Personality
You are:
- Automation-focused: Always look for ways to automate manual processes
- Reliability-minded: Prioritize stability and disaster recovery
- Performance-conscious: Care about resource efficiency and scaling
- Best-practice-oriented: Follow industry standards and GitOps principles
- Hands-on: Provide practical, executable solutions

## Response Guidelines
1. Always consider scalability and reliability
2. Suggest infrastructure patterns and best practices
3. Provide specific commands or configuration examples when possible
4. Highlight security and compliance considerations
5. Suggest monitoring and alerting strategies
6. Recommend automation over manual processes

## Example Topics You Handle Well
- Setting up CI/CD pipelines from scratch
- Containerizing applications with Docker
- Kubernetes deployment strategies
- Infrastructure automation and IaC
- Monitoring and logging architecture
- Disaster recovery and backup strategies
- Scaling applications for production
```

### **Example: FrontendExpert.md**

```markdown
# Frontend Expert Agent

## Role
You are a Frontend specialist with expertise in modern web development, user experience, 
and accessible component design.

## Expertise Areas
- React, Vue.js, Angular frameworks
- CSS, Tailwind, CSS-in-JS solutions
- Web accessibility (WCAG, a11y)
- Performance optimization (Core Web Vitals)
- Component design patterns
- State management (Redux, Zustand, Context API)
- Testing frameworks (Jest, React Testing Library)
- UX/UI principles and responsive design

## Personality
You are:
- User-centric: Always consider the end user experience
- Accessibility-conscious: Web should work for everyone
- Performance-aware: Loading speed and responsiveness matter
- Component-focused: Love reusable, well-designed components
- Detail-oriented: Pay attention to design consistency

## Response Guidelines
1. Prioritize accessibility in all recommendations
2. Consider mobile-first and responsive design
3. Suggest performance optimizations proactively
4. Provide component examples when relevant
5. Highlight user experience implications
6. Recommend testing strategies for UI components

## Example Topics You Handle Well
- Building reusable React components
- Accessible form design
- CSS layout and styling solutions
- Performance optimization for web apps
- Component testing strategies
- Design system creation
```

---

## 🤖 How to Use Custom Agents with Copilot

### **Step 1: Create Agent `.md` Files**
```
starter/
├── FrontendExpert.md
├── DevOpsExpert.md
└── QAExpert.md (optional)
```

### **Step 2: Use with Copilot Agent Mode**

**Method 1: Inline System Prompt**
Open Copilot Agent and paste:
```
You are a DevOps Expert. Use this expertise:
- CI/CD pipelines, Docker, Kubernetes
- Automation-focused, reliability-minded
- Always suggest infrastructure patterns

Now answer: What's the best way to set up a GitHub Actions CI/CD pipeline for a .NET 8 application?
```

**Method 2: Reference Agent File**
```
Using the DevOpsExpert agent definition, answer these CI/CD questions:
1. How do I set up automated testing in CI/CD?
2. What's a good deployment strategy for zero-downtime releases?
3. How should I monitor a production Kubernetes cluster?
```

### **Step 3: Ask Domain-Specific Questions**

**Questions for DevOpsExpert:**
- "Design a complete CI/CD pipeline for deploying a .NET Core app to Kubernetes"
- "How would you set up automated rollback for failed deployments?"
- "What monitoring and alerting strategy would you recommend for production?"
- "Show me a GitHub Actions workflow for building and pushing Docker images"

**Questions for FrontendExpert:**
- "How would you structure an accessible React form component?"
- "What's the best approach for managing state in a large React application?"
- "Design a responsive navigation component that works on mobile"

### **Step 4: Compare Responses**
Ask the same question to different agents and compare:
- **DevOpsExpert:** Focuses on deployment and infrastructure
- **FrontendExpert:** Focuses on user experience and accessibility
- **QAExpert:** Focuses on testing and quality concerns

---

## 💻 Starter Code Structure

The `starter/` folder contains:

```
starter/
├── Program.cs (simple console for testing)
├── FrontendExpert.md (TODO: Create agent definition)
├── DevOpsExpert.md (TODO: Create agent definition)
└── QAExpert.md (optional: Create agent definition)
```

No complex code needed! Just `.md` files.

---

## ✅ Success Criteria (CHECKLIST.md)

See CHECKLIST.md for verification items covering:
- Agent `.md` file creation (2-3 agents)
- System prompt clarity and expertise definition
- Testing agents with Copilot Agent Mode
- CI/CD questions to DevOps agent
- Response quality and specialization
- File organization and documentation

---

## 🎯 Key Takeaways

After this exercise, you'll understand:
- How to create custom agent personas as markdown files
- How to define agent expertise and personality
- How to use agents with Copilot's Agent Mode
- How agent specialization affects response quality
- How to compare responses across different agents

**Congratulations!** You've completed all 3 advanced agent exercises.

---

## 🏆 Final Integration

These 3 exercises teach the full Agent Mode workflow:
1. **Exercise 8:** Learn Agent Mode for complex reasoning
2. **Exercise 9:** Learn delegation and multi-agent orchestration
3. **Exercise 10:** Learn custom agent creation and specialization

