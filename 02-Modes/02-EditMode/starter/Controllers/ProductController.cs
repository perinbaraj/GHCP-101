namespace EditModeApp.Controllers;

using EditModeApp.Models;
using EditModeApp.Services;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// TODO: Using Edit Mode, refactor to:
/// 1. Use PascalCase consistently (svc → _productService)
/// 2. Return IActionResult with proper HTTP status codes
/// 3. Add XML documentation to all methods
/// 4. Handle null cases properly
/// 5. Inject service via constructor
/// </summary>
[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    private ProductService svc = new();

    [HttpGet]
    public List<Product> GetProducts()
    {
        return svc.GetAllProducts();
    }

    [HttpGet("{id}")]
    public Product GetProductById(int id)
    {
        return svc.GetProductById(id);
    }

    [HttpPost]
    public void CreateProduct(Product product)
    {
        svc.AddProduct(product);
    }

    [HttpPut("{id}")]
    public void UpdateProduct(int id, Product product)
    {
        svc.UpdateProduct(id, product);
    }

    [HttpDelete("{id}")]
    public void DeleteProduct(int id)
    {
        svc.DeleteProduct(id);
    }
}
