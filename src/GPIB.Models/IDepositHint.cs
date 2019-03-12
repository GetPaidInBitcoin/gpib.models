using System;

namespace GPIB.Models
{
    public interface IDepositHint : IUserEntity
    {
        String EmployerName { get; set; }
        String DepositReference { get; set; }
        String BankStatement { get; set; }
        Decimal DepositAmount { get; set; }
        String PayDay { get; set; }
    }
}