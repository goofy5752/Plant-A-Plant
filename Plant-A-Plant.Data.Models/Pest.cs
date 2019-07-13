using System;
using System.Collections.Generic;
using Plant_A_Plant.Data.Common.Models;

namespace Plant_A_Plant.Data.Models
{
    public class Pest : BaseModel<Guid>
    {
        public Pest()
        {
            this.PestsPlants = new HashSet<PestsPlants>();
        }

        public Guid PestTypeId { get; set; }
        public virtual PestType Type { get; set; }

        public virtual IEnumerable<PestsPlants> PestsPlants { get; set; }
    }
}
