namespace Microservices.Services;

/// <summary>
/// Interface for async message publishing between services.
/// Allows services to communicate asynchronously via event bus.
/// 
/// TODO: Could use RabbitMQ, Azure Service Bus, or simple in-memory implementation.
/// </summary>
public interface IMessagePublisher
{
    /// <summary>
    /// Publishes an async message/event.
    /// </summary>
    Task<bool> PublishAsync(string eventName, object data);

    /// <summary>
    /// Subscribes to an event from another service.
    /// </summary>
    void Subscribe(string eventName, Func<object, Task> handler);
}
