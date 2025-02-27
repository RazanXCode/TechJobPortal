// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// builder.Services.AddControllersWithViews();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Home/Error");
//     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//     app.UseHsts();
// }

// app.UseHttpsRedirection();
// app.UseRouting();

// app.UseAuthorization();

// app.MapStaticAssets();

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=JobListing}/{action=Index}/{id?}")
//     .WithStaticAssets();



// app.Run();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

// Define routes for Job Listings and Job Details
app.MapControllerRoute(
    name: "JobListing",
    pattern: "jobs/list", 
    defaults: new { controller = "JobListing", action = "Index" });

app.MapControllerRoute(
    name: "JobDetails",
    pattern: "jobs/{id:int}", 
    defaults: new { controller = "JobListing", action = "Details" });

// Map default route (for other pages like Home)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=JobListing}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapStaticAssets();

app.Run();


