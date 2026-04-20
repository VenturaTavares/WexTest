using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using wex_test.Application.AutoMapper;
using wex_test.Setup;
using wext_test.Data;
var builder = WebApplication.CreateBuilder(args);


builder.Configuration
           .SetBasePath(builder.Environment.ContentRootPath)
           .AddJsonFile("appsettings.json", true, true)
           .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
           .AddEnvironmentVariables();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");


//builder.Services.AddDbContext<WexTestContext>(options =>
//    options.UseSqlServer(connectionString));

builder.Services.AddDbContext<WexTestContext>(opt =>
{
    opt.UseInMemoryDatabase("WexTestDB");
});



builder.Services.AddAutoMapper(cfg => cfg.LicenseKey = "\r\neyJhbGciOiJSUzI1NiIsImtpZCI6Ikx1Y2t5UGVubnlTb2Z0d2FyZUxpY2Vuc2VLZXkvYmJiMTNhY2I1OTkwNGQ4OWI0Y2IxYzg1ZjA4OGNjZjkiLCJ0eXAiOiJKV1QifQ.eyJpc3MiOiJodHRwczovL2x1Y2t5cGVubnlzb2Z0d2FyZS5jb20iLCJhdWQiOiJMdWNreVBlbm55U29mdHdhcmUiLCJleHAiOiIxODA4MDkyODAwIiwiaWF0IjoiMTc3NjU1NzU3MyIsImFjY291bnRfaWQiOiIwMTlkYTMxNTAwMDM3NzU3OGJkZTRkYmRjZGM3NTU2NyIsImN1c3RvbWVyX2lkIjoiY3RtXzAxa3BoaGFobWc1bXp0ZG42ZDMwM2I0dDhjIiwic3ViX2lkIjoiLSIsImVkaXRpb24iOiIwIiwidHlwZSI6IjIifQ.xksT5towzwqGJcKy6R-se-MxuBxBR5mCruoNwAzgAP2AbPWfsXTpSPh0ZShZ3YbqjtRW9tDY00FL-cN-bwKx68L7ss6REvhtI6ZVE0KkxQ6GO3mSx7Z-NHIJqqi-9jG7WvAQsduR6Z1AOVCWfJ1IvAxnFkiYwbsZHA3G1jfzTttwjkIFnik_X3_k3UCTEzemrYGCFHt-UscPEGO9gtd6p-TEjrcW7BgTD-evaI_LBqCZryzOhUC0Fz4jLtRxBN46dVPic4ZVRJNJ5rcacd_tGpUPOD-JXgi2Gq_n7d_FhOPDEyjrtoIejxa17tMrPwDtzpHlGofu9gMXceG0BjvMBw", typeof(DomainToViewModelMappingTransaction), typeof(ViewModelToDomainMappingProfile));

//builder.Services.AddAutoMapper(typeof(DomainToViewModelMappingTransaction), typeof(ViewModelToDomainMappingProfile));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.RegisterServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Transaction}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
