using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public interface ITransfer : IUserEntity
    {
        [Required]
        decimal Amount { get; set; }
        String Tx { get; set; }

        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        DateTime Created { get; set; }

        [Required]
        Decimal Rate { get; set; }

        String Coin { get; set; }

        String Address { get; set; }

        [Required]
        Int32 DepositID { get; set; }

        [Required]
        String Type { get; set; }
    }
}