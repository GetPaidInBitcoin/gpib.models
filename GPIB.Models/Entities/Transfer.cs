using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public class Transfer : BaseUserEntity, IUserEntity
    {
        [Required]
        public decimal Amount { get; set; }

        public String Tx { get; set; }

        public DateTime Created { get; set; }

        [Required]
        public Decimal Rate { get; set; }

        public String Address { get; set; }

        [Required]
        public String Type { get; set; }

        public String Coin { get; set; }

        [Required]
        public Int32 DepositID { get; set; }
    }
}