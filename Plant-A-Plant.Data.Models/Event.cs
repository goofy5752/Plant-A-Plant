namespace Plant_A_Plant.Data.Models
{
    using Plant_A_Plant.Data.Common.Models;
    using System;
    using System.Collections.Generic;

    public class Event : BaseModel<Guid>
    {
        public Event()
        {
            this.CreatedOn = DateTime.UtcNow;
            this.Plants = new HashSet<Plant>();
        }

        public Guid FieldId { get; set; }
        public virtual Field Field { get; set; }

        public virtual IEnumerable<Plant> Plants { get; set; }
    }
}
