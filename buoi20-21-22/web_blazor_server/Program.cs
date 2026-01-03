// Tạo ra trang web
var builder = WebApplication.CreateBuilder(args);
// ------ build ------


// This is the 2 libraries that allow u to run the app on the server 

builder.Services.AddRazorPages(); // DI (thêm) thư viên razor web
builder.Services.AddServerSideBlazor(); // DI (add) server side library 


// Build Trang web
var app = builder.Build();



// ------ use ------ use the library 


// Web được chạy trên domain https and http 
// Neey ko dùng cái này thì chỉ mỗi domain http được dùng 
app.UseHttpsRedirection();


app.UseStaticFiles(); // middleware for static file
 

// Before the app run -> all middleware will be activated first 
// app.MapFallBackToPage() -> determined which page will be run first 

app.MapBlazorHub(); //middleware -> make file run first
// --> 
app.MapFallbackToPage("/_Host"); // first file

// Khi dùng dotnet run -> cái này sẽ được call
app.Run();
