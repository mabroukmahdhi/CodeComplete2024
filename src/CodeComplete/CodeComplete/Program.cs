// -----------------------------------
// Copyright (c) B&O Service AG.
// Made with love for DevConf 2024.
// -----------------------------------

using System;
using CodeComplete.Brokers.OpenAis;
using CodeComplete.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Standard.AI.OpenAI.Clients.OpenAIs;
using Standard.AI.OpenAI.Models.Configurations;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var openAIConfigurations = new OpenAIConfigurations
{
    ApiKey = Environment.GetEnvironmentVariable("OpenAiKey"),
    OrganizationId = Environment.GetEnvironmentVariable("OpenAiOrgKey")
};

builder.Services.AddSingleton<IOpenAIClient>(client =>
    new OpenAIClient(openAIConfigurations));

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
