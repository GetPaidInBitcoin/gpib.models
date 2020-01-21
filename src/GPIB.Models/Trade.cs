using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public class Trade
    {
        [Key]
        [Required]
        int ID { get; set; }

        [Required]
        String Exchange { get; set; }

        [Required]
        String ThirdPartyID { get; set; }

        [Required]
        string Type { get; set; }

        [Required]
        String Crypto { get; set; }

        [Required]
        String Fiat { get; set; }

        [Required]
        decimal CryptoAmount { get; set; }

        [Required]
        decimal Fee { get; set; }

        [Required]
        decimal GST { get; set; }

        [Required]
        decimal Rate { get; set; }

        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        DateTime Created { get; set; }
    }
}