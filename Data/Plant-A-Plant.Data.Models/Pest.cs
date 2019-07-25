using System;
using System.Collections.Generic;
using Plant_A_Plant.Data.Common.Models;

namespace Plant_A_Plant.Data.Models
{
    public class Pest : BaseModel<Guid>
    {
        public string Name { get; set; }

        public string SuperFamily { get; set; }

        public string ShortDescription { get; set; }

        public virtual IEnumerable<PestsPlants> PestsPlants => new HashSet<PestsPlants>();
    }
}
