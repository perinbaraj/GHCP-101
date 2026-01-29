namespace EditModeApp.Repositories;

using EditModeApp.Models;

/// <summary>
/// TODO: Refactor to use async/await and add interface
/// </summary>
public class ProductRepository
{
    private static List<Product> _products = new();

    public List<Product> GetProducts()
    {
        return _products;
    }

    public Product GetProductById(int id)
    {
        var product = _products.FirstOrDefault(p => p.id == id);
        if (product == null)
            return null;
        return product;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void UpdateProduct(int id, Product product)
    {
        var existing = _products.FirstOrDefault(p => p.id == id);
        if (existing != null)
        {
            existing.productName = product.productName;
            existing.price = product.price;
        }
    }

    public void DeleteProduct(int id)
    {
        var product = _products.FirstOrDefault(p => p.id == id);
        if (product != null)
            _products.Remove(product);
    }
}
