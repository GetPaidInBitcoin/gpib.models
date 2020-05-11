using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public class Referrals : BaseUserEntity, IUserEntity
    {
        public Guid FriendUserID { get; set; }

        [Required]
        public decimal FixedAmount { get; set; }

        [Required]
        public decimal PercentageAmount { get; set; }

        [Required]
        public decimal Rate { get; set; }

        [Required]
        public int DepositID { get; set; }

        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public DateTime Created { get; set; }
    }
}