using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public class Referrals : BaseUserEntity, IUserEntity
    {
        public Guid friendUserID { get; set; }

        [Required]
        public int depositID { get; set; }

        [Required]
        public decimal FixedAmount { get; set; }

        [Required]
        public decimal PercentageAmount { get; set; }

        [Required]
        public string Coin { get; set; }

        [Required]
        public decimal Rate { get; set; }

        [Required]
        public bool Enabled { get; set; }

        public DateTime Created { get; set; }

        public DateTime Expires { get; set; }
    }
}