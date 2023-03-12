#region ::Service Configuration using Builder ::
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); //MVC based application
/*
builder.Services.AddRazorPages(); // web application

builder.Services.AddControllers(); // web api's */

var app = builder.Build();
#endregion

#region :: Application Configuration ::
/*
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // middleware for authentication i.e credentials will be validated

app.UseAuthorization();// middleware for authorized to access the resources 

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();*/
#endregion

#region :: Custom Middleware Example ::

//first middle ware 
/*app
 *  1.Coontext
 *      1.request
 *          5
 *      2.response 
 *         4
 */
//first middleware 
app.Use(async(context,next) =>
{
   //context.Request.Headers.Keys.ToList().ForEach((val)=> Console.WriteLine("output"+context.Request.ToString()); 
   await context.Response.WriteAsync("Middleware 1 request flow \n");
   await next(context); // invoke passing the next middleware
    await context.Response.WriteAsync("Middleware 1 response flow\n");
});
//second middleware
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 2 request flow \n");
    await next(context); // invoke passing the next middleware
    await context.Response.WriteAsync("Middleware 2 response flow\n");
});
//third middleware
app.Run( async (context) =>
{
    await context.Response.WriteAsync("HelloWorld\n");
});
app.Run();

//app.Run();app.Use();
#endregion