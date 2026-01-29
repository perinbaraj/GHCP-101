namespace EditModeApp.Models;

/// <summary>
/// TODO: Using Edit Mode, refactor this class to:
/// 1. Use PascalCase for all properties (id → Id)
/// 2. Add XML documentation
/// 3. Use proper null safety (nullable types)
/// </summary>
public class Product
{
    public int id { get; set; }
    public string productName { get; set; }
    public decimal price { get; set; }
}
