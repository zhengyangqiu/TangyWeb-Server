using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TangyWeb_Server.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

else {
    app.UseDeveloperExceptionPage();


}

app.UseStaticFiles();

app.UseRouting();

//add signalR connection
app.MapBlazorHub();
//default page if can't routing
app.MapFallbackToPage("/_Host");

app.Run();


//it is the program to start the application
