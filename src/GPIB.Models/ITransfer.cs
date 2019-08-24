using System;

namespace GPIB.Models
{
    public interface ITransfer : IUserEntity
    {   
        decimal Amount { get; set; }
        
        String Tx { get; set; }
        
        DateTime Created { get; set; }
        
        Decimal Rate { get; set; }

        String Address { get; set; }
    }
}