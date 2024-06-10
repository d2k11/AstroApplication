namespace AstroFramework.Models.Responses;

public class AstroResponse
{
    /// <summary>
    /// If this request was successful.
    /// </summary>
    public bool success { get; set; } = true;
    /// <summary>
    /// If the request was not successful, the cause of the failure.
    /// </summary>
    public string? error { get; set; } = String.Empty;
    /// <summary>
    /// The timestamp in which this request completed.
    /// </summary>
    public DateTime timestamp { get; set; } = DateTime.Now;
}