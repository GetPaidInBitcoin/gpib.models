using System;
using System.ComponentModel.DataAnnotations;

namespace GPIB.Models
{
    public class BankAccount : BaseThirdPartyEntity, IThirdPartyEntity
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(50)]
        public String BSB { get; set; }

        [Required]
        [MaxLength(50)]
        public String Number { get; set; }

        [Required]
        public Boolean Enabled { get; set; }

        [Required]
        [MaxLength(50)]
        public string BankName { get; set; }
    }
}
