# Challenge 2: Weather App Backend — Add Server Logic

**Difficulty:** Intermediate | **Time:** 60-75 minutes | **Tech Stack:** Your choice (Node.js, Python, C#/.NET, Java, etc.)

---

## 🎯 Challenge Overview

Build a **REST API backend** for the weather app that adds business logic, data processing, and serves the frontend. This **extends Challenge 1** with server-side functionality.

### **What You'll Build:**
- 🔌 REST API endpoints for weather data
- 📊 Weather analysis and statistics
- 🔄 Caching strategies
- 📈 Historical weather tracking
- 🛡️ Input validation and error handling

---

## 📋 Requirements

### **API Endpoints:**

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/weather/{city}` | Get current weather for a city |
| GET | `/api/weather/forecast/{city}` | Get 5-day forecast |
| GET | `/api/cities/search?q={query}` | Search for cities |
| POST | `/api/favorites` | Save favorite cities |
| GET | `/api/favorites` | Get user's favorite cities |
| GET | `/api/weather/stats/{city}` | Get weather statistics |
| DELETE | `/api/favorites/{city}` | Remove favorite city |

### **Core Features:**

1. **Weather Data Retrieval**
   - Fetch from OpenWeatherMap API (or similar)
   - Return formatted JSON responses
   - Handle multiple city requests

2. **Business Logic**
   - Calculate weather statistics (average temp, max/min)
   - Track historical weather data
   - Identify weather patterns/trends
   - Generate alerts (extreme weather, etc.)

3. **Data Management**
   - Store user preferences (favorite cities)
   - Track weather history (optional for this phase)
   - User profiles (optional)

4. **Performance**
   - Implement caching (Redis or in-memory)
   - Rate limiting for API calls
   - Error handling and logging

---

## 📁 Suggested Project Structure

```
weather-api-backend/
├── server.js (or main.py, Program.cs, etc.)
├── package.json (or equivalent)
├── .env (environment variables)
├── routes/
│   ├── weather.js
│   ├── favorites.js
│   └── forecast.js
├── controllers/
│   ├── weatherController.js
│   └── userController.js
├── services/
│   ├── weatherService.js
│   ├── externalAPIService.js
│   └── cacheService.js
├── middleware/
│   ├── errorHandler.js
│   ├── validation.js
│   └── rateLimiter.js
└── utils/
    └── helpers.js
```

---

## 🤖 How to Use Copilot

### **API Design:**
```
I'm building a weather API. Help me design:
1. RESTful endpoint structure
2. Request/response data models
3. Error handling approach
4. Input validation strategy
```

### **Integration:**
```
Create a service to:
1. Fetch data from OpenWeatherMap API
2. Cache responses for 30 minutes
3. Handle rate limiting
4. Transform API response to our format
```

### **Business Logic:**
```
Implement a function to:
1. Calculate average temperature from historical data
2. Identify extreme weather alerts
3. Generate weather trends
4. Format data for frontend consumption
```

---

## 🔗 Connection to Challenge 1

**Your frontend** (Challenge 1) should now call **your backend** instead of the public API:

```javascript
// Before (direct API call):
const response = await fetch(
  `https://api.openweathermap.org/data/2.5/weather?q=${city}&appid=${key}`
);

// After (your backend):
const response = await fetch(
  `http://localhost:3000/api/weather/${city}`
);
```

---

## ✅ Success Criteria

- ✅ All endpoints functioning correctly
- ✅ Returns proper HTTP status codes
- ✅ Input validation on all endpoints
- ✅ Error handling with meaningful messages
- ✅ Caching implemented (30-60 min TTL)
- ✅ Rate limiting functional
- ✅ CORS enabled for frontend
- ✅ Logging for debugging
- ✅ API documentation (Postman/Swagger)
- ✅ Works with Challenge 1 frontend

---

## 🚀 Next: Part 3

After completing this challenge, move to **Challenge 3: Weather App Database** to persist data.

**Challenge Chain:**
1. ✅ Frontend (Completed)
2. ✅ Backend (Current)
3. → Database (Data persistence & advanced features)
