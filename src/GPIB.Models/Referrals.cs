using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public class Referrals
    {
        [Key]
        [Required]
        int ID { get; set; }

        [Required]
        Guid UserID { get; set; }

        [Required]
        decimal Amount { get; set; }

        [Required]
        String Coin { get; set; }

        [Required]
        decimal Rate { get; set; }

        [Required]
        int DepositId { get; set; }

        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        DateTime Created { get; set; }

    }
}