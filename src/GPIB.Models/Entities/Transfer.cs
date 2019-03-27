using System;

namespace GPIB.Models
{
    public class Transfer : BaseEntity, ITransfer
    {
        public decimal Amount { get; set; }

        public Int32 AddressID { get; set; }

        public String Tx { get; set; }

        public DateTime Created { get; set; }

        public Decimal Rate { get; set; }
    }
}
