using AstroApplication.Handlers;
using AstroFramework.Models.Objects;
using AstroFramework.Objects;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer().AddSwaggerGen();
var app = builder.Build();
app.UseHttpsRedirection();

// Astro Framework

AstroRouter router = new(app);

// app = router.AddRoute("/v1/test", AstroHttpMethod.GET, new TestHandler());

app.Run();