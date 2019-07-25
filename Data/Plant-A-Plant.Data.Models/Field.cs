using System;
using System.Collections.Generic;
using Plant_A_Plant.Data.Common.Models;
using Plant_A_Plant.Data.Models.Enums;

namespace Plant_A_Plant.Data.Models
{
    public class Field : BaseModel<Guid>
    {
        public Guid EventId { get; set; }
        public virtual Event Event { get; set; }

        public string Location { get; set; }

        public SoilType Soil { get; set; }

        public virtual IEnumerable<RegisterActivity> Activities => new HashSet<RegisterActivity>();

        public virtual IEnumerable<Plant> Plants => new HashSet<Plant>();
    }
}