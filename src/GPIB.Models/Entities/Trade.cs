using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public class Trade
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        public String Exchange { get; set; }

        [Required]
        public String thirdPartyID { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public String Crypto { get; set; }

        [Required]
        public String Fiat { get; set; }

        [Required]
        public decimal CryptoAmount { get; set; }

        [Required]
        public decimal Fee { get; set; }

        [Required]
        public decimal GST { get; set; }

        [Required]
        public decimal Rate { get; set; }

        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public DateTime Created { get; set; }
    }
}