using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Plant_A_Plant.Services.Data.Families.Contracts;
using Plant_A_Plant.ViewModels.Families;

namespace Plant_A_Plant.Controllers
{
    public class FamilyController : Controller
    {
        private readonly IFamiliesService _familiesService;

        public FamilyController(IFamiliesService familiesService)
        {
            _familiesService = familiesService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var familyViewModel = new CreateFamilyViewModel();

            return this.View(familyViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFamilyViewModel viewModel)
        {
            var id = await this._familiesService.CreateFamily(viewModel);

            return this.RedirectToAction("Details", new {id = id});
        }

        public IActionResult Details(Guid id)
        {
            var plantDetail = this._familiesService.GetById(id);

            return this.View(plantDetail);
        }

        public IActionResult FamilyDetails()
        {
            var familyDetails = this._familiesService.GetAllFamilies<FamilyDetailsViewModel>().ToList();

            return this.View(familyDetails);
        }
    }
}