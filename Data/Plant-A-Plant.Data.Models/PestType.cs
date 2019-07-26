using System;
using Plant_A_Plant.Data.Models.Enums;

namespace Plant_A_Plant.Data.Models
{
    public class PestType
    {
        public Guid Id { get; set; }

        public PestTypes Type { get; set; }
    }
}