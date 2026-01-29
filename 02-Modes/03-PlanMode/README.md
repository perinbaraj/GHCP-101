# Exercise 7: Plan Mode — Architectural Planning with Copilot

**Difficulty:** Advanced | **Time:** 45-60 minutes | **Copilot Features:** Plan Mode, Structured Breakdown, Architecture Discussion

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Use Copilot Plan Mode to break down complex features
- ✅ Design multi-layer architecture before coding
- ✅ Create structured task breakdowns for implementation
- ✅ Plan database schema and API contracts
- ✅ Understand SOLID principles in architectural context

---

## 📋 Scenario

You've been asked to design and build **an e-commerce order management system** with:
- Product catalog with inventory
- Shopping cart functionality
- Order placement and tracking
- Payment processing integration
- Notification system (email/SMS)
- Admin dashboard for order management

This is complex! Before coding, use Plan Mode to:
1. Break down into manageable components
2. Design API contracts
3. Plan database schema
4. Identify dependencies between components
5. Create implementation roadmap

---

## 🤖 Copilot Plan Mode (Reference)

### **Try This Prompt**
Open Chat and ask:
```
I need to build an e-commerce order management system.
Create a project plan including:
- System architecture and layers
- Database schema (tables, relationships)
- API endpoint specifications
- Implementation phases
- Estimated task breakdown

Be specific and actionable.
```

**🎯 Tips:**
- Ask for architecture diagrams
- Request API contract specifications
- Get database schema recommendations
- Ask for phased implementation roadmap

👉 **For complete architecture design and implementation plans, see [SOLUTION_GUIDE.md](../SOLUTION_GUIDE.md)**

---

## 📋 Tasks

### **Task 1: System Architecture**
1. Open Chat and ask the first prompt above
2. Document the architecture diagram Copilot suggests
3. Create an ASCII diagram or use Mermaid to visualize

### **Task 2: API Contract Specification**
1. Ask Prompt 2
2. Create an `API_CONTRACT.md` documenting all endpoints
3. Include request/response examples

### **Task 3: Database Design**
1. Ask Prompt 3
2. Create a database schema diagram
3. Document table relationships and indexes

### **Task 4: Implementation Roadmap**
1. Ask Prompt 4
2. Create a `IMPLEMENTATION_PLAN.md` with phased tasks
3. Estimate hours per task
4. Identify blockers and dependencies

### **Task 5: Design Review**
1. Ask Copilot: `Review this architecture design for potential issues or improvements. What are the scalability concerns?`
2. Document findings and improvements

---

## 📁 Deliverables

Create these documentation files:

```
starter/
├── ARCHITECTURE.md          # System design and components
├── API_CONTRACT.md          # REST endpoint specifications
├── DATABASE_SCHEMA.md       # ER diagram and table design
├── IMPLEMENTATION_PLAN.md   # Phased development roadmap
└── DESIGN_DECISIONS.md      # Rationale and trade-offs
```

---

## 📝 Example: ARCHITECTURE.md Structure

```markdown
# E-Commerce Order Management System Architecture

## Overview
High-level system design with components and data flow.

## Layers

### Presentation Layer
- Web API (ASP.NET Core)
- Admin Dashboard (React/Blazor)

### Business Logic Layer
- Services (OrderService, ProductService, CartService)
- Validators
- Domain models

### Data Access Layer
- Repositories
- Entity Framework Core
- SQL database

### External Integrations
- Payment Processor (Stripe/PayPal)
- Email Service (SendGrid)
- Notification Service (Twilio for SMS)

## Component Diagram
[ASCII or Mermaid diagram]

## Technology Stack
- Language: C#
- Framework: ASP.NET Core 8
- Database: SQL Server / PostgreSQL
- ORM: Entity Framework Core
- Testing: xUnit + Moq
- API Documentation: Swagger/OpenAPI
```

---

## 📝 Example: IMPLEMENTATION_PLAN.md Structure

```markdown
# Implementation Roadmap

## Phase 1: MVP (Week 1)
**Goal:** Core e-commerce functionality

### Task 1.1: Database Setup & Models
- [ ] Create database schema
- [ ] Create Product, Order, Customer models
- **Estimated:** 3 hours

### Task 1.2: Product API
- [ ] GET /products (list all)
- [ ] GET /products/{id} (get one)
- **Estimated:** 4 hours
- **Dependency:** Task 1.1

### Task 1.3: Order API
- [ ] POST /orders (create)
- [ ] GET /orders/{id} (retrieve)
- **Estimated:** 5 hours
- **Dependency:** Task 1.2

## Phase 2: Cart & Checkout (Week 2)
**Goal:** Shopping experience

### Task 2.1: Cart API
- [ ] POST /cart (add item)
- [ ] DELETE /cart/{itemId} (remove)
- **Estimated:** 4 hours

### Task 2.2: Checkout Process
- [ ] Create OrderCheckout service
- [ ] Integrate payment processor
- **Estimated:** 6 hours
- **Dependency:** Task 2.1

## Phase 3: Admin & Optimization (Week 3+)
**Goal:** Management and scalability
```

---

## ✅ Verification

- [ ] Architecture document is clear and comprehensive
- [ ] API contracts are detailed and realistic
- [ ] Database schema is normalized and efficient
- [ ] Implementation plan is phased and realistic
- [ ] All dependencies identified
- [ ] Time estimates provided for each task
- [ ] Design review completed with recommendations

---

## 🎓 Key Concepts

- **System Design** — Thinking before coding prevents costly rewrites
- **API Contracts** — Clear specs enable parallel frontend/backend development
- **Database Design** — Good schema prevents performance issues later
- **Phased Approach** — MVP first, advanced features later
- **Dependency Management** — Understanding task relationships enables efficient scheduling

---

## 💡 Plan Mode Benefits

- **Clarity** — Everyone understands the architecture
- **Parallelization** — Independent tasks can be worked on simultaneously
- **Risk Reduction** — Catch design issues before coding
- **Estimation** — Better time predictions based on detailed breakdown
- **Scalability** — Architecture designed for growth

---

## 📚 After Completion

✅ Document complete → Ready to implement! 

Consider using this plan as the foundation for the **App Challenge** (Section 4).

