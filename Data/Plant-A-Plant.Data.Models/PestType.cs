using System;
using System.Collections.Generic;
using Plant_A_Plant.Data.Common.Models;

namespace Plant_A_Plant.Data.Models
{
    public class PestType : BaseModel<Guid>
    {
        public PestType()
        {
            this.Pests = new HashSet<Pest>();
        }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public virtual IEnumerable<Pest> Pests { get; set; }
    }
}
