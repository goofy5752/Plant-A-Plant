namespace Plant_A_Plant.Services.Data.Plants
{
    using System;
    using System.Threading.Tasks;
    using System.Linq;
    using System.Collections.Generic;

    using Contracts;
    using Plant_A_Plant.Data.Common.Repositories;
    using Plant_A_Plant.Data.Models;
    using Plant_A_Plant.Web.ViewModels.Plants;
    using Mapping;

    public class PlantsService : IPlantsService
    {
        private readonly IRepository<Plant> _plantRepository;

        public PlantsService(IRepository<Plant> plantRepository)
        {
            _plantRepository = plantRepository;
        }

        public IEnumerable<TViewModel> GetAllPlants<TViewModel>()
        {
            var allPlants = _plantRepository
                .All()
                .To<TViewModel>()
                .ToList();

            return allPlants;
        }

        public async Task<Guid> CreatePlant(CreatePlantViewModel model)
        {
            var plant = new Plant()
            {
                Name = model.Name,
                Description = model.Description,
                EstimatedTimeForGrowing = model.EstimatedTimeForGrowing,
            };

            await this._plantRepository.AddAsync(plant);

            await this._plantRepository.SaveChangesAsync();

            return plant.Id;
        }

        public PlantDetailsViewModel GetById(Guid id)
        {
            var vm = this._plantRepository
                .All()
                .To<PlantDetailsViewModel>()
                .Single(x => x.Id == id);

            //var categories = this._moviesCategoriesService.MovieCategories(id);

            //vm.Categories = categories;
            //vm.Actors = this._moviesActorsService.Actors(vm.Id);
            return vm;
        }
    }
}