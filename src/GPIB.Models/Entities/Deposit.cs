using System;

namespace GPIB.Models
{
    public class Deposit
    {
        public DateTime Created { get; set; }

        public decimal Amount { get; set; }

        public string Reference { get; set; }

        public Decimal? Fee { get; set; }
    }
}
