var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

#region Logging

builder.Logging.ClearProviders(); //حذف تمامی پرووایردهایی که فعال شده بودن از قبل
builder.Logging.AddConsole(); //اگر ثبت لاگ کنیم تو کنسول نشون میده
builder.Logging.AddDebug(); // Debug
builder.Logging.AddEventLog(); //windows Log
#endregion

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
