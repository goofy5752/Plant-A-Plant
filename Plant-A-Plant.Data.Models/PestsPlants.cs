using System;

namespace Plant_A_Plant.Data.Models
{
    public class PestsPlants
    {
        public string Id { get; set; }

        public Guid PestId { get; set; }
        public Pest Pest { get; set; }

        public Guid PlantId { get; set; }
        public Plant Plant { get; set; }
    }
}
