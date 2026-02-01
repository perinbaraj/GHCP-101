namespace CodeCompletionApp;

/// <summary>
/// A simple calculator demonstrating Copilot autocomplete.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Adds two numbers together.
    /// </summary>
    public double Add(double a, double b)
    {
        // TODO: Let Copilot autocomplete - type { and press Tab
        throw new NotImplementedException();
    }

    /// <summary>
    /// Subtracts b from a.
    /// </summary>
    public double Subtract(double a, double b)
    {
        // TODO: Let Copilot autocomplete
        throw new NotImplementedException();
    }

    /// <summary>
    /// Multiplies two numbers.
    /// </summary>
    public double Multiply(double a, double b)
    {
        // TODO: Let Copilot autocomplete
        throw new NotImplementedException();
    }

    /// <summary>
    /// Divides a by b with zero check.
    /// </summary>
    public double Divide(double a, double b)
    {
        // TODO: Let Copilot autocomplete - but verify division by zero handling!
        if (b == 0)
        {
            throw new ArgumentException("Cannot divide by zero");
        }
        throw new NotImplementedException();
    }
}
