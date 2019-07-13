namespace Plant_A_Plant.ViewModels.Plants
{
    using Data.Models;
    using Services.Mapping;

    public class PlantViewModel : IMapFrom<Plant>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
