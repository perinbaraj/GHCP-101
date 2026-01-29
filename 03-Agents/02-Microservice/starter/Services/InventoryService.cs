namespace Microservices.Services.Inventory;

using Microservices.Models;

/// <summary>
/// Inventory Service - manages stock levels independently.
/// 
/// TODO: Implement inventory management with:
/// - Stock checking
/// - Reservation logic
/// - Event publishing for inventory changes
/// </summary>
public class InventoryService
{
    // TODO: Inject IInventoryRepository
    // TODO: Inject IMessagePublisher

    /// <summary>
    /// Checks if items are available in stock.
    /// TODO: Called by Order Service via message bus
    /// </summary>
    public async Task<bool> CheckAvailabilityAsync(List<OrderItem> items)
    {
        // TODO: Query current stock for each item
        // TODO: Return true if all items available
        // TODO: Return false if any item unavailable
        
        throw new NotImplementedException("TODO: Implement availability check");
    }

    /// <summary>
    /// Reserves inventory for a confirmed order.
    /// TODO: Called after payment confirmed
    /// </summary>
    public async Task ReserveAsync(int orderId, List<OrderItem> items)
    {
        // TODO: Decrement stock quantity for each item
        // TODO: Increment reserved quantity
        // TODO: Publish "inventory.reserved" event
        // TODO: Handle reservation failures
        
        throw new NotImplementedException("TODO: Implement inventory reservation");
    }
}
