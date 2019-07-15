namespace Plant_A_Plant.ViewModels.Families
{
    using System;

    using Data.Models;
    using Services.Mapping;

    public class FamilyDetailsViewModel : IMapFrom<Family>
    {
        public Guid Id { get; set; }

        public string Description { get; set; }
    }
}
