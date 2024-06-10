using AstroFramework.Models.Objects;

namespace AstroFramework.Objects;

public class AstroRouter
{
    private WebApplication _app;
    public AstroRouter(WebApplication app)
    {
        _app = app;
    }

    public WebApplication AddRoute(string route, AstroHttpMethod method, AstroHandler handler)
    {
        if (method.Equals(AstroHttpMethod.GET))
        {
            _app.MapGet(route, handler.Handle);
        }
        else if (method.Equals(AstroHttpMethod.POST))
        {
            _app.MapPost(route, handler.Handle);
        }

        return _app;
    }
}