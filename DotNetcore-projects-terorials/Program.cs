using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

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




// Action methods
 // Actions are the methods in controller class which are responsible for returning the view or Jason data.
 // Action methods are public methods in controller classses



// what is dependency Injection in ASP.NET core? 

// Dependency Injection (DI) is a software design pattern that allows us to develop loosely coupled application

//ANS: This is a process in which we are injecting the object of a class into another class that depends on that object.

//public class B
//{
//    public int MethodB()
//    {
//        return 100;
//    }
//}
//public class A
//{
//    public static void Main (string[] args)
//    {
//        B.b = new B();
//        int a = b.MethodB();
//        Console.WriteLine(a);

//    }
//}

// Why to use Dependency Injection? OR what problem does Dependency Injection solve?

//public class MathStudent
//{
//    public int GetStudentCount()
//    {
//        return 50;
//}


//    public class FirstController : controller {
    //public int Index()
    //    {
    //        MathStudent cls = new MathStudent();
    //        return cls.GetStudentCount();
    //    }
    //}

    // now if i am told to create a Science student class i will cretae ;like below example

    //public class ScienceStudent
    //{
    //    public int GetScienceCount() {
    //        return 100;

    //    }

        // now i will replace it in one controller what if there many controllers like 100 0f them which are creting the object of Math student class now when  we are asked to chnage it to Science student class then we  have to manually change it every where
        // // then we have to test each and every contrioller that will be headace then agin tommorow we will be asked to create another class again same problem
        // to get rid of this problem we need dependency injection concept 
        // now if we will create differnet classes then we do not  need to  make chnages in each controller 


        /// next question is how to implement the dependency injection


// Tight Coupling 

// . Tight coupling is when a group of classes are highly dependent on one another
// suppose Car class will use both Engine and Brakes means it will need to create object of both classes to implement there properties
     
// loose Coupling means that the classes are indepent of each other
  // like Stuent is not dependent on teacher and Admin classes
  // 
  // Dependence injection is achived using Interfaces.
  // interfaces are a powerful tool to use for decoupling

// Dependence Injection is basically providing the objects that
// an object ,instead of having it contruct the object themselves
// Di is a technique whereby one object supplies the dependencies of another object

app.Run();
