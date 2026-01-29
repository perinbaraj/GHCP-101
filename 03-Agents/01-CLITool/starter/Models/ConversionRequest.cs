namespace FileConversionAgent.Models;

/// <summary>
/// Represents a file conversion request from the user.
/// </summary>
public class ConversionRequest
{
    /// <summary>
    /// Source file path.
    /// </summary>
    public string SourceFilePath { get; set; } = string.Empty;

    /// <summary>
    /// Target file path where result will be saved.
    /// </summary>
    public string TargetFilePath { get; set; } = string.Empty;

    /// <summary>
    /// Source format (csv, json, xml).
    /// </summary>
    public string SourceFormat { get; set; } = string.Empty;

    /// <summary>
    /// Target format (csv, json, xml).
    /// </summary>
    public string TargetFormat { get; set; } = string.Empty;
}
