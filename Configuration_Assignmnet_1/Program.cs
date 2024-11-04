using Configuration_Assignmnet_1;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.Configure<SocialMediaLinksOptions>(builder.Configuration.GetSection("SocialMediaLinks"));
//builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
//{
//    config.AddJsonFile("SocialMediaLinksConfig.json", optional: true, reloadOnChange: true);
//});
var app = builder.Build();
app.UseRouting();
app.MapControllers();
app.UseStaticFiles();

app.Run();
