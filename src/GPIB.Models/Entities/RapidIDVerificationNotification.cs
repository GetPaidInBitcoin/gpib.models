using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GPIB.Models
{
    public class RapidIDVerificationNotification
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Guid UserID { get; set; }
        public string PEPStatus { get; set; }
        public string SMSStatus { get; set; }
    }
}