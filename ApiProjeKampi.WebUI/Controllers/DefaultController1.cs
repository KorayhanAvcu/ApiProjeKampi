using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUI.Controllers
{
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
