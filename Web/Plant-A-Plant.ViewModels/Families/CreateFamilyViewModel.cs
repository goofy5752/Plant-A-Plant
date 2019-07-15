namespace Plant_A_Plant.ViewModels.Families
{
    using Data.Models;
    using Services.Mapping;

    public class CreateFamilyViewModel : IMapFrom<Family>
    {
        public string Description { get; set; }
    }
}