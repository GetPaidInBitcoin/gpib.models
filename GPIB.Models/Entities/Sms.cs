using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GPIB.Models
{
    public class Sms : BaseUserEntity, IUserEntity
    {
        [Required]
        public String Message { get; set; }

        public DateTime Sent { get; set; }

        [Required]
        public DateTime Expires { get; set; }
    }
}