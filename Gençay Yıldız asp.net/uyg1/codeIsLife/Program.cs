var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddMvc();
//  AÞAÐIDAKÝ ÝKÝSÝNÝN TOPLAMI ADDMVC YE KARÞILIK GELÝYOR. 
builder.Services.AddControllersWithViews();
//builder.Services.AddRazorPages();


var app = builder.Build();


//app.MapGet("/", () =>
//{
//    return "Kanala abone olup bildirimleri açmayý unutmayýn!";
//}); BURASI DÝREK SAYFAYA YAZIYOR METNÝ. DÝÐER TÜRLÜ DAHA TEMÝZ BÝR KOD ELDE EDÝYORUZ


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");//PROJE ÇALIÞTIÐINDA NEREDEN BAÞLAYACAÐINI ANLAMASI ÝÇÝN YOL GÖSTERÝYORUZ
app.Run();
