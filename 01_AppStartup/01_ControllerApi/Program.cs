using _01_ControllerApi.Services;

var builder = WebApplication.CreateBuilder(args);

// DI container service registration

// Add IBookService to DI container
builder.Services.AddScoped<IBookService, BookService>();

// Add Controllers services to DI container
builder.Services.AddControllers();

var app = builder.Build();

// Middleware registration / request pipeline

// Add ControllersMiddleware to request pipeline
app.MapControllers();

app.Run();
