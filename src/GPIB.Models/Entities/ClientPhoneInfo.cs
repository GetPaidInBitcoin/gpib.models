
using System;

namespace GPIB.Models
{
    public class ClientPhoneInfo : BaseUserEntity, IEntity, IUserEntity
    {

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public PhoneStatus Status { get; set; }

        public string Code { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}