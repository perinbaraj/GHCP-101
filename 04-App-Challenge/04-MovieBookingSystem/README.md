# Challenge 4: Movie Booking System — Full Application

**Difficulty:** Advanced | **Time:** 90-120 minutes | **Tech Stack:** Your choice (any language/framework)

---

## 🎯 Challenge Overview

Build a **complete movie booking system** from scratch. This is an **independent challenge** (not connected to the weather app) that requires comprehensive design and implementation.

### **What You'll Build:**
- 🎬 Movie catalog with details
- 🎪 Theater/Cinema management
- 📅 Showtime scheduling
- 🎫 Booking and reservation system
- 💳 Payment processing (mock)
- 📧 Confirmation and notifications
- 👤 User accounts and history

---

## 📋 Complete Requirements

### **1. Movie Management**
- Movie title, description, rating, duration, genre
- Poster/cover image
- Cast and director information
- Release date and end date
- Language and subtitle options

### **2. Theater/Cinema Management**
- Theater name and location
- Number of screens/halls
- Seat layouts (standard, premium, accessible)
- Food/concession options available

### **3. Showtime Scheduling**
- Movie assigned to theater
- Show times (10:00 AM, 1:00 PM, 4:00 PM, 7:00 PM, 10:00 PM)
- Screen assignment
- Base ticket price
- Dynamic pricing (peak hours, weekends higher price)

### **4. Seating System**
- Seat categories: Economy, Premium, VIP, Accessible
- Seat availability tracking
- Seat holds/reservations (15 min expiry)
- Booking status: Available, Booked, Hold, Maintenance

### **5. Booking & Reservation**
- Select movie → theater → showtime → seats
- Multiple seat selection
- Seat hold during checkout (prevent overbooking)
- Booking confirmation number
- Cancellation with refund policy

### **6. User Management**
- User registration/login
- User profile with booking history
- Saved payment methods
- Booking preferences
- Email for notifications

### **7. Payment Processing**
- Mock payment gateway
- Multiple payment methods: Card, UPI, Wallet
- Transaction tracking
- Failed payment handling
- Refund processing

### **8. Notifications**
- Email confirmation after booking
- Cancellation confirmation
- Reminder before showtime
- Receipt/invoice generation

### **9. Admin Features** (Optional)
- Add movies, theaters, showtimes
- View booking statistics
- Revenue reports
- Dynamic pricing configuration
- Promotions/discounts

---

## 📁 Suggested Project Structure

```
movie-booking-system/
├── README.md
├── backend/
│   ├── models/
│   │   ├── Movie.js
│   │   ├── Theater.js
│   │   ├── Showtime.js
│   │   ├── Seat.js
│   │   ├── Booking.js
│   │   ├── User.js
│   │   └── Payment.js
│   ├── routes/
│   │   ├── movies.js
│   │   ├── theaters.js
│   │   ├── showtimes.js
│   │   ├── bookings.js
│   │   ├── users.js
│   │   └── payments.js
│   ├── services/
│   │   ├── movieService.js
│   │   ├── bookingService.js
│   │   ├── paymentService.js
│   │   ├── notificationService.js
│   │   └── pricingService.js
│   ├── controllers/
│   │   └── [controller files]
│   ├── middleware/
│   │   ├── auth.js
│   │   └── validation.js
│   ├── database/
│   │   └── migrations/
│   └── server.js
│
├── frontend/
│   ├── components/
│   │   ├── MovieList.js
│   │   ├── TheaterSelect.js
│   │   ├── ShowtimeSelect.js
│   │   ├── SeatSelection.js
│   │   ├── CheckoutForm.js
│   │   └── BookingConfirmation.js
│   ├── pages/
│   │   ├── HomePage.js
│   │   ├── BookingPage.js
│   │   ├── MyBookings.js
│   │   └── PaymentPage.js
│   └── app.js
│
└── database/
    └── schema.sql
```

---

## 📊 Database Schema Outline

**Key Tables:**
- `movies` - Movie catalog
- `theaters` - Theater/Cinema information
- `screens` - Screens within theaters
- `seats` - Seat layout and status
- `showtimes` - Movie schedules
- `users` - User accounts
- `bookings` - Booking records
- `bookings_seats` - Many-to-many: which seats in booking
- `payments` - Payment transactions
- `cancellations` - Cancellation records
- `notifications` - Email/SMS logs

---

## 🔑 Core Business Logic

### **Booking Flow:**
1. User selects movie → available theaters → showtimes
2. View seat map (shows available/booked seats)
3. Select seats (seats get "held" for 15 minutes)
4. Enter contact information
5. Select payment method
6. Process payment
7. Generate confirmation
8. Send confirmation email

### **Pricing Logic:**
- Base price varies by seat category
- Peak hours (7 PM - 9 PM) → +20%
- Weekends (Sat/Sun) → +15%
- Matinee (before 5 PM) → -20%
- Discounts/coupons applied

### **Seat Hold Management:**
- Hold seats for 15 minutes during checkout
- Auto-release if payment not completed
- Prevent double-booking
- Real-time seat availability

### **Cancellation:**
- Can cancel up to 2 hours before showtime
- Full refund for cancellations > 4 hours
- 50% refund for 2-4 hour cancellations
- No refund within 2 hours

---

## 🤖 How to Use Copilot

### **System Design:**
```
I'm building a movie booking system. Help me design:
1. Database schema for movies, theaters, showtimes, bookings
2. API endpoints needed
3. Business logic for seat selection and holds
4. Payment processing flow
5. Cancellation and refund policies
```

### **Booking Logic:**
```
Implement a booking service that:
1. Reserves seats (prevents double-booking)
2. Holds seats for 15 minutes
3. Applies dynamic pricing
4. Calculates total cost with taxes
5. Handles concurrent bookings
```

### **Seat Selection:**
```
Create a seat selection component that:
1. Shows seat layout with visual seats
2. Marks booked/available seats
3. Allows multi-select with drag
4. Shows price per seat
5. Highlights selected seats
```

---

## ✅ Success Criteria

**Minimum (MVP):**
- ✅ List movies and theaters
- ✅ Show showtimes
- ✅ Select seats
- ✅ Complete booking with payment
- ✅ Generate confirmation
- ✅ Email notification

**Complete:**
- ✅ User accounts and login
- ✅ Booking history
- ✅ Cancellations with refunds
- ✅ Admin panel for adding data
- ✅ Dynamic pricing
- ✅ Payment processing
- ✅ Seat holds during checkout
- ✅ Real-time seat availability
- ✅ Multiple payment methods
- ✅ Promotional codes/discounts

---

## 🎬 Real-World Features (Stretch Goals)

1. **Notifications**
   - SMS reminders 24 hours before
   - Email confirmations
   - Cancellation confirmations

2. **Analytics**
   - Popular movies
   - Theater occupancy rates
   - Revenue reports

3. **Advanced Pricing**
   - Early bird discounts
   - Group bookings
   - Subscription plans
   - Student discounts

4. **Social**
   - Refer a friend
   - Share bookings
   - Reviews and ratings

5. **Mobile**
   - Native mobile app
   - Mobile wallet integration
   - QR code tickets

---

## 🏆 Completion

You've built a production-ready movie booking system with:
- Complete user flows
- Database persistence
- Payment processing
- Real-time updates
- Professional code quality
