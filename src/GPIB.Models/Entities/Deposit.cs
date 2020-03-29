using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GPIB.Models
{
    public class Deposit : BaseUserEntity, IUserEntity
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
