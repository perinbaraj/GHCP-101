# 60-Minute App Challenge: Weather Service API

**Difficulty:** Intermediate | **Time:** 40-50 minutes | **Copilot Focus:** External API Integration + Caching

---

## 🎯 Challenge Overview

Build a **Weather Service API** that fetches weather data and returns it in a structured format.

### **Features:**
- ✅ Get weather for specific location
- ✅ 5-day forecast
- ✅ Response caching (improves performance)
- ✅ Mock weather data (no external API calls required)
- ✅ Unit tests with proper coverage
- ✅ Async operations throughout
- ✅ Error handling for invalid locations

---

## 📋 Feature Requirements

### **Endpoints:**

| Method | Route | Description |
|--------|-------|-------------|
| GET | `/api/weather/current/{location}` | Current weather for location |
| GET | `/api/weather/forecast/{location}` | 5-day forecast |
| GET | `/api/weather/locations` | Get available locations |

### **Response Model:**
```json
{
  "location": "New York",
  "temperature": 45,
  "condition": "Cloudy",
  "humidity": 65,
  "windSpeed": 12,
  "timestamp": "2024-01-29T10:00:00Z"
}
```

### **Forecast Model:**
```json
{
  "location": "New York",
  "forecast": [
    {
      "date": "2024-01-30",
      "high": 48,
      "low": 32,
      "condition": "Sunny",
      "precipitation": 0
    }
  ]
}
```

---

## 🤖 Copilot Prompting Strategy

### **Phase 1: Planning (5 minutes)**
```
I'm building a Weather Service API in 40 minutes.
Create a project plan including:
1. Architecture (controller, service, cache)
2. Endpoints and models
3. Data storage (in-memory mock data)
4. Caching strategy (improve performance)
5. Testing approach
```

### **Phase 2: Implementation (25 minutes)**
```
Generate an ASP.NET Core Weather API with:
- WeatherController with GET endpoints
- WeatherService for business logic
- IWeatherDataProvider (mock data source)
- ICache interface with in-memory implementation
- Async/await throughout
- Proper error handling
- Location validation

Include caching to reduce redundant lookups.
```

### **Phase 3: Caching Layer (5 minutes)**
```
Add a caching layer to the weather service:
- Cache weather responses for 1 hour
- Invalidate cache when location data changes
- Return cached data if available
- Implement IMemoryCache from ASP.NET Core
```

### **Phase 4: Testing & Documentation (15 minutes)**
```
/tests
Generate unit tests for:
- Weather endpoint retrieves correct data
- Forecast endpoint returns 5-day data
- Cache prevents redundant lookups
- Invalid location returns 404
- Current time is included in response

/doc
Add XML documentation to all public methods.
```

---

## 🚀 Quick Start

1. **Create project:**
   ```bash
   dotnet new webapi -n WeatherAPI
   cd WeatherAPI
   ```

2. **Create structure:**
   ```
   Models/
   ├── WeatherData.cs
   ├── Forecast.cs
   Services/
   ├── IWeatherService.cs
   ├── WeatherService.cs
   ├── IWeatherDataProvider.cs
   ├── MockWeatherDataProvider.cs
   Controllers/
   ├── WeatherController.cs
   ```

3. **Ask Copilot** to generate each component
4. **Test with sample locations:**
   ```bash
   curl http://localhost:5000/api/weather/current/new%20york
   curl http://localhost:5000/api/weather/forecast/london
   ```

5. **Submit PR**

---

## 🎯 Key Features

### **Caching Strategy:**
- Cache weather data for 1 hour
- Use `IMemoryCache` from Microsoft.Extensions.Caching.Memory
- Cache key: `weather_{location}`
- Return cached data if available and not expired

### **Mock Data:**
Instead of calling a real weather API, use mock data:
```csharp
private Dictionary<string, WeatherData> _mockData = new()
{
    ["new york"] = new() { Temperature = 45, Condition = "Cloudy" },
    ["london"] = new() { Temperature = 42, Condition = "Rainy" },
    // ... more locations
};
```

### **Error Handling:**
- Unknown location → 404 Not Found
- Invalid parameters → 400 Bad Request
- Service errors → 500 Internal Server Error

---

## ✅ Success Criteria

### **Functionality (50%)**
- [ ] Current weather endpoint works
- [ ] Forecast endpoint works
- [ ] Locations endpoint works
- [ ] Proper status codes (200, 400, 404)
- [ ] Data format matches specification

### **Performance & Caching (20%)**
- [ ] Caching implemented and working
- [ ] Cache improves response time (measurable)
- [ ] Cache invalidation works correctly

### **Code Quality & Testing (30%)**
- [ ] Async/await used throughout
- [ ] Unit tests passing (70%+ coverage)
- [ ] XML documentation complete
- [ ] Clean code, no duplication

---

## 📚 Advanced Features (Optional)

If you finish early:
- [ ] Add location search/autocomplete
- [ ] Add weather alerts (e.g., heavy rain warning)
- [ ] Add temperature conversion (C/F)
- [ ] Add historical weather data query
- [ ] Add user preference for temperature units

---

## 📚 Resources

- [ASP.NET Core Caching](https://learn.microsoft.com/en-us/aspnet/core/performance/caching/memory)
- [IMemoryCache Interface](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.caching.memory.imemorycache)

---

## 🏆 Submission

1. Branch: `challenge/weather-api-{your-name}`
2. PR with Copilot-generated description
3. Complete checklist from README
4. All tests passing

**Estimated Total Time: 40-50 minutes**

🌤️ Let's build! 🌤️

