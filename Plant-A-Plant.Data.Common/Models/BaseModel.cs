using System.ComponentModel.DataAnnotations;

namespace Plant_A_Plant.Data.Common.Models
{
    using System;

    public abstract class BaseModel<TKey> : IDeletableEntity, IAuditInfo
    {
        [Key]
        public TKey Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}