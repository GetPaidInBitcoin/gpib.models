using System;
using System.ComponentModel.DataAnnotations;

namespace GPIB.Models
{
    public class ApplicationUser
    {
        [Required]
        public String Id { get; set; }
        public String Email { get; set; }

        [Required]
        public Boolean EmailConfirmed { get; set; }

        public String PasswordHash { get; set; }

        public String PhoneNumber { get; set; }

        public Boolean PhoneNumberConfirmed { get; set; }
    }
}