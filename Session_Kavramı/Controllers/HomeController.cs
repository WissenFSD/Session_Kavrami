using Microsoft.AspNetCore.Mvc;
using Session_Kavramı.Models;
using System.Diagnostics;
using Microsoft.AspNetCore;

namespace Session_Kavramı.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
     
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            // Session tanımlaması : Session verilerimizi bir süre boyunca RAM'de saklayabildiğimiz bir ortamdır.
            // Session'a değer attık. Session'a değer atarken hem değeri hemde attığımız değerin adını yazmamız gerekmektedir.
            // Çünkü session bir sürü değer alabilir.Istenildiğinde  bu değeri size geri verebilmesi için attığınız değerin adını yazmanız lazım

            // Redis in memory veri tutan bir üründür. Profesyonel ortamda session'lar için REdis kullanılır.


            // Ödev : MVC'e redis'i entegre edip, session'ları redis'te tutmanız
            HttpContext.Session.SetInt32("MyInt", 10);


            //Sessiondan değeri silmek için Remove metodunu kullanabilirsiniz.
            //HttpContext.Session.Remove()



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}