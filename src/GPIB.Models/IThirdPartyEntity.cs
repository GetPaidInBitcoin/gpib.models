using System;

namespace GPIB.Models
{
    public interface IThirdPartyEntity : IEntity
    {
        Guid ThirdPartyID { get; set; }
    }
}