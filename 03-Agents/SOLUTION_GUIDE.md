# Solution Guide: 03-Agents Exercises (Revised)

Comprehensive guide for hands-on GitHub Copilot Agent Mode exercises with task delegation and specialized agent patterns.

---

## Exercise 8: GitHub Copilot Agent Mode Fundamentals

### 📝 Overview
Learn practical Agent Mode usage by building a Personal Finance Dashboard API. This exercise focuses on letting agents handle complex task breakdown and multi-step reasoning.

---

### 🤖 Agent Architecture Strategy

**Key Pattern:** Command Handler Pattern + Pipeline Pattern

```
User Input 
    ↓
[Validation Handler]
    ↓
[File Format Analyzer]
    ↓
[Strategy Selector]
    ↓
[Converter Handler] (CSV→JSON, JSON→XML, etc.)
    ↓
[Output Validator]
    ↓
[Result Reporter]
```

---

### ✅ Reference Implementation

#### **Models/ConversionRequest.cs**
```csharp
namespace FileConversionAgent.Models;

/// <summary>
/// Represents a file conversion request.
/// </summary>
public class ConversionRequest
{
    /// <summary>
    /// Source file path.
    /// </summary>
    public string SourceFilePath { get; set; } = string.Empty;

    /// <summary>
    /// Target file path.
    /// </summary>
    public string TargetFilePath { get; set; } = string.Empty;

    /// <summary>
    /// Source format (csv, json, xml).
    /// </summary>
    public string SourceFormat { get; set; } = string.Empty;

    /// <summary>
    /// Target format (csv, json, xml).
    /// </summary>
    public string TargetFormat { get; set; } = string.Empty;
}
```

#### **Models/ConversionResult.cs**
```csharp
namespace FileConversionAgent.Models;

/// <summary>
/// Result of a conversion operation.
/// </summary>
public class ConversionResult
{
    /// <summary>
    /// Whether conversion succeeded.
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// Message describing result or error.
    /// </summary>
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// Number of records/lines processed.
    /// </summary>
    public int RecordsProcessed { get; set; }

    /// <summary>
    /// Elapsed time in milliseconds.
    /// </summary>
    public long ElapsedMilliseconds { get; set; }

    /// <summary>
    /// Output file size in bytes.
    /// </summary>
    public long OutputFileSizeBytes { get; set; }
}
```

#### **Handlers/IConversionHandler.cs**
```csharp
namespace FileConversionAgent.Handlers;

using FileConversionAgent.Models;

/// <summary>
/// Interface for conversion handlers in the agent pipeline.
/// </summary>
public interface IConversionHandler
{
    /// <summary>
    /// Executes the conversion step.
    /// </summary>
    Task<ConversionResult> HandleAsync(ConversionRequest request);
}
```

#### **Handlers/ValidationHandler.cs**
```csharp
namespace FileConversionAgent.Handlers;

using FileConversionAgent.Models;

/// <summary>
/// Validates conversion requests before processing.
/// </summary>
public class ValidationHandler : IConversionHandler
{
    public async Task<ConversionResult> HandleAsync(ConversionRequest request)
    {
        return await Task.Run(() =>
        {
            // Validate source file exists
            if (!File.Exists(request.SourceFilePath))
                return new ConversionResult
                {
                    Success = false,
                    Message = $"Source file not found: {request.SourceFilePath}"
                };

            // Validate formats
            var validFormats = new[] { "csv", "json", "xml" };
            if (!validFormats.Contains(request.SourceFormat.ToLower()))
                return new ConversionResult
                {
                    Success = false,
                    Message = $"Invalid source format: {request.SourceFormat}"
                };

            if (!validFormats.Contains(request.TargetFormat.ToLower()))
                return new ConversionResult
                {
                    Success = false,
                    Message = $"Invalid target format: {request.TargetFormat}"
                };

            // Validation passed
            return new ConversionResult
            {
                Success = true,
                Message = "Validation successful"
            };
        });
    }
}
```

#### **Handlers/CsvToJsonHandler.cs**
```csharp
namespace FileConversionAgent.Handlers;

using FileConversionAgent.Models;
using System.Text.Json;

/// <summary>
/// Converts CSV to JSON format.
/// </summary>
public class CsvToJsonHandler : IConversionHandler
{
    public async Task<ConversionResult> HandleAsync(ConversionRequest request)
    {
        var startTime = DateTime.UtcNow;

        try
        {
            // Read CSV
            var lines = await File.ReadAllLinesAsync(request.SourceFilePath);
            if (lines.Length == 0)
                return new ConversionResult { Success = false, Message = "File is empty" };

            var headers = lines[0].Split(',');
            var jsonData = new List<Dictionary<string, string>>();

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');
                var row = new Dictionary<string, string>();
                for (int j = 0; j < headers.Length && j < values.Length; j++)
                {
                    row[headers[j].Trim()] = values[j].Trim();
                }
                jsonData.Add(row);
            }

            // Write JSON
            var json = JsonSerializer.Serialize(jsonData, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(request.TargetFilePath, json);

            var fileInfo = new FileInfo(request.TargetFilePath);
            var elapsed = DateTime.UtcNow - startTime;

            return new ConversionResult
            {
                Success = true,
                Message = "Conversion successful",
                RecordsProcessed = lines.Length - 1,
                ElapsedMilliseconds = (long)elapsed.TotalMilliseconds,
                OutputFileSizeBytes = fileInfo.Length
            };
        }
        catch (Exception ex)
        {
            return new ConversionResult
            {
                Success = false,
                Message = $"Conversion failed: {ex.Message}"
            };
        }
    }
}
```

#### **Services/ConversionAgent.cs** (Autonomous Agent)
```csharp
namespace FileConversionAgent.Services;

using FileConversionAgent.Handlers;
using FileConversionAgent.Models;

/// <summary>
/// Autonomous file conversion agent that orchestrates handlers.
/// </summary>
public class ConversionAgent
{
    private readonly Dictionary<string, IConversionHandler> _converters;
    private readonly IConversionHandler _validationHandler;

    public ConversionAgent()
    {
        _validationHandler = new ValidationHandler();
        _converters = new Dictionary<string, IConversionHandler>
        {
            { "csv_json", new CsvToJsonHandler() },
            { "json_csv", new JsonToCsvHandler() },
            { "csv_xml", new CsvToXmlHandler() },
            { "json_xml", new JsonToXmlHandler() }
        };
    }

    /// <summary>
    /// Autonomously processes a conversion request through the pipeline.
    /// </summary>
    public async Task<ConversionResult> ConvertAsync(ConversionRequest request)
    {
        // Step 1: Validate
        var validationResult = await _validationHandler.HandleAsync(request);
        if (!validationResult.Success)
            return validationResult;

        // Step 2: Select appropriate converter
        var key = $"{request.SourceFormat}_{request.TargetFormat}".ToLower();
        if (!_converters.ContainsKey(key))
            return new ConversionResult
            {
                Success = false,
                Message = $"Conversion from {request.SourceFormat} to {request.TargetFormat} not supported"
            };

        // Step 3: Execute conversion
        var handler = _converters[key];
        var result = await handler.HandleAsync(request);

        // Step 4: Validate output if successful
        if (result.Success && File.Exists(request.TargetFilePath))
        {
            var fileInfo = new FileInfo(request.TargetFilePath);
            if (fileInfo.Length == 0)
                return new ConversionResult
                {
                    Success = false,
                    Message = "Output file is empty"
                };
        }

        return result;
    }
}
```

#### **Program.cs** (CLI Usage)
```csharp
using FileConversionAgent.Models;
using FileConversionAgent.Services;

var agent = new ConversionAgent();

Console.WriteLine("=== File Conversion Agent ===\n");

while (true)
{
    try
    {
        Console.Write("Source file: ");
        var sourceFile = Console.ReadLine();

        Console.Write("Source format (csv/json/xml): ");
        var sourceFormat = Console.ReadLine();

        Console.Write("Target format (csv/json/xml): ");
        var targetFormat = Console.ReadLine();

        Console.Write("Output file: ");
        var targetFile = Console.ReadLine();

        var request = new ConversionRequest
        {
            SourceFilePath = sourceFile,
            SourceFormat = sourceFormat,
            TargetFormat = targetFormat,
            TargetFilePath = targetFile
        };

        Console.WriteLine("\nProcessing...\n");
        var result = await agent.ConvertAsync(request);

        if (result.Success)
        {
            Console.WriteLine("✓ Conversion successful!");
            Console.WriteLine($"  Records processed: {result.RecordsProcessed}");
            Console.WriteLine($"  Output size: {result.OutputFileSizeBytes} bytes");
            Console.WriteLine($"  Time: {result.ElapsedMilliseconds}ms\n");
        }
        else
        {
            Console.WriteLine($"✗ Error: {result.Message}\n");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unexpected error: {ex.Message}\n");
    }
}
```

---

### 💡 Agent Pattern Benefits

1. **Pipeline Execution** - Each handler is a step
2. **Extensibility** - Add new converters easily
3. **Separation of Concerns** - Each handler has one job
4. **Reusability** - Handlers can be used independently
5. **Testing** - Mock handlers for unit tests
6. **Error Recovery** - Validate before expensive operations

---

---

## Exercise 9: Microservice Agent — Distributed Architecture

### 📝 Overview
Design a microservice system where services communicate asynchronously through an API Gateway. Each service is autonomous and has its own database.

---

### 🤖 Microservice Architecture Strategy

```
Client
    ↓
[API Gateway] (routing, auth)
    ├→ [Product Service] + DB
    ├→ [Order Service] + DB  
    ├→ [Payment Service] + DB
    ├→ [Inventory Service] + DB
    └→ [Notification Service]
        
(Communication: REST APIs + Message Queue)
```

---

### ✅ Reference Implementation

#### **API Gateway/ApiGateway.cs**
```csharp
namespace Microservices.Gateway;

using Microservices.Models;

/// <summary>
/// API Gateway routes requests to appropriate microservices.
/// Handles authentication, logging, and request transformation.
/// </summary>
public class ApiGateway
{
    private readonly HttpClient _httpClient;
    private readonly Dictionary<string, string> _serviceUrls;

    public ApiGateway(Dictionary<string, string> serviceUrls)
    {
        _httpClient = new HttpClient();
        _serviceUrls = serviceUrls;
    }

    /// <summary>
    /// Routes a request to the appropriate microservice.
    /// </summary>
    public async Task<T?> RouteAsync<T>(string service, string endpoint, HttpMethod method, object? body = null)
    {
        if (!_serviceUrls.ContainsKey(service))
            throw new InvalidOperationException($"Service not found: {service}");

        var url = _serviceUrls[service] + endpoint;
        var request = new HttpRequestMessage(method, url);

        if (body != null && (method == HttpMethod.Post || method == HttpMethod.Put))
        {
            request.Content = new StringContent(
                System.Text.Json.JsonSerializer.Serialize(body),
                System.Text.Encoding.UTF8,
                "application/json"
            );
        }

        try
        {
            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return System.Text.Json.JsonSerializer.Deserialize<T>(content);
        }
        catch (HttpRequestException ex)
        {
            throw new InvalidOperationException($"Service call failed: {ex.Message}", ex);
        }
    }
}
```

#### **Services/OrderService/OrderService.cs**
```csharp
namespace Microservices.Services.Orders;

using Microservices.Models;
using Microservices.Repositories;

/// <summary>
/// Order microservice - handles order creation and management.
/// Independently owned database and business logic.
/// </summary>
public class OrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMessagePublisher _messagePublisher; // For async communication

    public OrderService(IOrderRepository orderRepository, IMessagePublisher messagePublisher)
    {
        _orderRepository = orderRepository;
        _messagePublisher = messagePublisher;
    }

    public async Task<Order> CreateOrderAsync(CreateOrderRequest request)
    {
        // Validate inventory (calls Inventory Service)
        var inventoryAvailable = await _messagePublisher.PublishAsync(
            "inventory.check",
            new { items = request.Items }
        );

        if (!inventoryAvailable)
            throw new InvalidOperationException("Inventory unavailable");

        // Create order
        var order = new Order
        {
            CustomerId = request.CustomerId,
            Items = request.Items,
            Status = "pending",
            CreatedDate = DateTime.UtcNow
        };

        await _orderRepository.AddOrderAsync(order);

        // Publish event for other services
        await _messagePublisher.PublishAsync(
            "order.created",
            new { orderId = order.Id, customerId = order.CustomerId }
        );

        return order;
    }

    public async Task<Order?> GetOrderAsync(int orderId)
    {
        return await _orderRepository.GetOrderByIdAsync(orderId);
    }

    public async Task<bool> UpdateOrderStatusAsync(int orderId, string status)
    {
        var order = await _orderRepository.GetOrderByIdAsync(orderId);
        if (order == null)
            return false;

        order.Status = status;
        await _orderRepository.UpdateOrderAsync(order);

        // Notify other services
        await _messagePublisher.PublishAsync(
            "order.status_changed",
            new { orderId, status }
        );

        return true;
    }
}
```

#### **Services/InventoryService/InventoryService.cs**
```csharp
namespace Microservices.Services.Inventory;

using Microservices.Models;
using Microservices.Repositories;

/// <summary>
/// Inventory microservice - manages stock levels.
/// Owns its database and stock logic.
/// </summary>
public class InventoryService
{
    private readonly IInventoryRepository _inventoryRepository;
    private readonly IMessagePublisher _messagePublisher;

    public InventoryService(IInventoryRepository inventoryRepository, IMessagePublisher messagePublisher)
    {
        _inventoryRepository = inventoryRepository;
        _messagePublisher = messagePublisher;
    }

    /// <summary>
    /// Checks if items are in stock.
    /// </summary>
    public async Task<bool> CheckAvailabilityAsync(List<OrderItem> items)
    {
        foreach (var item in items)
        {
            var inventory = await _inventoryRepository.GetByProductIdAsync(item.ProductId);
            if (inventory?.Quantity < item.Quantity)
                return false;
        }
        return true;
    }

    /// <summary>
    /// Reserves inventory for an order.
    /// </summary>
    public async Task ReserveAsync(int orderId, List<OrderItem> items)
    {
        foreach (var item in items)
        {
            var inventory = await _inventoryRepository.GetByProductIdAsync(item.ProductId);
            inventory.Quantity -= item.Quantity;
            inventory.Reserved += item.Quantity;
            await _inventoryRepository.UpdateAsync(inventory);
        }

        await _messagePublisher.PublishAsync(
            "inventory.reserved",
            new { orderId, items }
        );
    }
}
```

#### **Interfaces/IMessagePublisher.cs**
```csharp
namespace Microservices.Services;

/// <summary>
/// Interface for async message publishing between services.
/// Can use RabbitMQ, Azure Service Bus, etc. in production.
/// </summary>
public interface IMessagePublisher
{
    /// <summary>
    /// Publishes an async message to the event bus.
    /// </summary>
    Task<bool> PublishAsync(string eventName, object data);

    /// <summary>
    /// Subscribes to an event.
    /// </summary>
    void Subscribe(string eventName, Func<object, Task> handler);
}
```

#### **Models/Order.cs**
```csharp
namespace Microservices.Models;

/// <summary>
/// Order entity - owned by Order Service.
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
```

---

### 💡 Microservice Architecture Principles

1. **Service Independence** - Each service owns its database
2. **Loose Coupling** - Services communicate via APIs/events
3. **High Cohesion** - Service has single business domain
4. **Eventual Consistency** - Async communication for scalability
5. **API Gateway** - Single entry point for clients
6. **Resilience** - Service failures don't cascade

---

### ⚠️ Microservice Challenges

| Challenge | Solution |
|-----------|----------|
| Distributed transactions | Use Saga pattern for multi-service flows |
| Service discovery | Use service registry (Consul, Eureka) |
| Network latency | Cache, circuit breaker patterns |
| Data consistency | Accept eventual consistency or use 2-phase commit |
| Monitoring complexity | Use correlation IDs, distributed tracing |

---

## 🎓 Summary: 03-Agents Key Concepts

### **Agent Architecture Patterns**
1. **Pipeline Pattern** - Sequential handlers (Validation → Processing → Validation)
2. **Strategy Pattern** - Select handler based on input type
3. **Command Pattern** - Each handler executes a command
4. **Observer Pattern** - Publish events for other services

### **Microservice Principles**
1. **Single Responsibility** - Each service handles one domain
2. **Autonomous Deployment** - Services deploy independently
3. **Technology Diversity** - Each service chooses its stack
4. **Decentralized Data** - Database per service
5. **Observable** - Clear logging and tracing

### **Communication Patterns**
1. **Synchronous** - REST APIs, gRPC for real-time needs
2. **Asynchronous** - Message queues for decoupling
3. **Hybrid** - Use both as needed

---

## 📚 Next Steps

✅ Completed: **03-Agents**

🎉 **All Sections Complete!**

You now understand:
- **01-Basics:** Copilot fundamentals (autocomplete, chat, slash commands)
- **02-Modes:** Ask, Edit, Plan modes for analysis and refactoring
- **03-Agents:** Autonomous workflows and microservice architectures

---

## 🚀 Next: Application Challenges

Choose one of the 3 App Challenge templates:
1. **TodoAPI** - Build a complete todo application
2. **WeatherService** - Integrate with external APIs
3. **NoteAPI** - Rich text notes with search

All follow the patterns you've learned! 🎯
