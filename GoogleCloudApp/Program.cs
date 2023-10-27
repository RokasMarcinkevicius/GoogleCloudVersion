var builder = WebApplication.CreateBuilder(args);

// For Cloud Run
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
var url = $"http://0.0.0.0:{port}";

var app = builder.Build();

app.MapGet("/", () => $"Hello .NET {Environment.Version.ToString()}!");

app.Run(url);