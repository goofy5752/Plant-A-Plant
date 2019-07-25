using System;
using System.Collections.Generic;
using Plant_A_Plant.Data.Common.Models;

namespace Plant_A_Plant.Data.Models
{
    public class Family : BaseModel<Guid>
    {
        public Family()
        {
            this.CreatedOn = DateTime.UtcNow;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<Plant> Plants => new HashSet<Plant>();
    }
}