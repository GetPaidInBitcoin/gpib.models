using System;
using System.ComponentModel.DataAnnotations;

namespace GPIB.Models
{
    public abstract class BaseThirdPartyEntity
    {
        [Required]
        public int ID { get; set; }

        public Guid thirdPartyID { get; set; }
    }
}