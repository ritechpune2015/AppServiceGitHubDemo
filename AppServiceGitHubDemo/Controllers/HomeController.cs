using Microsoft.AspNetCore.Mvc;

namespace AppServiceGitHubDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
