namespace Microservices.Models;

/// <summary>
/// Order entity owned by Order Service.
/// TODO: Define order structure and properties
/// </summary>
public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public List<OrderItem> Items { get; set; } = new();
    public string Status { get; set; } = "pending"; // pending, confirmed, shipped, delivered
    public decimal TotalAmount { get; set; }
    public DateTime CreatedDate { get; set; }
}

/// <summary>
/// Order line item.
/// </summary>
public class OrderItem
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}
