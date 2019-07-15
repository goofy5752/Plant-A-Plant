using System;
using System.Collections.Generic;
using Plant_A_Plant.Data.Common.Models;
using Plant_A_Plant.Data.Models.Enums;

namespace Plant_A_Plant.Data.Models
{
    public class Field : BaseModel<Guid>
    {
        public Field()
        {
            this.Activities = new HashSet<RegisterActivity>();
            this.Plants = new HashSet<Plant>();
        }

        public Guid EventId { get; set; }
        public virtual Event Event { get; set; }

        public string Location { get; set; }

        public SoilType Soil { get; set; }

        public virtual IEnumerable<RegisterActivity> Activities { get; set; }

        public virtual IEnumerable<Plant> Plants { get; set; }
    }
}