using Microsoft.AspNetCore.Mvc;

namespace Plant_A_Plant.Web.Controllers
{
    public class FeedbackInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}