using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Plant_A_Plant.Services.Data.Pests.Contracts;
using Plant_A_Plant.Web.ViewModels.Pests;

namespace Plant_A_Plant.Web.Controllers
{
    public class PestController : Controller
    {
        private readonly IPestsService _pestsService;

        public PestController(IPestsService pestsService)
        {
            _pestsService = pestsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var familyViewModel = new CreatePestViewModel();

            return this.View(familyViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePestViewModel viewModel)
        {
            var id = await this._pestsService.CreatePest(viewModel);

            return this.RedirectToAction("Details", new { id = id });
        }

        public IActionResult Details(Guid id)
        {
            var pestDetailsViewModel = this._pestsService.GetById(id);

            return this.View(pestDetailsViewModel);
        }

        public IActionResult PestDetails()
        {
            var pestDetails = this._pestsService.GetAllPests<PestDetailsViewModel>().ToList();

            return this.View(pestDetails);
        }
    }
}