using System;

namespace GPIB.Models
{
    public interface ITransfer : IEntity
    {   
        decimal Amount { get; set; }
        
        Int32 AddressID { get; set; }
        
        String Tx { get; set; }
        
        DateTime Created { get; set; }
        
        Decimal Rate { get; set; }
    }
}