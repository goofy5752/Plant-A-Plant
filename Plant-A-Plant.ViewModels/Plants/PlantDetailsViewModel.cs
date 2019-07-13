namespace Plant_A_Plant.ViewModels.Plants
{
    using System;
    using Data.Models;
    using Services.Mapping;

    public class PlantDetailsViewModel : IMapFrom<Plant>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public TimeSpan EstimatedTimeForGrowing { get; set; }
    }
}