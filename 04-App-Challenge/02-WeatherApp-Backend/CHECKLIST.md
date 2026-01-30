# Challenge 2: Weather App Backend — Checklist

**Difficulty:** Intermediate | **Time:** 60-75 minutes | **Tech:** Any backend framework

**Prerequisite:** Challenge 1 (Frontend) completed (or API specs understood)

---

## 🛠️ Project Setup

- [ ] Initialize backend project
- [ ] Install dependencies (framework, database driver, utilities)
- [ ] Create `.env` file for configuration
- [ ] Set up directory structure (`/routes`, `/controllers`, `/models`, `/utils`)
- [ ] Configure CORS to allow frontend requests
- [ ] Add logging setup
- [ ] Set up Git repository
- [ ] Verify server starts on port 3000 (or custom)

---

## 🔌 API Endpoints

### **1. Current Weather**
- [ ] Endpoint: `GET /api/weather/:city`
- [ ] Query: `/api/weather?city=London`
- [ ] Response: `{ city, country, temp, humidity, wind, condition, icon, feelsLike }`
- [ ] Returns 200 on success
- [ ] Returns 400 if city missing
- [ ] Returns 404 if city not found
- [ ] Logs request and response

### **2. Forecast (5-day)**
- [ ] Endpoint: `GET /api/forecast/:city`
- [ ] Response: Array of daily forecasts with temp, condition, date
- [ ] Each forecast includes min/max temp
- [ ] Returns 404 if city not found
- [ ] Filters out old data

### **3. Multiple Cities Weather**
- [ ] Endpoint: `GET /api/weather/batch?cities=London,Paris,Tokyo`
- [ ] Response: Array of weather for each city
- [ ] Handles partial failures gracefully
- [ ] Returns successfully fetched cities + error list

### **4. Search Cities**
- [ ] Endpoint: `GET /api/search?q=Lond`
- [ ] Response: Array of matching cities with coordinates
- [ ] Case-insensitive search
- [ ] Limits results to 10
- [ ] Returns empty array if no matches

### **5. Weather Stats**
- [ ] Endpoint: `GET /api/stats`
- [ ] Response: `{ totalRequests, uniqueCities, avgTemp, avgHumidity }`
- [ ] Calculates from stored data
- [ ] Returns 200 with stats object

### **6. Favorite Cities (User-specific)**
- [ ] Endpoint: `POST /api/favorites` - Add favorite
- [ ] Body: `{ userId, city, country }`
- [ ] Returns 201 on success
- [ ] Endpoint: `GET /api/favorites?userId=123` - List favorites
- [ ] Returns array of favorite cities
- [ ] Endpoint: `DELETE /api/favorites/:id` - Remove favorite
- [ ] Returns 204 on success

### **7. Health Check**
- [ ] Endpoint: `GET /api/health`
- [ ] Response: `{ status: "ok", timestamp }`
- [ ] Always returns 200

---

## 🔄 API Behavior

### **Request Validation**
- [ ] Check required parameters exist
- [ ] Validate parameter types
- [ ] Return 400 with error message for invalid input
- [ ] Trim whitespace from strings
- [ ] Convert city names to proper case

### **Response Format**
- [ ] All responses have consistent structure
- [ ] Success: `{ success: true, data: {...}, timestamp }`
- [ ] Error: `{ success: false, error: "message", code: 404 }`
- [ ] Include timestamps on all responses
- [ ] Use proper HTTP status codes

### **Error Handling**
- [ ] 400: Bad Request (missing/invalid parameters)
- [ ] 404: Not Found (city doesn't exist)
- [ ] 429: Rate Limited (too many requests)
- [ ] 500: Server Error (internal issues)
- [ ] 503: Service Unavailable (external API down)
- [ ] All errors have descriptive messages

---

## ⚡ Performance & Caching

### **Caching Strategy**
- [ ] Cache weather data for 30 minutes (configurable)
- [ ] Cache forecast data for 2 hours
- [ ] Cache search results for 24 hours
- [ ] Implement cache invalidation on demand
- [ ] Show cache hit/miss in logs
- [ ] Use Redis or in-memory cache

### **Rate Limiting**
- [ ] Limit to 100 requests per IP per hour
- [ ] Return 429 status when exceeded
- [ ] Include `Retry-After` header
- [ ] Log rate limit violations
- [ ] Reset counter hourly

### **Database Optimization**
- [ ] Create indexes on frequently queried fields
- [ ] Set up connection pooling
- [ ] Query optimization (select only needed fields)
- [ ] Implement pagination for large datasets

---

## 🗄️ Data Persistence

### **Weather History Table**
- [ ] Store: city, temperature, humidity, wind, condition, timestamp
- [ ] Indexed by: city name, timestamp
- [ ] Auto-purge data older than 30 days
- [ ] Partition by date for performance

### **Favorites Table**
- [ ] Store: userId, city, country, savedAt
- [ ] Indexed by: userId
- [ ] Unique constraint on (userId, city)
- [ ] Cascade delete if user deleted

### **API Statistics**
- [ ] Track total requests
- [ ] Track unique cities searched
- [ ] Store daily aggregates

---

## 🔐 Security

- [ ] No API keys in code (use .env)
- [ ] Sanitize all user inputs
- [ ] Validate request sizes (prevent large payloads)
- [ ] Add CORS headers (allow only needed domains)
- [ ] Set security headers (CSP, X-Frame-Options)
- [ ] Rate limiting enabled
- [ ] Log suspicious activity
- [ ] No sensitive data in logs

---

## 🧪 Testing & Quality

- [ ] All endpoints return correct status codes
- [ ] Response format is consistent
- [ ] Error messages are helpful
- [ ] Handles network timeout gracefully
- [ ] Handles external API failure
- [ ] Large inputs handled properly
- [ ] Concurrent requests work
- [ ] No console.log() debugging left in
- [ ] No hardcoded values

---

## 📊 Logging & Monitoring

- [ ] Log all API requests (method, path, status, time)
- [ ] Log errors with stack traces
- [ ] Log cache hits/misses
- [ ] Log rate limit violations
- [ ] Include request ID for tracing
- [ ] Different log levels (info, warn, error)
- [ ] Logs rotated to prevent file growth
- [ ] Can disable verbose logging in production

---

## 🔗 Integration with Frontend

### **CORS Configuration**
- [ ] Allow requests from frontend domain
- [ ] Allow credentials if needed
- [ ] Allow GET, POST, DELETE methods
- [ ] Allow Content-Type header
- [ ] Allow Authorization header (if using tokens)

### **API Contract**
- [ ] Frontend can fetch weather by city
- [ ] Frontend can fetch multiple cities at once
- [ ] Frontend gets proper error messages
- [ ] Response time < 2 seconds for cached data
- [ ] Response time < 5 seconds for new data

---

## 📚 Documentation

- [ ] README with project description
- [ ] Setup instructions (dependencies, environment)
- [ ] API documentation (endpoints, request/response examples)
- [ ] How to set OpenWeatherMap API key
- [ ] How to run tests
- [ ] How to run locally
- [ ] Environment variables documented
- [ ] Postman collection or similar

---

## 🧹 Code Quality

- [ ] Consistent code formatting
- [ ] Separation of concerns (routes, controllers, services)
- [ ] DRY principle (no repeated code)
- [ ] Comments for complex logic
- [ ] Error handling everywhere
- [ ] No magic numbers (use constants)
- [ ] Follows framework best practices
- [ ] Proper dependency injection

---

## 🚀 Deployment (Optional)

- [ ] Push to GitHub
- [ ] Deploy to Heroku / Railway / Render
- [ ] Environment variables configured on host
- [ ] Database set up on cloud
- [ ] Health check endpoint working
- [ ] Logs accessible on host
- [ ] Monitor error rates

---

## 🏆 Success Criteria

**Minimum to Pass:**
- ✅ All 7 endpoints implemented and working
- ✅ Proper error handling and HTTP status codes
- ✅ CORS configured for frontend
- ✅ Caching implemented
- ✅ Rate limiting active
- ✅ Clean, organized code
- ✅ API documentation complete

**To Exceed Expectations:**
- ✅ Comprehensive logging
- ✅ Advanced performance optimizations
- ✅ Database indexes and query optimization
- ✅ Excellent error messages
- ✅ Automated tests (unit + integration)
- ✅ Deployed and working live
- ✅ Handles edge cases gracefully

---

## 💡 Copilot Usage Tips

### **Generate Endpoint Structure:**
```
Create a [framework] route handler for GET /api/weather/:city
It should:
1. Validate the city parameter
2. Check cache
3. Fetch from OpenWeatherMap API if needed
4. Return proper response format
5. Handle errors
```

### **Database Schema Help:**
```
Design a database schema for storing:
- Weather history (city, temp, humidity, wind, timestamp)
- User favorites (userId, city, country, savedAt)
Include indices and constraints.
```

### **Generate Tests:**
```
Generate unit tests for the weather endpoint handler.
Test cases:
- Valid city
- Missing city parameter
- City not found
- API error
Use [testing framework].
```

---

## 🎓 What You'll Learn

- REST API design principles
- Backend frameworks and routing
- Database schema design
- Caching strategies
- Error handling
- API testing and documentation
- Performance optimization
- Security best practices
- GitHub Copilot for backend tasks

---

## 🔄 Integration Path

This backend serves the **Challenge 1 frontend**. After completing this, you can:

1. **Test together:** Start frontend, start backend, verify API calls work
2. **Iterate:** Make improvements based on real usage
3. **Next:** Add Challenge 3 (Database) to persist data

**Next Challenge:** [Weather App Database →](../03-WeatherApp-Database/README.md)
