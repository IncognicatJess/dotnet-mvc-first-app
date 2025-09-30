using dotnet_mvc_first_app.Filters;

var builder = WebApplication.CreateBuilder(args);

// Tambahkan MVC
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<AuthFilter>();


// Tambahkan session (harus sebelum app.Build)
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // expired 30 menit
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseRouting();

app.UseSession(); // <-- aktifkan session DI SINI, setelah UseRouting

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Account}/{action=Login}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
