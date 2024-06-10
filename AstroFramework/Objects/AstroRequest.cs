using System.Net;

namespace AstroFramework.Objects;

public class AstroRequest
{
    /// <summary>
    /// The underlying HttpRequest.
    /// </summary>
    public HttpRequest Request { get; set; }
    /// <summary>
    /// The query parameters associated with this request.
    /// </summary>
    public Dictionary<string, string> Query { get; set; }
    /// <summary>
    /// The body associated with this request, if any.
    /// </summary>
    public string? Body { get; set; }
    /// <summary>
    /// The IP address associated with this request.
    /// </summary>
    public IPAddress IpAddress { get; set; }
    
    /// <summary>
    /// Wraps an HttpRequest into an AstroRequest.
    /// </summary>
    /// <param name="request">The HttpRequest to wrap.</param>
    public AstroRequest(HttpRequest request)
    {
        Request = request;

        // Initialize the request.
        Initialize(request).Wait();
    }

    private async Task Initialize(HttpRequest request)
    {
        Query = new();
        foreach (string key in request.Query.Keys)
        {
            Query.Add(key, request.Query[key]);
        }

        Body = await new StreamReader(request.Body).ReadToEndAsync();
        IpAddress = request.HttpContext.Connection.RemoteIpAddress;
    }
}