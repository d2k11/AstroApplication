using AstroFramework.Models.Responses;
using AstroFramework.Objects;

namespace AstroApplication.Handlers;

public class TestHandler : AstroHandler
{
    public override async Task<AstroResponse> Handle(HttpRequest request)
    {
        Initialize(request);
        
        return new AstroResponse()
        {
            success = true
        };
    }
}