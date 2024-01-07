var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//mvc service added
builder.Services.AddControllersWithViews();

//route with controller => Controller/Action/id
app.MapDefaultControllerRoute();

app.Run();
