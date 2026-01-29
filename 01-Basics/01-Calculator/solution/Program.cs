using CalculatorApp;

Console.WriteLine("Welcome to the Simple Calculator!");
Console.WriteLine("==================================\n");

try
{
    Console.Write("Enter first number: ");
    if (!double.TryParse(Console.ReadLine(), out double firstNumber))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        return;
    }

    Console.Write("Enter operation (+, -, *, /): ");
    string? operation = Console.ReadLine();

    Console.Write("Enter second number: ");
    if (!double.TryParse(Console.ReadLine(), out double secondNumber))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        return;
    }

    var calculator = new Calculator();
    double result = operation switch
    {
        "+" => calculator.Add(firstNumber, secondNumber),
        "-" => calculator.Subtract(firstNumber, secondNumber),
        "*" => calculator.Multiply(firstNumber, secondNumber),
        "/" => calculator.Divide(firstNumber, secondNumber),
        _ => throw new ArgumentException($"Invalid operation: {operation}")
    };

    Console.WriteLine($"\nResult: {firstNumber} {operation} {secondNumber} = {result}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}
