using System;

namespace GPIB.Models
{
    public class AddressHistory : BaseUserEntity
    {
        public Int32 AddressID { get; set; }
        
        public String IPAddress { get; set; }
        
        public DateTime Created { get; set; }
        
        public String Message { get; set; }
    }
}