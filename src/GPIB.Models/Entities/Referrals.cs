using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public class Referrals : IUserEntity
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        public Guid UserID { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public String Coin { get; set; }

        [Required]
        public decimal Rate { get; set; }

        [Required]
        public int DepositID { get; set; }

        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public DateTime Created { get; set; }
    }
}