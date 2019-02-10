using System;

namespace GPIB.Models
{
    public class Settings
    {
        public Boolean Require2FAOnLogin { get; set; }

        public Boolean SendPGPEmails { get; set; }

        public Boolean SendEmailOnDeposit { get; set; }

        public Boolean SendEmailOnTransfer { get; set; }

        public Boolean RequireEmailVerificationOnAddressChange { get; set; }
    }
}