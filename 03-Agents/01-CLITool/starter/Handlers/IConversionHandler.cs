namespace FileConversionAgent.Handlers;

using FileConversionAgent.Models;

/// <summary>
/// Interface for conversion handlers in the agent pipeline.
/// TODO: Implement handlers for different conversion types (CSV→JSON, JSON→XML, etc.)
/// </summary>
public interface IConversionHandler
{
    /// <summary>
    /// Executes the conversion step.
    /// </summary>
    Task<ConversionResult> HandleAsync(ConversionRequest request);
}
