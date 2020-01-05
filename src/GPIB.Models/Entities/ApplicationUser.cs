using System;

namespace GPIB.Models
{
    public class ApplicationUser : IUser
    {
        public String Id { get; set; }
        
        public String Email { get; set; }
        
        public Boolean EmailConfirmed { get; set; }
        
        public String PasswordHash { get; set; }
    }
}