using QasrUy.Api.Brokers.Storages;
using QasrUy.Api.Models;
using QasrUy.Api.Services.Foundations.HouseServices;
using QasrUy.Api.Services.Foundations.PictureServices;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddSwaggerGen(c =>
        {
            c.SchemaFilter<IgnorePropertySchemaFilter>();
        });

        BrokersMethod(builder);
        FoundationsMethods(builder);

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseStaticFiles();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
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