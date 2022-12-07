var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
//builder.Services.AddSpaStaticFiles(configuration => configuration.RootPath = $"{GlobalWiring.AngularClient}/dist");
var app = builder.Build();
app.UseStaticFiles();
//app.MapGet("index.html", () => "Hello World!");
//app.usespa
app.Run();
