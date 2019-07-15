namespace Plant_A_Plant.Services.Data.Plants.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Plant_A_Plant.Web.ViewModels.Plants;

    public interface IPlantsService
    {
        IEnumerable<TViewModel> GetAllPlants<TViewModel>();

        Task<Guid> CreatePlant(CreatePlantViewModel viewModel);

        PlantDetailsViewModel GetById(Guid id);
    }
}
