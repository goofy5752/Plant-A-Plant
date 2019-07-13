namespace Plant_A_Plant.Services.Data.Families
{
    using System.Linq;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Plant_A_Plant.ViewModels.Families;
    using Plant_A_Plant.Data.Models;
    using Plant_A_Plant.Data.Common.Repositories;
    using Mapping;
    using Contracts;

    public class FamiliesService : IFamiliesService
    {
        private readonly IRepository<Family> _familyRepository;

        public FamiliesService(IRepository<Family> familyRepository)
        {
            _familyRepository = familyRepository;
        }

        public async Task<Guid> CreateFamily(CreateFamilyViewModel model)
        {
            var family = new Family()
            {
                Description = model.Description
            };

            await this._familyRepository.AddAsync(family);

            await this._familyRepository.SaveChangesAsync();

            return family.Id;
        }

        public IEnumerable<TViewModel> GetAllFamilies<TViewModel>()
        {
            var allFamilies = this._familyRepository
                .All()
                .To<TViewModel>()
                .ToList();

            return allFamilies;
        }

        public FamilyDetailsViewModel GetById(Guid id)
        {
            var familyId = this._familyRepository
                .All()
                .To<FamilyDetailsViewModel>()
                .Single(x => x.Id == id);

            return familyId;
        }
    }
}
