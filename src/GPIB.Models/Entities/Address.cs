using System;

namespace GPIB.Models
{
    public class Address : BaseUserEntity, IAddress
    {
        public short Percent { get; set; }

        public String Label { get; set; }

        public Boolean Deleted { get; set; }
        
        public String Address1 { get; set; }

        public String Coin { get; set; }
    }
}