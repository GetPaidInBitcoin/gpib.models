using System;

namespace GPIB.Models
{
    public class ApplicationUser
    {
        public Guid Id { get; set; }
        
        public String Email { get; set; }
        
        public Boolean EmailConfirmed { get; set; }
        
        public String PasswordHash { get; set; }
    }
}