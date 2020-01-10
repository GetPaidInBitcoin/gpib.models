using System;

namespace GPIB.Models
{
    public class RapidIDVerificationNotification
    {
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public string PEPStatus { get; set; }
        public string SMSStatus { get; set; }
    }
}