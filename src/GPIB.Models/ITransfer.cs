using System;

namespace GPIB.Models
{
    public interface ITransfer : IUserEntity
    {   
        String Coin { get; set; }
        
        decimal Amount { get; set; }
        
        String Address { get; set; }
        
        String Tx { get; set; }
        
        DateTime Created { get; set; }
        
        Decimal Rate { get; set; }
    }
}