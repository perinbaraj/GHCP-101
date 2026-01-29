# Solution Guide: 02-Modes Exercises

This guide demonstrates how to use Copilot's Ask, Edit, and Plan modes effectively with complete examples.

---

## Exercise 5: Ask Mode — Research & Debugging

### 📝 Overview
Ask Mode is for research, debugging, and understanding patterns. You paste code and ask Copilot questions to analyze, debug, or learn from it.

---

### 🤖 Prompting Strategies

#### **Strategy 1: Problem Analysis**
```
Paste buggy code and ask:
"Analyze this code. What design issues do you see?
How would you refactor it following SOLID principles?"
```
Copilot will identify anti-patterns and suggest improvements.

#### **Strategy 2: Debug-by-Discussion**
```
"This code filters users by age but returns wrong results.
Here's my test: (show test)
Here's my code: (show code)
Why doesn't it work?"
```
Copilot will trace through logic and identify bugs.

#### **Strategy 3: Pattern Research**
```
"Explain the Repository Pattern.
When should I use it? What are benefits vs drawbacks?
Show me a modern C# example with dependency injection."
```
Great for learning architectural patterns.

---

### ✅ Refactored Solution

#### **Repositories/IUserRepository.cs** (New Interface)
```csharp
namespace AskModeApp.Repositories;

using AskModeApp.Models;

/// <summary>
/// Interface for user data access operations.
/// Follows the Repository Pattern for clean abstraction.
/// </summary>
public interface IUserRepository
{
    Task<User?> GetUserByIdAsync(int id);
    Task<IEnumerable<User>> GetAllUsersAsync();
    Task<IEnumerable<User>> FilterByAgeAsync(int minAge, int maxAge);
    Task<int> AddUserAsync(User user);
    Task<bool> UpdateUserAsync(int id, User updatedUser);
    Task<bool> DeleteUserAsync(int id);
}
```

#### **Repositories/UserRepository.cs** (Refactored)
```csharp
namespace AskModeApp.Repositories;

using AskModeApp.Models;

/// <summary>
/// Repository for user data access operations.
/// Implements IUserRepository for testability and loose coupling.
/// </summary>
public class UserRepository : IUserRepository
{
    private static List<User> _users = new();
    private static int _nextId = 1;

    public async Task<User?> GetUserByIdAsync(int id)
    {
        return await Task.FromResult(_users.FirstOrDefault(u => u.Id == id));
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        // Return copy to prevent external modification
        return await Task.FromResult(_users.ToList());
    }

    public async Task<IEnumerable<User>> FilterByAgeAsync(int minAge, int maxAge)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(minAge);
        ArgumentOutOfRangeException.ThrowIfNegative(maxAge);
        
        if (minAge > maxAge)
            throw new ArgumentException("minAge cannot be greater than maxAge");

        return await Task.FromResult(
            _users.Where(u => u.Age >= minAge && u.Age <= maxAge).ToList()
        );
    }

    public async Task<int> AddUserAsync(User user)
    {
        ArgumentNullException.ThrowIfNull(user);
        
        user.Id = _nextId++;
        user.CreatedDate = DateTime.UtcNow;
        _users.Add(user);
        
        return await Task.FromResult(user.Id);
    }

    public async Task<bool> UpdateUserAsync(int id, User updatedUser)
    {
        ArgumentNullException.ThrowIfNull(updatedUser);
        
        var user = _users.FirstOrDefault(u => u.Id == id);
        if (user == null)
            return await Task.FromResult(false);

        user.Name = updatedUser.Name;
        user.Age = updatedUser.Age;
        user.Email = updatedUser.Email;
        
        return await Task.FromResult(true);
    }

    public async Task<bool> DeleteUserAsync(int id)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);
        if (user == null)
            return await Task.FromResult(false);

        _users.Remove(user);
        return await Task.FromResult(true);
    }
}
```

#### **Controllers/UserController.cs** (Refactored with DI)
```csharp
using AskModeApp.Models;
using AskModeApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AskModeApp.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    // Dependency injection: Repository is provided, not instantiated
    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
    {
        var users = await _userRepository.GetAllUsersAsync();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUserById(int id)
    {
        var user = await _userRepository.GetUserByIdAsync(id);
        if (user == null)
            return NotFound(new { message = $"User with id {id} not found" });
        
        return Ok(user);
    }

    [HttpGet("filter")]
    public async Task<ActionResult<IEnumerable<User>>> FilterByAge([FromQuery] int minAge, [FromQuery] int maxAge)
    {
        try
        {
            var users = await _userRepository.FilterByAgeAsync(minAge, maxAge);
            return Ok(users);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }

    [HttpPost]
    public async Task<ActionResult<User>> CreateUser([FromBody] User newUser)
    {
        if (newUser == null)
            return BadRequest(new { error = "User data is required" });

        var userId = await _userRepository.AddUserAsync(newUser);
        newUser.Id = userId;
        
        return CreatedAtAction(nameof(GetUserById), new { id = userId }, newUser);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, [FromBody] User updatedUser)
    {
        var success = await _userRepository.UpdateUserAsync(id, updatedUser);
        if (!success)
            return NotFound(new { message = $"User with id {id} not found" });

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        var success = await _userRepository.DeleteUserAsync(id);
        if (!success)
            return NotFound(new { message = $"User with id {id} not found" });

        return NoContent();
    }
}
```

---

### 💡 Key Improvements

1. **Interface Abstraction** - `IUserRepository` allows testing with mocks
2. **Async Operations** - All methods return `Task` for scalability
3. **Null Handling** - Returns `null` or `bool` instead of exceptions where appropriate
4. **Encapsulation** - Returns copy of list, not reference
5. **Validation** - Proper argument validation with meaningful exceptions
6. **Dependency Injection** - Repository injected into controller
7. **HTTP Status Codes** - Proper REST semantics (201 Created, 204 No Content, etc.)
8. **Error Messages** - Clear, actionable error responses

---

### ⚠️ Common Mistakes in Design

| Mistake | Problem | Fix |
|---------|---------|-----|
| Direct instantiation in Controller | Can't mock/test, tight coupling | Use dependency injection |
| Exposing internal `List<T>` | External code can modify data | Return `.ToList()` copy |
| No validation in Repository | Bad data slips in | Check parameters before adding/updating |
| Null returns without indication | Caller doesn't know if not found | Return `User?` or throw exception |
| Synchronous I/O operations | Blocks threads | Use async/await (`Task<T>`) |
| No error codes in HTTP responses | Frontend doesn't know what failed | Use proper status codes (400, 404, 500) |

---

---

## Exercise 6: Edit Mode — Bulk Refactoring

### 📝 Overview
Edit Mode is for refactoring multiple files simultaneously. You describe the transformation and Copilot applies it consistently across files.

---

### 🤖 Refactoring Strategy

**Typical Workflow:**
1. Select files to refactor
2. Describe transformation in Chat
3. Copilot suggests changes
4. Review and apply changes

---

### ✅ Complete Refactored Solution

#### **Models/Product.cs** (Refactored)
```csharp
namespace EditModeApp.Models;

/// <summary>
/// Represents a product in the catalog.
/// </summary>
public class Product
{
    /// <summary>
    /// Unique identifier for the product.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of the product.
    /// </summary>
    public string ProductName { get; set; } = string.Empty;

    /// <summary>
    /// Price of the product in USD.
    /// </summary>
    public decimal Price { get; set; }
}
```

#### **Repositories/IProductRepository.cs** (New)
```csharp
namespace EditModeApp.Repositories;

using EditModeApp.Models;

/// <summary>
/// Interface for product data access.
/// </summary>
public interface IProductRepository
{
    Task<IEnumerable<Product>> GetProductsAsync();
    Task<Product?> GetProductByIdAsync(int id);
    Task<int> AddProductAsync(Product product);
    Task<bool> UpdateProductAsync(int id, Product product);
    Task<bool> DeleteProductAsync(int id);
}
```

#### **Repositories/ProductRepository.cs** (Refactored)
```csharp
namespace EditModeApp.Repositories;

using EditModeApp.Models;

/// <summary>
/// Repository for product data access operations.
/// </summary>
public class ProductRepository : IProductRepository
{
    private static List<Product> _products = new();

    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        return await Task.FromResult(_products.ToList());
    }

    public async Task<Product?> GetProductByIdAsync(int id)
    {
        return await Task.FromResult(_products.FirstOrDefault(p => p.Id == id));
    }

    public async Task<int> AddProductAsync(Product product)
    {
        ArgumentNullException.ThrowIfNull(product);
        product.Id = _products.Any() ? _products.Max(p => p.Id) + 1 : 1;
        _products.Add(product);
        return await Task.FromResult(product.Id);
    }

    public async Task<bool> UpdateProductAsync(int id, Product product)
    {
        ArgumentNullException.ThrowIfNull(product);
        var existing = _products.FirstOrDefault(p => p.Id == id);
        if (existing == null)
            return await Task.FromResult(false);

        existing.ProductName = product.ProductName;
        existing.Price = product.Price;
        return await Task.FromResult(true);
    }

    public async Task<bool> DeleteProductAsync(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
            return await Task.FromResult(false);

        _products.Remove(product);
        return await Task.FromResult(true);
    }
}
```

#### **Services/IProductService.cs** (New)
```csharp
namespace EditModeApp.Services;

using EditModeApp.Models;

/// <summary>
/// Service for product business logic.
/// </summary>
public interface IProductService
{
    Task<IEnumerable<Product>> GetAllProductsAsync();
    Task<Product?> GetProductByIdAsync(int id);
    Task<int> CreateProductAsync(Product product);
    Task<bool> UpdateProductAsync(int id, Product product);
    Task<bool> DeleteProductAsync(int id);
}
```

#### **Services/ProductService.cs** (Refactored)
```csharp
namespace EditModeApp.Services;

using EditModeApp.Models;
using EditModeApp.Repositories;

/// <summary>
/// Service for product business operations.
/// Implements business logic and coordinates with repository.
/// </summary>
public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    /// <summary>
    /// Initializes a new instance of the ProductService.
    /// </summary>
    /// <param name="productRepository">The product repository.</param>
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _productRepository.GetProductsAsync();
    }

    public async Task<Product?> GetProductByIdAsync(int id)
    {
        return await _productRepository.GetProductByIdAsync(id);
    }

    public async Task<int> CreateProductAsync(Product product)
    {
        ArgumentNullException.ThrowIfNull(product);
        
        if (string.IsNullOrWhiteSpace(product.ProductName))
            throw new ArgumentException("Product name is required.", nameof(product.ProductName));
        
        if (product.Price <= 0)
            throw new ArgumentException("Price must be greater than zero.", nameof(product.Price));

        return await _productRepository.AddProductAsync(product);
    }

    public async Task<bool> UpdateProductAsync(int id, Product product)
    {
        ArgumentNullException.ThrowIfNull(product);
        
        if (string.IsNullOrWhiteSpace(product.ProductName))
            throw new ArgumentException("Product name is required.", nameof(product.ProductName));

        return await _productRepository.UpdateProductAsync(id, product);
    }

    public async Task<bool> DeleteProductAsync(int id)
    {
        return await _productRepository.DeleteProductAsync(id);
    }
}
```

#### **Controllers/ProductController.cs** (Refactored)
```csharp
namespace EditModeApp.Controllers;

using EditModeApp.Models;
using EditModeApp.Services;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// API controller for product operations.
/// </summary>
[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    /// <summary>
    /// Initializes a new instance of the ProductController.
    /// </summary>
    /// <param name="productService">The product service.</param>
    public ProductController(IProductService productService)
    {
        _productService = productService ?? throw new ArgumentNullException(nameof(productService));
    }

    /// <summary>
    /// Gets all products.
    /// </summary>
    /// <returns>List of all products.</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetAllProductsAsync()
    {
        var products = await _productService.GetAllProductsAsync();
        return Ok(products);
    }

    /// <summary>
    /// Gets a specific product by id.
    /// </summary>
    /// <param name="id">The product id.</param>
    /// <returns>The product if found, otherwise 404.</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProductByIdAsync(int id)
    {
        var product = await _productService.GetProductByIdAsync(id);
        if (product == null)
            return NotFound(new { message = $"Product {id} not found" });

        return Ok(product);
    }

    /// <summary>
    /// Creates a new product.
    /// </summary>
    /// <param name="product">The product to create.</param>
    /// <returns>The created product with id.</returns>
    [HttpPost]
    public async Task<ActionResult<Product>> CreateProductAsync([FromBody] Product product)
    {
        if (product == null)
            return BadRequest(new { error = "Product data is required" });

        try
        {
            var productId = await _productService.CreateProductAsync(product);
            product.Id = productId;
            return CreatedAtAction(nameof(GetProductByIdAsync), new { id = productId }, product);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }

    /// <summary>
    /// Updates an existing product.
    /// </summary>
    /// <param name="id">The product id.</param>
    /// <param name="product">The updated product data.</param>
    /// <returns>204 No Content on success, 404 if not found.</returns>
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProductAsync(int id, [FromBody] Product product)
    {
        try
        {
            var success = await _productService.UpdateProductAsync(id, product);
            if (!success)
                return NotFound(new { message = $"Product {id} not found" });

            return NoContent();
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }

    /// <summary>
    /// Deletes a product.
    /// </summary>
    /// <param name="id">The product id.</param>
    /// <returns>204 No Content on success, 404 if not found.</returns>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProductAsync(int id)
    {
        var success = await _productService.DeleteProductAsync(id);
        if (!success)
            return NotFound(new { message = $"Product {id} not found" });

        return NoContent();
    }
}
```

---

### 💡 Key Refactoring Points

1. **Async/Await** - All methods return `Task<T>`
2. **Interfaces** - `IProductRepository`, `IProductService` for testability
3. **Dependency Injection** - Constructor injection, no `new` statements
4. **PascalCase** - Consistent C# naming conventions
5. **XML Documentation** - `/summary` on all public members
6. **Validation** - Business logic validated in service layer
7. **HTTP Status Codes** - 200, 201, 204, 400, 404 usage
8. **Error Handling** - Try-catch with meaningful messages

---

---

## Exercise 7: Plan Mode — Architectural Planning

### 📝 Overview
Plan Mode breaks down complex features into structured plans. You describe what you want to build, and Copilot creates a detailed blueprint.

---

### ✅ E-Commerce System Plan

#### **ARCHITECTURE.md**
```markdown
# E-Commerce Order Management System Architecture

## System Layers

### Presentation Layer
- ASP.NET Core Web API
- Returns JSON responses
- Validation on incoming requests

### Service Layer  
- Business logic (discounts, inventory checks)
- Coordination between repositories
- Error handling

### Data Access Layer
- Repository pattern
- CRUD operations
- Database abstraction

### Database Layer
- SQL Server (or any relational DB)
- Normalized schema
- Proper indexes

## Core Components

### Product Service
- CRUD operations
- Search/filter
- Inventory tracking

### Order Service
- Order creation
- Status tracking
- Order history

### Payment Service
- Payment processing
- Refunds
- Transaction logging

### Notification Service
- Email notifications
- Order confirmations
- Shipment updates
```

#### **API_CONTRACT.md**
```markdown
# API Contract Specification

## Products Endpoints

### GET /api/products
**Description:** Get all products
**Response:** 200 OK
```json
[
  {
    "id": 1,
    "name": "Product Name",
    "price": 29.99,
    "stock": 100
  }
]
```

### GET /api/products/{id}
**Description:** Get specific product
**Response:** 200 OK (if found) or 404 Not Found

### POST /api/products
**Description:** Create new product
**Request:**
```json
{
  "name": "New Product",
  "price": 49.99,
  "stock": 50
}
```
**Response:** 201 Created

## Orders Endpoints

### POST /api/orders
**Description:** Create new order
**Request:**
```json
{
  "customerId": 1,
  "items": [
    {"productId": 1, "quantity": 2}
  ],
  "paymentMethod": "credit_card"
}
```
**Response:** 201 Created

### GET /api/orders/{id}
**Description:** Get order status
**Response:** 200 OK with order details

### PUT /api/orders/{id}/status
**Description:** Update order status (admin)
**Request:**
```json
{
  "status": "shipped"
}
```
**Response:** 204 No Content
```

#### **DATABASE_SCHEMA.md**
```markdown
# Database Schema

## Products Table
```sql
CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY,
    Name VARCHAR(255) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    StockQuantity INT NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
);
```

## Orders Table
```sql
CREATE TABLE Orders (
    Id INT PRIMARY KEY IDENTITY,
    CustomerId INT NOT NULL,
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(12, 2) NOT NULL,
    Status VARCHAR(50) DEFAULT 'pending',
    FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
);
```

## OrderItems Table
```sql
CREATE TABLE OrderItems (
    Id INT PRIMARY KEY IDENTITY,
    OrderId INT NOT NULL,
    ProductId INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (OrderId) REFERENCES Orders(Id),
    FOREIGN KEY (ProductId) REFERENCES Products(Id)
);
```
```

#### **IMPLEMENTATION_PLAN.md**
```markdown
# Implementation Roadmap

## Phase 1: MVP (Week 1-2)
- [ ] Product Service (CRUD, 3-5 hours)
- [ ] Product API endpoints (2-3 hours)
- [ ] Basic database setup (1-2 hours)
- [ ] Unit tests for Product Service (2-3 hours)

**Subtotal: 8-13 hours**

## Phase 2: Order Management (Week 3)
- [ ] Order Service implementation (5-6 hours)
- [ ] Order API endpoints (3-4 hours)
- [ ] Shopping cart logic (3-4 hours)
- [ ] Order tests (3-4 hours)

**Subtotal: 14-18 hours**

## Phase 3: Payment & Notifications (Week 4)
- [ ] Payment Service integration (6-8 hours)
- [ ] Notification Service (email) (4-5 hours)
- [ ] Payment endpoints (2-3 hours)
- [ ] Integration tests (3-4 hours)

**Subtotal: 15-20 hours**

## Total Estimated: 37-51 hours
```

---

### 💡 Plan Mode Benefits

1. **Structure** - Breaks large projects into phases
2. **Clarity** - API contracts prevent misunderstandings
3. **Database Design** - Schema planned before coding
4. **Time Estimates** - Realistic task breakdown
5. **Dependencies** - Clear what blocks what
6. **Team Alignment** - Everyone knows the plan

---

## 🎓 Summary: 02-Modes Key Concepts

### **Ask Mode**
- Use for analysis and debugging
- Ask about patterns and best practices
- Good for learning architectural decisions
- Paste code and ask "what's wrong?"

### **Edit Mode**
- Use for refactoring multiple files
- Apply consistent patterns project-wide
- Good for migrations (sync → async)
- Maintains logical consistency

### **Plan Mode**
- Use before building large features
- Creates architecture and API contracts
- Plans database schema
- Estimates effort and identifies risks

---

## 📚 Next Section

✅ Completed: **02-Modes**

🚀 Next: **03-Agents** (Autonomous agents, microservices, MCP)
