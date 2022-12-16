using Autofac;
using Autofac.Extensions.DependencyInjection;
using CleanTest.Core;
using CleanTest.Infrastructure;
using CleanTest.Web.Configuration;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//builder.Services.AddRazorPages().AddRazorPagesOptions(options =>
//    {
//        options.Conventions.AddAreaPageRoute("CatalogArea", "/CatalogPages/index", "catalog2");
//    });


builder.RegisterAutoFacModules();

builder.Services.AddDbContextServices(builder.Configuration);
builder.Services.AddAutoMapperServices();
builder.Services.AddCoreServices(builder.Configuration);
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddWebServices(builder.Configuration);



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapRazorPages();

app.Run();
