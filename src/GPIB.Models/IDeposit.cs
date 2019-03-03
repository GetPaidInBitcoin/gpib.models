using System;

namespace GPIB.Models
{
    public interface IDeposit
    {
        int ID { get; set; }

        Guid UserID { get; set; }
        
        DateTime Created { get; set; }
        
        decimal Amount { get; set; }
        
        string Reference { get; set; }
        
        Decimal? Fee { get; set; }
    }
}