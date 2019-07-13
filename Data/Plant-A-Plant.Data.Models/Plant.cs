using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Plant_A_Plant.Data.Common.Models;

namespace Plant_A_Plant.Data.Models
{
    public class Plant : BaseModel<Guid>
    {
        public Plant()
        {
            this.PlantsPests = new HashSet<PestsPlants>();
        }

        [Required]
        [MinLength(3), MaxLength(40)]
        public string Name { get; set; }

        public string Description { get; set; }

        public TimeSpan EstimatedTimeForGrowing { get; set; }

        public Guid FamilyId { get; set; }
        public virtual Family Family { get; set; }

        public virtual IEnumerable<PestsPlants> PlantsPests { get; set; }
    }
}
