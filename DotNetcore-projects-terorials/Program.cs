var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/Home", () => "Hello World!");
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
// 

// in conventional based Routing ,the route is determined based on the conventions defined
// .. in the route templates which will map the incoming Requests(i,e URLs) to controllers and their action methods

// In ASP.NET Core MVC application ,the Convention based Routes are defined within the Program.cs class file

// In ASP.NET core MVC application ,it is the controller action method that is going to handle the incoming Requests i,e URLs

// for example if we issue a request to the "Home/index" URL then it is the index action method of Home Controller class which is going to handle the request


//app.MapControllerRoute(
//  name: "default",
// pattern: "{controller=User}/{action=About}/{id?}"
//   );


// Now let us start Attribute based Routing
// In Attribute-Based Routing ,[Route] attribute is used to define the routes

// in order to implement attribute routing we need the below middleware
//app.MapControllers();


// let us understand the concepts of Get ,POST,PUT AND DELETE WITH BELOW EXAMPLE

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>

    {
        await context.Response.WriteAsync("this is home page..");
    

       });

    endpoints.MapPost("/Home", async (context) =>

    {
        await context.Response.WriteAsync("this is home page..... Post");


    });

    endpoints.MapPut("/Home", async (context) =>

    {
        await context.Response.WriteAsync("this is home page......Put");


    });

    endpoints.MapDelete("/Home", async (context) =>

    {
        await context.Response.WriteAsync("this is home page......Delete");


    });

    // An endpoint is something that can be : selected by matching the URL and HTTP method.
});


/// let us understand now CONTROLLERS 
  //     R          GET DATA   Updates
//USER > Controller > > MODEL > VIEW

// controller cummunicates between view and model

// Browser > Routing > Controler > Action methods > view

// controller is nothing  but class of C#  inside controller we have written differnet action methods when request is send it calls one of the action methods
// controller manages the flow of the application
// controller is used to define  and group a set of actions
// controller is responsible for intercepting incoming requests and executing the appropriate application code
// controller communicates with the model of the appliaction and selects the required view to be rendered for the request
// allows seperating the business logic of the application from the presentation logic
app.Run();
