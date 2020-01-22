using System;
using System.ComponentModel.DataAnnotations;

namespace GPIB.Models
{
    public class Address : BaseUserEntity, IUserEntity
    {
        [Required]
        public short Percent { get; set; }

        public String Label { get; set; }

        [Required]
        public Boolean Deleted { get; set; }

        public String Address1 { get; set; }

        public String Coin { get; set; }
    }
}