using Microsoft.AspNetCore.Mvc;

namespace Session_Kavramı.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {

            int deger = (int)HttpContext.Session.GetInt32("MyInt");
            return View();
        }
    }
}
