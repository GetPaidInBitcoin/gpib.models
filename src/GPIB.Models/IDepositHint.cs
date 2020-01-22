using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GPIB.Models
{
    public interface IDepositHint : IUserEntity
    {
        [Required]
        String EmployerName { get; set; }
        String DepositReference { get; set; }
        String BankStatement { get; set; }

        [Required]
        Decimal DepositAmount { get; set; }

        [Required]
        String PayDay { get; set; }
    }
}