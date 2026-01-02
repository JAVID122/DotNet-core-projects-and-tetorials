var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!")
//app.Run(async (context) =>
//await context.Response.WriteAsync("welcome to Programmentor"));

// so when ever send a request it will hit the above middke ware .
//if we use Run function then the nxt middle ware will not run because it does not have next function 
// so we should use USE insted 
// in use we have the facility to call nxt middle wares
// example
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("welcome to Programmentor  regarding middle wares");
    await next(context);
}
);
app.MapGet("/", () => "Hello World!");

app.Run(async (context) =>
await context.Response.WriteAsync("welcome to Programmentor"));

//middle wares have acess to all the requests and responses
// order of middlewares is important as middel wares execute as per there order
// middleware defined using app.run will never call subsiquest middleware
//the Use() metheod places a middleware in the pipeline and allows that midddle ware to pass control to the next item in the pipeline
app.Run();
