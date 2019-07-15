using System;
using Plant_A_Plant.Data.Models;
using Plant_A_Plant.Services.Mapping;

namespace Plant_A_Plant.Web.ViewModels.Plants
{
    public class PlantDetailsViewModel : IMapFrom<Plant>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public TimeSpan EstimatedTimeForGrowing { get; set; }
    }
}