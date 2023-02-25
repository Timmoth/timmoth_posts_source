using Learning_AutoMapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddSingleton<BlogCollection>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();