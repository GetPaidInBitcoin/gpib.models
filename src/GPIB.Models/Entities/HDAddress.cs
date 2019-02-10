using System;

namespace GPIB.Models
{
    public class HDAddress : BaseAddress
    {
        public HDAddress()
        {
            this.Percent = 100;
        }

        public string ExtPubKey { get; set; }

        public String Path { get; set; }
    }
}
