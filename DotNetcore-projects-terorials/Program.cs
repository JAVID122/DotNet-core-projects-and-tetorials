var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!")
//app.Run(async (context) =>
//await context.Response.WriteAsync("welcome to Programmentor"));

// so when ever send a request it will hit the above middke ware .
//if we use Run function then the nxt middle ware will not run because it does not have next function 
// so we should use USE insted 
// in use we have the facility to call nxt middle wares
// example
//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("welcome to Programmentor  regarding middle wares  gvghvhvh");
//    await next(context);
//}
//);
//app.MapGet("/", () => "Hello World! hello world");

//app.Run(async (context) =>
//await context.Response.WriteAsync("welcome to Programmentor this was very informative"));

//middle wares have acess to all the requests and responses
// order of middlewares is important as middel wares execute as per there order
// middleware defined using app.run will never call subsiquest middleware
//the Use() metheod places a middleware in the pipeline and allows that midddle ware to pass control to the next item in the pipeline

//Rounting in Asp.Net core MVC  application is a machanism in which it will inspect the incoming Requests(i,e URLS) and then mapped that request to the controllers and their action methods
// Routing = URL + HTTP METHODS(GET POST ,PUT , DELETE)

// This mapping is done by the routing rules which are defined for the application

// We can do this by adding the routing middleware to the request processing pipeline

// so, the ASP.NET core Framework maps or connects the incoming Rerquests i,e URLS to the controllers action methods based on the Routes configured in your application

// What are the differnet types of routing supported by ASP.NET core MVC?

// .1 Convention based Routing 
// 2. Attribute-Based Routing

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=index}/{id?}"
//    );
// above we have convention based routing

//app.MapDefaultControllerRoute();
// if we do not want to call index controller by default then we will not call the above method 
// insted we will define below which contoller to call by setting a pattern

app.MapControllerRoute(
  name: "default",
 pattern: "{controller=User}/{action=index}/{id?}"
   );
app.Run();
