namespace Microservices.Services.Orders;

using Microservices.Models;

/// <summary>
/// Order Service - handles order creation and management.
/// Owns its own database and order logic.
/// 
/// TODO: Implement communication with:
/// - Inventory Service (check stock availability)
/// - Payment Service (process payment)
/// - Notification Service (send confirmations)
/// </summary>
public class OrderService
{
    // TODO: Inject IOrderRepository
    // TODO: Inject IMessagePublisher for async communication

    /// <summary>
    /// Creates a new order after validating inventory and processing payment.
    /// </summary>
    public async Task<Order> CreateOrderAsync(Order order)
    {
        // TODO: Call Inventory Service to check availability
        
        // TODO: Call Payment Service to process payment
        
        // TODO: Save order to database
        
        // TODO: Publish "order.created" event for other services
        
        // TODO: Send notification
        
        throw new NotImplementedException("TODO: Implement order creation");
    }

    /// <summary>
    /// Retrieves an order by ID.
    /// </summary>
    public async Task<Order?> GetOrderAsync(int orderId)
    {
        // TODO: Query order from repository
        throw new NotImplementedException("TODO: Implement order retrieval");
    }

    /// <summary>
    /// Updates order status and notifies other services.
    /// </summary>
    public async Task<bool> UpdateOrderStatusAsync(int orderId, string status)
    {
        // TODO: Update order status in database
        
        // TODO: Publish "order.status_changed" event
        
        // TODO: Notify customer of status change
        
        throw new NotImplementedException("TODO: Implement status update");
    }
}
