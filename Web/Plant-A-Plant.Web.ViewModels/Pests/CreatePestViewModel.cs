﻿using System.Collections.Generic;
using Plant_A_Plant.Data.Models;
using Plant_A_Plant.Data.Models.Enums;
using Plant_A_Plant.Services.Mapping;

namespace Plant_A_Plant.Web.ViewModels.Pests
{
    public class CreatePestViewModel : IMapFrom<Pest>
    {
        public string Name { get; set; }

        public string SuperFamily { get; set; }

        public string ShortDescription { get; set; }

        public PestTypes Type { get; set; }

        public string PestImgUrl { get; set; }

        public IEnumerable<PestsPlants> PestsPlants => new List<PestsPlants>();
    }
}
