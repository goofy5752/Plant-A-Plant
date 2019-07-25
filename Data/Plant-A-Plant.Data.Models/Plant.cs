using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Plant_A_Plant.Data.Common.Models;

namespace Plant_A_Plant.Data.Models
{
    public class Plant : BaseModel<Guid>
    {
        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public TimeSpan EstimatedTimeForGrowing { get; set; }

        public Guid FamilyId { get; set; }
        public virtual Family Family { get; set; }

        public virtual IEnumerable<PestsPlants> PlantsPests => new HashSet<PestsPlants>();
    }
}
