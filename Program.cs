var builder = WebApplication.CreateBuilder(args);

//mvc service added
builder.Services.AddControllersWithViews();

var app = builder.Build();
//route with controller => Controller/Action/id
app.MapDefaultControllerRoute();

app.Run();
