using Microsoft.AspNetCore.HttpOverrides;
using QasrUy.Api.Brokers.Storages;
using QasrUy.Api.Services.Foundations.HouseServices;
using QasrUy.Api.Services.Foundations.PictureServices;
using QasrUy.Api.Services.Orchestrations;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        BrokersMethod(builder);
        FoundationsMethods(builder);
        OrchestrationsMethods(builder);


        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", policy =>
            {
                policy.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader();
            });
        });
        var app = builder.Build();

        app.UseStaticFiles();

        app.UseCors("AllowAll");

        if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseForwardedHeaders(new ForwardedHeadersOptions
        {
            ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
        });

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }

    private static void OrchestrationsMethods(WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IHouseOrchestrationService, HouseOrchestrationService>();
    }

    private static void FoundationsMethods(WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IHouseService, HouseService>();
        builder.Services.AddTransient<IPictureService, PictureService>();
    }

    private static void BrokersMethod(WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IStorageBroker, StorageBroker>();
    }
}