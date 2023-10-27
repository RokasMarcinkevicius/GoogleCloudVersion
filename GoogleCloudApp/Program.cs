var builder = WebApplication.CreateBuilder(args);

// For Cloud Run
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
var url = $"http://0.0.0.0:{port}";

var app = builder.Build();

app.MapGet("/", () => $"Hello .NET {Environment.Version.ToString()}!");

app.Run(url);
// https://console.cloud.google.com/run/detail/europe-west4/googlecloudversion/revisions?hl=en&project=portfolio-1559066296541