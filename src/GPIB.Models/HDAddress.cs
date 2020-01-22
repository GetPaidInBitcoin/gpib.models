using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GPIB.Models
{
    public class HDAddress : BaseAddress
    {
        public HDAddress ()
        {
            this.Percent = 100;
        }

        [Required]
        public string ExtPubKey { get; set; }

        public String Path { get; set; }
    }
}