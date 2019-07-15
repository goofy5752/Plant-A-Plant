using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Plant_A_Plant.Services.Data.Plants.Contracts;
using Plant_A_Plant.Web.ViewModels.Plants;

namespace Plant_A_Plant.Web.Controllers
{
    public class PlantController : Controller
    {
        private readonly IPlantsService _service;

        public PlantController(IPlantsService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var plants = _service.GetAllPlants<PlantViewModel>();

            return View(plants);
        }

        public IActionResult Create()
        {
            var plantViewModel = new CreatePlantViewModel();

            return this.View(plantViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePlantViewModel model)
        {
            var id = await this._service.CreatePlant(model);

            return this.RedirectToAction("Details", new {id = id});
        }

        public IActionResult Details(Guid id)
        {
            var plantDetail = this._service.GetById(id);

            return this.View(plantDetail);
        }
    }
}