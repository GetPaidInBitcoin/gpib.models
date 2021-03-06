using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public class Fees : BaseEntity, IEntity
    {
        [Required]
        public decimal Amount { get; set; }

        public decimal Rate { get; set; }

        [Required]
        public string Tx { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Coin { get; set; }

        public DateTime Created { get; set; }
    }
}