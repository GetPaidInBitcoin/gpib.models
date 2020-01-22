using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GPIB.Models
{
    public class Sms : BaseUserEntity, ISms
    {
        [Required]
        public String Message { get; set; }

        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public DateTime Sent { get; set; }

        [Required]
        public DateTime Expires { get; set; }
    }
}