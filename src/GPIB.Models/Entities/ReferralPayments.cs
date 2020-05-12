using System;
using System.ComponentModel.DataAnnotations;

namespace GPIB.Models
{
    public class ReferralPayments : BaseEntity, IEntity
    {
        [Required]
        public int DepositID { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Coin { get; set; }

        public DateTime Created { get; set; }

        public String Tx { get; set; }
    }
}