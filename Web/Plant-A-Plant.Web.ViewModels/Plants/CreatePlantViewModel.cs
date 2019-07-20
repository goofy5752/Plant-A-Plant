using System;
using System.Collections.Generic;
using Plant_A_Plant.Data.Models;
using Plant_A_Plant.Services.Mapping;

namespace Plant_A_Plant.Web.ViewModels.Plants
{
    public class CreatePlantViewModel : IMapFrom<Plant>
    {
        public CreatePlantViewModel()
        {
            this.Family = new List<Family>();
        }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public TimeSpan EstimatedTimeForGrowing { get; set; }

        public IEnumerable<Family> Family { get; set; }
    }
}
