using System;

namespace GPIB.Models
{
    public interface IUserEntity : IEntity
    {
        Guid userID { get; set; }
    }
}
