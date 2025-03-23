using Serilog;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog((context, config) => 
    config.ReadFrom.Configuration(context.Configuration)
);

builder.Services.AddOpenApi();

builder.Services.AddControllers();
builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddCors(options => options
    .AddDefaultPolicy(builder => builder
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()
        .SetIsOriginAllowed(_ => true)
    )
);

var app = builder.Build();

app.MapOpenApi();
app.UseHttpsRedirection();

app.UseCors();
app.UseRouting();
app.UseEndpoints(options =>
{
    options.MapControllers();
});

app.Run();
