using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GPIB.Models
{
    public class Settings :  BaseUserEntity, IUserEntity
    {
        public Boolean Require2FAOnLogin { get; set; }

        public Boolean SendPGPEmails { get; set; }

        public Boolean SendEmailOnDeposit { get; set; }

        public Boolean SendEmailOnTransfer { get; set; }

        public Boolean RequireEmailVerificationOnAddressChange { get; set; }
    }
}