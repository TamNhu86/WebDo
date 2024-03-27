using Microsoft.AspNetCore.Identity;

namespace WebDo.Models
{
    public class ApplicationUser: IdentityUser
    {
        public String FullName {  get; set; }   
    }
}
