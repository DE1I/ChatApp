using ChatApp.Hubs; // lets you use the ChatHub class defined in the ChatApp.Hubs namespace, which is responsible for handling real-time communication between clients and the server using SignalR.

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR(); // This line registers SignalR services with the dependency injection container, enabling the application to use SignalR for real-time communication between clients and the server.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Auth}/{action=Login}/{id?}")
    .WithStaticAssets();

app.MapHub<ChatHub>("/chathub"); // This line maps the ChatHub class to the "/chathub" URL path, allowing clients to connect to the SignalR hub at that endpoint for real-time communication.


app.Run();
