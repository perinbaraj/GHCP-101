namespace Microservices.Models;

/// <summary>
/// Product information (from Product Service).
/// TODO: Define product model
/// </summary>
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
}

/// <summary>
/// Inventory information (from Inventory Service).
/// </summary>
public class Inventory
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public int Reserved { get; set; }
}
