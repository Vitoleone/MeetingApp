var builder = WebApplication.CreateBuilder(args);

//mvc service added
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(); //we can use wwwroot files with this.
app.UseRouting();
//route with controller => Controller/Action/id
app.MapDefaultControllerRoute();

app.Run();
