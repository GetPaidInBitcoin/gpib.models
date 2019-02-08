using System;

namespace GPIB.Repository
{
    public class Deposit
    {
        public DateTime Created { get; set; }

        public decimal Amount { get; set; }

        public string Reference { get; set; }

        public Decimal? Fee { get; set; }
    }
}
