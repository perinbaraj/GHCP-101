namespace FileConversionAgent.Models;

/// <summary>
/// Represents the result of a conversion operation.
/// </summary>
public class ConversionResult
{
    /// <summary>
    /// Whether conversion succeeded.
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// Message describing result or error.
    /// </summary>
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// Number of records/lines processed.
    /// </summary>
    public int RecordsProcessed { get; set; }

    /// <summary>
    /// Elapsed time in milliseconds.
    /// </summary>
    public long ElapsedMilliseconds { get; set; }

    /// <summary>
    /// Output file size in bytes.
    /// </summary>
    public long OutputFileSizeBytes { get; set; }
}
