using System;

namespace GPIB.Models
{
    public interface IUserEntity : IEntity
    {
        Guid UserID { get; set; }
    }
}