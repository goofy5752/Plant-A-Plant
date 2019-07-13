using System;
using System.ComponentModel.DataAnnotations;
using Plant_A_Plant.Data.Common.Models;

namespace Plant_A_Plant.Data.Models
{
    public class RegisterActivity : BaseModel<Guid>
    {
        public RegisterActivity()
        {
            this.CreatedOn = DateTime.UtcNow;
        }

        public string Description { get; set; }

        public DateTime RegisteredOn { get; set; }

        [Required]
        public Guid FieldId { get; set; }
        public Field Field { get; set; }
    }
}