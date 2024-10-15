// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

using CodeComplete.Brokers.OpenAis;
using CodeComplete.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IOpenAiBroker, OpenAiBroker>();
builder.Services.AddScoped<ICompleteService, CompleteService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
