// TODO: Using Agent Mode, design and implement a microservice architecture.
//
// Ask Copilot:
// "Design a microservice architecture for an e-commerce system with:
// - Product Service
// - Inventory Service  
// - Order Service
// - Payment Service
// - Notification Service
// - API Gateway
//
// Include:
// 1. Service responsibilities and boundaries
// 2. Communication patterns (REST vs async messaging)
// 3. Database per service strategy
// 4. API Gateway design
// 5. Error handling and resilience patterns
// 6. Event-driven architecture"

using Microservices.Gateway;
using Microservices.Models;

Console.WriteLine("=== E-Commerce Microservice System ===\n");

// TODO: Configure service URLs
var serviceUrls = new Dictionary<string, string>
{
    { "product", "http://localhost:5001" },
    { "inventory", "http://localhost:5002" },
    { "order", "http://localhost:5003" },
    { "payment", "http://localhost:5004" }
};

// TODO: Create API Gateway
var gateway = new ApiGateway(serviceUrls);

// TODO: Implement endpoints:
// - POST /orders - Create order
// - GET /orders/{id} - Get order status
// - PUT /orders/{id}/status - Update order status
// - GET /products - List products
// - GET /inventory/{productId} - Check stock

Console.WriteLine("TODO: Implement microservice architecture");
