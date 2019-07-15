using Microsoft.AspNetCore.Identity;

namespace Plant_A_Plant.Data.Models
{
    public class PaPUser : IdentityUser
    {
        public override string UserName { get; set; }

        public override string Email { get; set; }
    }
}
