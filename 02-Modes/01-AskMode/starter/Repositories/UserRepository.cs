namespace AskModeApp.Repositories;

using AskModeApp.Models;

/// <summary>
/// TODO: Analyze this repository. What issues do you see?
/// Use Ask Mode to research design patterns and refactor this code.
/// 
/// Issues to identify:
/// - Direct data exposure (returning _users list)
/// - No return value feedback
/// - Manual iteration instead of LINQ
/// - No abstraction (interface)
/// - Tightly coupled (can't test)
/// </summary>
public class UserRepository
{
    private static List<User> _users = new();

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public User GetUserById(int id)
    {
        foreach (var user in _users)
        {
            if (user.Id == id)
                return user;
        }
        return null; // TODO: Should this throw instead?
    }

    public List<User> GetAllUsers()
    {
        return _users; // TODO: Exposes internal collection
    }

    public List<User> FilterByAge(int minAge, int maxAge)
    {
        var result = new List<User>();
        foreach (var user in _users)
        {
            if (user.Age >= minAge && user.Age <= maxAge)
                result.Add(user);
        }
        return result;
    }

    public void UpdateUser(int id, User updatedUser)
    {
        var user = GetUserById(id);
        if (user != null)
        {
            user.Name = updatedUser.Name;
            user.Age = updatedUser.Age;
            user.Email = updatedUser.Email;
        }
        // TODO: No indication if update succeeded
    }

    public bool DeleteUser(int id)
    {
        var user = GetUserById(id);
        if (user != null)
        {
            _users.Remove(user);
            return true;
        }
        return false;
    }
}
