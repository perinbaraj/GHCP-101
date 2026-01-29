using FileConversionAgent.Models;
using FileConversionAgent.Services;

// TODO: Using Agent Mode, design and implement an autonomous file conversion agent.
// 
// Ask Copilot:
// "Design a file conversion agent that autonomously:
// 1. Accepts user input
// 2. Validates the request
// 3. Selects the appropriate converter
// 4. Performs the conversion
// 5. Validates the output
// 6. Reports results
//
// Include command patterns, handler chains, and error recovery strategies."

var agent = new ConversionAgent();

Console.WriteLine("=== File Conversion Agent ===\n");

while (true)
{
    try
    {
        // TODO: Get user input
        // TODO: Create ConversionRequest
        // TODO: Call agent.ConvertAsync()
        // TODO: Display results

        Console.WriteLine("TODO: Implement CLI prompts and agent execution");
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}\n");
    }
}
