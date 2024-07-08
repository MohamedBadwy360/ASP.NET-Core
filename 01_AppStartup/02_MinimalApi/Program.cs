using _02_MinimalApi.Services;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// DI container service registration

// register IBookService to DI container as scoped 
builder.Services.AddScoped<IBookService, BookService>();

var app = builder.Build();

// Middleware registration / request pipeline

// Add Custom Middleware to the request pipeline that calculates the response time and adds it to the response header
app.Use(async (context, next) =>
{
    var stopWatch = new Stopwatch();
    stopWatch.Start();

    context.Response.OnStarting(() =>
    {
        stopWatch.Stop();
        context.Response.Headers.Append("X-Response-Time", stopWatch.ElapsedMilliseconds.ToString());
        return Task.CompletedTask;
    });

    await next(context);
});

// Get endpoint for the root path
app.MapGet("/", () => "Hello World!");

// Get endpoint for the /books path that returns a list of books
app.MapGet("/books", async (IBookService bookService) => Results.Ok(await bookService.GetBooksAsync()));

app.Run();