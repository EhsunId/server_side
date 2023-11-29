using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project_2.Models;

namespace Project_2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

        public IActionResult Products_Page()
    {

        List<products> ListProducts = new List<products>();
        
        products obj1 = new products();
        obj1.P_id=123;
        obj1.P_name="Phone";
        obj1.P_category="Digital";
        obj1.P_weight=100;
        obj1.P_height=200;
        obj1.P_DateInsert=DateTime.Parse("2018/7/20");
        obj1.P_price=10000;
        obj1.P_available=true;
        ListProducts.Add(obj1);

        products obj2 = new products();
        obj2.P_name="Computer_Book";
        obj2.P_category="Book";
        obj2.P_weight=10;
        obj2.P_height=25;
        obj2.P_DateInsert=DateTime.Parse("2001/8/21");
        obj2.P_id=234;
        obj2.P_price=170;
        obj2.P_available=true;
        ListProducts.Add(obj2);

        products obj3 = new products();
        obj3.P_id=345;
        obj3.P_name="Laptop";
        obj3.P_category="Digital";
        obj3.P_weight=3600;
        obj3.P_height=5500;
        obj3.P_DateInsert=DateTime.Parse("2015/9/22");
        obj3.P_price=20000;
        obj3.P_available=true;
        ListProducts.Add(obj3);

        products obj4 = new products();
        obj4.P_id=456;
        obj4.P_name="AI_Book";
        obj4.P_category="Book";
        obj4.P_weight=15;
        obj4.P_height=30;
        obj4.P_DateInsert=DateTime.Parse("2021/10/20");
        obj4.P_price=250;
        obj4.P_available=false;
        ListProducts.Add(obj4);

        var query = ListProducts.ToList();

        int sum = 0; 
        foreach (var item in query){
            if(item.P_available==true)
                sum += item.P_price;
        }
        ViewBag.ret=sum;

        return View(query);
    }












    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
