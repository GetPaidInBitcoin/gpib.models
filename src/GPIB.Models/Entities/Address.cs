using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public class Address : BaseUserEntity, IUserEntity
    {
        [Required]
        public short Percent { get; set; }

        public String Label { get; set; }

        [Required]
        public Boolean Deleted { get; set; }

        [Column("Address")]
        public String Address1 { get; set; }

        public String Coin { get; set; }
    }
}