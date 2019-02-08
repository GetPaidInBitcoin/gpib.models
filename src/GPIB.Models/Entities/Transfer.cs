using System;

namespace GPIB.Repository
{
    public class Transfer : BaseEntity
    {
        public String Coin { get; set; }
        
        public decimal Amount { get; set; }

        public String Address { get; set; }

        public String Tx { get; set; }

        public DateTime Created { get; set; }

        public Decimal Rate { get; set; }
    }
}
