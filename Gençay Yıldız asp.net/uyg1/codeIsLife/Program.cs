var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddMvc();
//  A�A�IDAK� �K�S�N�N TOPLAMI ADDMVC YE KAR�ILIK GEL�YOR. 
builder.Services.AddControllersWithViews();
//builder.Services.AddRazorPages();


var app = builder.Build();


//app.MapGet("/", () =>
//{
//    return "Kanala abone olup bildirimleri a�may� unutmay�n!";
//}); BURASI D�REK SAYFAYA YAZIYOR METN�. D��ER T�RL� DAHA TEM�Z B�R KOD ELDE ED�YORUZ


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");//PROJE �ALI�TI�INDA NEREDEN BA�LAYACA�INI ANLAMASI ���N YOL G�STER�YORUZ
app.Run();
