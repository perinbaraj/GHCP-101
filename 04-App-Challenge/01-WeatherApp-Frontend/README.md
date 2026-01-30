# Challenge 1: Weather App Frontend — Visualize City Weather

**Difficulty:** Beginner-Intermediate | **Time:** 45-60 minutes | **Tech Stack:** Your choice (React, Vue, Angular, or any frontend framework)

---

## 🎯 Challenge Overview

Build a **responsive weather visualization application** that displays real-time weather data for multiple cities using a public Weather API. This is the **first part** of an interconnected 3-part weather app series.

### **What You'll Build:**
- 🌍 Search for weather by city name
- 🌡️ Display current weather: temperature, humidity, wind speed, conditions
- 📍 Show weather for multiple cities
- 📱 Responsive design (works on desktop and mobile)
- 🎨 Clean, professional UI with weather icons

---

## 📋 Requirements

### **Core Features:**
1. **City Search**
   - Input field to search for cities
   - Display search results
   - Add/remove cities from favorites

2. **Weather Display**
   - Current temperature
   - Weather condition (Sunny, Cloudy, Rainy, etc.)
   - Humidity percentage
   - Wind speed
   - "Feels like" temperature
   - Weather icons/illustrations

3. **Multiple Cities**
   - Display weather for 3-5 cities simultaneously
   - Save city preferences (localStorage)
   - Easy city management (add/remove)

4. **UI/UX**
   - Responsive layout (mobile-first)
   - Professional styling
   - Loading states while fetching data
   - Error handling with user-friendly messages
   - Smooth animations/transitions

---

## 🔌 Public Weather API

Use **OpenWeatherMap Free API** (https://openweathermap.org/api):
- Free tier available (no credit card needed for limited requests)
- Provides current weather, forecasts, etc.
- JSON response format
- CORS-friendly for frontend requests

**Sample API Call:**
```
GET https://api.openweathermap.org/data/2.5/weather?q={city}&appid={YOUR_API_KEY}&units=metric
```

---

## 📁 Suggested Project Structure

```
weather-app-frontend/
├── index.html
├── styles.css (or styled-components/Tailwind)
├── app.js (or main framework file)
├── components/
│   ├── SearchBar.js
│   ├── WeatherCard.js
│   ├── CityList.js
│   └── LoadingSpinner.js
├── services/
│   └── weatherService.js (API calls)
└── utils/
    └── constants.js (API keys, etc.)
```

---

## 🤖 How to Use Copilot

### **Planning Phase:**
```
I'm building a weather app frontend. Help me plan:
1. Component architecture
2. How to fetch data from OpenWeatherMap API
3. How to structure the component hierarchy
4. State management approach
```

### **Implementation Phase:**
```
Create a React component for displaying weather data:
- Show city name, temperature, condition, humidity
- Use weather icons
- Make it responsive
- Add proper error handling
```

### **Styling Phase:**
```
Help me make this weather app mobile-responsive using CSS Grid/Flexbox
Focus on:
- Mobile-first design
- Weather card layout
- Search bar styling
- Weather icon display
```

---

## ✅ Success Criteria

- ✅ App displays weather for at least 3 cities
- ✅ Search functionality works
- ✅ Responsive design (works on mobile and desktop)
- ✅ Handles errors gracefully
- ✅ Data fetches from real API
- ✅ Clean, professional UI
- ✅ Loading states while fetching
- ✅ City preferences persist (localStorage)

---

## 🚀 Next: Part 2

After completing this challenge, move to **Challenge 2: Weather App Backend** to add server-side logic and APIs.

**Challenge Chain:**
1. ✅ Frontend (Current)
2. → Backend (API + business logic)
3. → Database (Data persistence)
