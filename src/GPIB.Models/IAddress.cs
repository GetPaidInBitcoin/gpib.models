using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public interface IAddress : IUserEntity
    {
        String Coin { get; set; }

        [Required]
        short Percent { get; set; }

        String Label { get; set; }

        [Required]
        Boolean Deleted { get; set; }

        String Address1 { get; set; }
    }
}