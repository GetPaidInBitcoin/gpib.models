using System;

namespace GPIB.Models
{
    public interface IDepositHint
    {
        String EmployerName { get; set; }
        String DepositReference { get; set; }
        String BankStatement { get; set; }
        Decimal DepositAmount { get; set; }
        String PayDay { get; set; }
        int ID { get; set; }
        Guid UserID { get; set; }
    }
}