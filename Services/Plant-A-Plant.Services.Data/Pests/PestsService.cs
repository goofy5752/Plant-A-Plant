using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plant_A_Plant.Data.Common.Repositories;
using Plant_A_Plant.Data.Models;
using Plant_A_Plant.Services.Data.Pests.Contracts;
using Plant_A_Plant.Services.Mapping;
using Plant_A_Plant.Web.ViewModels.Pests;

namespace Plant_A_Plant.Services.Data.Pests
{
    public class PestsService : IPestsService
    {
        private readonly IRepository<Pest> _pestRepository;

        public PestsService(IRepository<Pest> pestRepository)
        {
            _pestRepository = pestRepository;
        }

        public async Task<Guid> CreatePest(CreatePestViewModel model)
        {
            var pest = new Pest()
            {
                Name = model.Name,
                CreatedOn = DateTime.UtcNow,
                PestImgUrl = model.PestImgUrl,
                ShortDescription = model.ShortDescription,
                SuperFamily = model.SuperFamily,
                Type = model.Type
            };

            await this._pestRepository.AddAsync(pest);

            await this._pestRepository.SaveChangesAsync();

            return pest.Id;
        }

        public IEnumerable<TViewModel> GetAllPests<TViewModel>()
        {
            var allPest = this._pestRepository
                .All()
                .To<TViewModel>()
                .ToList();

            return allPest;
        }

        public PestDetailsViewModel GetById(Guid id)
        {
            var pestId = this._pestRepository
                .All()
                .To<PestDetailsViewModel>()
                .Single(x => x.Id == id);

            return pestId;
        }
    }
}
