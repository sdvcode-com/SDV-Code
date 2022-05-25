// <copyright file="Program.cs" company="SDV Code">
// Copyright (c) SDV Code. All rights reserved.
// </copyright>

using AutoMapper;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using SdvCode.Models.User;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DbConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found.");

builder.Services.AddDbContext<global::SdvCode.Data.Context>((global::Microsoft.EntityFrameworkCore.DbContextOptionsBuilder options) =>
    options.UseSqlServer(connectionString));

builder.Services.AddIdentity<User, Role>((IdentityOptions options) => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<SdvCode.Data.Context>();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddRazorPages();

// Setup AutoMapper Profiles Configurations
builder.Services.AddScoped(provider => new MapperConfiguration(cfg =>
{
    // Register Profiles
}).CreateMapper());

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Use(async (context, next) =>
{
    // Middleware logic
    await next();
});

app.Run();