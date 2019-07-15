using Plant_A_Plant.Data.Models;
using Plant_A_Plant.Services.Mapping;

namespace Plant_A_Plant.Web.ViewModels.Plants
{
    public class PlantViewModel : IMapFrom<Plant>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
