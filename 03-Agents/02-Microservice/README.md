# Exercise 9: Microservice Agent — Distributed Architecture & MCP

**Difficulty:** Advanced | **Time:** 60+ minutes | **Copilot Features:** Agent Coordination, MCP Integration, Multi-service Orchestration

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Design distributed microservice architectures
- ✅ Understand Model Context Protocol (MCP) basics
- ✅ Implement inter-service communication
- ✅ Design API gateways and service coordination
- ✅ Learn about eventual consistency and event-driven architecture

---

## 📋 Scenario

Design and build a **simplified e-commerce microservice system** with multiple autonomous agents:

### **Services:**
1. **Product Service** — Manages product catalog
2. **Inventory Service** — Tracks stock levels
3. **Order Service** — Handles order creation and tracking
4. **Payment Service** — Processes payments
5. **Notification Service** — Sends emails/notifications
6. **API Gateway** — Routes requests to services

### **Workflow:**
```
User → API Gateway → Order Service → Inventory Service
                           ↓
                    Payment Service
                           ↓
                    Notification Service
```

---

## 🤖 Copilot Agent Mode (Reference)

### **Try This Prompt**
Open Chat and ask:
```
Design a microservice architecture for e-commerce with:
- Product, Inventory, Order, Payment, Notification services
- API Gateway
- Inter-service communication

Include architecture diagram, responsibilities, communication patterns,
error handling, and resilience strategies. Show C# examples.
```

**🎯 Tips:**
- Ask about REST vs messaging patterns
- Request service discovery concepts
- Get API Gateway implementation examples
- Ask about event-driven architecture

👉 **For complete microservice design and implementation, see [SOLUTION_GUIDE.md](../SOLUTION_GUIDE.md)**

---

## 💻 Starter Code Structure

### **starter/Shared/Models.cs**
```csharp
namespace EcommerceServices.Shared;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public List<OrderItem> Items { get; set; }
    public OrderStatus Status { get; set; }
}

public class OrderItem
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

public enum OrderStatus { Pending, Confirmed, Shipped, Delivered, Cancelled }
```

### **starter/Services/ProductService.cs**
```csharp
namespace EcommerceServices;

using EcommerceServices.Shared;

/// <summary>
/// Manages product catalog.
/// </summary>
public class ProductService
{
    private static List<Product> _products = new();

    public async Task<Product> GetProductAsync(int id)
    {
        return await Task.FromResult(_products.FirstOrDefault(p => p.Id == id));
    }

    public async Task<List<Product>> GetAllProductsAsync()
    {
        return await Task.FromResult(_products);
    }

    public async Task AddProductAsync(Product product)
    {
        _products.Add(product);
        await Task.CompletedTask;
    }
}
```

### **starter/Services/OrderService.cs**
```csharp
namespace EcommerceServices;

using EcommerceServices.Shared;

/// <summary>
/// Orchestrates order creation and processing.
/// Uses other services (Inventory, Payment, Notification).
/// </summary>
public class OrderService
{
    private readonly ProductService _productService;
    private readonly InventoryService _inventoryService;
    private readonly PaymentService _paymentService;
    private readonly NotificationService _notificationService;

    private static List<Order> _orders = new();

    public OrderService(
        ProductService productService,
        InventoryService inventoryService,
        PaymentService paymentService,
        NotificationService notificationService)
    {
        _productService = productService;
        _inventoryService = inventoryService;
        _paymentService = paymentService;
        _notificationService = notificationService;
    }

    /// <summary>
    /// Creates an order and orchestrates payment and inventory.
    /// </summary>
    public async Task<Order> CreateOrderAsync(int customerId, List<OrderItem> items)
    {
        // TODO: Implement Order Service workflow
        // Step 1: Validate products exist
        // Step 2: Check inventory
        // Step 3: Process payment
        // Step 4: Reduce inventory
        // Step 5: Send notification
        // Step 6: Return order

        throw new NotImplementedException();
    }

    public async Task<Order> GetOrderAsync(int orderId)
    {
        return await Task.FromResult(_orders.FirstOrDefault(o => o.Id == orderId));
    }
}
```

### **starter/Gateway/ApiGateway.cs**
```csharp
namespace EcommerceServices;

using EcommerceServices.Shared;

/// <summary>
/// Routes requests to appropriate microservices.
/// </summary>
public class ApiGateway
{
    private readonly ProductService _productService;
    private readonly OrderService _orderService;

    public ApiGateway(ProductService productService, OrderService orderService)
    {
        _productService = productService;
        _orderService = orderService;
    }

    /// <summary>
    /// Routes HTTP-like requests to services.
    /// </summary>
    public async Task<object> HandleRequestAsync(string endpoint, string method, object body = null)
    {
        // TODO: Implement routing logic
        // Pattern: GET /products/{id} → ProductService.GetProductAsync(id)
        // Pattern: POST /orders → OrderService.CreateOrderAsync(...)
        // Pattern: GET /orders/{id} → OrderService.GetOrderAsync(id)

        throw new NotImplementedException();
    }
}
```

---

## 📋 Tasks

### **Task 1: Microservice Architecture Design**
1. Ask Copilot Prompt 1
2. Document service boundaries and responsibilities
3. Create architecture diagram (ASCII or Mermaid)
4. Define service contracts (what each service exposes)

### **Task 2: Implement Services**
1. Implement `ProductService`
2. Implement `InventoryService`
3. Implement `PaymentService` (mock)
4. Implement `NotificationService` (mock)

### **Task 3: Build Order Orchestrator**
1. Implement `OrderService.CreateOrderAsync()` with multi-step workflow
2. Handle inter-service communication
3. Implement error recovery (e.g., payment fails → cancel order)
4. Use async/await throughout

### **Task 4: Design API Gateway**
1. Ask Copilot Prompt 4
2. Implement `ApiGateway.HandleRequestAsync()`
3. Route requests to appropriate services
4. Handle errors and fallbacks

### **Task 5: Communication Patterns**
1. Ask Copilot Prompt 2
2. Implement synchronous (REST-like) calls between services
3. Consider asynchronous patterns (optional advanced)
4. Document communication decisions

### **Task 6: Testing**
1. Write unit tests for each service in isolation
2. Write integration tests for Order workflow
3. Test failure scenarios (payment fails, inventory unavailable)
4. Test API Gateway routing

---

## 🤖 What is MCP (Model Context Protocol)?

**MCP** is a protocol that:
- **Standardizes** how AI agents interact with tools and data sources
- **Enables** agents to understand context from multiple sources
- **Facilitates** better decision-making through rich context
- **Improves** coordination between multiple agents/services

In microservices context: MCP helps agents (or services) share context and coordinate actions.

---

## 🎓 Key Concepts

- **Service Boundary** — Clear separation of concerns
- **API Gateway** — Single entry point for clients
- **Service Coordination** — Orchestrating workflow across services
- **Distributed Transactions** — Handling multi-service operations
- **Resilience** — Handling service failures gracefully
- **Event-Driven Architecture** — Services communicate via events

---

## ✅ Verification

- [ ] All 5+ services implemented
- [ ] Service contracts clearly defined
- [ ] Order creation workflow orchestrates all services
- [ ] API Gateway routes requests correctly
- [ ] Error scenarios handled (payment fails, inventory low)
- [ ] Unit tests for each service passing
- [ ] Integration tests for order workflow passing
- [ ] Documentation explains architecture

---

## 📚 Section 3 Complete!

✅ Exercise 8 & 9 complete → **Agents section done!**

🎉 **Congratulations!** You've mastered Copilot Basics, Modes, and Agents. 

Next: Section 4 - **60-Minute App Challenge** → Build a real-world app!

