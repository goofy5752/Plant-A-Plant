using System.Collections.Generic;

namespace Plant_A_Plant.ViewModels.Plants
{
    using System;
    using Data.Models;
    using Services.Mapping;

    public class CreatePlantViewModel : IMapFrom<Plant>
    {
        public CreatePlantViewModel()
        {
            this.Family = new List<Family>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public TimeSpan EstimatedTimeForGrowing { get; set; }

        public IEnumerable<Family> Family { get; set; }
    }
}
