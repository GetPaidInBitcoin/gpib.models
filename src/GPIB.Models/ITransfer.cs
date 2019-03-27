using System;

namespace GPIB.Models
{
    public interface ITransfer : IUserEntity
    {   
        decimal Amount { get; set; }
        
        Int32 AddressID { get; set; }
        
        String Tx { get; set; }
        
        DateTime Created { get; set; }
        
        Decimal Rate { get; set; }
    }
}