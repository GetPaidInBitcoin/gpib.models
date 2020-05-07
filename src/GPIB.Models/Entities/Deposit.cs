using System;
using System.ComponentModel.DataAnnotations;

namespace GPIB.Models
{
    public class Deposit : BaseUserEntity
    {
        public DateTime Created { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Reference { get; set; }
        
        [Required]
        public Int32 BankID { get; set; }

        public Decimal? Fee { get; set; }

        public DateTime BankTransactionDate { get; set; }
    }
}
