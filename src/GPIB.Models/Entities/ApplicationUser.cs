using System;

namespace GPIB.Models
{
    public class ApplicationUser : IUser
    {
        public String ID { get; set; }
        
        public String Email { get; set; }
        
        public Boolean EmailConfirmed { get; set; }
        
        public String PasswordHash { get; set; }
        
        public Boolean AccountLocked { get; set; }
    }
}