using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Cho phép ứng dụng phục vụ static files từ thư mục wwwroot
app.UseStaticFiles();

// Nếu người dùng truy cập "/", tự động chuyển sang trang SignUp.html
app.MapGet("/", (context) =>
{
    context.Response.Redirect("/SignUp.html");
    return Task.CompletedTask;
});

// Cấu hình thêm nếu bạn có thư mục khác chứa file tĩnh (tuỳ chọn)
// app.UseStaticFiles(new StaticFileOptions
// {
//     FileProvider = new PhysicalFileProvider(
//         Path.Combine(Directory.GetCurrentDirectory(), "assets")),
//     RequestPath = "/assets"
// });

// Khởi chạy ứng dụng
app.Run();
