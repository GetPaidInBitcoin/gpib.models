using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GPIB.Models
{
    public class Deposit : BaseUserEntity, IUserEntity
    {
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public DateTime Created { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Reference { get; set; }

        public Decimal? Fee { get; set; }
        public DateTime BankTransactionDate { get; set; }
    }
}