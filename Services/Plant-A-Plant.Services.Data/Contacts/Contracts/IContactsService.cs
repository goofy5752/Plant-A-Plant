using System.Collections.Generic;
using Plant_A_Plant.Data.Models;

namespace Plant_A_Plant.Services.Data.Contacts.Contracts
{
    public interface IContactService
    {
        void RegisterFeedBack(string fullName, string message, string email, string phone);

        IEnumerable<FeedbackInfo> AllFeedback();
    }
}