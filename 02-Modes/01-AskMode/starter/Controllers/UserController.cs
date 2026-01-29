using AskModeApp.Models;
using AskModeApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AskModeApp.Controllers;

/// <summary>
/// TODO: Using Ask Mode, analyze how this controller and repository work together.
/// Ask Copilot:
/// - "What design patterns are missing here?"
/// - "How can I refactor for testability?"
/// - "What's the Repository Pattern and when should I use it?"
/// - "Should this use dependency injection?"
/// 
/// Then refactor based on the guidance.
/// </summary>
[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly UserRepository _repository = new();

    [HttpGet]
    public List<User> GetAllUsers()
    {
        // TODO: Should return IActionResult with proper status codes
        return _repository.GetAllUsers();
    }

    [HttpGet("{id}")]
    public User GetUserById(int id)
    {
        // TODO: Handle null case
        return _repository.GetUserById(id);
    }

    [HttpGet("filter")]
    public List<User> FilterByAge(int minAge, int maxAge)
    {
        // TODO: Add error handling and validation
        return _repository.FilterByAge(minAge, maxAge);
    }

    [HttpPost]
    public void CreateUser(User user)
    {
        // TODO: No return value, should return 201 Created
        _repository.AddUser(user);
    }

    [HttpPut("{id}")]
    public void UpdateUser(int id, User user)
    {
        // TODO: No feedback if succeeded
        _repository.UpdateUser(id, user);
    }

    [HttpDelete("{id}")]
    public bool DeleteUser(int id)
    {
        return _repository.DeleteUser(id);
    }
}
