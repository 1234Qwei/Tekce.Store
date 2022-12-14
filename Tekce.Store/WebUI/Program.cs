using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using WebUI._keenthemes;
using WebUI._keenthemes.libs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(1);
});
builder.Services.AddScoped<IKTTheme, KTTheme>();
builder.Services.AddSingleton<IKTBootstrapBase, KTBootstrapBase>();

// Add services to the container.
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddMvc()
    .AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();
var mvcBuilder = builder.Services.AddRazorPages();
if (builder.Environment.IsDevelopment())
{
    mvcBuilder.AddRazorRuntimeCompilation();
}

builder.Services.Configure<RequestLocalizationOptions>(options =>
    {
        var supportedCultures = new[] {
            new CultureInfo("ja"),
            new CultureInfo("en"),
            new CultureInfo("ar"),
            new CultureInfo("de"),
            new CultureInfo("es"),
            new CultureInfo("fr"),
        };
        options.DefaultRequestCulture = new RequestCulture(culture: "en", uiCulture: "en");
        options.SupportedCultures = supportedCultures;
        options.SupportedUICultures = supportedCultures;
    });

IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("themesettings.json")
                            .Build();

var app = builder.Build();

app.Use(async (context, next) =>
    {
        await next();
        if (context.Response.StatusCode == 404)
        {
            context.Request.Path = "/not-found";
            await next();
        }
    });

KTThemeSettings.init(configuration);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();
app.UseThemeMiddleware();


app.MapControllerRoute(name: "signin",
                pattern: "signin",
                defaults: new { controller = "Auth", action = "signIn" });
app.MapControllerRoute(name: "signup",
                pattern: "signup",
                defaults: new { controller = "Auth", action = "signUp" });
app.MapControllerRoute(name: "reset-password",
                pattern: "reset-password",
                defaults: new { controller = "Auth", action = "resetPassword" });
app.MapControllerRoute(name: "new-password",
                pattern: "new-password",
                defaults: new { controller = "Auth", action = "newPassword" });

app.MapControllerRoute(name: "not-found",
                pattern: "not-found",
                defaults: new { controller = "System", action = "notFound" });
app.MapControllerRoute(name: "error",
                pattern: "error",
                defaults: new { controller = "System", action = "error" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboards}/{action=Index}/{id?}");

app.Run();
