using System;
using Plant_A_Plant.Data.Models;
using Plant_A_Plant.Services.Mapping;

namespace Plant_A_Plant.Web.ViewModels.Families
{
    public class FamilyDetailsViewModel : IMapFrom<Family>
    {
        public Guid Id { get; set; }

        public string Description { get; set; }
    }
}
