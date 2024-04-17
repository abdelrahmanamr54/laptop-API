using Microsoft.AspNetCore.Identity;

namespace Api_Laptop_Task.Model
{
    public class ApplicationUser : IdentityUser
    {

        public int Id { get; set; }
        public string Address { get; set; }

    }
}
