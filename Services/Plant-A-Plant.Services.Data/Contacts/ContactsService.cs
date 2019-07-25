using System;
using System.Collections.Generic;
using Plant_A_Plant.Data.Common.Repositories;
using Plant_A_Plant.Data.Models;
using Plant_A_Plant.Services.Data.Contacts.Contracts;

namespace Plant_A_Plant.Services.Data.Contacts
{
    public class ContactsService : IContactService
    {
        private readonly IRepository<FeedbackInfo> _feedbackRepository;

        public ContactsService(IRepository<FeedbackInfo> feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        public void RegisterFeedBack(string fullName, string message, string email, string phone)
        {
            var info = new FeedbackInfo()
            {
                FullName = fullName,
                Message = message,
                SenderEmail = email,
                SenderPhoneNumber = phone,
                SendOn = DateTime.UtcNow
            };

            this._feedbackRepository.AddAsync(info);
            this._feedbackRepository.SaveChangesAsync();
        }

        public IEnumerable<FeedbackInfo> AllFeedback()
        {
            return this._feedbackRepository.All();
        }
    }
}
