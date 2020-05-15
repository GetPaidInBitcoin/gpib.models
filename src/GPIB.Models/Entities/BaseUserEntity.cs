using System;
using System.ComponentModel.DataAnnotations;

namespace GPIB.Models
{
    public abstract class BaseUserEntity
    {
        [Required]
        public int ID { get; set; }

        public Guid userID { get; set; }
    }
}