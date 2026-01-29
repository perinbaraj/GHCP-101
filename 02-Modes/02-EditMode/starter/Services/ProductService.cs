namespace EditModeApp.Services;

using EditModeApp.Models;
using EditModeApp.Repositories;

/// <summary>
/// TODO: Using Edit Mode, refactor to:
/// 1. Use async/await for all methods
/// 2. Accept IProductRepository via constructor (dependency injection)
/// 3. Add proper null validation
/// 4. Add meaningful error messages
/// </summary>
public class ProductService
{
    private ProductRepository _productRepository = new();

    public List<Product> GetAllProducts()
    {
        var products = _productRepository.GetProducts();
        return products;
    }

    public Product GetProductById(int id)
    {
        var product = _productRepository.GetProductById(id);
        if (product == null)
            return null;
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
