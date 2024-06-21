var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/example-list", () => TypedResults.Ok<string[]>([
            "Tokyo",
            "Delhi",
            "Shanghai",
            "Sao Paulo",
            "Mumbai",
            "Beijing",
            "Cairo",
            "Dhaka",
            "Mexico City",
            "Osaka",
            "Karachi",
            "Chongqing",
            "Istanbul",
            "Buenos Aires",
            "Kolkata",
            "Lagos",
            "Kinshasa",
            "Manila",
            "Tianjin",
            "Guangzhou"
        ]))
    .WithOpenApi();

app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.Run();
