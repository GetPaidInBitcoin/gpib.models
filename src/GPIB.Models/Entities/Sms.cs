using System;

namespace GPIB.Models.Entities
{
    public class Sms : BaseUserEntity, IUserEntity, ISms
    {
        public String Message { get; set; }

        public DateTime Sent { get; set; }

        public DateTime Expires { get; set; }
    }
}
