using System;

namespace GPIB.Repository
{
    public class DepositHint : BaseUserEntity
    {
        public String EmployerName { get; set; }

        public String DepositReference { get; set; }

        public String BankStatement { get; set; }

        public Decimal DepositAmount { get; set; }

        //public PayCycle Cadence { get; set; }

        public String PayDay { get; set; }
    }
}
