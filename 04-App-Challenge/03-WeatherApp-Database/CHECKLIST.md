# Challenge 3: Weather App Database — Checklist

**Difficulty:** Intermediate-Advanced | **Time:** 60-75 minutes | **Tech:** Any database

**Prerequisites:** Challenge 1 (Frontend) and Challenge 2 (Backend) completed

---

## 🛠️ Database Setup

- [ ] Choose database (PostgreSQL, MongoDB, MySQL, SQLite, etc.)
- [ ] Create database/schema
- [ ] Configure connection from backend
- [ ] Create migration/setup scripts
- [ ] Verify connection works
- [ ] Set up database user with proper permissions
- [ ] Create `.env` with database credentials (not in code)
- [ ] Add database driver to backend dependencies

---

## 🗄️ Database Schema

### **Users Table**
```sql
- user_id (Primary Key)
- email (Unique, Not Null)
- username (Unique, Not Null)
- password_hash (Not Null)
- created_at (Timestamp)
- last_login (Timestamp)
```
- [ ] Create Users table with above fields
- [ ] Index on email and username
- [ ] Verify constraints work

### **Cities Table**
```sql
- city_id (Primary Key)
- name (Not Null)
- country (Not Null)
- latitude (Float)
- longitude (Float)
- timezone (String)
```
- [ ] Create Cities table
- [ ] Index on city name
- [ ] Unique constraint on (name, country)
- [ ] Store geographic data

### **Weather History Table**
```sql
- history_id (Primary Key)
- city_id (Foreign Key → Cities)
- temperature (Float)
- humidity (Integer 0-100)
- wind_speed (Float)
- weather_condition (String)
- weather_icon (String)
- feels_like (Float)
- recorded_at (Timestamp)
```
- [ ] Create WeatherHistory table
- [ ] Index on (city_id, recorded_at)
- [ ] Set up foreign key constraint
- [ ] Allows multiple records per city

### **Favorites Table**
```sql
- favorite_id (Primary Key)
- user_id (Foreign Key → Users)
- city_id (Foreign Key → Cities)
- added_at (Timestamp)
```
- [ ] Create Favorites table
- [ ] Unique constraint on (user_id, city_id)
- [ ] Foreign keys to Users and Cities
- [ ] Index on user_id

### **Weather Alerts Table**
```sql
- alert_id (Primary Key)
- user_id (Foreign Key → Users)
- city_id (Foreign Key → Cities)
- alert_type (String: temp_high, temp_low, rain, wind)
- threshold_value (Float)
- is_active (Boolean)
- created_at (Timestamp)
```
- [ ] Create Alerts table
- [ ] Foreign keys to Users and Cities
- [ ] Track alert conditions
- [ ] Support multiple alerts per user/city

### **API Statistics Table**
```sql
- stat_id (Primary Key)
- date (Date, Unique)
- total_requests (Integer)
- unique_cities (Integer)
- avg_temp (Float)
- avg_humidity (Float)
```
- [ ] Create Stats table
- [ ] Daily aggregation
- [ ] Index on date

---

## 🔗 Relationships & Constraints

- [ ] Users → Favorites (1:many)
- [ ] Users → Alerts (1:many)
- [ ] Cities → Favorites (1:many)
- [ ] Cities → WeatherHistory (1:many)
- [ ] Cities → Alerts (1:many)
- [ ] Cascade delete: User deleted → delete favorites & alerts
- [ ] Cascade delete: City deleted → delete favorites & alerts & history
- [ ] Foreign key constraints enforced

---

## 📝 Database Migrations

- [ ] Create migration files (v1_create_users, v2_create_cities, etc.)
- [ ] Up migration (create schema)
- [ ] Down migration (rollback)
- [ ] Run migrations in order
- [ ] Verify schema after migrations
- [ ] Track migration history
- [ ] Easy rollback capability

---

## 🔍 Queries

### **User Queries**
- [ ] Insert new user
- [ ] Get user by email
- [ ] Update user password
- [ ] Update last login timestamp
- [ ] Delete user (and cascade)

### **City Queries**
- [ ] Insert city
- [ ] Get city by name + country
- [ ] Search cities by partial name
- [ ] Get all cities
- [ ] Update city coordinates/timezone

### **Weather History Queries**
- [ ] Insert weather record
- [ ] Get latest weather for city
- [ ] Get weather history for past 7 days
- [ ] Get weather history for past 30 days
- [ ] Get average temp for city (all time)
- [ ] Get average humidity for city (month)
- [ ] Delete old records (older than 30 days)

### **Favorites Queries**
- [ ] Add favorite (user + city)
- [ ] Get user's favorites
- [ ] Remove favorite
- [ ] Check if city is favorited by user
- [ ] Count favorites per user

### **Alert Queries**
- [ ] Create alert for user
- [ ] Get active alerts for user
- [ ] Update alert status
- [ ] Get alerts triggered for user
- [ ] Delete alert

### **Statistics Queries**
- [ ] Insert daily stats
- [ ] Get stats for date range
- [ ] Calculate most searched cities
- [ ] Calculate average temperature trend
- [ ] Get top 10 most popular cities

---

## 💾 Data Persistence

### **Weather History**
- [ ] Automatically stored on every weather request
- [ ] Indexed by city and timestamp
- [ ] Queryable by date range
- [ ] Auto-purge records > 30 days old
- [ ] Aggregate into hourly/daily summaries

### **User Data**
- [ ] Favorites persist across sessions
- [ ] Alerts stored and checked
- [ ] Last login tracked
- [ ] User preferences saved

### **Analytics Data**
- [ ] Aggregate daily stats
- [ ] Track popular cities
- [ ] Calculate trends
- [ ] Identify peak usage times

---

## 🔐 Security

- [ ] No passwords stored in plain text (use bcrypt/hashing)
- [ ] Database credentials in .env (not in code)
- [ ] SQL injection prevention (prepared statements)
- [ ] Connection pooling for security
- [ ] Database user has minimal permissions
- [ ] Backups configured
- [ ] No sensitive data in logs
- [ ] Encrypted connection to database (if remote)

---

## ⚡ Performance

- [ ] All indexes created and verified
- [ ] Query execution plans reviewed
- [ ] Slow queries identified and optimized
- [ ] Connection pooling configured
- [ ] Database statistics updated
- [ ] Pagination for large result sets
- [ ] Batch inserts for bulk operations
- [ ] Archive old data to separate tables (optional)

---

## 🧪 Testing & Validation

- [ ] All tables created successfully
- [ ] Insert sample data
- [ ] Query sample data
- [ ] Foreign key constraints work
- [ ] Cascade deletes work
- [ ] Indexes exist and work
- [ ] Complex queries perform well
- [ ] Handles concurrent inserts
- [ ] Transactions work correctly
- [ ] Constraints prevent invalid data

---

## 📊 Integration with Backend

### **New Endpoints to Add**
- [ ] `POST /api/users` - Register user
- [ ] `POST /api/login` - Authenticate
- [ ] `GET /api/weather/:city` - Returns stored + live data
- [ ] `GET /api/weather/:city/history?days=7` - Historical data
- [ ] `POST /api/alerts` - Create alert
- [ ] `GET /api/alerts` - Get user's alerts
- [ ] `POST /api/favorites/:city` - Save favorite
- [ ] `GET /api/analytics/popular-cities` - Get trending cities
- [ ] `GET /api/analytics/average-temp` - Temperature trends

### **Database Integration**
- [ ] Backend connects to database
- [ ] Queries work from backend
- [ ] Connection pooling active
- [ ] Error handling for DB failures
- [ ] Logging of database operations
- [ ] Transaction handling for critical operations

---

## 📈 Analytics & Reporting

- [ ] Track most searched cities
- [ ] Generate temperature trends
- [ ] Calculate user engagement metrics
- [ ] Identify peak usage times
- [ ] Daily/weekly/monthly reports
- [ ] Query performance metrics
- [ ] Storage usage statistics

---

## 📚 Documentation

- [ ] Database schema diagram (ERD)
- [ ] Schema documentation (each table explained)
- [ ] Query examples for common operations
- [ ] Migration documentation
- [ ] Backup and recovery procedures
- [ ] Performance tuning guide
- [ ] Security configuration guide
- [ ] Troubleshooting guide

---

## 🧹 Code Quality

- [ ] Migration files organized
- [ ] Query functions DRY (reusable)
- [ ] Error handling on all DB operations
- [ ] No hardcoded queries (use parameters)
- [ ] Comments on complex queries
- [ ] Consistent naming conventions
- [ ] No debugging code left in
- [ ] Follows framework best practices

---

## 🚀 Deployment (Optional)

- [ ] Database hosted on cloud (AWS RDS, Heroku Postgres, etc.)
- [ ] Backups automated
- [ ] Monitoring alerts configured
- [ ] Connection secure (SSL/TLS)
- [ ] Database user has limited permissions
- [ ] Firewall restricts access
- [ ] Database accessible from backend only
- [ ] Credentials rotated regularly

---

## 🏆 Success Criteria

**Minimum to Pass:**
- ✅ All 6 tables created with proper structure
- ✅ Foreign key relationships working
- ✅ Cascade deletes functional
- ✅ Sample queries working
- ✅ Backend successfully connects
- ✅ Data persists across restarts
- ✅ Schema documentation complete

**To Exceed Expectations:**
- ✅ Advanced queries (joins, aggregations, subqueries)
- ✅ Performance optimization (indexes tuned)
- ✅ Automated backups working
- ✅ Monitoring and alerts set up
- ✅ Analytics features implemented
- ✅ Comprehensive test data sets
- ✅ Deployed to production database
- ✅ Complex transactions implemented

---

## 💡 Copilot Usage Tips

### **Generate Schema:**
```
Design a database schema for a weather app with:
- Users (email, password, preferences)
- Cities (name, country, coordinates)
- Weather history (temperature, humidity, condition, timestamp)
- User favorites (user + city)
Include proper data types, constraints, and indices.
```

### **Write Complex Queries:**
```
Write a SQL query to get:
- Average temperature per city for the last 7 days
- Order by city name
- Format: city_name, avg_temp, min_temp, max_temp
Use [database] syntax.
```

### **Migration Generation:**
```
Generate a migration file for [database] that:
1. Creates Users table
2. Creates Cities table
3. Creates WeatherHistory table with foreign keys
Include up/down functions for rollback.
```

---

## 🎓 What You'll Learn

- Database design and normalization
- Schema planning and relationships
- SQL/query writing
- Indexing and performance
- Migration management
- Data integrity and constraints
- Backup and recovery
- Analytics queries
- Cloud database deployment
- GitHub Copilot for database design

---

## 🔄 Full System Integration

You now have:
- ✅ **Challenge 1 (Frontend):** Beautiful UI
- ✅ **Challenge 2 (Backend):** REST API
- ✅ **Challenge 3 (Database):** Persistent storage

### **Next Steps:**
1. **Integration Test:** Run all 3 together
2. **End-to-End Flow:** Add city → Backend saves → Database stores
3. **Analytics:** Query historical data
4. **Optimize:** Monitor and improve performance
5. **Deploy:** Take entire system to production

**Completed:** Weather App Full Stack ✅  
**Alternative:** [Movie Booking System →](../04-MovieBookingSystem/README.md)
