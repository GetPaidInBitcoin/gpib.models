using System;

namespace GPIB.Models
{
    public class Sms : BaseUserEntity, ISms
    {
        public String Message { get; set; }

        public DateTime Sent { get; set; }

        public DateTime Expires { get; set; }
    }
}