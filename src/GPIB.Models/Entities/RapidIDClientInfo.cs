using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public class RapidIDClientInfo : BaseUserEntity
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
        //[Required]
        //public ICollection<RapidID> RapidIDs { get; set; }
    }
}