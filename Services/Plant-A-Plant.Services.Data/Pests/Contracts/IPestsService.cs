using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plant_A_Plant.Web.ViewModels.Pests;
using Plant_A_Plant.Web.ViewModels.Plants;

namespace Plant_A_Plant.Services.Data.Pests.Contracts
{
    public interface IPestsService
    {
        IEnumerable<TViewModel> GetAllPests<TViewModel>();

        Task<Guid> CreatePest(CreatePestViewModel viewModel);

        PestDetailsViewModel GetById(Guid id);
    }
}
