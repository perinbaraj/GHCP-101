namespace FileConversionAgent.Handlers;

using FileConversionAgent.Models;

/// <summary>
/// Validates conversion requests before processing.
/// This is the first handler in the pipeline.
/// TODO: Implement validation logic
/// </summary>
public class ValidationHandler : IConversionHandler
{
    public async Task<ConversionResult> HandleAsync(ConversionRequest request)
    {
        // TODO: Validate source file exists
        // TODO: Validate source format is supported
        // TODO: Validate target format is supported
        // TODO: Check target directory is writable
        
        return await Task.FromResult(new ConversionResult
        {
            Success = false,
            Message = "TODO: Implement validation"
        });
    }
}
