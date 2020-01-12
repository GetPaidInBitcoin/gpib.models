using System;

namespace GPIB.Models
{
    public class AccountInfo : BaseUserEntity
    {
        public Decimal Fees { get; set; }

        public String FirstName { get; set; }

        public String MiddleName { get; set; }

        public String LastName { get; set; }
        
        public DateTime SignUpDate { get; set; }

        public Int16 RandomCent { get; set; }

        public Byte IdVerificationStatus { get; set; }

        public String IdVerificationUrl { get; set; }

        public String TwoFactorSecret { get; set; }

        public Int32 YOB { get; set; }

        public Int32 BankId { get; set; }
    }
}
