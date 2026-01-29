# Exercise 6: Edit Mode — Bulk Refactoring with Copilot

**Difficulty:** Intermediate-Advanced | **Time:** 40-50 minutes | **Copilot Features:** Edit Mode, Multi-file Refactoring, Chat

---

## 🎯 Learning Objectives

By completing this exercise, you will:
- ✅ Use Copilot Edit Mode for bulk transformations
- ✅ Refactor code across multiple files simultaneously
- ✅ Apply consistent naming conventions project-wide
- ✅ Migrate code patterns (callbacks to async/await)
- ✅ Improve code maintainability at scale

---

## 📋 Task

You have a **legacy ASP.NET Core project with inconsistent patterns and naming**. Use Copilot Edit Mode to:

1. **Standardize naming** — Rename classes, methods, variables consistently
2. **Add async/await** — Convert synchronous methods to async
3. **Apply formatting** — Consistent indentation, spacing, organization
4. **Extract duplicates** — Refactor repeated code into shared methods
5. **Add XML docs** — Generate documentation across the project

---

## 🤖 Copilot Edit Mode (Reference)

### **Try This Prompt**
Open Chat and describe what to refactor:
```
Refactor these files to use async/await, apply PascalCase naming,
add XML docs, and use dependency injection. Keep business logic intact.
```

**🎯 Tips:**
- Select files before asking Copilot
- Ask follow-ups: "Can you add unit tests?" or "Show async/await patterns"
- Use `/explain` to understand refactored code

👉 **For refactored examples and patterns, see [SOLUTION_GUIDE.md](../SOLUTION_GUIDE.md)**

---

## 💻 Starter Code (Inconsistent)

### **starter/Models/Product.cs**
```csharp
namespace EditModeApp.Models;

// Issue: Inconsistent documentation
public class Product
{
    public int id { get; set; } // Issue: camelCase in C# (should be PascalCase)
    public string productName { get; set; }
    public decimal price { get; set; }
}
```

### **starter/Services/ProductService.cs** (Synchronous)
```csharp
namespace EditModeApp.Services;

using EditModeApp.Models;
using EditModeApp.Repositories;

public class ProductService
{
    private ProductRepository _productRepository = new(); // Issue: Direct instantiation

    // Issue: Synchronous with no async
    public List<Product> GetAllProducts()
    {
        var products = _productRepository.GetProducts();
        return products;
    }

    public Product GetProductById(int id)
    {
        var product = _productRepository.GetProductById(id);
        if (product == null)
            return null; // Issue: Should throw or return Optional
        return product;
    }

    public void AddProduct(Product product)
    {
        _productRepository.AddProduct(product);
    }

    public void UpdateProduct(int id, Product product)
    {
        _productRepository.UpdateProduct(id, product);
    }

    public void DeleteProduct(int id)
    {
        _productRepository.DeleteProduct(id);
    }
}
```

### **starter/Controllers/ProductController.cs** (Inconsistent)
```csharp
namespace EditModeApp.Controllers;

using EditModeApp.Models;
using EditModeApp.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    private ProductService svc = new(); // Issue: Naming, direct instantiation

    [HttpGet]
    public List<Product> GetProducts() // Issue: Should return IActionResult
    {
        return svc.GetAllProducts();
    }

    [HttpGet("{id}")]
    public Product GetProductById(int id) // Issue: No null handling
    {
        return svc.GetProductById(id);
    }

    [HttpPost]
    public void CreateProduct(Product product) // Issue: No return value
    {
        svc.AddProduct(product);
    }

    [HttpPut("{id}")]
    public void UpdateProduct(int id, Product product) // Issue: No return value
    {
        svc.UpdateProduct(id, product);
    }

    [HttpDelete("{id}")]
    public void DeleteProduct(int id) // Issue: No return value
    {
        svc.DeleteProduct(id);
    }
}
```

---

## 📋 Refactoring Tasks

### **Task 1: Fix Model Naming**
- Rename `id` → `Id`, `productName` → `ProductName`, `price` → `Price`
- Ensure all properties use PascalCase

### **Task 2: Add Async/Await**
- Convert `ProductService` methods to async
- Add `Async` suffix to method names
- Update repository calls to use async equivalents

### **Task 3: Dependency Injection**
- Create `IProductRepository` and `IProductService` interfaces
- Update controller to receive injected services
- Remove direct instantiation

### **Task 4: Update Return Types**
- Change controller methods to return `IActionResult`
- Add proper HTTP status codes (200, 201, 404, 400)
- Add error handling

### **Task 5: Add Documentation**
- Add XML documentation to all public classes and methods
- Include parameter and return value descriptions

---

## ✅ Verification

- [ ] All properties follow PascalCase naming
- [ ] All methods are async with `Async` suffix
- [ ] All methods have XML documentation
- [ ] Dependency injection configured
- [ ] Controllers return `IActionResult` with proper status codes
- [ ] No direct instantiation (all DI)
- [ ] Code compiles without errors
- [ ] Functionality preserved after refactoring

---

## 🎓 Key Concepts

- **Edit Mode** enables large-scale transformations
- **Pattern consistency** improves maintainability
- **Async/await** is essential in modern .NET
- **Dependency injection** enables testing and flexibility
- **XML documentation** aids discoverability

---

## 📚 Next Steps

✅ Complete this exercise → Move to **03-PlanMode** (architectural planning)

