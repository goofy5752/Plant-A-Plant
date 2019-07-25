using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Plant_A_Plant.Services.Data.Contacts.Contracts;
using Plant_A_Plant.Web.ViewModels;
using Plant_A_Plant.Web.ViewModels.Contacts;

namespace Plant_A_Plant.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactService _contactService;

        public HomeController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Service()
        {
            return this.View();
        }

        public IActionResult Contact()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            this._contactService.RegisterFeedBack(model.FullName, model.Message, model.SenderEmail, model.SenderPhoneNumber);

            return this.View();
        }

        public IActionResult About()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
