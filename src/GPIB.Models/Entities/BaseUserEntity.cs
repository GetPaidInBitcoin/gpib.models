using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GPIB.Models
{
    public abstract class BaseUserEntity
    {
        [Required]
        public int ID { get; set; }

        public Guid UserID { get; set; }
    }
}