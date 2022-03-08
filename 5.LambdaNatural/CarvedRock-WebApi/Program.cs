using CarvedRock_WebApi.Data;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
builder.Services.AddSingleton<IProductRepository, ProductRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(b => { 
    b.WithOrigins("https://localhost:7220"); 
    b.AllowAnyHeader(); 
    b.AllowAnyMethod(); 
});

app.MapGet("/product", async (IProductRepository productRepository) =>
{
    var products = await productRepository.GetAll();
    if (products.Count() == 0)
        return Results.NoContent();

    return Results.Ok(products);
});

app.MapGet("/product/{id:int}", async ([FromBody]int id, IProductRepository repo) =>
{
    var product = await repo.GetOne(id);

    if (product == null)
        return Results.NotFound();

    return Results.Ok(product);
})
    .WithName("GetOne");

app.MapPost("/product", async (Product product, 
    IProductRepository productRepository) =>
{
    //no validation

    await productRepository.Add(product);
    return Results.CreatedAtRoute("GetOne", new { id = product.Id }, product);
});

app.Run();
