using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using ShippingTrackingAPI.Data;
using ShippingTrackingAPI.DataRepository;
using ShippingTrackingAPI.Models;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<WizmoShippingDetailsContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("ShippingApiConnectionString"))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet(pattern: "/GetShippingStatus", (DateTime startDate, DateTime endDate, WizmoShippingDetailsContext db) =>
{
    try
    {
        var result = db.LoadStoreProcedure("GetShippingStatus")
            .WithSqlParams(
                (nameof(startDate), startDate),
                (nameof(endDate), endDate))
            .ExecuteStoreProcedure<ShippingTrackingStatus>();
        return Results.Ok(result);
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message);
    }
})
.WithOpenApi();

app.Run();
