# Challenge 1: Weather App Frontend — Checklist

**Difficulty:** Intermediate | **Time:** 45-60 minutes | **Tech:** Any frontend framework

---

## 📋 Project Setup

- [ ] Initialize project (create-react-app / npm create vue / ng new, etc.)
- [ ] Install required dependencies (axios/fetch, CSS framework optional)
- [ ] Set up project structure (components, pages, utils directories)
- [ ] Create .env file with API key placeholder
- [ ] Set up Git repository with initial commit
- [ ] Verify build process works (`npm start` or `npm run dev`)

---

## 🎨 UI Components

### **Search Bar**
- [ ] Create search input component
- [ ] Add search button or enter-key trigger
- [ ] Show loading state while searching
- [ ] Display error message if city not found
- [ ] Clear button to reset search
- [ ] Prevent duplicate city searches

### **Weather Card (Per City)**
- [ ] Display city name and country
- [ ] Display current temperature (°C or °F)
- [ ] Display weather condition (Sunny, Rainy, etc.)
- [ ] Display weather icon/emoji
- [ ] Display humidity percentage
- [ ] Display wind speed
- [ ] Display "feels like" temperature
- [ ] Add delete/remove button for city
- [ ] Show last updated timestamp

### **Overall Layout**
- [ ] Header with app title
- [ ] Search bar prominently placed
- [ ] Grid/list layout for weather cards
- [ ] Responsive design (mobile-first)
- [ ] Footer with credits (if using free API)
- [ ] Loading spinner during API calls
- [ ] Error message display

---

## 🔌 API Integration

### **OpenWeatherMap Setup**
- [ ] Get free API key from openweathermap.org
- [ ] Store API key in .env file (not in code)
- [ ] Create API utility/service file
- [ ] Use weather endpoint: `/data/2.5/weather`
- [ ] Handle API rate limiting gracefully
- [ ] Add request timeout (5-10 seconds)

### **API Calls**
- [ ] Search by city name
- [ ] Parse response correctly
- [ ] Handle 404 (city not found)
- [ ] Handle network errors
- [ ] Show meaningful error messages to user
- [ ] Display HTTP status codes in console for debugging

---

## 💾 Local Storage

- [ ] Save selected cities to localStorage
- [ ] Load cities on page refresh
- [ ] Max 5 cities (or limit of your choice)
- [ ] Clear storage button (optional)
- [ ] Handle corrupted storage gracefully
- [ ] Show notification when storage limit reached

---

## 🎯 Features

### **Multiple Cities Support**
- [ ] Add new city while keeping others
- [ ] Display all cities simultaneously
- [ ] Remove individual cities
- [ ] Show count of tracked cities
- [ ] Prevent adding duplicate cities

### **Temperature Display**
- [ ] Show Celsius by default
- [ ] Add Celsius/Fahrenheit toggle
- [ ] Remember user's preference in localStorage
- [ ] Update all cities when toggling

### **Visual Enhancements**
- [ ] Weather icons from Font Awesome, emoji, or images
- [ ] Color-code based on temperature (blue=cold, yellow=warm, red=hot)
- [ ] Smooth transitions between states
- [ ] Hover effects on cards
- [ ] Loading skeleton during API call
- [ ] Success animation when city added

---

## 🧪 Testing & Quality

- [ ] Console is clean (no warnings/errors)
- [ ] Search works with uppercase/lowercase
- [ ] Search works with city + country (e.g., "London, UK")
- [ ] Error states display properly
- [ ] Works on mobile (375px width)
- [ ] Works on tablet (768px width)
- [ ] Works on desktop (1200px+ width)
- [ ] All interactive elements have hover states
- [ ] Keyboard accessible (tab through inputs)
- [ ] No hardcoded API keys in code

---

## 📱 Responsive Design

- [ ] Mobile (375px): Single column, readable text
- [ ] Tablet (768px): 2 columns max
- [ ] Desktop (1200px): 3-4 columns
- [ ] Touch targets min 44x44px
- [ ] Font sizes readable on all devices
- [ ] No horizontal scrolling
- [ ] Images scale properly

---

## 🔄 Edge Cases

- [ ] Empty search field → show message
- [ ] Special characters in city name → handled
- [ ] Very long city names → truncated gracefully
- [ ] API down → show offline message
- [ ] Slow network → show loading spinner
- [ ] User closes browser → data persists (localStorage)
- [ ] Adds same city twice → prevented
- [ ] Delete all cities → clean slate works

---

## 🎨 Code Quality

- [ ] Code is formatted consistently
- [ ] Components are reusable
- [ ] No hardcoded strings (use constants/config)
- [ ] Comments for complex logic
- [ ] Proper error handling
- [ ] No console.log() for debugging left in
- [ ] Follows framework conventions
- [ ] DRY principle applied

---

## 📚 Documentation

- [ ] README with project description
- [ ] Installation instructions
- [ ] How to get OpenWeatherMap API key
- [ ] How to run locally
- [ ] Features list
- [ ] Technologies used
- [ ] Screenshots of UI
- [ ] Troubleshooting section

---

## 🚀 Deployment (Optional)

- [ ] Push to GitHub with clean history
- [ ] Deploy to Vercel / Netlify / gh-pages
- [ ] Verify API calls work on production
- [ ] Environment variables configured
- [ ] HTTPS enforced
- [ ] Share link to live demo

---

## 🏆 Success Criteria

**Minimum to Pass:**
- ✅ Search and display 1+ cities
- ✅ Show current temperature, condition, humidity, wind
- ✅ Responsive on mobile and desktop
- ✅ localStorage persistence
- ✅ Proper error handling
- ✅ Code is readable and organized

**To Exceed Expectations:**
- ✅ Celsius/Fahrenheit toggle
- ✅ Smooth animations and transitions
- ✅ Weather icons/colors
- ✅ Excellent error messages
- ✅ Beautiful UI design
- ✅ Deployed to live URL

---

## 💡 Copilot Usage Tips

### **Generate Component Structure:**
```
Create a weather card component that displays:
- City name, temperature, humidity, wind speed
- Uses props for weather data
- Has a delete button
Use [framework name] and style with [CSS framework/approach]
```

### **Fix API Integration:**
```
This API call isn't working. Here's the error: [paste error]
I'm using [framework] and [HTTP client].
How do I fix it?
```

### **Generate Documentation:**
```
Create a README for this weather app with:
- Project description
- Setup instructions
- API key setup steps
- Features list
- Screenshots
```

---

## 🎓 What You'll Learn

- Frontend framework fundamentals
- API integration and error handling
- State management
- localStorage and persistence
- Responsive design
- GitHub Copilot for frontend tasks
- Debugging network requests
- Component-based architecture

**Next Challenge:** [Weather App Backend →](../02-WeatherApp-Backend/README.md)
