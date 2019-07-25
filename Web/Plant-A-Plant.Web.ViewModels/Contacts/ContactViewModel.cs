using System.ComponentModel.DataAnnotations;

namespace Plant_A_Plant.Web.ViewModels.Contacts
{
    public class ContactViewModel
    {
        [Required]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Provide us with an e-mail so we can contact back to you")]
        [EmailAddress]
        public string SenderEmail { get; set; }

        [Phone]
        public string SenderPhoneNumber { get; set; }

        [Required(ErrorMessage = "Spam?")]
        [StringLength(700, ErrorMessage = "I think we will understand you :)!")]
        public string Message { get; set; }
    }
}
