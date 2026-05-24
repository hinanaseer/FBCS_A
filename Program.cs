var builder = WebApplication.CreateBuilder(args); var app = builder.Build(); app.MapGet("/", () => "FBCA Live Deployment Simulation Successful!"); app.Run();
