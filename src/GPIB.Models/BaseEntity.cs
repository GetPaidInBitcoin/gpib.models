using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GPIB.Models
{
    public abstract class BaseEntity
    {
        [Required]
        public int ID { get; set; }
    }
}