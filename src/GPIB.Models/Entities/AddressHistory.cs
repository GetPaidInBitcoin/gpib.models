using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GPIB.Models
{
    public class AddressHistory : BaseUserEntity
    {
        [Required]
        public Int32 AddressID { get; set; }

        [Required]
        public String IPAddress { get; set; }

        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public DateTime Created { get; set; }

        public String Message { get; set; }
    }
}