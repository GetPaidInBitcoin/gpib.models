using System;

namespace GPIB.Models
{
    public class DepositHint : BaseUserEntity, IDepositHint
    {
        public String EmployerName { get; set; }

        public String DepositReference { get; set; }

        public String BankStatement { get; set; }

        public Decimal DepositAmount { get; set; }

        //public PayCycle Cadence { get; set; }

        public String PayDay { get; set; }
    }
}