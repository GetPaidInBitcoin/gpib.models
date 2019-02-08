using System;

namespace GPIB.Repository
{
    public class Promotion : BaseEntity
    {
        public String Name { get; set; }

        public String Code { get; set; }

        public Decimal FixedDiscount { get; set; }

        public Decimal DiscountPercent { get; set; }

        public Int32 MaxUseage { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime Experation { get; set; }
    }
}
