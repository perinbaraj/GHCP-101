# API Contract Template

## Products Endpoints

### GET /api/products
- **Description:** Get all products
- **Response:** 200 OK
- **Body:** Array of Product objects

### GET /api/products/{id}
- **Description:** Get specific product
- **Response:** 200 OK or 404 Not Found

### POST /api/products
- **Description:** Create new product
- **Request:** Product object
- **Response:** 201 Created

---

## Orders Endpoints

### POST /api/orders
- **Description:** Create new order
- **Request:** Order object
- **Response:** 201 Created

### GET /api/orders/{id}
- **Description:** Get order details
- **Response:** 200 OK

### PUT /api/orders/{id}/status
- **Description:** Update order status
- **Request:** Status object
- **Response:** 204 No Content

---
**TODO: Complete detailed API specifications using Plan Mode**
