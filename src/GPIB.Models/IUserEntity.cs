using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GPIB.Models
{
    public interface IUserEntity : IEntity
    {
        [Required]
        Guid UserID { get; set; }
    }
}