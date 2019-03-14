using System;

namespace GPIB.Models
{
    public class Address : BaseUserEntity, IAddress
    {
        public short Percent { get; set; }

        public String Label { get; set; }

        public Boolean Deleted { get; set; }
        
        public string Address1 { get; set; }
    }
}