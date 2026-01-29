namespace CalculatorApp;

/// <summary>
/// A simple calculator class that performs basic arithmetic operations.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Adds two numbers together.
    /// </summary>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <returns>The sum of a and b.</returns>
    public double Add(double a, double b) => a + b;

    /// <summary>
    /// Subtracts the second number from the first.
    /// </summary>
    /// <param name="a">The minuend.</param>
    /// <param name="b">The subtrahend.</param>
    /// <returns>The difference of a and b.</returns>
    public double Subtract(double a, double b) => a - b;

    /// <summary>
    /// Multiplies two numbers together.
    /// </summary>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <returns>The product of a and b.</returns>
    public double Multiply(double a, double b) => a * b;

    /// <summary>
    /// Divides the first number by the second.
    /// </summary>
    /// <param name="a">The dividend.</param>
    /// <param name="b">The divisor.</param>
    /// <returns>The quotient of a divided by b.</returns>
    /// <exception cref="ArgumentException">Thrown when b is zero.</exception>
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new ArgumentException("Divisor cannot be zero.", nameof(b));
        }
        return a / b;
    }
}
