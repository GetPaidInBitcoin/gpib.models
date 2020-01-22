using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public interface ISms : IUserEntity
    {
        [Required]
        DateTime Expires { get; set; }

        [Required]
        string Message { get; set; }

        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        DateTime Sent { get; set; }
    }
}