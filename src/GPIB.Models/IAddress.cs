using System;

namespace GPIB.Models
{
    public interface IAddress : IUserEntity
    {
        String Coin { get; set; }

        short Percent { get; set; }

        String Label { get; set; }

        Boolean Deleted { get; set; }
        
        String Address1 { get; set; }
    }
}