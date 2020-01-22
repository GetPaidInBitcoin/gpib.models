using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GPIB.Models
{
    public interface IEntity
    {
        [Required]
        int ID { get; set; }
    }
}