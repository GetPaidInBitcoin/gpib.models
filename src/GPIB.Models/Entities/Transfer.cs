using System;

namespace GPIB.Models
{
    public class Transfer : BaseUserEntity, IEntity, ITransfer
    {
        public decimal Amount { get; set; }

        public String Tx { get; set; }

        public DateTime Created { get; set; }

        public Decimal Rate { get; set; }

        public String Address { get; set; }
        
        public String Type { get; set; }
        
        public String Coin { get; set; }
        
        public Int32 DepositID { get; set; }
    }
}
