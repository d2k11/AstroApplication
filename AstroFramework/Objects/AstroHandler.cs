using AstroFramework.Models.Objects;
using AstroFramework.Models.Responses;

namespace AstroFramework.Objects;

public abstract class AstroHandler
{
    /// <summary>
    /// The underlying request.
    /// </summary>
    public AstroRequest Request { get; set; }

    /// <summary>
    /// Handle this request.
    /// </summary>
    /// <returns>The request response.</returns>
    public abstract Task Handle(HttpRequest request);
    
    /// <summary>
    /// Initializes this request.
    /// </summary>
    /// <returns>The request response.</returns>
    public Task Initialize(HttpRequest request)
    {
        Request = new(request);
        return Task.CompletedTask;
    }

    /// <summary>
    /// Fail this request.
    /// </summary>
    /// <param name="error">The error that occurred to fail this request.</param>
    /// <returns>A generic error with the provided error text.</returns>
    public object Fail(string error)
    {
        return new AstroResponse()
        {
            success = false,
            error = error
        };
    }

    /// <summary>
    /// Pass this request.
    /// </summary>
    /// <returns>A generic success.</returns>
    public object Success()
    {
        return new AstroResponse()
        {
            success = true
        };
    }
}