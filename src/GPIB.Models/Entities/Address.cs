using System;

namespace GPIB.Models
{
    public class Address : IAddress
    {
        public int ID { get; set; }

        public Guid UserID { get; set; }
        
        public short Percent { get; set; }

        public String Label { get; set; }

        public Boolean Deleted { get; set; }
        
        public string Address1 { get; set; }
        
        public Address()
        {
        }
    }
}