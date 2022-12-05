using Galleria.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Azure.Identity;

var builder = WebApplication.CreateBuilder(args);

var keyVaultEndpoint = new Uri(Environment.GetEnvironmentVariable("VaultUri"));
builder.Configuration.AddAzureKeyVault(keyVaultEndpoint, new DefaultAzureCredential());

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "About Me Page",
    pattern: "{ controller = Profile}/{ action = _AboutMePartial}/{ id ?}");
app.MapControllerRoute(
    name: " PricingInformation",
    pattern: "{ controller = Profile}/{ action = _PricingInformation}/{ id ?}");
app.MapControllerRoute(
    name: " Contact Information",
    pattern: "{ controller = Profile}/{ action = _ContactInformation}/{ id ?}");
app.MapControllerRoute(
    name: "Commissions",
    pattern: "{ controller = Profile}/{ action = Index}/{ id ?}");
app.MapControllerRoute(
    name: "CreateCommissions",
    pattern: "{ controller = Profile}/{ action = CreateCommission}/{ id ?}");
app.MapControllerRoute(
    name: "EditCommissions",
    pattern: "{ controller = Profile}/{ action = EditCommission}/{ id ?}");

app.MapControllerRoute(
    name: "Settings",
    pattern: "{ controller = Account}/{ action = Settings}/{ id ?}");


app.MapRazorPages();

app.Run();