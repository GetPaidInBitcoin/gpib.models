using System;
using GPIB.Models;

namespace GPIB.Admin.WebAPI.Models
{
    public class Enterprise : BaseEntity
    {
        public Enterprise() { }

        public string Name { get; set; }

        public string ABN { get; set; }

        public string EmailDomain { get; set; }

        public string ContactEmail { get; set; }

        public string ContactPhoneNumber { get; set; }

        public string PayrollContact { get; set; }

        public string PayrollInformation { get; set; }

        public Int32 Status { get; set; }

    }
}