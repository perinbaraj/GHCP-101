# Challenge 3: Weather App Database — Add Data Persistence

**Difficulty:** Intermediate-Advanced | **Time:** 60-75 minutes | **Tech Stack:** Your choice (PostgreSQL, MongoDB, MySQL, SQLite, etc.)

---

## 🎯 Challenge Overview

Add a **database layer** to the weather app to persist historical data, user preferences, and analytics. This **completes the interconnected weather app** by adding data persistence.

### **What You'll Build:**
- 💾 Database schema for weather and user data
- 📊 Store historical weather data
- 👤 User profiles and preferences
- 📈 Analytics and reporting
- 🔍 Query weather history by date/city

---

## 📋 Requirements

### **Database Design:**

**Users Table:**
```sql
id (UUID)
email (unique)
username
created_at
preferences (JSON: favorite_cities, units, theme, etc.)
```

**Cities Table:**
```sql
id (UUID)
name (unique)
latitude
longitude
country
```

**Weather History Table:**
```sql
id (UUID)
city_id (FK)
temperature
humidity
wind_speed
condition
weather_icon
recorded_at (timestamp)
```

**User Favorites Table:**
```sql
id (UUID)
user_id (FK)
city_id (FK)
added_at
```

**Weather Alerts Table:**
```sql
id (UUID)
user_id (FK)
city_id (FK)
alert_type (extreme_temp, extreme_wind, etc.)
message
triggered_at
acknowledged
```

---

## 🎯 Core Features:

1. **Data Persistence**
   - Save weather data every hour
   - Store user preferences
   - Track favorite cities per user
   - Maintain weather history

2. **Historical Analysis**
   - Query weather for past dates
   - Calculate temperature trends
   - Identify weather patterns
   - Generate reports (weekly, monthly)

3. **User Management**
   - Create user accounts
   - Store preferences
   - Track activity
   - Generate alerts for users

4. **Advanced Features**
   - Weather alerts (extreme conditions)
   - Comparison between cities
   - Seasonal trends
   - Prediction data (optional)

---

## 📁 Suggested Project Structure

```
weather-api-backend/  (extends Challenge 2)
├── database/
│   ├── migrations/
│   │   ├── 001_create_users.sql
│   │   ├── 002_create_cities.sql
│   │   ├── 003_create_weather_history.sql
│   │   └── 004_create_alerts.sql
│   └── schema.sql
├── models/
│   ├── User.js
│   ├── City.js
│   ├── WeatherRecord.js
│   └── Alert.js
├── repositories/
│   ├── userRepository.js
│   ├── weatherRepository.js
│   └── alertRepository.js
├── services/
│   ├── weatherDataService.js (historical analysis)
│   ├── alertService.js
│   └── userService.js
└── scripts/
    └── seedData.js (populate initial cities)
```

---

## 📝 New API Endpoints

**Add these to Challenge 2 API:**

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/weather/history/{city}?days=30` | Get historical data |
| GET | `/api/weather/stats/{city}` | Get temperature statistics |
| POST | `/api/users/register` | Create new user |
| GET | `/api/users/{id}/favorites` | Get user's favorites |
| POST | `/api/alerts/{city}` | Create weather alert |
| GET | `/api/alerts` | Get user's active alerts |
| GET | `/api/weather/compare?cities=London,Paris` | Compare cities |

---

## 🤖 How to Use Copilot

### **Schema Design:**
```
Design a database schema for a weather app that needs to:
1. Store historical weather data (hourly updates)
2. Track user preferences and favorites
3. Generate weather alerts
4. Analyze temperature trends
5. Support multi-user access

Include: tables, relationships, indices, sample queries
```

### **Migration Scripts:**
```
Create a database migration that:
1. Creates users, cities, weather_history tables
2. Adds proper relationships and constraints
3. Creates indexes for performance
4. Seeds initial city data (10 major cities)
```

### **Data Analysis:**
```
Write a query that:
1. Gets average temperature for a city over the last 30 days
2. Identifies temperature trend (increasing/decreasing)
3. Calculates temperature variance
4. Compares with historical average
```

---

## 🔗 Integration Points

**Update Challenge 2 Backend to:**
1. Write weather data to database (after fetching from API)
2. Read from database for historical queries
3. Store user favorites and preferences
4. Generate alerts based on thresholds
5. Serve historical data in responses

**Frontend** (Challenge 1) gains:
- Historical weather view
- Temperature trend charts
- Alert notifications
- User login/preferences
- City comparison

---

## ✅ Success Criteria

- ✅ Database schema designed and normalized
- ✅ All tables created with proper relationships
- ✅ Historical weather data stored
- ✅ User accounts functional
- ✅ Favorites system working
- ✅ Historical queries performant
- ✅ Data integrity constraints in place
- ✅ Migrations versioned and documented
- ✅ Initial seed data populated
- ✅ Works with Challenge 1 & 2

---

## 🏆 Completion

**Congratulations!** You've built a complete interconnected weather application:
1. ✅ Frontend (UI/UX)
2. ✅ Backend (API & logic)
3. ✅ Database (Persistence & analytics)

You can now:
- Track weather history
- Generate reports
- Create user accounts
- Set up alerts
- Analyze trends
