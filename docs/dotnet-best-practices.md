# .NET & C# Best Practices for Copilot-Generated Code

---

## 🎯 Core Principles

### **1. Async/Await is Mandatory**
Never use `.Result` or `.Wait()` — always use `await`.

❌ **Bad:**
```csharp
var result = GetDataAsync().Result; // DEADLOCK!
```

✅ **Good:**
```csharp
var result = await GetDataAsync();
```

### **2. Dependency Injection Everywhere**
Use constructor injection, never direct instantiation.

❌ **Bad:**
```csharp
public class UserController : ControllerBase
{
    private UserService _service = new(); // Tightly coupled
}
```

✅ **Good:**
```csharp
public class UserController : ControllerBase
{
    private readonly IUserService _service;
    
    public UserController(IUserService service)
    {
        _service = service;
    }
}
```

### **3. Null Safety with Nullable Reference Types**
Enable nullable reference types in `.csproj`:

```xml
<PropertyGroup>
    <Nullable>enable</Nullable>
</PropertyGroup>
```

❌ **Bad:**
```csharp
public void ProcessUser(User user)
{
    Console.WriteLine(user.Name); // Could be null!
}
```

✅ **Good:**
```csharp
public void ProcessUser(User? user)
{
    if (user is null)
        throw new ArgumentNullException(nameof(user));
    
    Console.WriteLine(user.Name);
}
```

### **4. Immutability by Default**
Use `readonly` for fields, records for data objects.

❌ **Bad:**
```csharp
public class User
{
    public string Name { get; set; } // Mutable
    public int Age { get; set; }
}
```

✅ **Good:**
```csharp
public record User(string Name, int Age); // Immutable

// Or:
public class User
{
    public required string Name { get; init; }
    public required int Age { get; init; }
}
```

---

## 🏗️ Architecture Patterns

### **1. Service Layer Pattern**
Separate business logic from controllers.

```csharp
// Models
public record CreateUserRequest(string Name, string Email);
public record UserResponse(int Id, string Name, string Email);

// Service Interface
public interface IUserService
{
    Task<UserResponse> CreateUserAsync(CreateUserRequest request);
    Task<UserResponse> GetUserAsync(int id);
    Task UpdateUserAsync(int id, CreateUserRequest request);
    Task DeleteUserAsync(int id);
}

// Service Implementation
public class UserService : IUserService
{
    private readonly IUserRepository _repository;
    
    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<UserResponse> CreateUserAsync(CreateUserRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
            throw new ArgumentException("Name is required");
        
        var user = new User { Name = request.Name, Email = request.Email };
        var created = await _repository.CreateAsync(user);
        
        return MapToResponse(created);
    }
    
    private UserResponse MapToResponse(User user)
        => new(user.Id, user.Name, user.Email);
}

// Controller
[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _service;
    
    public UsersController(IUserService service) => _service = service;
    
    [HttpPost]
    public async Task<ActionResult<UserResponse>> Create(CreateUserRequest request)
    {
        var user = await _service.CreateUserAsync(request);
        return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<UserResponse>> Get(int id)
    {
        var user = await _service.GetUserAsync(id);
        return Ok(user);
    }
}
```

### **2. Repository Pattern**
Abstract data access.

```csharp
public interface IRepository<T>
{
    Task<T> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
    Task<T> CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
}

public class UserRepository : IRepository<User>
{
    private static readonly List<User> _users = new();
    
    public async Task<User> GetByIdAsync(int id)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);
        return await Task.FromResult(user);
    }
    
    public async Task<List<User>> GetAllAsync()
    {
        return await Task.FromResult(new List<User>(_users));
    }
    
    public async Task<User> CreateAsync(User entity)
    {
        entity.Id = _users.Count + 1;
        _users.Add(entity);
        return await Task.FromResult(entity);
    }
    
    // ... other methods
}
```

### **3. SOLID Principles**

**S - Single Responsibility**
```csharp
// ✅ Good: Validator has one job
public class UserValidator
{
    public void Validate(User user)
    {
        if (string.IsNullOrWhiteSpace(user.Name))
            throw new ArgumentException("Name required");
        if (!user.Email.Contains("@"))
            throw new ArgumentException("Invalid email");
    }
}

// ✗ Bad: UserService doing too much
public class UserService
{
    public void CreateUser(User user)
    {
        // Validation
        if (string.IsNullOrWhiteSpace(user.Name))
            throw new ArgumentException("Name required");
        
        // Database save
        // Send email
        // Log event
        // Cache update
        // ... everything!
    }
}
```

**O - Open/Closed**
```csharp
// ✅ Open for extension, closed for modification
public interface INotificationService
{
    Task SendAsync(string message);
}

public class EmailNotification : INotificationService
{
    public async Task SendAsync(string message) { /* ... */ }
}

public class SMSNotification : INotificationService
{
    public async Task SendAsync(string message) { /* ... */ }
}

// Add new notification types without modifying existing code
```

**L - Liskov Substitution**
```csharp
// ✅ Derived classes are substitutable for base
public interface IUserService
{
    Task<User> GetUserAsync(int id);
}

public class UserService : IUserService
{
    public async Task<User> GetUserAsync(int id)
    {
        // Can be called wherever IUserService is expected
        return await _repository.GetByIdAsync(id);
    }
}

public class CachedUserService : IUserService
{
    public async Task<User> GetUserAsync(int id)
    {
        // Also implements interface correctly
        var cached = _cache.Get(id);
        if (cached != null) return cached;
        
        var user = await _repository.GetByIdAsync(id);
        _cache.Set(id, user);
        return user;
    }
}
```

**I - Interface Segregation**
```csharp
// ✅ Small, focused interfaces
public interface IRead<T>
{
    Task<T> GetAsync(int id);
    Task<List<T>> GetAllAsync();
}

public interface IWrite<T>
{
    Task<T> CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
}

// Clients can depend on what they actually need
public class ReadOnlyUserService
{
    private readonly IRead<User> _repository; // Only needs read
}

// ✗ Bad: Fat interface (should be segregated)
public interface IUserRepository
{
    // 20 methods here...
}
```

**D - Dependency Inversion**
```csharp
// ✅ Depend on abstractions
public interface IEmailSender
{
    Task SendAsync(string to, string message);
}

public class UserService
{
    private readonly IEmailSender _emailSender;
    
    public UserService(IEmailSender emailSender)
    {
        _emailSender = emailSender; // Injected, not created
    }
}

// ✗ Bad: Tight coupling to implementation
public class UserService
{
    private readonly SmtpEmailSender _emailSender = new(); // Direct dependency
}
```

---

## 🧪 Testing Best Practices

### **Unit Testing with xUnit**
```csharp
public class UserServiceTests
{
    // Arrange: Set up test data and mocks
    private readonly Mock<IUserRepository> _mockRepository;
    private readonly UserService _service;
    
    public UserServiceTests()
    {
        _mockRepository = new Mock<IUserRepository>();
        _service = new UserService(_mockRepository.Object);
    }
    
    // ✅ Test happy path
    [Fact]
    public async Task CreateUser_WithValidData_ReturnsUser()
    {
        // Arrange
        var request = new CreateUserRequest("John", "john@example.com");
        var mockUser = new User { Id = 1, Name = "John", Email = "john@example.com" };
        
        _mockRepository
            .Setup(r => r.CreateAsync(It.IsAny<User>()))
            .ReturnsAsync(mockUser);
        
        // Act
        var result = await _service.CreateUserAsync(request);
        
        // Assert
        Assert.NotNull(result);
        Assert.Equal(1, result.Id);
        _mockRepository.Verify(r => r.CreateAsync(It.IsAny<User>()), Times.Once);
    }
    
    // ✅ Test error case
    [Fact]
    public async Task CreateUser_WithNullName_ThrowsException()
    {
        // Arrange
        var request = new CreateUserRequest(null, "john@example.com");
        
        // Act & Assert
        await Assert.ThrowsAsync<ArgumentException>(
            () => _service.CreateUserAsync(request)
        );
    }
    
    // ✅ Test with Theory (multiple cases)
    [Theory]
    [InlineData("", "john@example.com")]
    [InlineData(null, "john@example.com")]
    [InlineData("John", "")]
    public async Task CreateUser_WithInvalidData_ThrowsException(
        string name, string email)
    {
        var request = new CreateUserRequest(name, email);
        
        await Assert.ThrowsAsync<ArgumentException>(
            () => _service.CreateUserAsync(request)
        );
    }
}
```

---

## 📝 Naming Conventions

### **Classes & Methods**
```csharp
public class UserService { }           // PascalCase
public async Task<User> GetUserAsync() { } // PascalCase, Async suffix
private void ValidateUser(User user) { }   // PascalCase

public interface IUserService { }       // Prefix with I
public record UserResponse { }          // Record naming
public enum UserStatus { Active, Inactive } // PascalCase
```

### **Variables & Fields**
```csharp
// Local variables: camelCase
var userName = "John";
int userId = 1;

// Fields: _camelCase
private string _userName;
private readonly IUserService _userService;

// Constants: PascalCase
private const int MaxLoginAttempts = 5;
```

---

## 🔐 Error Handling

### **Use Custom Exceptions**
```csharp
public class UserNotFoundException : Exception
{
    public int UserId { get; }
    
    public UserNotFoundException(int userId)
        : base($"User with ID {userId} not found")
    {
        UserId = userId;
    }
}

// Usage
public async Task<User> GetUserAsync(int id)
{
    var user = await _repository.GetByIdAsync(id);
    if (user is null)
        throw new UserNotFoundException(id);
    
    return user;
}

// In controller
[HttpGet("{id}")]
public async Task<ActionResult<UserResponse>> Get(int id)
{
    try
    {
        var user = await _service.GetUserAsync(id);
        return Ok(user);
    }
    catch (UserNotFoundException ex)
    {
        return NotFound(ex.Message);
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Unexpected error");
        return StatusCode(500, "Internal server error");
    }
}
```

---

## 📊 API Response Patterns

### **Consistent Response Format**
```csharp
// Success response
[HttpGet("{id}")]
public async Task<ActionResult<UserResponse>> Get(int id)
{
    var user = await _service.GetUserAsync(id);
    return Ok(user);                  // 200 OK
}

[HttpPost]
public async Task<ActionResult<UserResponse>> Create(
    CreateUserRequest request)
{
    var user = await _service.CreateUserAsync(request);
    return CreatedAtAction(             // 201 Created
        nameof(Get), 
        new { id = user.Id }, 
        user);
}

[HttpPut("{id}")]
public async Task<IActionResult> Update(
    int id, UpdateUserRequest request)
{
    await _service.UpdateUserAsync(id, request);
    return NoContent();                // 204 No Content
}

[HttpDelete("{id}")]
public async Task<IActionResult> Delete(int id)
{
    await _service.DeleteUserAsync(id);
    return NoContent();                // 204 No Content
}

// Error responses
public async Task<ActionResult<UserResponse>> Get(int id)
{
    try
    {
        var user = await _service.GetUserAsync(id);
        return Ok(user);
    }
    catch (UserNotFoundException)
    {
        return NotFound();             // 404 Not Found
    }
    catch (ArgumentException ex)
    {
        return BadRequest(ex.Message); // 400 Bad Request
    }
}
```

---

## 🔍 Validation Patterns

### **Input Validation**
```csharp
[HttpPost]
public async Task<ActionResult<UserResponse>> Create(
    [FromBody] CreateUserRequest request)
{
    // Model validation (automatic with [Required], [StringLength])
    if (!ModelState.IsValid)
        return BadRequest(ModelState);
    
    try
    {
        var user = await _service.CreateUserAsync(request);
        return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
    }
    catch (ArgumentException ex)
    {
        return BadRequest(ex.Message);
    }
}

// Or use FluentValidation
public class CreateUserRequestValidator : 
    AbstractValidator<CreateUserRequest>
{
    public CreateUserRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(100);
        
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();
    }
}
```

---

## 📚 Resource Links

- [Microsoft .NET Documentation](https://learn.microsoft.com/en-us/dotnet/)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [ASP.NET Core Best Practices](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/best-practices)
- [SOLID Principles](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/architectural-principles)
- [Design Patterns in C#](https://refactoring.guru/design-patterns/csharp)

---

**Remember:** When Copilot generates code, always verify it follows these best practices before accepting it!

