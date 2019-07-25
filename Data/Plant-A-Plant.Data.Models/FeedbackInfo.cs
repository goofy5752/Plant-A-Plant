using System;

namespace Plant_A_Plant.Data.Models
{
    public class FeedbackInfo
    {
        public string Id { get; set; }

        public string FullName { get; set; }

        public string SenderEmail { get; set; }

        public string SenderPhoneNumber { get; set; }

        public string Message { get; set; }

        public DateTime SendOn { get; set; }
    }
}