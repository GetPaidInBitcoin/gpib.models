using System;

namespace GPIB.Models
{
    public class RapidIDClientInfo : BaseUserEntity
    {
        public Int32 AllowedAttempts { get; set; }

        public Int32 TotalAttempts { get; set; }

        public RapidIDPEPStatus PEPStatus { get; set; }

        public RapidIDSMSStatus SMSStatus { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        //public ICollection<RapidID> RapidIDs { get; set; }
    }
}
