using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public class DepositHint : BaseUserEntity, IUserEntity
    {
        [Required]
        public String EmployerName { get; set; }

        public String DepositReference { get; set; }

        public String BankStatement { get; set; }

        [Required]
        public Decimal DepositAmount { get; set; }

        public String PayDay { get; set; }
    }
}