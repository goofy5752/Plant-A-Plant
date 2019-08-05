using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plant_A_Plant.Data.Common.Repositories;
using Plant_A_Plant.Data.Models;

namespace Plant_A_Plant.Web.Views.ViewComponents
{
    public class FeedbackInfoViewComponent : ViewComponent
    {
        private readonly IRepository<FeedbackInfo> _feedbackRepository;

        public FeedbackInfoViewComponent(IRepository<FeedbackInfo> feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _feedbackRepository.All().OrderByDescending(x => x.SendOn).ToListAsync());
        }
    }
}