namespace Microservices.Gateway;

using Microservices.Models;

/// <summary>
/// API Gateway routes requests to appropriate microservices.
/// TODO: Implement routing logic for all services
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
    /// TODO: Implement service routing
    /// </summary>
    public async Task<T?> RouteAsync<T>(string service, string endpoint, HttpMethod method, object? body = null)
    {
        // TODO: Route to appropriate service URL
        // TODO: Build HTTP request with proper headers
        // TODO: Send request and deserialize response
        // TODO: Handle service failures gracefully

        throw new NotImplementedException("TODO: Implement API Gateway routing");
    }
}
