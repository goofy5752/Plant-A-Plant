namespace Plant_A_Plant.Services.Data.Families.Contracts
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using Plant_A_Plant.ViewModels.Families;

    public interface IFamiliesService
    {
        Task<Guid> CreateFamily(CreateFamilyViewModel model);

        IEnumerable<TViewModel> GetAllFamilies<TViewModel>();

        FamilyDetailsViewModel GetById(Guid id);
    }
}
