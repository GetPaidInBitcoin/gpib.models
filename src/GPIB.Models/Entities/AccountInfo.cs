using System;
using System.ComponentModel.DataAnnotations;

namespace GPIB.Models
{
    public class AccountInfo : BaseUserEntity, IUserEntity
    {
        [Required]
        public Decimal Fees { get; set; }

        public String FirstName { get; set; }

        public String MiddleName { get; set; }

        public String LastName { get; set; }

        public DateTime SignUpDate { get; set; }

        [Required]
        public Int16 RandomCent { get; set; }

        [Required]
        public Byte IdVerificationStatus { get; set; }

        public String IdVerificationUrl { get; set; }

        public String TwoFactorSecret { get; set; }

        public Int32? YOB { get; set; }

        [Required]
        public Int32 bankID { get; set; }
    }
}