
//this application is a web app when main method is invoke then create a web application
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
var app = builder.Build();
//configuration middlewares
// http://localhost:54321
// http://localhost:54321/home
// http://localhost:54321/privacy
// routing -> html
app.UseStaticFiles();
//MVC pattern we are using and serving file 
//serve the routes defined in controllers 

//routing routes [/, /home. /privacy]
app.UseRouting();// middleware

//where to find the routes and how to invoke
// find Controller folder in the project and list all the controller there in the folder 
//home controller => home

/*
 * Asp.net framework is reading the classes there in the controller folder and list all the methods as routes 
 * using reflection technique
 */
app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Home}"
    );

/*
app.MapGet("/", () => "Hello World!");
app.MapGet("/myHome", () => "Home Page");
app.MapGet("/Privacy", () => "Privacy");
*/

app.Run();
