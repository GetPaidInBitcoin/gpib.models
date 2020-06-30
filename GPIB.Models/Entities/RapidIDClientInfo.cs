using System;
using System.ComponentModel.DataAnnotations;

namespace GPIB.Models
{
    public class RapidIDClientInfo : BaseUserEntity, IUserEntity
    {
        [Required]
        public Int32 AllowedAttempts { get; set; }

        [Required]
        public Int32 TotalAttempts { get; set; }

        [Required]
        public RapidIDPEPStatus PEPStatus { get; set; }

        [Required]
        public RapidIDSMSStatus SMSStatus { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime ModifiedOn { get; set; }
    }
}