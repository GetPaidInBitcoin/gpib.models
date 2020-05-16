using System;
using System.ComponentModel.DataAnnotations;

namespace GPIB.Models
{
    public class ApplicationUser
    {
        [Required]
        public String ID { get; set; }

        public String Email { get; set; }

        [Required]
        public Boolean EmailConfirmed { get; set; }

        public String PasswordHash { get; set; }

        public String SecurityStamp { get; set; }

        public String PhoneNumber { get; set; }

        public Boolean PhoneNumberConfirmed { get; set; }

        public DateTime LockoutEndDateUtc { get; set; }

        public Boolean LockoutEnabled { get; set; }

        public Int32 AccessFailedCount { get; set; }

        public String UserName { get; set; }
    }
}