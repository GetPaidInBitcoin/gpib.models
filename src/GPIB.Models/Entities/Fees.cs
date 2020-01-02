using System;

namespace GPIB.Models
{
    public class Fees : BaseEntity
    {
        public decimal Amount { get; set; }

        public decimal Rate { get; set; }

        public string Tx { get; set; }

        public string Address { get; set; }

        public string Coin { get; set; }

        public DateTime Created { get; set; }
    }
}